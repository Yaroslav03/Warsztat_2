using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Warsztat_2._0.UserControls
{
    public partial class UC_ViewDataCar : UserControl
    {
        #region VALUE
        private readonly string[] connectionStringArray = new string[] { "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;", "Data Source=Archive.db;Version=3;New=False;Compress=True;" };
        private readonly string[] clientRead = new string[3];
        private readonly string[] carRead = new string[3];
        private readonly string[] historyRead = new string[3];

        private string? vin;

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
            using SQLiteConnection conn = new(connectionStringArray[0]);

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
            if(vin != null)
            {
                GeneretePDF pdf = new();
                pdf.Create(vin);

            }            
        }

        private void ReadData()
        {

            clientRead[0] = $"{ViewActualData.CurrentRow.Cells["Imię_Column"].Value}";
            clientRead[1] = $"{ViewActualData.CurrentRow.Cells["Nazwisko_Column"].Value}";
            clientRead[2] = $"{ViewActualData.CurrentRow.Cells["Telefon_Column"].Value}";
            carRead[0] = $"{ViewActualData.CurrentRow.Cells["Marka_Column"].Value}";
            carRead[1] = $"{ViewActualData.CurrentRow.Cells["Model_Column"].Value}";
            carRead[2] = $"{ViewActualData.CurrentRow.Cells["VIN_Column"].Value}";
            historyRead[0] = $"{ViewActualData.CurrentRow.Cells["DataPrzyjęcie_Column"].Value}";
            historyRead[1] = $"{ViewActualData.CurrentRow.Cells["KosztZMarżą_Column"].Value}";
        }
        private void ViewActualData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ReadData();
        }

        private void ViewActualData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vin = $"{ViewActualData.CurrentRow.Cells["VIN_Column"].Value}";
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
                    
                    SqlCmd.SendDataToArchive(vin, connectionStringArray);
                    ViewActualData.Rows.RemoveAt(selectedIndex);
                }
            }
        }
        private async void DeleteData(string vin, int index)
        {
            Cursor.Current = Cursors.WaitCursor;
            string[] nameTable = { "Klienty", "Samochód", "HistoriaNapraw", "ZarządzanieZleceniami", "NaprawaSamochodu" };
            try
            {
                using SQLiteConnection conn = new(connectionStringArray[0]);
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
    }
}