namespace Warsztat_2.UserControls.BarMenu.UC_CreateData {
    public partial class Form_AddOrderManagement :Form {
        #region variables

        private string? paymentDay, paymentType, orderAddoptedDay;
        private decimal priceOfPart, PricePartWithMarzha, Marzha, finallyPrice, wasPayed, earningOnParts;
        private decimal priceOfService;
        uint ID;
        private bool isDataLoadedFromDB = false;
        Guid uniqueKey;


        //private decimal pricePart_;
        #endregion
        public Form_AddOrderManagement()
            {
            InitializeComponent();
            }

        #region Event
        private async void ButtonOrderManagementSave_Click(object sender, EventArgs e)
            {
            if(ButtonOrderManagementSave.Text == "Zapisz")
                {
                await SaveDB();
                }
            else if(ButtonOrderManagementSave.Text == "Odśwież")
                {
                await UpdateDB();
                }
            }

        private async void UC_AddOrderManagement_Load(object sender, EventArgs e)
            {
            PrepereUIToClient();
            await LoadWorkerListBox();
            await LoadDataFromDB();

            }
        private async void CloseOrder_Click(object sender, EventArgs e)
            {
            DialogResult dialogResult = MessageBox.Show("Na pewno chcesz oznaczyć samochód jak wykonany?", "Potwierdzenie wykonania", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
                {
                var managementDataUpdate = GetValue();
                var managementDataUpdateID = new Dictionary<string, object>
                {
                    {"ID", ID}
                };
                managementDataUpdate.Add("DataZamknięciaZlecenia", DateTime.Today.ToString("D"));
                bool isSucceed = await SqlCmd.UpdateRecordAsync("ZarządzanieZleceniem", managementDataUpdate, "ID=@ID", managementDataUpdateID);
                if(isSucceed)
                    {
                    bool isSucceed2 = await SqlCmd.SendToArchive(uniqueKey);
                    if(isSucceed2)
                        {
                        MessageBox.Show("Dane zostałe wysłane do archiwum");
                        }
                    }
                }
            }

        private void FinallPriceNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            decimal x = FinallPriceNumericUpDown.Value;
            finallyPrice = PricePartWithMarzha + x + priceOfService;
            LabelFinallyPrice.Text = "Koszt końcowy: " + finallyPrice;
            }
        #endregion
        #region Methods
        private void PrepereUIToClient()
            {
            if(!isDataLoadedFromDB)
                {
                CostEstimation();
                }

            OrderAddoptedTimePicker.Value = DateTime.Now;
            DateOfPay.Value = DateTime.Now;
            OrderAddoptedTimePicker.Hide();
            CloseOrder.Hide();
            DateOfPay.Hide();
            paymentDay = "Brak";
            }
        private async void CostEstimation()
            {
            Marzha = await SqlCmd.GetMarzaAsync();

            marzhaNumericUpDown.Value = Marzha;

            PricePartWithMarzhaCalculate();

            earningOnParts = PricePartWithMarzha - priceOfPart;
            }
        private void PricePartWithMarzhaCalculate()
            {

            PricePartWithMarzha = Math.Round(priceOfPart * (1 + (Marzha / 100)), 2);
            LabelPricePartWithMarzha.Text = "Koszt za części z marzą: " + PricePartWithMarzha;
            }
        private async Task LoadDataFromDB()
            {
            var data = await SqlCmd.LoadDataAsync("WarsztatDB", "ZarządzanieZleceniem", ButtonOrderManagementSave, "UniqueKey", uniqueKey);

            if(data.Count > 0)
                {
                isDataLoadedFromDB = true;
                // Привласнення значень змінним з отриманого словника
                ID = Convert.ToUInt32(data["ID"]);
                OrderAddoptedTimePicker.Text = data["DataOczekiwaniaOdbioru"]?.ToString();
                paymentDay = data["DataPłatności"]?.ToString();
                paymentType = data["MetodaPłatności"]?.ToString();
                //priceOfPart = Convert.ToDecimal(data["KosztCzęści"]);
                //PricePartWithMarzha = Convert.ToDecimal(data["KosztCzęściZMarżą"]);
                FinallPriceNumericUpDown.Value = Convert.ToDecimal(data["KosztPracyRęcznej"]);
                //finallyPrice = Convert.ToDecimal(data["KosztKońcowy"]);
                wasPayed = Convert.ToDecimal(data["Zapłacono"]);
                WorkPerfomedTextBox.Text = data["WykonanaPraca"]?.ToString();
                WorkerListBox.SelectedItem = data["WykonawcaPracy"]?.ToString();
                if(data["Marża"] != null)
                    {
                    marzhaNumericUpDown.Value = Convert.ToDecimal(data["Marża"].ToString());
                    }

                // Встановлення стану елементів управління на основі отриманих даних
                if(paymentType == "gotówka")
                    {
                    CashRadioButton.Checked = true;
                    PaidnumericUpDown.Value = wasPayed; // Припускаємо, що wasPayed збережено у базі
                    }
                else if(paymentType == "kartą płatniczą")
                    {
                    radioButton2.Checked = true;
                    }

                // Якщо дата оплати сьогоднішня, встановлюємо відповідний чекбокс
                if(paymentDay == "Brak")
                    {
                    NeitherRadioButton.Checked = true;
                    }
                else if(paymentDay == DateTime.Today.ToString("D"))
                    {
                    TodayPaycheck.Checked = true;
                    }
                else if(paymentDay != DateTime.Today.ToString("D"))
                    {
                    OtherDatePayCheck.Checked = true;
                    DateOfPay.Text = paymentDay;
                    DateOfPay.Show();
                    }
                // Якщо замовлення реалізовано, відображаємо дату
                if(data["DataOczekiwaniaOdbioru"]?.ToString() != null && data["DataOczekiwaniaOdbioru"]?.ToString().Length != 0)
                    {
                    realiseOrderCheck.Checked = true;
                    OrderAddoptedTimePicker.Text = data["DataOczekiwaniaOdbioru"]?.ToString();
                    OrderAddoptedTimePicker.Show();
                    }

                CloseOrder.Show();
                }
            }
        private Dictionary<string, object> GetValue()
            {
            wasPayed = CashRadioButton.Checked ? PaidnumericUpDown.Value : finallyPrice;

            if(OtherDatePayCheck.Checked == true)
                {
                paymentDay = DateOfPay.Text.ToString();
                }

            return new Dictionary<string, object>
                {
                    {"VIN", Vin_Label.Text},
                    {"DataOczekiwaniaOdbioru", orderAddoptedDay},
                    {"DataPłatności", paymentDay},
                    {"MetodaPłatności", paymentType},
                    {"Zapłacono",  wasPayed},
                    {"KosztCzęści", priceOfPart},
                    {"KosztCzęściZMarżą", PricePartWithMarzha},
                    {"KosztPracyRęcznej", FinallPriceNumericUpDown.Value.ToString()},
                    {"KosztKońcowy",  finallyPrice},
                    {"KosztUsługi", priceOfService},
                    {"WykonanaPraca", WorkPerfomedTextBox.Text},
                    {"WykonawcaPracy", WorkerListBox.SelectedItem},
                    {"UniqueKey", uniqueKey },
                    {"DochódZCzęści", earningOnParts},
                    {"Marża", Marzha}
                };
            }
        private async Task SaveDB()
            {
            var managementData = GetValue();
            bool isSucceed = await SqlCmd.AddRecordAsync("WarsztatDB", "ZarządzanieZleceniem", managementData);
            if(isSucceed)
                {
                MessageBox.Show("Zlecenie zostało zapisane");
                }
            }
        private async Task UpdateDB()
            {
            var managementDataUpdate = GetValue();
            var managementDataUpdateID = new Dictionary<string, object>
                {
                    {"ID", ID}
                };
            bool isSucceed = await SqlCmd.UpdateRecordAsync("ZarządzanieZleceniem", managementDataUpdate, "ID=@ID", managementDataUpdateID);
            if(isSucceed)
                {
                MessageBox.Show("Dane zostałe odświeżone");
                }
            }
        private async Task LoadWorkerListBox()
            {
            string[] columns = { "Imię", "Stanowisko" };
            await SqlCmd.ReadAddDataListBox("SELECT Imię, Stanowisko FROM Pracownicy", columns, WorkerListBox);
            }
        public void SendDataFromLastWindow(decimal pricePart, decimal priceService, Guid key)
            {
            uniqueKey = key;
            priceOfPart = pricePart;
            priceOfService = priceService;
            labelPriceofService.Text += priceOfService;
            labelPriceofPart.Text += priceOfPart;
            }
        #endregion
        #region CheckBoxes and RadioBoxes
        private void RealiseOrderCheck_CheckedChanged(object sender, EventArgs e)
            {
            if(realiseOrderCheck.Checked == true)
                {
                OrderAddoptedTimePicker.Show();
                return;
                }
            OrderAddoptedTimePicker.Hide();
            }
        private void TodayPaycheck_CheckedChanged(object sender, EventArgs e)
            {
            if(TodayPaycheck.Checked == true)
                {
                DateOfPay.Hide();
                paymentDay = DateTime.Today.ToString("D");
                }
            }
        private void OtherDatePayCheck_CheckedChanged(object sender, EventArgs e)
            {
            if(OtherDatePayCheck.Checked == true)
                {
                DateOfPay.Show();
                }
            }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
            {
            paymentType = "gotówka";
            label5.Show();
            PaidnumericUpDown.Show();
            }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
            {
            paymentType = "kartą płatniczą";
            label5.Hide();
            PaidnumericUpDown.Hide();
            PaidnumericUpDown.Value = 0;
            }

        private void NeitherRadioButton_CheckedChanged(object sender, EventArgs e)
            {
            if(NeitherRadioButton.Checked == true)
                {
                paymentDay = "Brak";
                }
            }
        #endregion      

        private void OrderAddoptedTimePicker_ValueChanged(object sender, EventArgs e)
            {
            orderAddoptedDay = OrderAddoptedTimePicker.Text;
            }

        private void marzhaNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            Marzha = marzhaNumericUpDown.Value;
            PricePartWithMarzhaCalculate();

            decimal x = FinallPriceNumericUpDown.Value;
            finallyPrice = PricePartWithMarzha + x + priceOfService;
            LabelFinallyPrice.Text = "Koszt końcowy: " + finallyPrice;

            earningOnParts = PricePartWithMarzha - priceOfPart;
            }
        }
    }