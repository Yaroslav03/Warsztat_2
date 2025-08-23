using System.Data;
using System.Windows.Forms;
using Warsztat_2._0;

namespace Warsztat_2.UserControls.BarMenu.Archive {
    public partial class UC_Archive :UserControl {
        private Guid uniqueKey;
        private readonly string connectionStringArchive = "Data Source=Archive.db;Version=3;New=False;Compress=True;";
        private readonly BindingSource _bs = new();

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

            string? id = ViewActualData.Rows[e.RowIndex].Cells["ID_Column"].Value.ToString();
            int selectedIndex = (int)ViewActualData.CurrentRow.Index;
            uniqueKey = await SqlCmd.GetUniqueKey(id, "Klienty", "Data Source=Archive.db;Version=3;New=False;Compress=True;");

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

        private void OrderButton_Click(object sender, EventArgs e)
            {
            if(uniqueKey != Guid.Empty)
                {
                GeneretePDF pdf = new();
                pdf.Create(uniqueKey);
                }
            }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
            {
            var dataTable = ViewActualData.DataSource as DataTable;
            if(dataTable != null)
                {
                if(!string.IsNullOrEmpty(SearchTextBox.Text))
                    {
                    dataTable.DefaultView.RowFilter = string.Format(
                        "Imię LIKE '%{0}%' OR Nazwisko LIKE '%{0}%' OR NrTelefonu LIKE '%{0}%' OR Marka LIKE '%{0}%' OR Model LIKE '%{0}%' OR VIN LIKE '%{0}%' OR Zlecenie LIKE '%{0}%'",
                        SearchTextBox.Text);
                    Settings.SearchTextBox(SearchTextBox, ViewActualData);
                    }                
                else
                    {
                    dataTable.DefaultView.RowFilter = string.Empty;
                    }
                }
            }
        }
    }