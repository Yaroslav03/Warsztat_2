namespace Warsztat_2._0.UserControls
{
    public partial class UC_ViewDataCar :UserControl {
        #region VALUE
        private readonly string[] connectionStringArray = new string[] { "Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;", "Data Source=Archive.db;Version=3;New=False;Compress=True;" };
        readonly private string directory = "pdf\\";
        Guid uniqueKey;
        private string? vin;
        private string id;

        #endregion
        public UC_ViewDataCar()
            {
            InitializeComponent();
            }
        #region Event
        private async void UC_ViewDataCar_Load(object sender, EventArgs e)
            {
            await LoadDB();
            }
        #endregion
        #region Methods

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
        ZarządzanieZleceniem.KosztKońcowy
    FROM Klienty
    LEFT JOIN Samochód ON Klienty.UniqueKey = Samochód.UniqueKey
    LEFT JOIN HistoriaNapraw ON Klienty.UniqueKey = HistoriaNapraw.UniqueKey
    LEFT JOIN ZarządzanieZleceniem ON Klienty.UniqueKey = ZarządzanieZleceniem.UniqueKey
    WHERE Klienty.UniqueKey IS NOT NULL";
            await SqlCmd.LoadData(query, ViewActualData, "ViewData", "error");

            }
        #endregion

        public async void InsuranceButton_Click(object sender, EventArgs e)
            {
            if(uniqueKey != null)
                {
                GeneretePDF pdf = new();
                pdf.GeneratePDFSecondType(uniqueKey);
                }
            }

        private async void ViewActualData_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            id = $"{ViewActualData.CurrentRow.Cells["ID_Column"].Value}";
            int selectedIndex = (int)ViewActualData.CurrentRow.Index;

            uniqueKey = await SqlCmd.GetUniqueKey(id, "Klienty");

            if(e.ColumnIndex == ViewActualData.Columns["BtnDelete"].Index)
                {
                DialogResult dialogResult = MessageBox.Show("Na pewno chcesz usunąć te dane?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                    {
                    bool isSucced = await DeleteData(uniqueKey);
                    if(isSucced)
                        {
                        ViewActualData.Rows.RemoveAt(selectedIndex);
                        }
                    }
                }
            else if(e.ColumnIndex == ViewActualData.Columns["BtnFinish"].Index)
                {
                DialogResult dialogResult = MessageBox.Show("Na pewno chcesz oznaczyć samochód jak wykonany?", "Potwierdzenie wykonania", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                    {

                    bool isSucceed = await SqlCmd.SendToArchive(uniqueKey);
                    if(isSucceed)
                        {
                        MessageBox.Show("Dane zostałe wysłane do archiwum");
                        ViewActualData.Rows.RemoveAt(selectedIndex);
                        }
                    }
                }
            }
        private async Task<bool> DeleteData(Guid uniqueKey)
            {
            string[] tables = { "Klienty", "Samochód", "NaprawaSamochodu", "HistoriaNapraw", "ZarządzanieZleceniem" };
            var key = new Dictionary<string, object>
            {
                {"UniqueKey", uniqueKey}
            };
            try
                {
                foreach(var table in tables)
                    {
                    await SqlCmd.DeleteRecordAsync("WarsztatDB", table, "UniqueKey=@UniqueKey", key);
                    }
                return true;
                }
            catch(Exception ex)
                {
                return false;
                }
            }

        private void PathButton_Click(object sender, EventArgs e)
            {
            System.Diagnostics.Process.Start("explorer.exe", directory);
            }

        private async void ViewActualData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
            if(e.RowIndex >= 0)
                {
                id = $"{ViewActualData.CurrentRow.Cells["ID_Column"].Value}";
                int selectedIndex = (int)ViewActualData.CurrentRow.Index;

                uniqueKey = await SqlCmd.GetUniqueKey(id, "Klienty");
                CarSelected?.Invoke(this, uniqueKey);
                }
            }

        private async void UC_ViewDataCar_VisibleChanged(object sender, EventArgs e)
            {
            await LoadDB();
            }

        public event EventHandler<Guid> CarSelected;
        }
    }