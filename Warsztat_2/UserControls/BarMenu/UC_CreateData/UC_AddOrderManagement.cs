using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Core;
using Warsztat_2._0;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Warsztat_2._0.UserControls.UC_CreateData
{
    public partial class UC_AddOrderManagement : UserControl
    {

        public UC_AddOrderManagement()
        {
            InitializeComponent();
            OrderAddoptedTimePicker.Hide();
            CarRealiseTimePicker.Hide();
            DateOfPay.Hide();

            LoadDB();
        }
        #region variables
        readonly string pathOrderManagement = "Data Source=Warsztat_OrderManagement.db;Version=3;New=False;Compress=True;";
        private string today, paymentType;
        private Queue<string> dataError = new();
        private OrderManagment orderManagment = new();
        private string VIN;
        private ushort IdOrder;
        private float Marża;
        #endregion

        #region Event

        private async void ButtonOrderManagementSave_Click(object sender, EventArgs e)
        {

            if (ButtonOrderManagementSave.Text == "Zapisz")
            {
                await SaveDB();
            }
            else if (ButtonOrderManagementSave.Text == "Odśwież")
            {
                await UpdateDB();
                ButtonOrderManagementSave.Text = "Zapisz";
            }

        }
        private async void ViewOrderManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            await DeleteDB(e);
        }

        private void ViewOrderManagement_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ReadDataTable();
            ButtonOrderManagementSave.Text = "Odśwież";
        }

        #region checkbox
        private void OrderAddoptedCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (OrderAddoptedCheck.Checked == true)
            {
                OrderAddoptedTimePicker.Value = DateTime.Now;
                OrderAddoptedTimePicker.Show();
            }
            else
            {
                OrderAddoptedTimePicker.Hide();
            }

        }
        private void realiseOrderCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (realiseOrderCheck.Checked == true)
            {
                CarRealiseTimePicker.Show();
            }
            else
            {
                CarRealiseTimePicker.Hide();
            }

        }
        private void TodayPaycheck_CheckedChanged(object sender, EventArgs e)
        {
            if (TodayPaycheck.Checked == true)
            {
                today = DateTime.Today.ToString("D");
                MessageBox.Show(today);
            }
        }
        private void OtherDatePayCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (OtherDatePayCheck.Checked == true)
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
        #region Methods
        public void UpdateVIN(string newVIN)
        {
            Vin_Label.Text = newVIN;
            VIN = newVIN;
        }
        private void CollectData()
        {

            if (OtherDatePayCheck.Checked == true)// Якщо правда OtherDatePayCheck тоді змінити дані у змінній
            {
                today = DateOfPay.Text.ToString();
            }
            if (CashCheck.Checked == true)
            {
                paymentType = "gotówka";
            }
            else if (CardCheck.Checked == true)
            {
                paymentType = "kartą";
            }
            orderManagment = new()
            {
                OrderAddopted = OrderAddoptedCheck.Checked,
                realiseOrder = realiseOrderCheck.Checked,
                DateOrderAddopted = OrderAddoptedTimePicker.Text.ToString(),
                DateRealiseOrder = CarRealiseTimePicker.Text.ToString(),
                DateOfPay = today,
                TypeOfPay = paymentType,
                EstimatedCost = (ushort)EstimatedCostNumericUpDown.Value,
                Cost = (ushort)FinallPriceNumericUpDown.Value,
                CostWithMarge = Convert.ToUInt16(priceWithMarża.Text),
                WorkPerfomed = WorkPerfomedTextBox.Text,
                Employer = WorkerListBox.SelectedItem.ToString()
            };

        }
        private void ReadDataTable()
        {
            IdOrder = Convert.ToUInt16(ViewOrderManagement.CurrentRow.Cells["ID"].Value.ToString());

            OrderAddoptedCheck.Checked = ViewOrderManagement.CurrentRow.Cells["Przyjęty_Column"].Value.ToString() == "1";
            realiseOrderCheck.Checked = ViewOrderManagement.CurrentRow.Cells["OczekujeNaOdbiór_Column"].Value.ToString() == "1";

            OrderAddoptedTimePicker.Text = ViewOrderManagement.CurrentRow.Cells["DataPrzyjęcia_Column"].Value.ToString();
            CarRealiseTimePicker.Text = ViewOrderManagement.CurrentRow.Cells["DataWydania_Column"].Value.ToString();

            OtherDatePayCheck.Checked = true;
            DateOfPay.Text = ViewOrderManagement.CurrentRow.Cells["DataPayer_Column"].Value.ToString();
            string? typeOfPay = ViewOrderManagement.CurrentRow.Cells["TypPłatności_Column"].Value.ToString();
            if (typeOfPay == "gotówka")
            {
                CashCheck.Checked = true;
            }
            else
            {
                CardCheck.Checked = true;
            }

            EstimatedCostNumericUpDown.Text = ViewOrderManagement.CurrentRow.Cells["KosztSzacunkowy_Column"].Value.ToString();
            FinallPriceNumericUpDown.Text = ViewOrderManagement.CurrentRow.Cells["KosztKońcowy_Column"].Value.ToString();
            priceWithMarża.Text = ViewOrderManagement.CurrentRow.Cells["ZMarżą_Column"].Value.ToString();

            WorkPerfomedTextBox.Text = ViewOrderManagement.CurrentRow.Cells["WykonanaPraca_Column"].Value.ToString();
            string? worker = ViewOrderManagement.CurrentRow.Cells["WykonawcaPracy_Column"].Value.ToString();

            // Пошук елементу за словом "wykonawца" (ігнорує регістр)
            int index = WorkerListBox.FindString(worker, -1);

            // Перевірка, чи знайдено відповідний елемент
            if (index != ListBox.NoMatches)
            {
                // Вибір знайденого елементу
                WorkerListBox.SelectedIndex = index;
            }
            else
            {
                // Обробка випадку, коли елемент не знайдено
            }

        }
        private async Task SaveDB()
        {
            CollectData();

            using SQLiteConnection conn = new(pathOrderManagement);

            await conn.OpenAsync();

            using var transaction = conn.BeginTransaction();

            try
            {
                // Використовуйте IF NOT EXISTS для створення таблиці лише у випадку, якщо вона не існує
                using SQLiteCommand createTable = new($"CREATE TABLE IF NOT EXISTS OrderManagement (ID INTEGER PRIMARY KEY AUTOINCREMENT, VIN TEXT, Przyjęty TEXT, OczekujeNaOdbiór TEXT, DataPrzyjęcie TEXT, DataOczekiwaniaOdbioru TEXT, DataPłatności TEXT, MetodaPłatności TEXT, KosztSzacunkowy INTEGER, KosztKońcowy INTEGER, KosztZMarżą INTEGER, WykonanaPraca TEXT, WykonawcaPracy TEXT);", conn);

                await createTable.ExecuteNonQueryAsync();


                using SQLiteCommand insert = new($"INSERT INTO OrderManagement (VIN, Przyjęty, OczekujeNaOdbiór, DataPrzyjęcie, DataOczekiwaniaOdbioru, DataPłatności, MetodaPłatności, KosztSzacunkowy, KosztKońcowy, KosztZMarżą, WykonanaPraca, WykonawcaPracy)" +
                "VALUES (@VIN, @Przyjęty, @OczekujeNaOdbiór, @DataPrzyjęcie, @DataOczekiwaniaOdbioru, @DataPłatności, @MetodaPłatności, @KosztSzacunkowy, @KosztKońcowy, @KosztZMarżą, @WykonanaPraca, @WykonawcaPracy)", conn);

                insert.Parameters.AddWithValue("@VIN", VIN);
                insert.Parameters.AddWithValue("@Przyjęty", orderManagment.OrderAddopted);
                insert.Parameters.AddWithValue("@OczekujeNaOdbiór", orderManagment.realiseOrder);
                insert.Parameters.AddWithValue("@DataPrzyjęcie", orderManagment.DateOrderAddopted);
                insert.Parameters.AddWithValue("@DataOczekiwaniaOdbioru", orderManagment.DateRealiseOrder);
                insert.Parameters.AddWithValue("@DataPłatności", orderManagment.DateOfPay);
                insert.Parameters.AddWithValue("@MetodaPłatności", orderManagment.TypeOfPay);
                insert.Parameters.AddWithValue("@KosztSzacunkowy", orderManagment.EstimatedCost);
                insert.Parameters.AddWithValue("@KosztKońcowy", orderManagment.Cost);
                insert.Parameters.AddWithValue("@KosztZMarżą", orderManagment.CostWithMarge);
                insert.Parameters.AddWithValue("@WykonanaPraca", orderManagment.WorkPerfomed);
                insert.Parameters.AddWithValue("@WykonawcaPracy", orderManagment.Employer);


                await insert.ExecuteNonQueryAsync();

                await transaction.CommitAsync();

                await LoadDB();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                dataError.Enqueue($"VIN:{VIN}");
                dataError.Enqueue($"Przyjęty: {orderManagment.OrderAddopted}");
                dataError.Enqueue($"OczekujeNaOdbiór:{orderManagment.realiseOrder}");
                dataError.Enqueue($"DataPrzyjęcie:{orderManagment.DateOrderAddopted} ");
                dataError.Enqueue($"DataOczekiwaniaOdbioru:{orderManagment.DateRealiseOrder}");
                dataError.Enqueue($"DataPłatności:{orderManagment.DateOfPay} ");
                dataError.Enqueue($"MetodaPłatności:{orderManagment.TypeOfPay}");
                dataError.Enqueue($"KosztSzacunkowy:{orderManagment.EstimatedCost}");
                dataError.Enqueue($"KosztKońcowy:{orderManagment.Cost} ");
                dataError.Enqueue($"KosztZMarżą:{orderManagment.CostWithMarge}");
                dataError.Enqueue($"WykonanaPraca:{orderManagment.WorkPerfomed} ");
                dataError.Enqueue($"WykonawcaPracy:{orderManagment.Employer}");



                await Settings.Error(ex, dataError, "OrderManagement", "problem with saving data or cmd SQL to ordermanagement");
                throw;
            }
            finally
            {
                /*                StanCheckBox.Checked = false;
                                PriceNumericUpDown.Value = IloscNumericUpDown.Value = 0;*/
            }
        }
        private async Task UpdateDB()
        {
            CollectData();
            using SQLiteConnection conn = new(pathOrderManagement);

            await conn.OpenAsync();

            using var transaction = conn.BeginTransaction();
            try
            {
                using SQLiteCommand update = new($"UPDATE OrderManagement SET VIN = @VIN, Przyjęty = @Przyjęty, OczekujeNaOdbiór = @OczekujeNaOdbiór, DataPrzyjęcie = @DataPrzyjęcie, DataOczekiwaniaOdbioru = @DataOczekiwaniaOdbioru, DataPłatności = @DataPłatności, MetodaPłatności = @MetodaPłatności, KosztSzacunkowy = @KosztSzacunkowy, KosztKońcowy = @KosztKońcowy, KosztZMarżą = @KosztZMarżą, WykonanaPraca = @WykonanaPraca, WykonawcaPracy = @WykonawcaPracy WHERE ID=@ID", conn);

                update.Parameters.AddWithValue("@ID", IdOrder);
                update.Parameters.AddWithValue("@VIN", VIN);
                update.Parameters.AddWithValue("@Przyjęty", orderManagment.OrderAddopted);
                update.Parameters.AddWithValue("@OczekujeNaOdbiór", orderManagment.realiseOrder);
                update.Parameters.AddWithValue("@DataPrzyjęcie", orderManagment.DateOrderAddopted);
                update.Parameters.AddWithValue("@DataOczekiwaniaOdbioru", orderManagment.DateRealiseOrder);
                update.Parameters.AddWithValue("@DataPłatności", orderManagment.DateOfPay);
                update.Parameters.AddWithValue("@MetodaPłatności", orderManagment.TypeOfPay);
                update.Parameters.AddWithValue("@KosztSzacunkowy", orderManagment.EstimatedCost);
                update.Parameters.AddWithValue("@KosztKońcowy", orderManagment.Cost);
                update.Parameters.AddWithValue("@KosztZMarżą", orderManagment.CostWithMarge);
                update.Parameters.AddWithValue("@WykonanaPraca", orderManagment.WorkPerfomed);
                update.Parameters.AddWithValue("@WykonawcaPracy", orderManagment.Employer);

                await update.ExecuteNonQueryAsync();

                await transaction.CommitAsync();

                await conn.CloseAsync();

                await LoadDB();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                dataError.Enqueue($"VIN:{VIN}");
                dataError.Enqueue($"Przyjęty: {orderManagment.OrderAddopted}");
                dataError.Enqueue($"OczekujeNaOdbiór:{orderManagment.realiseOrder}");
                dataError.Enqueue($"DataPrzyjęcie:{orderManagment.DateOrderAddopted} ");
                dataError.Enqueue($"DataOczekiwaniaOdbioru:{orderManagment.DateRealiseOrder}");
                dataError.Enqueue($"DataPłatności:{orderManagment.DateOfPay} ");
                dataError.Enqueue($"MetodaPłatności:{orderManagment.TypeOfPay}");
                dataError.Enqueue($"KosztSzacunkowy:{orderManagment.EstimatedCost}");
                dataError.Enqueue($"KosztKońcowy:{orderManagment.Cost} ");
                dataError.Enqueue($"KosztZMarżą:{orderManagment.CostWithMarge}");
                dataError.Enqueue($"WykonanaPraca:{orderManagment.WorkPerfomed} ");
                dataError.Enqueue($"WykonawcaPracy:{orderManagment.Employer}");

                await Settings.Error(ex, dataError, "OrderManagement", "problem with updating data or cmd SQL to OrderManagement");
                throw;
            }
            finally
            {
                /*                Id_Repair = 0;
                                Repair.Reset();
                                Settings.ClearTextBox(panelDodatkowy);
                                StanCheckBox.Checked = false;
                                ButtonRepairSave.Text = "Zapisz";
                                PriceNumericUpDown.Value = IloscNumericUpDown.Value = 0;*/
            }
        }
        private async Task DeleteDB(DataGridViewCellEventArgs e)
        {
            await SqlCmd.DeleteDataTable(ViewOrderManagement, e, pathOrderManagement, "BtnDelete", "ID", "OrderManagement");
        }
        private async Task LoadDB()
        {
            await SqlCmd.LoadData(pathOrderManagement, "SELECT ID, VIN, Przyjęty, OczekujeNaOdbiór, DataPrzyjęcie, DataOczekiwaniaOdbioru, DataPłatności, MetodaPłatności, KosztSzacunkowy, KosztKońcowy, KosztZMarżą, WykonanaPraca, WykonawcaPracy FROM OrderManagement", ViewOrderManagement, "order management", "Load data OrderManagement table from db");
        }
        private void VariablesDB()
        {

        }
        private async Task CalculateMarża(float x)
        {
            if (FinallPriceNumericUpDown.Value != 0)
            {
                if(Marża == 0)
                {
                    await ReadValueMarża();
                }
                

                float a = Marża / 100;
                float b = x * (Marża / 100);
                float c = b + x;
                float procentage = (x * (Marża / 100)) + x; //приведення Marża до типу float

                //MessageBox.Show($"Marża={Marża} \n a={a}; b={b}; c={c};");
                priceWithMarża.Text = procentage.ToString();
            }
            

        }
        private async Task ReadValueMarża()
        {

                using SQLiteConnection conn = new("Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;");
                await conn.OpenAsync();
                using SQLiteCommand cmd = new("SELECT Marża FROM DaneFirmy", conn);

                using SQLiteDataReader reader = cmd.ExecuteReader();

            while (await reader.ReadAsync()) // Опрацювання результатів запиту, якщо є
            {
                Marża = reader.GetInt32(0); // Отримання значення Marża з рядка результату запиту
            }
            //MessageBox.Show(s);

            

        }
        #endregion
        #endregion

        private async void FinallPriceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            float num =  Convert.ToUInt32(FinallPriceNumericUpDown.Value.ToString());
            await CalculateMarża(num);
        }
    }
}