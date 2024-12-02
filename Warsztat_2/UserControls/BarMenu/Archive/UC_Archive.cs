using System.Data;
using System.Data.SQLite;

namespace Warsztat_2.UserControls.BarMenu.Archive {
    public partial class UC_Archive :UserControl {
        private readonly string connectionStringArchive = "Data Source=Archive.db;Version=3;New=False;Compress=True;";
        public UC_Archive()
            {
            InitializeComponent();
            }

        private async void UC_Archive_Load(object sender, EventArgs e)
            {
            await LoadDB();
            }
        private async Task LoadDB()
            {
            //Queue<string> data = new();
            Queue<string> clientVIN = new();

            string[] client = new string[3];
            string[] car = new string[2];
            string[] history = new string[1];
            string[] orderManagemnt = new string[4];

            /////////ReadDataClient//////////
            using SQLiteConnection conn = new(connectionStringArchive);

            await conn.OpenAsync();
            #region ReadData from DB
            /////////////////////READ VIN/////////////////////
            using(SQLiteCommand cmdVIN = new("SELECT VIN FROM Klienty WHERE VIN IS NOT NULL", conn))
                {
                using SQLiteDataReader reader = cmdVIN.ExecuteReader();

                while(reader.Read())
                    {
                    clientVIN.Enqueue($"{reader["VIN"]}");
                    }
                }
            string[] data = { "Imię", "Nazwisko", "Telefon", "Marka", "Model", "Zlecenie", "Przyjęty", "OczekujeNaOdbiór", "DataPrzyjęcie", "KosztZMarżą", "VIN" };
            DataTable dataTable = new();
            ViewActualData.DataSource = dataTable;

            foreach(string s in data)
                dataTable.Columns.Add(s);

            //////////////////////////////////////////////
            foreach(string vin in clientVIN)
                {
                Task task1 = Task.Run(() =>
                {
                    using(SQLiteCommand klient = new($"SELECT Imię, Nazwisko, NrTelefonu FROM Klienty WHERE VIN LIKE '%{vin}'", conn))
                        {
                        using SQLiteDataReader reader = klient.ExecuteReader();

                        while(reader.Read())
                            {
                            client[0] = $"{reader["Imię"]}";
                            client[1] = $"{reader["Nazwisko"]}";
                            client[2] = $"{reader["NrTelefonu"]}";
                            }
                        }

                    using SQLiteCommand cmdCAR = new($"SELECT Model, Marka FROM Samochód WHERE VIN LIKE '%{vin}'", conn);
                    using SQLiteDataReader carRead = cmdCAR.ExecuteReader();
                    while(carRead.Read())
                        {
                        car[0] = $"{carRead["Marka"]}";
                        car[1] = $"{carRead["Model"]}";
                        }
                });
                Task task2 = Task.Run(() =>
                {
                    //////////////////////////////////////////
                    using(SQLiteCommand cmdHistory = new($"SELECT Zlecenie FROM HistoriaNapraw WHERE VIN LIKE '%{vin}'", conn))
                        {
                        using SQLiteDataReader hisotryRead = cmdHistory.ExecuteReader();
                        while(hisotryRead.Read())
                            {
                            history[0] = $"{hisotryRead["Zlecenie"]}";
                            }
                        }
                    //////////////////////////////////////////////////
                    using SQLiteCommand cmdOrderManagement = new($"SELECT Przyjęty, OczekujeNaOdbiór, DataPrzyjęcie, KosztZMarżą FROM ZarządzanieZleceniami WHERE VIN LIKE '%{vin}'", conn);
                    using SQLiteDataReader orderManagementRead = cmdOrderManagement.ExecuteReader();
                    while(orderManagementRead.Read())
                        {
                        orderManagemnt[0] = $"{orderManagementRead["Przyjęty"]}";
                        orderManagemnt[1] = $"{orderManagementRead["OczekujeNaOdbiór"]}";
                        orderManagemnt[2] = $"{orderManagementRead["DataPrzyjęcie"]}";
                        orderManagemnt[3] = $"{orderManagementRead["KosztZMarżą"]}";

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
        }
    }