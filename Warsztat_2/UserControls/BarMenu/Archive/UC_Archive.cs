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
            string query = @"
    SELECT 
        Klienty.ID,
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
        ZarządzanieZleceniem.DataZamknięciaZlecenia,
        ZarządzanieZleceniem.KosztKońcowy
    FROM Klienty
    LEFT JOIN Samochód ON Klienty.UniqueKey = Samochód.UniqueKey
    LEFT JOIN HistoriaNapraw ON Klienty.UniqueKey = HistoriaNapraw.UniqueKey
    LEFT JOIN ZarządzanieZleceniem ON Klienty.UniqueKey = ZarządzanieZleceniem.UniqueKey
    WHERE Klienty.UniqueKey IS NOT NULL";

            await SqlCmd.LoadData(query, ViewActualData, "ViewData", "error", null, "Data Source=Archive.db;Version=3;New=False;Compress=True;");
            }

        private async void ViewActualData_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            string? id = ViewActualData.Rows[e.RowIndex].Cells["ID_Column"].Value.ToString();
            int selectedIndex = (int)ViewActualData.CurrentRow.Index;

            if(e.ColumnIndex == ViewActualData.Columns["BtnRecover"].Index && ViewActualData.Rows[e.RowIndex].Cells["ID_Column"].Value != DBNull.Value && id != null)
                {
                Guid uniqueKey = await SqlCmd.GetUniqueKey(id, "Klienty", "Data Source=Archive.db;Version=3;New=False;Compress=True;");
                bool isSucceed = await SqlCmd.RecoverData(uniqueKey);
                if(isSucceed)
                    {
                    MessageBox.Show("Dane zostałe przywrócone do domyślnej tablicy danych");
                    ViewActualData.Rows.RemoveAt(selectedIndex);
                    }
                }
            }
        }
    }