using System.Data.SQLite;

namespace Warsztat_2._0.UserControls
{
    public partial class UC_Settings : UserControl
    {
        // Змінна для збереження рядка підключення до бази даних
        private readonly string connectionString = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        List<string> Employer = new();
        public UC_Settings()
        {
            InitializeComponent();
        }
        #region Event
        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            // Використовуємо using для автоматичного закриття з'єднання після виходу з блоку
            using SQLiteConnection conn = new(connectionString);
            conn.Open();

            if (DataExists(conn))
            {
                UpdateData(conn);
            }
            else
            {
                InsertData(conn);
            }
        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {

            SaveDataButton.Enabled = EmployerAddButton.Enabled = false;
            SaveDataButton.Text = "Odśwież";
            try
            {
                // Використовуємо using для автоматичного закриття з'єднання після виходу з блоку
                using SQLiteConnection conn = new(connectionString);
                conn.Open();

                // Використовуємо using для автоматичного закриття команди після виходу з блоку
                using SQLiteCommand cmd = new("SELECT * FROM DaneFirmy", conn);

                // Використовуємо using для автоматичного закриття читача даних після виходу з блоку
                using SQLiteDataReader reader = cmd.ExecuteReader();

                // Перевірка наявності даних та виведення повідомлення при їх відсутності
                if (!DataExistsRead(reader))
                {
                    SaveDataButton.Text = "Zapisz";
                    MessageBox.Show("Brak recordów, Proszę wpisać dane firmy, dane wymagane do drukowania zamówień i faktur", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                ReadDataEmployer();
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
        private void NazwaFirmyTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveDataButton.Enabled = !string.IsNullOrEmpty(NazwaFirmyTextBox.Text);
        }
        private void NumerTelefonuTextBox_TextChanged(object sender, EventArgs e)
        {
            EmployerAddButton.Enabled = !string.IsNullOrEmpty(NazwaFirmyTextBox.Text);
        }
        private void EmployerAddButton_Click(object sender, EventArgs e)
        {

            Employer.Add(ImiePracownikaTextBox.Text);
            Employer.Add(StanowiskoSelect.Text);
            Employer.Add(NumerTelefonuTextBox.Text);

            using SQLiteConnection connection = new(connectionString);
            connection.Open();
            using SQLiteCommand cmd = new("INSERT INTO Pracownicy (Imie, Stanowisko, Telefon) " +
                "VALUES (@Imie, @Stanowisko, @Telefon)", connection);

            cmd.Parameters.AddWithValue("@Imie", Employer[0]);
            cmd.Parameters.AddWithValue("@Stanowisko", Employer[1]);
            cmd.Parameters.AddWithValue("@Telefon", Employer[2]);

            cmd.ExecuteNonQuery();

            Employer.Clear();

            ReadDataEmployer();
        }

        private void RemoveEmployerButton_Click(object sender, EventArgs e)
        {
            // Переконатися, що є вибраний елемент у ListBoxEmployer
            if (ListBoxEmployer.SelectedIndex >= 0)
            {
                // Отримати текст виділеного рядка
                string? selectedRow = ListBoxEmployer.SelectedItem.ToString();

                // Розділити рядок за допомогою коми
                string[] rowData = selectedRow.Split(',');

                // Переконатися, що масив містить принаймні 3 елементи (Ім'я, Становище, Номер телефону)
                if (rowData.Length >= 3)
                {
                    // Отримати номер телефону (третій елемент масиву після розділу)
                    string phoneNumber = rowData[2].Trim();

                    using SQLiteConnection conn = new(connectionString);
                    conn.Open();

                    using SQLiteCommand deletecmd = new("DELETE FROM Pracownicy WHERE Telefon = @Telefon", conn);
                    deletecmd.Parameters.AddWithValue("@Telefon", phoneNumber);
                    deletecmd.ExecuteNonQuery();

                    phoneNumber = selectedRow = string.Empty;
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
            ReadDataEmployer();
        }

        private void UpdateEmployerButton_Click(object sender, EventArgs e)
        {
            ReadDataEmployer();
        }
        #endregion
        #region Methods
        private static bool DataExistsRead(SQLiteDataReader reader)
        {
            return reader.Read();
        }
        ///////////
        private static bool DataExists(SQLiteConnection conn)
        {
            using SQLiteCommand cmd = new("SELECT COUNT(*) FROM DaneFirmy", conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
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
        private void ReadDataEmployer()
        {
            try
            {
                List<string> Employer2 = new(); // Створюємо новий список, щоб зберігати дані

                using SQLiteConnection connection = new(connectionString);
                connection.Open();
                using SQLiteCommand readEmployer = new("SELECT Imie, Stanowisko, Telefon FROM Pracownicy", connection);
                using SQLiteDataReader reader2 = readEmployer.ExecuteReader();

                if (!DataExistsRead(reader2))
                {
                    MessageBox.Show("Brak recordów, Proszę wpisać dane pracowników", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                while (reader2.Read())
                {
                    Employer2.Add($"{reader2["Imie"]}, {reader2["Stanowisko"]}, {reader2["Telefon"]}");
                }

                // Встановлюємо нові дані у ListBoxEmployer за допомогою властивості Items
                ListBoxEmployer.Items.Clear();
                ListBoxEmployer.Items.AddRange(Employer2.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie przewidziany warunek: " + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void ListBoxEmployer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}