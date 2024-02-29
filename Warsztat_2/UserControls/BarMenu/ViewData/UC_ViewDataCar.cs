using System.Data;
using System.Data.SQLite;

namespace Warsztat_2._0.UserControls
{
    public partial class UC_ViewDataCar : UserControl
    {
        #region VALUE
        private readonly string connectionString = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
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
        /*        private async Task LoadDB()
                {
                    Queue<string> data = new();
                    /////////ReadDataClient//////////
                    using SQLiteConnection conn = new(connectionString);

                    await conn.OpenAsync();
                    #region ReadData from DB

                    using (SQLiteCommand klient = new("SELECT Imię, Nazwisko, NrTelefonu, VIN_Samochodu FROM Klienty WHERE VIN_Samochodu IS NOT NULL", conn))
                    {
                        using SQLiteDataReader reader = klient.ExecuteReader();

                        while (reader.Read())
                        {
                            data.Enqueue($"{reader["Imię"]} {reader["Nazwisko"]} {reader["NrTelefonu"]} {reader["VIN_Samochodu"]}");
                        }
                    }

                    //////////////////////////////////////////////
                    string[] clientInfo = data.Dequeue().Split(' ');
                    //ŚMessageBox.Show($"clientInfo2:{clientInfo[2]}");
                    if (clientInfo[3] == "")
                    {
                        return;
                    }
                    using (SQLiteCommand cmdCAR = new SQLiteCommand($"SELECT Model, Marka FROM Samochód WHERE VIN LIKE '%{clientInfo[3]}'", conn))
                    {
                        using SQLiteDataReader carRead = cmdCAR.ExecuteReader();
                        while (carRead.Read())
                        {
                            data.Enqueue($"{carRead["Marka"]} {carRead["Model"]}");
                        }
                    }
                    string[] CarInfo = data.Dequeue().Split(" ");
                    //////////////////////////////////////////
                    using (SQLiteCommand cmdHistory = new($"SELECT Zlecenie FROM HistoriaNapraw WHERE VIN LIKE '%{clientInfo[3]}'", conn))
                    {
                        using SQLiteDataReader hisotryRead = cmdHistory.ExecuteReader();
                        while (hisotryRead.Read())
                        {
                            data.Enqueue($"{hisotryRead["Zlecenie"]}");
                        }
                    }
                    string HistoryInfo = data.Dequeue();
                    //////////////////////////////////////////////////
                    using (SQLiteCommand cmdOrderManagement = new($"SELECT Przyjęty, OczekujeNaOdbiór, DataPrzyjęcie, KosztZMarżą FROM ZarządzanieZleceniami WHERE VIN LIKE '%{clientInfo[3]}'", conn))
                    {
                        using SQLiteDataReader orderManagementRead = cmdOrderManagement.ExecuteReader();
                        while (orderManagementRead.Read())
                        {
                            data.Enqueue($"{orderManagementRead["Przyjęty"]}|{orderManagementRead["OczekujeNaOdbiór"]}|{orderManagementRead["DataPrzyjęcie"]}|{orderManagementRead["KosztZMarżą"]}");
                        }
                    }
                    string[] oMI = data.Dequeue().Split("|");//order Management Info (oMI)
                    #endregion
                    #region Add data to table            
                    DataTable dataTable = new();
                    dataTable.Columns.Add("Imię");
                    dataTable.Columns.Add("Nazwisko");
                    dataTable.Columns.Add("Telefon");
                    dataTable.Columns.Add("Model");
                    dataTable.Columns.Add("Marka");
                    dataTable.Columns.Add("Zlecenie");
                    dataTable.Columns.Add("Przyjęty");
                    dataTable.Columns.Add("OczekujeNaOdbiór");
                    dataTable.Columns.Add("DataPrzyjęcie");
                    dataTable.Columns.Add("KosztZMarżą");

                    DataRow row = dataTable.NewRow();
                    row["Imię"] = clientInfo[0]; // Використовуйте відповідні імена колонок з вашої таблиці
                    row["Nazwisko"] = clientInfo[1];
                    row["Telefon"] = clientInfo[2];
                    row["Marka"] = CarInfo[0];
                    row["Model"] = CarInfo[1];
                    row["Zlecenie"] = HistoryInfo;

                    row["Przyjęty"] = oMI[0];
                    row["OczekujeNaOdbiór"] = oMI[1];
                    row["DataPrzyjęcie"] = oMI[2];
                    row["KosztZMarżą"] = oMI[3];



                    dataTable.Rows.Add(row);

                    ViewActualData.DataSource = dataTable;
                    //HistoryInfo = null;
                   // ClearArray(clientInfo, CarInfo, oMI);
                    #endregion
                }
                private void ClearArray(string[] I, string[] II, string[] III)
                {
                    for (int i = 0; i < I.Length; i++)
                    {
                        I[i] = "";
                    }
                    for (int i = 0; i < II.Length; i++)
                    {
                        II[i] = "";
                    }
                    for (int i = 0; i < III.Length; i++)
                    {
                        III[i] = "";
                    }
                }*/
        private async Task LoadDB()
        {

            //Queue<string> data = new();
            Queue<string> clientVIN = new();
            
            string[] client= new string[3];
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
            dataTable.Columns.Add("Imię");
            dataTable.Columns.Add("Nazwisko");
            dataTable.Columns.Add("Telefon");
            dataTable.Columns.Add("Model");
            dataTable.Columns.Add("Marka");
            dataTable.Columns.Add("Zlecenie");
            dataTable.Columns.Add("Przyjęty");
            dataTable.Columns.Add("OczekujeNaOdbiór");
            dataTable.Columns.Add("DataPrzyjęcie");
            dataTable.Columns.Add("KosztZMarżą");
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


                DataRow row = dataTable.NewRow();

                row["Imię"] = client[0];// Використовуйте відповідні імена колонок з вашої таблиці
                row["Nazwisko"] = client[1];
                row["Telefon"] = client[2];

                row["Marka"] = car[0];
                row["Model"] = car[1];

                row["Zlecenie"] = history[0];

                row["Przyjęty"] = orderManagemnt[0];
                row["OczekujeNaOdbiór"] = orderManagemnt[1];
                row["DataPrzyjęcie"] = orderManagemnt[2];
                row["KosztZMarżą"] = orderManagemnt[3];

                dataTable.Rows.Add(row);
                Array.Clear(client,0, client.Length);
                Array.Clear(car, 0, car.Length);
                Array.Clear(history, 0, history.Length);
                Array.Clear(orderManagemnt, 0, orderManagemnt.Length);
                ViewActualData.DataSource = dataTable;
            }
            #endregion
        }
        #endregion
    }
}
