
using System.Data.SQLite;

namespace Warsztat_2.UserControls.BarMenu.ScheduleCar
{
    public partial class AddDataFromScheduleCar : Form
    {
        #region Values
        private readonly string connection = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        private Queue<string> data = new();
        private string? VIN, ID;
        #endregion

        public AddDataFromScheduleCar()
        {
            InitializeComponent();
        }
        #region Event

        private void AddDataFromScheduleCar_Load(object sender, EventArgs e)
        {
            SaveDataButton.Enabled = false;
        }
        private async void SaveDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                await SaveToDB();
                MessageBox.Show("Dane zostali przypisane do odpowiednich tabeli w bazie danych");

                ID = VIN = "";
                Close();
            }
            catch
            {
                MessageBox.Show("Problem z połączeniem do bazy danych");
            }
        }
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void VINTextBox_TextChanged(object sender, EventArgs e)
        {
            NumLenghtNadwoziaLabel.Text = VINTextBox.TextLength.ToString();

            VINTextBox.MaxLength = 17;

            SaveDataButton.Enabled = VINTextBox.TextLength == 17;
        }
        #endregion
        #region Method
        private async Task SaveToDB()
        {
            Cursor.Current = Cursors.WaitCursor;
            CollectData();
            using SQLiteConnection conn = new(connection);

            await conn.OpenAsync();

            using var transaction = conn.BeginTransaction();
            try
            {////////////////////////////////////////////Додавання даних до таблиці клієнти////////////////////////////////////////////
                using SQLiteCommand client = new("INSERT INTO Klienty (Imię, Nazwisko, NrTelefonu, AdresFirmy, NIP, VIN)" +
                    "VALUES(@Imię, @Nazwisko, @NrTelefonu, @AdresFirmy, @NIP, @VIN)", conn);

                client.Parameters.AddWithValue("@Imię", data.Dequeue());
                client.Parameters.AddWithValue("@Nazwisko", data.Dequeue());
                client.Parameters.AddWithValue("@NrTelefonu", data.Dequeue());
                client.Parameters.AddWithValue("@AdresFirmy", data.Dequeue());
                client.Parameters.AddWithValue("@NIP", data.Dequeue());
                client.Parameters.AddWithValue("@VIN", VIN);

                await client.ExecuteNonQueryAsync();
                ////////////////////////////////////////////Додавання даних до таблиці машини////////////////////////////////////////////
                using SQLiteCommand car = new("INSERT INTO Samochód (Marka, Model, Silnik, RokProdukcji, VIN)" +
                "VALUES (@Marka, @Model, @Silnik, @RokProdukcji, @VIN)", conn);

                car.Parameters.AddWithValue("@Marka", data.Dequeue());
                car.Parameters.AddWithValue("@Model", data.Dequeue());
                car.Parameters.AddWithValue("@Silnik", data.Dequeue());
                car.Parameters.AddWithValue("@RokProdukcji", data.Dequeue());
                car.Parameters.AddWithValue("@VIN", VIN);

                await car.ExecuteNonQueryAsync();
                ////////////////////////////////////////////Додавання даних до таблиці історії ремонту////////////////////////////////////////////
                using SQLiteCommand history = new("INSERT INTO HistoriaNapraw (DataPrzyjęcia, NrRejestracji, Przebieg,  Zlecenie, VIN)" +
                    "VALUES (@DataPrzyjęcia, @NrRejestracji, @Przebieg, @Zlecenie, @VIN)", conn);

                history.Parameters.AddWithValue("@DataPrzyjęcia", data.Dequeue());
                history.Parameters.AddWithValue("@Zlecenie", data.Dequeue());
                history.Parameters.AddWithValue("@NrRejestracji", data.Dequeue());
                history.Parameters.AddWithValue("@Przebieg", data.Dequeue());

                history.Parameters.AddWithValue("@VIN", VIN);

                await history.ExecuteNonQueryAsync();
                ////////////////////////////////////////////Видалення старої таблиці////////////////////////////////////////////
                using SQLiteCommand delete = new("DELETE FROM ZaplanowaneSamochody WHERE ID=@ID", conn);
                delete.Parameters.AddWithValue("@ID", ID);

                await delete.ExecuteNonQueryAsync();
                ////////////////////////////////////////////Якщо помилок немає, зберегти зміни////////////////////////////////////////////
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Problem z zapisem danych do bazy danych:" + ex);
                throw;
            }
            Cursor.Current = Cursors.Default;
        }
        private void CollectData()
        {
            data.Clear();
            string[] s;

            s = NameLabel.Text.Split(':');
            data.Enqueue(s[1].Trim());

            s = SurnameLabel.Text.Split(":");
            data.Enqueue(s[1].Trim());

            s = labelTelephone.Text.Split(":");
            data.Enqueue(s[1].Trim());

            data.Enqueue(AdressCompanyTextBox.Text);
            data.Enqueue(NIPTextBox.Text);

            //////////////////////////////////////
            s = labelMarka.Text.Split(":");
            data.Enqueue(s[1].Trim());

            s = labelModel.Text.Split(":");
            data.Enqueue(s[1].Trim());

            data.Enqueue(EngineTextBox.Text);

            data.Enqueue(YearOfProductionNumericUpDown.Value.ToString());
            ////////////////////////////////////////
            ///
            s = labelOrderAddopted.Text.Split(":");
            data.Enqueue(s[1].Trim());

            data.Enqueue(ProblemTextBox.Text);
            data.Enqueue(RegistrationNumberTextBox.Text);
            data.Enqueue(MileageTextBox.Text);
            ////////////////////////////////////////
            VIN = VINTextBox.Text;

            Array.Clear(s, 0, s.Length);
        }
        #endregion
        #region LoadData
        public void SetDataToLoad(TransferData transfer)
        {
            data = transfer.Data;

            AutocompleteData();
        }
        private void AutocompleteData()
        {
            ID = data.Dequeue();

            NameLabel.Text = $"{NameLabel.Text}  {data.Dequeue()}";
            SurnameLabel.Text = $"{SurnameLabel.Text}  {data.Dequeue()}";
            labelTelephone.Text = $"{labelTelephone.Text}  {data.Dequeue()}";

            labelMarka.Text = $"{labelMarka.Text}  {data.Dequeue()}";
            labelModel.Text = $"{labelModel.Text}  {data.Dequeue()}";

            labelOrderAddopted.Text = $"{labelOrderAddopted.Text}  {data.Dequeue()}";
            ProblemTextBox.Text = data.Dequeue();
        }
        #endregion
    }
}