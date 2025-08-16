namespace Warsztat_2.UserControls.BarMenu.Archive {
    public partial class UC_Archive :UserControl {
        private Guid uniqueKey;
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
            // 1) клік по заголовку/за межами таблиці – ігноруємо
            if(e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var grid = (DataGridView)sender;

            // 2) реагуємо лише на кнопку "BtnRecover"
            if(grid.Columns[e.ColumnIndex].Name != "BtnRecover") return;

            // 3) беремо саме той рядок, по якому клікнули
            var row = grid.Rows[e.RowIndex];

            var idObj = row.Cells["ID_Column"].Value;
            if(idObj == null || idObj == DBNull.Value) return;

            string id = idObj.ToString();

            // 4) один виклик для отримання ключа
            Guid uniqueKey = await SqlCmd.GetUniqueKey(
                id, "Klienty", "Data Source=Archive.db;Version=3;New=False;Compress=True;");

            bool ok = await SqlCmd.RecoverData(uniqueKey);
            if(ok)
                {
                MessageBox.Show("Dane zostałe przywrócone do domyślnej tablicy danych");

                // 5) видаляємо саме той рядок (після сортування індекси могли змінитися)
                grid.Rows.RemoveAt(e.RowIndex);
                // Якщо грід прив'язаний до BindingSource, роби так:
                // ((BindingSource)grid.DataSource).RemoveAt(grid.Rows[e.RowIndex].Index);
                }
            }

        private void OrderButton_Click(object sender, EventArgs e)
            {
            if(uniqueKey != Guid.Empty)
                {
                GeneretePDF pdf = new();
                pdf.Create(uniqueKey);
                }
            }
        }
    }