using System.Data.SQLite;
using System.Windows.Forms;
using Warsztat_2._0;

namespace Warsztat_2.UserControls.BarMenu.UC_CreateData {
    public partial class Form_AddOrderManagement :Form {
        #region variables
        private readonly string[] connectionStringArray = new string[] { "Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;", "Data Source=Archive.db;Version=3;New=False;Compress=True;" };


        private string? paymentDay, paymentType, orderAddoptedDay;
        private OrderManagment orderManagment = new();
        private decimal priceOfPart, PricePartWithMarzha, Marzha, finallyPrice, wasPayed;
        uint ID;
        private bool isDataLoadedFromDB = false;


        //private decimal pricePart_;
        #endregion
        public Form_AddOrderManagement()
            {
            InitializeComponent();
            }
        private void SendDataToArchive()
            {
            DialogResult dialogResult = MessageBox.Show("Na pewno chcesz oznaczyć samochód jak wykonany?", "Potwierdzenie wykonania", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
                {

                }
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
            SqlCmd.SendDataToArchive(Vin_Label.Text, connectionStringArray);
            }

        private void FinallPriceNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            decimal x = FinallPriceNumericUpDown.Value;
            finallyPrice = PricePartWithMarzha + x;
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
            DateOfPay.Hide();
            paymentDay = "Brak";
            }
        private async void CostEstimation()
            {
            Marzha = await SqlCmd.GetMarzaAsync();

            PricePartWithMarzhaCalculate();
            }
        private void PricePartWithMarzhaCalculate()
            {

            PricePartWithMarzha = Math.Round(priceOfPart * (1 + (Marzha / 100)), 2);
            LabelPricePartWithMarzha.Text = LabelPricePartWithMarzha.Text + PricePartWithMarzha;
            }
        private async Task LoadDataFromDB()
            {
            var data = await SqlCmd.LoadDataAsync(ButtonOrderManagementSave, "ZarządzanieZleceniem", "VIN", Vin_Label.Text);

            if(data.Count > 0)
                {
                isDataLoadedFromDB = true;
                // Привласнення значень змінним з отриманого словника
                ID = Convert.ToUInt32(data["ID"]);
                OrderAddoptedTimePicker.Text = data["DataOczekiwaniaOdbioru"]?.ToString();
                paymentDay = data["DataPłatności"]?.ToString();
                paymentType = data["MetodaPłatności"]?.ToString();
                priceOfPart = Convert.ToDecimal(data["KosztCzęści"]);
                PricePartWithMarzha = Convert.ToDecimal(data["KosztCzęściZMarżą"]);
                FinallPriceNumericUpDown.Value = Convert.ToDecimal(data["KosztPracyRęcznej"]);
                finallyPrice = Convert.ToDecimal(data["KosztKońcowy"]);
                wasPayed = Convert.ToDecimal(data["Zapłacono"]);
                WorkPerfomedTextBox.Text = data["WykonanaPraca"]?.ToString();
                WorkerListBox.SelectedItem = data["WykonawcaPracy"]?.ToString();

                // Оновлення текстових полів або міток
                labelPriceofPart.Text = "Koszt części: " + priceOfPart;
                LabelPricePartWithMarzha.Text = "Koszt części z marżą: " + PricePartWithMarzha;
                LabelFinallyPrice.Text = "Koszt końcowy: " + finallyPrice;

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
                if(data["DataOczekiwaniaOdbioru"]?.ToString() != null)
                    {
                    realiseOrderCheck.Checked = true;
                    OrderAddoptedTimePicker.Text = data["DataOczekiwaniaOdbioru"]?.ToString();
                    OrderAddoptedTimePicker.Show();
                    }
                }
            }
        private Dictionary<string, object> GetValue()
            {
            if(CashRadioButton.Checked == true)
                {
                wasPayed = Convert.ToDecimal(PaidnumericUpDown.Value);
                }
            else
                {
                wasPayed = finallyPrice;
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
                    {"WykonanaPraca", WorkPerfomedTextBox.Text},
                    {"WykonawcaPracy", WorkerListBox.SelectedItem}
                };
            }
        private async Task SaveDB()
            {
            var managementData = GetValue();
            bool isSucceed = await SqlCmd.AddRecordAsync("ZarządzanieZleceniem", managementData);
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
            string[] columns = { "Imie", "Stanowisko" };
            await SqlCmd.ReadAddDataListBox("SELECT Imie, Stanowisko FROM Pracownicy", columns, WorkerListBox);
            }
        public void SendDataFromLastWindow(string[] data)
            {
            Vin_Label.Text = data[0];
            priceOfPart = Convert.ToDecimal(data[1]);
            labelPriceofPart.Text = labelPriceofPart.Text + " " + priceOfPart;
            }
        #endregion
        #region CheckBoxes and RadioBoxes
        private void RealiseOrderCheck_CheckedChanged(object sender, EventArgs e)
            {
            if(realiseOrderCheck.Checked == true)
                {
                orderAddoptedDay = OrderAddoptedTimePicker.Text;
                OrderAddoptedTimePicker.Show();
                return;
                }
            OrderAddoptedTimePicker.Hide();
            orderAddoptedDay = null;
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
                paymentDay = DateOfPay.Text.ToString();
                DateOfPay.Show();
                }
            }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
            {
            paymentType = "gotówka";
            label5.Show();
            PaidnumericUpDown.Show();
            }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
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
        }
    }