using System.Data;
using System.Data.SQLite;

namespace Warsztat_2._0.UserControls
{
    public partial class UC_ViewDataCar : UserControl
    {
        #region VALUE
        private readonly string connectionString = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        private readonly string connectionStringArchive = "Data Source=Archive.db;Version=3;New=False;Compress=True;";
        string[] clientRead = new string[3];
        string[] carRead = new string[3];
        string[] historyRead = new string[3];

        private string[] clientdata = new string[6];
        private string[] cardata = new string[5];
        private string[] historydata = new string[10];
        private string[] repairdata = new string[7];
        private string[] orderManagementdata = new string[12];

        string vin;

        bool operation = false;

        #endregion
        public UC_ViewDataCar()
        {
            InitializeComponent();
        }
        #region Event
        private async void UC_ViewDataCar_Load(object sender, EventArgs e)
        {

            try
            {
                await LoadDB();
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
            using (SQLiteCommand cmdVIN = new("SELECT VIN FROM Klienty WHERE VIN IS NOT NULL", conn))
            {
                using SQLiteDataReader reader = cmdVIN.ExecuteReader();

                while (reader.Read())
                {
                    clientVIN.Enqueue($"{reader["VIN"]}");
                }
            }
            string[] data = { "Imię", "Nazwisko", "Telefon", "Marka", "Model", "Zlecenie", "Przyjęty", "OczekujeNaOdbiór", "DataPrzyjęcie", "KosztZMarżą", "VIN" };

            DataTable dataTable = new();
            ViewActualData.DataSource = dataTable;

            foreach (string s in data)
                dataTable.Columns.Add(s);

            //////////////////////////////////////////////
            foreach (string vin in clientVIN)
            {
                Task task1 = Task.Run(() =>
                {
                    using (SQLiteCommand klient = new($"SELECT Imię, Nazwisko, NrTelefonu FROM Klienty WHERE VIN LIKE '%{vin}'", conn))
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

        void OrderButton_Click(object sender, EventArgs e)
        {
            GeneretePDF pdf = new GeneretePDF();
            pdf.Create(vin);
        }

        private void readData()
        {

            clientRead[0] = $"{ViewActualData.CurrentRow.Cells["Imię_Column"].Value.ToString()}";
            clientRead[1] = $"{ViewActualData.CurrentRow.Cells["Nazwisko_Column"].Value.ToString()}";
            clientRead[2] = $"{ViewActualData.CurrentRow.Cells["Telefon_Column"].Value.ToString()}";
            carRead[0] = $"{ViewActualData.CurrentRow.Cells["Marka_Column"].Value.ToString()}";
            carRead[1] = $"{ViewActualData.CurrentRow.Cells["Model_Column"].Value.ToString()}";
            carRead[2] = $"{ViewActualData.CurrentRow.Cells["VIN_Column"].Value.ToString()}";
            historyRead[0] = $"{ViewActualData.CurrentRow.Cells["DataPrzyjęcie_Column"].Value.ToString()}";
            historyRead[1] = $"{ViewActualData.CurrentRow.Cells["KosztZMarżą_Column"].Value.ToString()}";
        }
        private void ViewActualData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            readData();
        }

        private void ViewActualData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vin = $"{ViewActualData.CurrentRow.Cells["VIN_Column"].Value.ToString()}";
            int selectedIndex = (int)ViewActualData.CurrentRow.Index;
            if (e.ColumnIndex == ViewActualData.Columns["BtnDelete"].Index)
            {
                DialogResult dialogResult = MessageBox.Show("Na pewno chcesz usunąć te dane?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteData(vin, selectedIndex);
                }
            }
            else if (e.ColumnIndex == ViewActualData.Columns["BtnFinish"].Index)
            {
                DialogResult dialogResult = MessageBox.Show("Na pewno chcesz oznaczyć samochód jak wykonany?", "Potwierdzenie wykonania", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SendDataToArchive(vin, selectedIndex);
                }
            }
        }
        private async void DeleteData(string vin, int index)
        {
            Cursor.Current = Cursors.WaitCursor;
            string[] nameTable = { "Klienty", "Samochód", "HistoriaNapraw", "ZarządzanieZleceniami", "NaprawaSamochodu" };
            try
            {
                using SQLiteConnection conn = new(connectionString);
                await conn.OpenAsync();

                foreach (string table in nameTable)
                {
                    SQLiteCommand delete = new($"DELETE FROM {table} WHERE VIN = @VIN", conn);
                    delete.Parameters.AddWithValue("@VIN", vin);
                    await delete.ExecuteNonQueryAsync();
                }
                ViewActualData.Rows.RemoveAt(index);
            }
            catch
            {
                MessageBox.Show("Błąd usunięcia tabeli");
            }
        }
        private void SendDataToArchive(string vin, int index)
        {
            ReadData(vin);
            SaveData(vin);
            if (operation == true)
            {
                DeleteData(vin, index);

                MessageBox.Show("Operacja przebiegła pomyślne i bez problemu");

                operation = false;
            }

        }
        private void ReadData(string vin)
        {
            Cursor.Current = Cursors.WaitCursor;

            using SQLiteConnection conn = new(connectionString);

            conn.Open();

            using var transaction = conn.BeginTransaction();
            try
            {
                copyData(conn, vin);

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Błąd pod czas odczytu bazy danych\n" + ex);
                throw;
            }
            Cursor.Current = Cursors.Default;
        }
        private void SaveData(string vin)
        {
            Cursor.Current = Cursors.WaitCursor;

            using SQLiteConnection conn = new(connectionStringArchive);

            conn.Open();

            using var transaction = conn.BeginTransaction();
            try
            {
                SaveToArchive(conn);

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                MessageBox.Show("Błąd pod czas archiwizacji bazy danych");
                throw;
            }
            Cursor.Current = Cursors.Default;
        }
        private void copyData(SQLiteConnection conn, string vin)
        {
            //////////////read client data
            using SQLiteCommand client = new($"SELECT Imię, Nazwisko, NrTelefonu, AdresFirmy, NIP FROM Klienty WHERE VIN LIKE '%{vin}'", conn);
            using SQLiteDataReader clientReader = client.ExecuteReader();

            while (clientReader.Read())
            {
                clientdata[0] = $"{clientReader["Imię"]}";
                clientdata[1] = $"{clientReader["Nazwisko"]}";
                clientdata[2] = $"{clientReader["NrTelefonu"]}";
                clientdata[3] = $"{clientReader["AdresFirmy"]}";
                clientdata[4] = $"{clientReader["NIP"]}";
                clientdata[5] = vin;
            }
            //////////////////read car data
            using SQLiteCommand car = new($"SELECT Marka, Model, Silnik, RokProdukcji FROM Samochód WHERE VIN LIKE '%{vin}'", conn);
            using SQLiteDataReader carReader = car.ExecuteReader();

            while (carReader.Read())
            {
                cardata[0] = $"{carReader["Marka"]}";
                cardata[1] = $"{carReader["Model"]}";
                cardata[2] = $"{carReader["Silnik"]}";
                cardata[3] = $"{carReader["RokProdukcji"]}";
                cardata[4] = vin;
            }

            using SQLiteCommand history = new($"SELECT DataPrzyjęcia, NrRejestracji, Przebieg, DokumentySamochodu, KluczykiSamochodu, TestDrive, Zlecenie, Diagnostyka, Naprawa FROM HistoriaNapraw WHERE VIN LIKE '%{vin}'", conn);
            using SQLiteDataReader historyReader = history.ExecuteReader();

            while (historyReader.Read())
            {
                historydata[0] = $"{historyReader["DataPrzyjęcia"]}";
                historydata[1] = $"{historyReader["NrRejestracji"]}";
                historydata[2] = $"{historyReader["Przebieg"]}";
                historydata[3] = $"{historyReader["DokumentySamochodu"]}";
                historydata[4] = $"{historyReader["KluczykiSamochodu"]}";
                historydata[5] = $"{historyReader["TestDrive"]}";
                historydata[6] = $"{historyReader["Zlecenie"]}";
                historydata[7] = $"{historyReader["Diagnostyka"]}";
                historydata[8] = $"{historyReader["Naprawa"]}";
                historydata[9] = vin;
            }
            //////////////////read repair data
            using SQLiteCommand repair = new($"SELECT Opis, NumerCzęści, Cena, Ilość, Stan, DataNapraw FROM NaprawaSamochodu WHERE VIN LIKE '%{vin}'", conn);
            using SQLiteDataReader repairReader = repair.ExecuteReader();

            while (repairReader.Read())
            {
                repairdata[0] = $"{repairReader["Opis"]}";
                repairdata[1] = $"{repairReader["NumerCzęści"]}";
                repairdata[2] = $"{repairReader["Cena"]}";
                repairdata[3] = $"{repairReader["Ilość"]}";
                repairdata[4] = $"{repairReader["Stan"]}";
                repairdata[5] = $"{repairReader["DataNapraw"]}";
                repairdata[6] = vin;
            }
            //////////////////read repair data
            using SQLiteCommand ordermanagement = new($"SELECT VIN, Przyjęty, OczekujeNaOdbiór, DataPrzyjęcie, DataOczekiwaniaOdbioru, DataPłatności, MetodaPłatności, KosztSzacunkowy, KosztKońcowy, KosztZMarżą, WykonanaPraca, WykonawcaPracy FROM ZarządzanieZleceniami WHERE VIN LIKE '%{vin}'", conn);
            using SQLiteDataReader ordermanagementReader = ordermanagement.ExecuteReader();

            while (ordermanagementReader.Read())
            {
                orderManagementdata[0] = vin;
                orderManagementdata[1] = $"{ordermanagementReader["Przyjęty"]}";
                orderManagementdata[2] = $"{ordermanagementReader["OczekujeNaOdbiór"]}";
                orderManagementdata[3] = $"{ordermanagementReader["DataPrzyjęcie"]}";
                orderManagementdata[4] = $"{ordermanagementReader["DataOczekiwaniaOdbioru"]}";
                orderManagementdata[5] = $"{ordermanagementReader["DataPłatności"]}";
                orderManagementdata[6] = $"{ordermanagementReader["MetodaPłatności"]}";
                orderManagementdata[7] = $"{ordermanagementReader["KosztSzacunkowy"]}";
                orderManagementdata[8] = $"{ordermanagementReader["KosztKońcowy"]}";
                orderManagementdata[9] = $"{ordermanagementReader["KosztZMarżą"]}";
                orderManagementdata[10] = $"{ordermanagementReader["WykonanaPraca"]}";
                orderManagementdata[11] = $"{ordermanagementReader["WykonawcaPracy"]}";
            }
        }
        private void SaveToArchive(SQLiteConnection conn)
        {
            using SQLiteCommand insertClient = new("INSERT INTO Klienty (Imię, Nazwisko, NrTelefonu, AdresFirmy, NIP, VIN) VALUES(@Imię, @Nazwisko, @NrTelefonu, @AdresFirmy, @NIP, @VIN)", conn);

            string[] valueClient = { "@Imię", "@Nazwisko", "@NrTelefonu", "@AdresFirmy", "@NIP", "@VIN" };

            for (int i = 0; i < clientdata.Length; i++)
                insertClient.Parameters.AddWithValue(valueClient[i], clientdata[i]);

            insertClient.ExecuteNonQuery();
            ///////////////////////////////////////////////////////////////////////////
            using SQLiteCommand insertCar = new("INSERT INTO Samochód (Marka, Model, Silnik, RokProdukcji, VIN)" +
                "VALUES (@Marka, @Model, @Silnik, @RokProdukcji, @VIN)", conn);

            string[] valueCar = { "@Marka", "@Model", "@Silnik", "@RokProdukcji", "@VIN" };

            for (int i = 0; i < cardata.Length; i++)
                insertCar.Parameters.AddWithValue(valueCar[i], cardata[i]);

            insertCar.ExecuteNonQuery();
            ///////////////////////////////////////////////////////////////////////////
            using SQLiteCommand insertHistory = new($"INSERT INTO HistoriaNapraw (DataPrzyjęcia, NrRejestracji, Przebieg, DokumentySamochodu, KluczykiSamochodu, TestDrive, Zlecenie, Diagnostyka, Naprawa, VIN)" +
                        "VALUES (@DataPrzyjęcia, @NrRejestracji, @Przebieg, @DokumentySamochodu, @KluczykiSamochodu, @TestDrive, @Zlecenie, @Diagnostyka, @Naprawa, @VIN)", conn);

            string[] valueHistory = { "@DataPrzyjęcia", "@NrRejestracji", "@Przebieg", "@DokumentySamochodu", "@KluczykiSamochodu", "@TestDrive", "@Zlecenie", "@Diagnostyka", "@Naprawa", "@VIN" };

            for (int i = 0; i < historydata.Length; i++)
                insertHistory.Parameters.AddWithValue(valueHistory[i], historydata[i]);

            insertHistory.ExecuteNonQuery();
            ///////////////////////////////////////////////////////////////////////////
            using SQLiteCommand insertRepair = new($"INSERT INTO NaprawaSamochodu (Opis, NumerCzęści, Cena, Ilość, Stan, DataNapraw, VIN)" +
                        "VALUES (@Opis, @NumerCzęści, @Cena, @Ilość, @Stan, @DataNapraw, @VIN)", conn);

            string[] valueRepair = { "@Opis", "@NumerCzęści", "@Cena", "@Ilość", "@Stan", "@DataNapraw", "@VIN" };

            for (int i = 0; i < repairdata.Length; i++)
                insertRepair.Parameters.AddWithValue(valueRepair[i], repairdata[i]);

            insertRepair.ExecuteNonQuery();
            ///////////////////////////////////////////////////////////////////////////
            using SQLiteCommand insertOrderManagement = new($"INSERT INTO ZarządzanieZleceniami (VIN, Przyjęty, OczekujeNaOdbiór, DataPrzyjęcie, DataOczekiwaniaOdbioru, DataPłatności, MetodaPłatności, KosztSzacunkowy, KosztKońcowy, KosztZMarżą, WykonanaPraca, WykonawcaPracy)" +
               "VALUES (@VIN, @Przyjęty, @OczekujeNaOdbiór, @DataPrzyjęcie, @DataOczekiwaniaOdbioru, @DataPłatności, @MetodaPłatności, @KosztSzacunkowy, @KosztKońcowy, @KosztZMarżą, @WykonanaPraca, @WykonawcaPracy)", conn);

            string[] valueOrderManagement = { "@VIN", "@Przyjęty", "@OczekujeNaOdbiór", "@DataPrzyjęcie", "@DataOczekiwaniaOdbioru", "@DataPłatności", "@MetodaPłatności", "@KosztSzacunkowy", "@KosztKońcowy", "@KosztZMarżą", "@WykonanaPraca", "@WykonawcaPracy" };

            for (int i = 0; i < orderManagementdata.Length; i++)
                insertOrderManagement.Parameters.AddWithValue(valueOrderManagement[i], orderManagementdata[i]);

            insertOrderManagement.ExecuteNonQuery();

            operation = true;
        }
    }
}