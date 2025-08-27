namespace Warsztat_2.UserControls.BarMenu.UC_CreateData {
    public partial class Form_AddService :Form {
        private Guid uniqueKey;

        public Form_AddService()
            {
            InitializeComponent();
            }

        private Dictionary<string, object> ServiceData()
            {
            return new Dictionary<string, object>
                {
                    {"ServiceName", ServiceTextBox.Text},
                    {"Price", PriceNumericUpDown.Value},
                    {"UniqueKey", uniqueKey }
                };
            }
        private async void AddButton_Click(object sender, EventArgs e)
            {
            var serviceData = ServiceData();

            await SqlCmd.AddRecordAsync("WarsztatDB", "HistoriaUsług", serviceData);
            LoadData();
            }

        private async void Form_AddService_Load(object sender, EventArgs e)
            {
            await SqlCmd.LoadData("SELECT Id, ServiceName, Price FROM Usługi", ServiceView, "Usługi", "Load table Usługi From DB");
            LoadData();
            }
        public void TransferUniqueKey(Guid key)
            {
            uniqueKey = key;
            }

        private async void ServiceView_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if(e.ColumnIndex == ServiceView.Columns["SelectBtn"].Index && ServiceView.Rows[e.RowIndex].Cells["ID_Column_"].Value != DBNull.Value)
                {
                Dictionary<string, object> data = new()
                {
                    {"ServiceName", ServiceView.CurrentRow.Cells["ServiceName_Column_"].Value.ToString()},
                    {"Price", ServiceView.CurrentRow.Cells["Price_Column_"].Value.ToString()},
                    {"UniqueKey", uniqueKey }
                };

                await SqlCmd.AddRecordAsync("WarsztatDB", "HistoriaUsług", data);
                await SqlCmd.LoadData("SELECT Id, ServiceName, Price FROM Usługi", ServiceView, "Usługi", "Load table Usługi From DB");
                LoadData();
                }
            else if(e.ColumnIndex == ServiceView.Columns["BtnDelete_"].Index && ServiceView.Rows[e.RowIndex].Cells["ID_Column_"].Value != DBNull.Value)
                {
                await SqlCmd.DeleteDataTable(ServiceView, e, "BtnDelete_", "ID_Column_", "Usługi");
                }
            }

        private async void ServiceHistoryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if(e.ColumnIndex == ServiceHistoryView.Columns["RemoveBtn"].Index && ServiceHistoryView.Rows[e.RowIndex].Cells["ID_Column"].Value != DBNull.Value)
                {
                await SqlCmd.DeleteDataTable(ServiceHistoryView, e, "RemoveBtn", "ID_Column", "HistoriaUsług");

                LoadData();
                }
            else if(e.ColumnIndex == ServiceHistoryView.Columns["SelectBtn_"].Index && ServiceHistoryView.Rows[e.RowIndex].Cells["ID_Column"].Value != DBNull.Value)
                {
                Dictionary<string, object> data = new()
                {
                    {"ServiceName", ServiceHistoryView.CurrentRow.Cells["ServiceName_Column"].Value.ToString()},
                    {"Price", ServiceHistoryView.CurrentRow.Cells["Price_Column"].Value.ToString()}
                };

                await SqlCmd.AddRecordAsync("WarsztatDB", "Usługi", data);
                await SqlCmd.LoadData("SELECT Id, ServiceName, Price FROM Usługi", ServiceView, "Usługi", "Load table Usługi From DB");

                }
            }
        private async void LoadData()
            {
            var searchKey = new Dictionary<string, object>
                {
                    {"UniqueKey", uniqueKey }
                };
            await SqlCmd.LoadData($"SELECT Id, ServiceName, Price FROM HistoriaUsług WHERE UniqueKey=@UniqueKey", ServiceHistoryView, "Service", "Load table Service from DB", searchKey);
            }
        }
    }
