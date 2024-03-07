using System.Data;
using System.Data.SQLite;

namespace Warsztat_2._0.UserControls
{
    public partial class UC_ViewDataCar : UserControl
    {
        #region VALUE
        private readonly string connectionString = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        string[] clientRead = new string[3];
        string[] carRead = new string[3];
        string[] historyRead = new string[3];

        #endregion
        public UC_ViewDataCar()
        {
            InitializeComponent();
        }
        #region Event
        private async void UC_ViewDataCar_Load(object sender, EventArgs e)
        {
            await LoadDB();
            try
            {

            }
            catch
            {

            }
        }
        #endregion
        #region Methods

        private async Task LoadDB()
        {

            //Queue<string> data = new();
            Queue<string> clientVIN = new();

            string[] client = new string[3];
            string[] car = new string[2];
            string[] history = new string[1];
            string[] orderManagemnt = new string[4];

            /////////ReadDataClient//////////
            using SQLiteConnection conn = new(connectionString);

            await conn.OpenAsync();
            #region ReadData from DB
            /////////////////////READ VIN/////////////////////
            using (SQLiteCommand cmdVIN = new("SELECT VIN_Samochodu FROM Klienty WHERE VIN_Samochodu IS NOT NULL", conn))
            {
                using SQLiteDataReader reader = cmdVIN.ExecuteReader();

                while (reader.Read())
                {
                    clientVIN.Enqueue($"{reader["VIN_Samochodu"]}");
                }
            }
            DataTable dataTable = new();
            ViewActualData.DataSource = dataTable;
            dataTable.Columns.Add("Imię");
            dataTable.Columns.Add("Nazwisko");
            dataTable.Columns.Add("Telefon");
            dataTable.Columns.Add("Marka");
            dataTable.Columns.Add("Model");
            dataTable.Columns.Add("Zlecenie");
            dataTable.Columns.Add("Przyjęty");
            dataTable.Columns.Add("OczekujeNaOdbiór");
            dataTable.Columns.Add("DataPrzyjęcie");
            dataTable.Columns.Add("KosztZMarżą");
            dataTable.Columns.Add("VIN");

            //////////////////////////////////////////////
            foreach (string vin in clientVIN)
            {
                Task task1 = Task.Run(() =>
                {
                    using (SQLiteCommand klient = new($"SELECT Imię, Nazwisko, NrTelefonu FROM Klienty WHERE VIN_Samochodu LIKE '%{vin}'", conn))
                    {
                        using SQLiteDataReader reader = klient.ExecuteReader();

                        while (reader.Read())
                        {
                            client[0] = $"{reader["Imię"]}";
                            client[1] = $"{reader["Nazwisko"]}";
                            client[2] = $"{reader["NrTelefonu"]}";
                        }
                    }

                    using (SQLiteCommand cmdCAR = new($"SELECT Model, Marka FROM Samochód WHERE VIN LIKE '%{vin}'", conn))
                    {
                        using SQLiteDataReader carRead = cmdCAR.ExecuteReader();
                        while (carRead.Read())
                        {
                            car[0] = $"{carRead["Marka"]}";
                            car[1] = $"{carRead["Model"]}";
                        }
                    }
                });
                Task task2 = Task.Run(() =>
                {
                    //////////////////////////////////////////
                    using (SQLiteCommand cmdHistory = new($"SELECT Zlecenie FROM HistoriaNapraw WHERE VIN LIKE '%{vin}'", conn))
                    {
                        using SQLiteDataReader hisotryRead = cmdHistory.ExecuteReader();
                        while (hisotryRead.Read())
                        {
                            history[0] = $"{hisotryRead["Zlecenie"]}";
                        }
                    }
                    //////////////////////////////////////////////////
                    using (SQLiteCommand cmdOrderManagement = new($"SELECT Przyjęty, OczekujeNaOdbiór, DataPrzyjęcie, KosztZMarżą FROM ZarządzanieZleceniami WHERE VIN LIKE '%{vin}'", conn))
                    {
                        using SQLiteDataReader orderManagementRead = cmdOrderManagement.ExecuteReader();
                        while (orderManagementRead.Read())
                        {
                            orderManagemnt[0] = $"{orderManagementRead["Przyjęty"]}";
                            orderManagemnt[1] = $"{orderManagementRead["OczekujeNaOdbiór"]}";
                            orderManagemnt[2] = $"{orderManagementRead["DataPrzyjęcie"]}";
                            orderManagemnt[3] = $"{orderManagementRead["KosztZMarżą"]}";

                        }
                    }
                });
                Task.WaitAll(task1, task2);
                #endregion
                #region Add data to table          

                dataTable.Rows.Add(client[0], client[1], client[2], car[0], car[1], history[0], orderManagemnt[0], orderManagemnt[1], orderManagemnt[2], orderManagemnt[3], vin);

                Array.Clear(client, 0, client.Length);
                Array.Clear(car, 0, car.Length);
                Array.Clear(history, 0, history.Length);
                Array.Clear(orderManagemnt, 0, orderManagemnt.Length);

                ViewActualData.DataSource = dataTable;
            }
            clientVIN.Clear();
            #endregion
        }
        #endregion

        private async void button2_Click(object sender, EventArgs e)
        {
            await CreatePDF();
        }

        private async Task CreatePDF()
        {
        }

        private void readData()
        {

            clientRead[0] = $"{ViewActualData.CurrentRow.Cells["Imię_Column"].Value.ToString()}";
            clientRead[1] = $"{ViewActualData.CurrentRow.Cells["Nazwisko_Column"].Value.ToString()}";
            clientRead[2] = $"{ViewActualData.CurrentRow.Cells["Telefon_Column"].Value.ToString()}";
            carRead[0] = $"{ViewActualData.CurrentRow.Cells["Marka_Column"].Value.ToString()}";
            carRead[1] = $"{ViewActualData.CurrentRow.Cells["Model_Column"].Value.ToString()}";
            carRead[2] = $"{ViewActualData.CurrentRow.Cells["VIN_Column"].Value.ToString()}";
            historyRead[0] =$"{ViewActualData.CurrentRow.Cells["DataPrzyjęcie_Column"].Value.ToString()}";
            historyRead[1] = $"{ViewActualData.CurrentRow.Cells["KosztZMarżą_Column"].Value.ToString()}";
        }
        private void ViewActualData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            readData();
        }

    }
}