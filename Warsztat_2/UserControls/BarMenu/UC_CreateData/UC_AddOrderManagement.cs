using System.Data.SQLite;
namespace Warsztat_2._0.UserControls.UC_CreateData {
    public partial class UC_AddOrderManagement :UserControl {
        public UC_AddOrderManagement()
            {
            InitializeComponent();

            OrderAddoptedTimePicker.Hide();
            DateOfPay.Hide();
            }
        #region variables
        private string? today, paymentType;
        private OrderManagment orderManagment = new();
        private string? VIN;
        private ushort IdOrder;
        private float Marża;
        //private decimal pricePart_;
        #endregion
        #region Event
        private async void Vin_Label_TextChanged(object sender, EventArgs e)
            {
            if(Vin_Label.Text != "");
            }

        private async void ButtonOrderManagementSave_Click(object sender, EventArgs e)
            {
            if(ButtonOrderManagementSave.Text == "Zapisz")
                {
                await SaveDB();
                }
            else if(ButtonOrderManagementSave.Text == "Odśwież")
                {
                await UpdateDB();
                ButtonOrderManagementSave.Text = "Zapisz";
                }
            }

        private async void FinallPriceNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            float num = (float)FinallPriceNumericUpDown.Value;
            await CalculateMarża(num);
            }

        private async void UC_AddOrderManagement_Load(object sender, EventArgs e)
            {
            await LoadWorkerListBox();
            OrderAddoptedTimePicker.Value = DateTime.Now;
            }
        #region checkbox

        private void RealiseOrderCheck_CheckedChanged(object sender, EventArgs e)
            {
            if(realiseOrderCheck.Checked == true)
                {
                OrderAddoptedTimePicker.Show();
                }
            else
                {
                OrderAddoptedTimePicker.Hide();
                }

            }
        private void TodayPaycheck_CheckedChanged(object sender, EventArgs e)
            {
            if(TodayPaycheck.Checked == true)
                {
                today = DateTime.Today.ToString("D");
                MessageBox.Show(today);
                }
            }
        private void OtherDatePayCheck_CheckedChanged(object sender, EventArgs e)
            {
            if(OtherDatePayCheck.Checked == true)
                {
                today = string.Empty;
                DateOfPay.Show();
                }
            else
                {
                DateOfPay.Hide();
                }
            }

        #endregion

        #endregion
        #region Methods
        private Dictionary<string, object> GetValue()
            {
            string? worker = WorkerListBox.SelectedItems.Count > 0 ? WorkerListBox.SelectedItems[0].ToString() : "";
            return new Dictionary<string, object>
                {
                    {"VIN", VIN},
                    {"OczekujeNaOdbiór", realiseOrderCheck.Checked},
                    {"DataPrzyjęcie", OrderAddoptedTimePicker.Text.ToString()},
                    {"DataOczekiwaniaOdbioru", OrderAddoptedTimePicker.Text.ToString()},
                    {"DataPłatności", OtherDatePayCheck.Checked ? DateOfPay.Text.ToString() : ""},
                    {"MetodaPłatności", CashCheck.Checked ? "gotówka" : "kartą"}, //спосіб оплати
                    {"KosztSzacunkowy", (decimal)EstimatedCostNumericUpDown.Value},
                    {"KosztKońcowy", (decimal)FinallPriceNumericUpDown.Value},
                    {"KosztZMarżą", Convert.ToDecimal(LabelPriceWithMarża.Text)},
                    {"KosztCałkowityCzęści", Convert.ToDecimal(LabelTotalCostOfParts.Text)},
                    {"WykonanaPraca", WorkPerfomedTextBox.Text.Trim()},
                    {"WykonawcaPracy", worker }
                };
            }


        private async Task SaveDB()
            {
            MessageBox.Show($"EstimatedCost: {orderManagment.EstimatedCost}, Cost: {orderManagment.Cost}, TotalCostOfParts: {orderManagment.TotalCostOfParts}, CostWithMarge: {orderManagment.CostWithMarge}");
            var orderManagementData = GetValue();

            await SqlCmd.AddRecordAsync("ZarządzanieZleceniami", orderManagementData);
            /*                StanCheckBox.Checked = false;
                                PriceNumericUpDown.Value = IloscNumericUpDown.Value = 0;*/
            }
        private async Task UpdateDB()
            {
            var orderManagementData = GetValue();
            var orderManagementID = new Dictionary<string, object>
                {
                    {"ID", IdOrder }
                };
            await SqlCmd.UpdateRecordAsync("ZarządzanieZleceniami", orderManagementData, "ID=@ID", orderManagementID);

            /*Id_Repair = 0; Repair.Reset();Settings.ClearTextBox(panelDodatkowy);StanCheckBox.Checked = false;ButtonRepairSave.Text = "Zapisz";PriceNumericUpDown.Value = IloscNumericUpDown.Value = 0;*/
            }


        private async Task CalculateMarża(float x)
            {
            if(FinallPriceNumericUpDown.Value != 0)
                {
                if(Marża == 0)
                    {
                    await ReadValueMarża();
                    }

                float procentage = (x * (Marża / 100)) + x; //приведення Marża до типу float

                LabelPriceWithMarża.Text = procentage.ToString("0.00");
                }
            }

        private async Task ReadValueMarża()
            {

            using SQLiteConnection conn = new("Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;");
            await conn.OpenAsync();
            using SQLiteCommand cmd = new("SELECT Marża FROM DaneFirmy", conn);

            using SQLiteDataReader reader = cmd.ExecuteReader();

            while(await reader.ReadAsync()) // Опрацювання результатів запиту, якщо є
                {
                Marża = reader.GetInt32(0); // Отримання значення Marża з рядка результату запиту
                }
            }
        private async Task LoadWorkerListBox()
            {
            await SqlCmd.ReadRecordListBoxAsync(WorkerListBox, "SELECT Imie, Stanowisko", "Pracownicy");
            }
        #endregion
        }
    }