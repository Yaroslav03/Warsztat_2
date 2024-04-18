using System.Data.SQLite;

namespace Warsztat_2._0.UserControls
{
    public partial class UC_Settings : UserControl
    {
        // Змінна для збереження рядка підключення до бази даних
        private readonly string connection = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        readonly List<string> Employer = new();
        private readonly string[] nameColumns = { "Imie", "Stanowisko", "Telefon" };
        public UC_Settings()
        {
            InitializeComponent();
        }
        #region Event
        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            // Використовуємо using для автоматичного закриття з'єднання після виходу з блоку
            using SQLiteConnection conn = new(connection);
            conn.Open();

            if (SqlCmd.DataExists(conn, "DaneFirmy"))
            {
                UpdateData(conn);
            }
            else
            {
                InsertData(conn);
            }
            SaveDataButton.Text = "Odśwież";
        }

        private async void UC_Settings_Load(object sender, EventArgs e)
        {
            EmployerAddButton.Enabled = false;
            SaveDataButton.Text = "Odśwież";
            await LoadData();
        }
        private async Task LoadData()
        {
            await LoadDataWarsztat();
            await SqlCmd.ReadAddDataListBox(connection, "SELECT Imie, Stanowisko, Telefon FROM Pracownicy", nameColumns, ListBoxEmployer);
        }
        private async Task LoadDataWarsztat()
        {
            try
            {
                // Використовуємо using для автоматичного закриття з'єднання після виходу з блоку
                using SQLiteConnection conn = new(connection);
                await conn.OpenAsync();

                // Використовуємо using для автоматичного закриття команди після виходу з блоку
                using SQLiteCommand cmd = new("SELECT * FROM DaneFirmy", conn);

                // Використовуємо using для автоматичного закриття читача даних після виходу з блоку
                using SQLiteDataReader reader = cmd.ExecuteReader();

                // Перевірка наявності даних та виведення повідомлення при їх відсутності
                if (!SqlCmd.DataExistsRead(reader))
                {
                    SaveDataButton.Text = "Zapisz";
                    MessageBox.Show("Brak recordów, Proszę wpisać dane firmy, dane wymagane do drukowania zamówień i faktur", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Якщо дані є, зчитуємо та відображаємо їх на текстових полях
                NazwaFirmyTextBox.Text = reader["NazwaFirmy"].ToString();
                AdresFirmyTextBox.Text = reader["AdresFirmy"].ToString();
                NIPTextBox.Text = reader["NIP"].ToString();
                NrTelefonuTextBox.Text = reader["NrTelefonu"].ToString();
                NumerBDOTextBox.Text = reader["BDO"].ToString();
                KontoBankoweTextBox.Text = reader["KontoBankowe"].ToString();
                MarzaTextBox.Text = reader["Marża"].ToString();
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            }
            catch (Exception ex)
            {
                //не передбачена подія
                MessageBox.Show("Nie przewidziany warunek, proszę zrobić zdjęcie błędu i wysłać na adres yaroslavturbo13@gmail.com: \n" + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Метод для перевірки текстового поля чи він пустий, запобігаючи записанню пустих даних

        private void NumerTelefonuTextBox_TextChanged(object sender, EventArgs e)
        {
            EmployerAddButton.Enabled = !string.IsNullOrEmpty(NumerTelefonuTextBox.Text);
        }
        private async void EmployerAddButton_Click(object sender, EventArgs e)
        {

            Employer.Add(ImiePracownikaTextBox.Text);
            Employer.Add(StanowiskoSelect.Text);
            Employer.Add(NumerTelefonuTextBox.Text);

            using SQLiteConnection conn = new(connection);
            conn.Open();
            using SQLiteCommand cmd = new("INSERT INTO Pracownicy (Imie, Stanowisko, Telefon) " +
                "VALUES (@Imie, @Stanowisko, @Telefon)", conn);

            cmd.Parameters.AddWithValue("@Imie", Employer[0]);
            cmd.Parameters.AddWithValue("@Stanowisko", Employer[1]);
            cmd.Parameters.AddWithValue("@Telefon", Employer[2]);

            cmd.ExecuteNonQuery();

            Employer.Clear();

            await SqlCmd.ReadAddDataListBox(connection, "SELECT Imie, Stanowisko, Telefon FROM Pracownicy", nameColumns, ListBoxEmployer);
        }

        private async void RemoveEmployerButton_Click(object sender, EventArgs e)
        {
            string? selectEmployer = (ListBoxEmployer.SelectedItem ?? "").ToString();
            // Переконатися, що є вибраний елемент у ListBoxEmployer
            if (ListBoxEmployer.SelectedIndex >= 0 && selectEmployer != null)
            {
                //string? selectEmployer = ListBoxEmployer.SelectedItem.ToString();

                // Розділити рядок за допомогою коми
                string[] rowData = selectEmployer.Split(' ');

                // Переконатися, що масив містить принаймні 3 елементи (Ім'я, Становище, Номер телефону)
                if (rowData.Length == 3)
                {
                    // Отримати номер телефону (третій елемент масиву після розділу)
                    string phoneNumber = rowData[2].Trim();

                    using SQLiteConnection conn = new(connection);
                    conn.Open();

                    using SQLiteCommand deletecmd = new("DELETE FROM Pracownicy WHERE Telefon = @Telefon", conn);
                    deletecmd.Parameters.AddWithValue("@Telefon", phoneNumber);
                    deletecmd.ExecuteNonQuery();

                    phoneNumber = selectEmployer = string.Empty;
                }
                else
                {
                    MessageBox.Show("Обраний рядок не містить необхідних даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Brak danych, Proszę dodać pracowników zanim usuwać :D", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            await SqlCmd.ReadAddDataListBox(connection, "SELECT Imie, Stanowisko, Telefon FROM Pracownicy", nameColumns, ListBoxEmployer);
        }

        private async void UpdateEmployerButton_Click(object sender, EventArgs e)
        {
            await SqlCmd.ReadAddDataListBox(connection, "SELECT Imie, Stanowisko, Telefon FROM Pracownicy", nameColumns, ListBoxEmployer);
        }
        #endregion
        #region Methods
        ///////////

        private void InsertData(SQLiteConnection conn)
        {
            using SQLiteCommand cmd = new("INSERT INTO DaneFirmy (NazwaFirmy, AdresFirmy, NIP, NrTelefonu, BDO, KontoBankowe, Marża) " +
             "VALUES (@NazwaFirmy, @AdresFirmy, @NIP, @NrTelefonu, @BDO, @KontoBankowe, @Marża)", conn);

            Data(cmd);
        }
        // Функція для оновлення даних
        private void UpdateData(SQLiteConnection conn)
        {
            using SQLiteCommand cmd = new("UPDATE DaneFirmy SET NazwaFirmy = @NazwaFirmy, AdresFirmy = @AdresFirmy, NIP = @NIP, " +
                "NrTelefonu = @NrTelefonu, BDO = @BDO, KontoBankowe = @KontoBankowe, Marża = @Marża", conn);

            Data(cmd);
        }
        // Функція яка запобігає повторюваності коду
        private void Data(SQLiteCommand cmd)
        {
            cmd.Parameters.AddWithValue("@NazwaFirmy", NazwaFirmyTextBox.Text);
            cmd.Parameters.AddWithValue("@AdresFirmy", AdresFirmyTextBox.Text);
            cmd.Parameters.AddWithValue("@NIP", NIPTextBox.Text);
            cmd.Parameters.AddWithValue("@NrTelefonu", NrTelefonuTextBox.Text);
            cmd.Parameters.AddWithValue("@BDO", NumerBDOTextBox.Text);
            cmd.Parameters.AddWithValue("@KontoBankowe", KontoBankoweTextBox.Text);
            cmd.Parameters.AddWithValue("@Marża", MarzaTextBox.Text);

            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}