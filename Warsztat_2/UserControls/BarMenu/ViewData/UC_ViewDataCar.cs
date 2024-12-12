using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace Warsztat_2._0.UserControls {
    public partial class UC_ViewDataCar :UserControl {
        #region VALUE
        private readonly string[] connectionStringArray = new string[] { "Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;", "Data Source=Archive.db;Version=3;New=False;Compress=True;" };


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
            //string[] tableNames = { "Imię", "Nazwisko", "NrTelefonu", "Marka", "Model", "Zlecenie", "DataPrzyjęcia", "WykonawcaPracy", "DataOczekiwaniaOdbioru", "KosztKońcowy", "UniqueKey" };

            string query = @"
    SELECT 
        Klienty.Imię, 
        Klienty.Nazwisko, 
        Klienty.NrTelefonu, 
        Samochód.Marka, 
        Samochód.Model, 
        Samochód.VIN,
        HistoriaNapraw.Zlecenie,
        HistoriaNapraw.DataPrzyjęcia,
        ZarządzanieZleceniem.WykonawcaPracy, 
        ZarządzanieZleceniem.DataOczekiwaniaOdbioru, 
        ZarządzanieZleceniem.KosztKońcowy
    FROM Klienty
    LEFT JOIN Samochód ON Klienty.UniqueKey = Samochód.UniqueKey
    LEFT JOIN HistoriaNapraw ON Klienty.UniqueKey = HistoriaNapraw.UniqueKey
    LEFT JOIN ZarządzanieZleceniem ON Klienty.UniqueKey = ZarządzanieZleceniem.UniqueKey
    WHERE Klienty.UniqueKey IS NOT NULL";

            using SQLiteConnection conn = new(connectionStringArray[0]);
            await conn.OpenAsync();

            SQLiteDataAdapter adapter = new(query, conn);
            DataTable dataTable = new ();

            adapter.Fill(dataTable);

            ViewActualData.DataSource = dataTable;
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
/*
            clientRead[0] = $"{ViewActualData.CurrentRow.Cells["Imię_Column"].Value}";
            clientRead[1] = $"{ViewActualData.CurrentRow.Cells["Nazwisko_Column"].Value}";
            clientRead[2] = $"{ViewActualData.CurrentRow.Cells["Telefon_Column"].Value}";
            carRead[0] = $"{ViewActualData.CurrentRow.Cells["Marka_Column"].Value}";
            carRead[1] = $"{ViewActualData.CurrentRow.Cells["Model_Column"].Value}";
            carRead[2] = $"{ViewActualData.CurrentRow.Cells["VIN_Column"].Value}";
            historyRead[0] = $"{ViewActualData.CurrentRow.Cells["DataPrzyjęcie_Column"].Value}";
            historyRead[1] = $"{ViewActualData.CurrentRow.Cells["KosztZMarżą_Column"].Value}";*/
            }
        private void ViewActualData_MouseDoubleClick(object sender, MouseEventArgs e)
            {
            ReadData();
            }

        private void ViewActualData_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            vin = $"{ViewActualData.CurrentRow.Cells["VIN_Column"].Value}";
            int selectedIndex = (int)ViewActualData.CurrentRow.Index;
            if(e.ColumnIndex == ViewActualData.Columns["BtnDelete"].Index)
                {
                DialogResult dialogResult = MessageBox.Show("Na pewno chcesz usunąć te dane?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                    {
                    DeleteData(vin, selectedIndex);
                    }
                }
            else if(e.ColumnIndex == ViewActualData.Columns["BtnFinish"].Index)
                {
                DialogResult dialogResult = MessageBox.Show("Na pewno chcesz oznaczyć samochód jak wykonany?", "Potwierdzenie wykonania", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
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

                foreach(string table in nameTable)
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