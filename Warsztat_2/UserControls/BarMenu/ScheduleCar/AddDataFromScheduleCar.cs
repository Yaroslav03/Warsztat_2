namespace Warsztat_2.UserControls.BarMenu.ScheduleCar
{
    public partial class AddDataFromScheduleCar : Form
    {
        #region Values
        private Queue<string> data = new();
        private string? ID;
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

                ID = "";
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
        private string GetLabelValue(Label label)
        {
            return label.Text.Contains(":") ? label.Text.Split(':')[1].Trim() : string.Empty;
        }


        private async Task SaveToDB()
        {
            Guid uniqueKey = Guid.NewGuid();
            var clientData = new Dictionary<string, object>{
                    {"Imię", GetLabelValue(NameLabel)},
                    {"Nazwisko", GetLabelValue(SurnameLabel)},
                    {"NrTelefonu", GetLabelValue(labelTelephone)},
                    {"AdresFirmy", AdressCompanyTextBox.Text.Trim()},
                    {"NIP", NIPTextBox.Text.Trim()},
                    {"UniqueKey", uniqueKey}
                };
            var carData = new Dictionary<string, object>{
                    {"Marka", GetLabelValue(labelMarka)},
                    {"Model", GetLabelValue(labelModel)},
                    {"Silnik", EngineTextBox.Text.Trim()},
                    {"RokProdukcji", YearOfProductionNumericUpDown.Value.ToString()},
                    {"VIN", VINTextBox.Text.Trim()},
                    {"UniqueKey", uniqueKey}
                };
            var historiaNaprawData = new Dictionary<string, object>{
                    {"DataPrzyjęcia", GetLabelValue(labelOrderAddopted)},
                    {"Zlecenie", ProblemTextBox.Text.Trim()},
                    {"NrRejestracji", RegistrationNumberTextBox.Text.Trim()},
                    {"Przebieg", MileageTextBox.Text.Trim()},
                    {"UniqueKey", uniqueKey}
                };
            var scheduleCarID = new Dictionary<string, object>
                {
                    {"ID", ID}
                };
            //await SqlCmd.AddAndReadLastRecordAddedWithoutDublicatedRecord(await SqlCmd.AddRecordAsync("Klienty", clientData), await SqlCmd.CheckLastAddedRecord());

            await SqlCmd.AddRecordAsync("WarsztatDB", "Klienty", clientData);
            await SqlCmd.AddRecordAsync("WarsztatDB", "Samochód", carData);
            await SqlCmd.AddRecordAsync("WarsztatDB", "HistoriaNapraw", historiaNaprawData);

            await SqlCmd.DeleteRecordAsync("WarsztatDB", "ZaplanowaneSamochody", "ID=@ID", scheduleCarID);
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