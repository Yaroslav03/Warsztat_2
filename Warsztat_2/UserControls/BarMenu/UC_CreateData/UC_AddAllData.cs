using System.Data;

namespace Warsztat_2.UserControls.BarMenu.UC_CreateData {
    public partial class UC_AddAllData :UserControl {
        #region variables
        Guid uniqueKey;
        private protected ushort Id_Repair;
        private decimal pricePart, priceService, earningParts;
        #endregion
        #region event
        public UC_AddAllData()
            {
            InitializeComponent();
            }

        private async void UC_AddAllData_Load(object sender, EventArgs e)
            {
            if(uniqueKey == Guid.Empty)
                {
                DateAdoptionTimePicker.Text = DateTime.Today.ToString();
                }
            }
        private async void SaveButton_Click(object sender, EventArgs e)
            {
            if(await CheckDataBeforeSave())
                {
                await (SaveButton.Text == "Odśwież" ? UpdateData() : SaveData());
                }
            }

        private void ButtonOrderManagement_Click(object sender, EventArgs e)
            {
            SumRepair();
            Form_AddOrderManagement form_AddOrderManagement = new();
            form_AddOrderManagement.SendDataFromLastWindow(pricePart, priceService, earningParts, uniqueKey);
            form_AddOrderManagement.ShowDialog();
            }
        #endregion

        #region Method
        private async Task UpdateData()
            {
            await SqlCmd.UpdateAllData(
                uniqueKey,
                GetClientData(),
                GetCarData(),
                GetHistoryData()
                );
            }

        private async Task SaveData()
            {
            uniqueKey = Guid.NewGuid();

            await SqlCmd.SaveAllData
            (
                GetClientData(),
                GetCarData(),
                GetHistoryData()
            );
            }

        private async Task<bool> CheckDataBeforeSave()
            {
            bool check = true;

            var fieldsToCheck = new Dictionary<string, string>
    {
        { "*Brakuje danych do imienia", NameTextBox.Text.Trim() },
        { "*Brakuje danych do telefonu", TelephoneTextBox.Text.Trim()},
        { "*Brakuje danych do marki", MarkaTextBox.Text.Trim()},
        { "*Brakuje danych do modelu", ModelTextBox.Text.Trim()},
        { "*Brakuje danych do numeru VIN", VINTextBox.Text.Trim()},
        { "*Brakuje danych do zlecenia", OrderTextBox.Text.Trim()},
        { "*Brakuje danych do numeru rejestracyjnego", RegistrationNumberTextBox.Text.Trim()},
        { "*Brakuje danych do przebiegu", MileageTextBox.Text.Trim()}
    };



            List<string> nulldata = fieldsToCheck
                .Where(f => f.Value == null || string.IsNullOrWhiteSpace(f.Value.ToString()))
                .Select(f => f.Key)
                .ToList();
            if(VINTextBox.Text.Length != 17)
                {
                nulldata.Add($"Numer VIN musi mieć dokładnie 17 znaków. Aktualna długość: {VINTextBox.Text.Length}");
                }


            if(nulldata.Any())
                {
                MessageBox.Show($"Brakuje danych do następnych komórek danych:\n\n{string.Join("\n\n", nulldata)}",
                                "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
                }

            return true;
            }
        private Dictionary<string, object> GetClientData()
            {
            return new Dictionary<string, object>
                {
                    {"Imię", NameTextBox.Text.Trim()},
                    {"Nazwisko", SurnameTextBox.Text.Trim()},
                    {"NrTelefonu", TelephoneTextBox.Text.Trim()},
                    {"NIP", NIPTextBox.Text.Trim()},
                    {"AdresFirmy", AdressCompanyTextBox.Text.Trim()},
                    {"NazwaFirmyKlienta", CompanyNameTextBox.Text.Trim()},
                    {"UniqueKey", uniqueKey}
                };
            }
        private Dictionary<string, object> GetCarData()
            {
            return new Dictionary<string, object>
            {
                {"Marka", MarkaTextBox.Text.Trim()},
                {"Model", ModelTextBox.Text.Trim()},
                {"Silnik", EngineTextBox.Text.Trim()},
                {"KodSilnika", IdEngineTextBox.Text.Trim()},
                {"RokProdukcji", YearNumericUpDown.Value.ToString()},
                {"VIN", VINTextBox.Text},
                {"UniqueKey", uniqueKey}
            };
            }
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
                    {"DataPrzyjęcia", DateAdoptionTimePicker.Text.ToString()},
                    {"UniqueKey", uniqueKey }
                };
            }
        private void SumRepair()
            {
            decimal totalPriceRepairPart = 0;
            decimal totalPriceService = 0;
            decimal totalEarningParts = 0;
            foreach(DataGridViewRow row in ViewRepair.Rows)
                {
                if(row.Cells["Suma_Column"].Value != null && decimal.TryParse(row.Cells["Suma_Column"].Value.ToString(), out decimal price))
                    {
                    totalPriceRepairPart += price;
                    }
                }

            foreach(DataGridViewRow row in ServiceHistoryView.Rows)
                {
                if(row.Cells["Price_Column"].Value != null && decimal.TryParse(row.Cells["Price_Column"].Value.ToString(), out decimal price))
                    {
                    totalPriceService += price;
                    }
                }
            foreach(DataGridViewRow row in ViewRepair.Rows)
                {
                if(row.Cells["SumaZarobku_Column"].Value != null && decimal.TryParse(row.Cells["SumaZarobku_Column"].Value.ToString(), out decimal price))
                    {
                    totalEarningParts += price;
                    }
                }
            pricePart = totalPriceRepairPart;
            priceService = totalPriceService;
            earningParts = totalEarningParts;
            }
        #endregion

        private async void SelectPartButton_Click(object sender, EventArgs e)
            {
            if(uniqueKey != Guid.Empty)
                {
                Form_AddRepair addRepair = new();
                addRepair.TransferUniqueKey(uniqueKey);
                addRepair.ShowDialog();

                var searchKey = new Dictionary<string, object>
                {
                    {"UniqueKey", uniqueKey }
                };
                await SqlCmd.LoadData($"SELECT ID, Typ, Nazwa, Opis, NumerCzęści, Cena, Ilość, ZarobekCzęści, SumaZarobku, Suma, Stan FROM NaprawaSamochodu WHERE UniqueKey=@UniqueKey", ViewRepair, "Repair", "Load table Repair from DB", searchKey);
                ViewRepair.ClearSelection();
                }
            }
        private async void SelectServiceButton_Click(object sender, EventArgs e)
            {
            if(uniqueKey != Guid.Empty)
                {
                Form_AddService addService = new();
                addService.TransferUniqueKey(uniqueKey);
                addService.ShowDialog();

                var searchKey = new Dictionary<string, object>
                {
                    {"UniqueKey", uniqueKey }
                };
                await SqlCmd.LoadData($"SELECT Id, ServiceName, Price FROM HistoriaUsług WHERE UniqueKey=@UniqueKey", ServiceHistoryView, "Service", "Load table Service from DB", searchKey);
                ServiceHistoryView.ClearSelection();
                }

            }
        private void VINTextBox_TextChanged(object sender, EventArgs e)
            {
            VINTextBox.MaxLength = 17;
            VINTextBox.Text = String.Concat(VINTextBox.Text.Where(char.IsLetterOrDigit));
            NumLenghtNadwoziaLabel.Text = VINTextBox.Text.Length.ToString();
            }
        public async void SetCarGuid(Guid key)
            {
            uniqueKey = key;

            var clientData = await SqlCmd.LoadDataAsync("WarsztatDB", "Klienty", null, "UniqueKey", uniqueKey);
            var carData = await SqlCmd.LoadDataAsync("WarsztatDB", "Samochód", null, "UniqueKey", uniqueKey);
            var historyData = await SqlCmd.LoadDataAsync("WarsztatDB", "HistoriaNapraw", null, "UniqueKey", uniqueKey);

            //client
            NameTextBox.Text = clientData["Imię"].ToString();
            SurnameTextBox.Text = clientData["Nazwisko"].ToString();
            TelephoneTextBox.Text = clientData["NrTelefonu"].ToString();
            NIPTextBox.Text = clientData["NIP"].ToString();
            AdressCompanyTextBox.Text = clientData["AdresFirmy"].ToString();
            CompanyNameTextBox.Text = clientData["NazwaFirmyKlienta"].ToString();
            //car
            MarkaTextBox.Text = carData["Marka"].ToString();
            ModelTextBox.Text = carData["Model"].ToString();
            EngineTextBox.Text = carData["Silnik"].ToString();
            IdEngineTextBox.Text = carData["KodSilnika"].ToString();
            YearNumericUpDown.Value = Convert.ToUInt32(carData["RokProdukcji"]);
            VINTextBox.Text = carData["VIN"].ToString();
            //history
            RegistrationNumberTextBox.Text = historyData["NrRejestracji"].ToString();
            MileageTextBox.Text = historyData["Przebieg"].ToString();
            OrderTextBox.Text = historyData["Zlecenie"].ToString();

            LeftDocumentsCheck.Checked = historyData["DokumentySamochodu"].ToString() == "1";
            LeftKeyChceck.Checked = historyData["KluczykiSamochodu"].ToString() == "1";
            TestDriveChceck.Checked = historyData["TestDrive"].ToString() == "1";

            DiagnosticTextBox.Text = historyData["Diagnostyka"].ToString();
            RepairTextBox.Text = historyData["Naprawa"].ToString();
            DateAdoptionTimePicker.Text = historyData["DataPrzyjęcia"].ToString();
            ///
            SaveButton.Text = "Odśwież";
            //
            var searchKey = new Dictionary<string, object>
                {
                    {"UniqueKey", uniqueKey }
                };
            await SqlCmd.LoadData($"SELECT ID, Typ, Nazwa, Opis, NumerCzęści, Cena, Ilość, ZarobekCzęści, SumaZarobku, Suma, Stan FROM NaprawaSamochodu WHERE UniqueKey=@UniqueKey", ViewRepair, "Repair", "Load table Repair from DB", searchKey);
            await SqlCmd.LoadData($"SELECT Id, ServiceName, Price FROM HistoriaUsług WHERE UniqueKey=@UniqueKey", ServiceHistoryView, "Service", "Load table Service from DB", searchKey);
            ViewRepair.ClearSelection();
            ServiceHistoryView.ClearSelection();
            }
        }
    };