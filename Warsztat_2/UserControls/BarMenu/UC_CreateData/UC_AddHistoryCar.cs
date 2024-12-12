using System.Data;

namespace Warsztat_2.UserControls.BarMenu.UC_CreateData {
    public partial class UC_AddHistoryCar :UserControl {

        #region variables
        Guid uniqueKey;
        private protected ushort Id_Car;
        #endregion
        public UC_AddHistoryCar()
            {
            InitializeComponent();
            }
        #region Event

        private async void SaveHistoryButton_Click(object sender, EventArgs e)
            {

            if(SaveHistoryButton.Text == "Zapisz")
                {
                await SaveHistory();
                }
            else if(SaveHistoryButton.Text == "Odśwież")
                {
                await UpdateHistory();
                SaveHistoryButton.Text = "Zapisz";
                }
            await LoadOfHistoryCar();
            }
        private async void UC_AddHistoryCar_Load(object sender, EventArgs e)
            {
            await LoadDataCar();
            ScheduleTimePicker.Value = DateTime.Now;
            }
        private async void ViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            VINTextBox.Text = ViewAllCar.CurrentRow.Cells["VIN_Car_Column"].Value.ToString();
            string? id = ViewAllCar.CurrentRow.Cells["ID_Column_"].Value.ToString();

            uniqueKey = await SqlCmd.GetUniqueKey(id, "Samochód");
            await LoadOfHistoryCar();
            }
        private void VINTextBox_TextChanged(object sender, EventArgs e)
            {
            VINTextBox.MaxLength = 17;
            VINTextBox.Text = String.Concat(VINTextBox.Text.Where(char.IsLetterOrDigit));
            NumLenghtNadwoziaLabel.Text = VINTextBox.Text.Length.ToString();
            }
        #endregion
        #region Methods
        private Dictionary<string, object> GetHistoryData()
            {
            return new Dictionary<string, object>
                {
                    {"NrRejestracji", RegistrationNumberTextBox.Text.Trim()},
                    {"Przebieg", MileageTextBox.Text.Trim()},
                    {"DokumentySamochodu", LeftDocumentsCheck.Checked},
                    {"KluczykiSamochodu", LeftKeyChceck.Checked},
                    {"Zlecenie", OrderTextBox.Text.Trim()},
                    {"TestDrive", TestDriveChceck.Checked},
                    {"Diagnostyka", DiagnosticTextBox.Text.Trim()},
                    {"Naprawa", RepairTextBox.Text.Trim()},
                    {"DataPrzyjęcia", ScheduleTimePicker.Text.ToString()},
                    {"VIN", VINTextBox.Text.Trim()},
                    {"UniqueKey", uniqueKey }

                };
            }
        private void ReadData()
            {
            Id_Car = Convert.ToByte(ViewHistory.CurrentRow.Cells["ID_Column"].Value.ToString());

            string GetCellValue(string nameTable) => ViewHistory.CurrentRow.Cells[nameTable].Value.ToString() ?? string.Empty;

            RegistrationNumberTextBox.Text = GetCellValue("NrRejestracji_Column");
            MileageTextBox.Text = GetCellValue("Przebieg_Column");
            OrderTextBox.Text = GetCellValue("Zlecenie_Column");
            DiagnosticTextBox.Text = GetCellValue("Diagnostic_Column");
            RepairTextBox.Text = GetCellValue("Repair_Column");

            LeftDocumentsCheck.Checked = ViewHistory.CurrentRow.Cells["Documents_Column"].Value.ToString() == "1";
            LeftKeyChceck.Checked = ViewHistory.CurrentRow.Cells["Key_Column"].Value.ToString() == "1";
            TestDriveChceck.Checked = ViewHistory.CurrentRow.Cells["TestDrive_Column"].Value.ToString() == "1";

            ScheduleTimePicker.Text = GetCellValue("DataPrzyjęcia_Column");  //ViewHistory.CurrentRow.Cells["DataPrzyjęcia_Column"].Value.ToString();
            }
        private async Task UpdateHistory()
            {
            var historyDataUpdate = GetHistoryData();
            var idHistory = new Dictionary<string, object>
                {
                {"ID", Id_Car.ToString()}
                };

            await SqlCmd.UpdateRecordAsync("HistoriaNapraw", historyDataUpdate, "ID = @ID", idHistory);

            Id_Car = 0;
            }
        private async Task SaveHistory()
            {
            var historyData = GetHistoryData();

            await SqlCmd.AddRecordAsync("HistoriaNapraw", historyData);
            }
        private async Task LoadDataCar()
            {
            await SqlCmd.LoadData("SELECT ID, Marka, Model, RokProdukcji, VIN FROM Samochód", ViewAllCar, "history", "Load table Car From DB");
            }
        private async Task LoadOfHistoryCar()
            {
            await SqlCmd.LoadData($"SELECT ID, DataPrzyjęcia, NrRejestracji, Przebieg, DokumentySamochodu, KluczykiSamochodu, TestDrive, Zlecenie, Diagnostyka, Naprawa FROM HistoriaNapraw WHERE VIN LIKE '%{VINTextBox.Text}'", ViewHistory, "history", "Load table history from DB");
            }
        #endregion
        private async void ViewHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            await SqlCmd.DeleteDataTable(ViewHistory, e, "BtnDelete", "ID_Column", "HistoriaNapraw");
            }
        private void ViewHistory_MouseDoubleClick(object sender, MouseEventArgs e)
            {
            ReadData();
            SaveHistoryButton.Text = "Odśwież";
            }
        }
    }