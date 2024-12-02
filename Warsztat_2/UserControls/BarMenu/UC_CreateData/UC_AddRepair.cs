using MigraDoc.DocumentObjectModel.Tables;
using System.Data.SQLite;
using System.Windows.Forms;
using Warsztat_2.UserControls.BarMenu.UC_CreateData;


namespace Warsztat_2._0.UserControls.UC_CreateData {
    public partial class UC_AddRepair :UserControl {
        private List<string> tranferData = new();
        #region variables

        private protected ushort Id_Repair;
        private string? pricePart;

        #endregion
        #region Event
        private async void UC_AddOrderRepair_Load(object sender, EventArgs e)
            {
            await LoadCarData();
            GC.Collect();
            }

        private async void ViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
            {
            VIN_label.Text = ViewCar.CurrentRow.Cells["VIN_Column"].Value.ToString();
            await LoadRepair();
            }
        public UC_AddRepair()
            {
            InitializeComponent();
            }

        private async void ButtonOrderRepairSave_Click(object sender, EventArgs e)
            {
            if(ButtonRepairSave.Text == "Zapisz")
                {
                await SaveRepair();
                }
            else if(ButtonRepairSave.Text == "Odśwież")
                {
                await UpdateRepair();
                ButtonRepairSave.Text = "Zapisz";
                }
            await LoadRepair();
            }
        private void ButtonOrderManagement_Click(object sender, EventArgs e)
            {
            if(VIN_label.Text != "Brak")
                {
                SumRepair();
                string[] data = { $"{VIN_label.Text}", $"{pricePart}" };
                Form_AddOrderManagement form_AddOrderManagement = new();
                form_AddOrderManagement.SendDataFromLastWindow(data);
                form_AddOrderManagement.ShowDialog();
                }
            }
        #endregion
        #region Methods

        private void CollectDataFromTable()
            {
            string GetCellValue(string columnName) => ViewRepair.CurrentRow.Cells[columnName]?.Value?.ToString() ?? string.Empty;
            Id_Repair = Convert.ToUInt16(GetCellValue("ID"));

            DescriptionTextBox.Text = GetCellValue("Opis_Column");
            NazwaTextBox.Text = GetCellValue("Nazwa_Column_");
            NrPartTextBox.Text = GetCellValue("NrCzęści_Column");
            PriceNumericUpDown.Text = GetCellValue("Cena_Column");
            IloscNumericUpDown.Text = GetCellValue("Ilość_Column");

            StanCheckBox.Checked = GetCellValue("Wykonane_Checked") =="1";

            RepairTimePicker.Text = GetCellValue("DateRepair");
            }

        private async Task LoadCarData()
            {
            await SqlCmd.LoadData("SELECT ID, Marka, Model, RokProdukcji, VIN FROM Samochód", ViewCar, "history", "Load table Car From DB");
            await SqlCmd.LoadData("SELECT ID, Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość, Suma FROM Magazyn", WarehouseView, "Warehouse", "Load table Warehouse From DB");
            }

        #endregion

        private async Task UpdateRepair()
            {
            var repairUpdateData = GetValue();
            var repairId = new Dictionary<string, object>
                {
                    {"ID", Id_Repair}
                };

            await SqlCmd.UpdateRecordAsync("NaprawaSamochodu", repairUpdateData, "ID=@ID", repairId);

                Id_Repair = 0;
                Settings.ClearTextBox(panelDodatkowy);
                StanCheckBox.Checked = false;
                ButtonRepairSave.Text = "Zapisz";
                PriceNumericUpDown.Value = 0; IloscNumericUpDown.Value = 1;                
            }
        private Dictionary<string, object> GetValue()
            {
            return new Dictionary<string, object>
                {
                    {"Typ", "" },
                    {"Nazwa", NazwaTextBox.Text.Trim()},
                    {"Opis", DescriptionTextBox.Text.Trim()},
                    {"NumerCzęści", NrPartTextBox.Text.Trim()},
                    {"Cena", PriceNumericUpDown.Value },
                    {"Ilość", (byte)IloscNumericUpDown.Value},
                    {"Suma", Convert.ToDecimal(SumLabel.Text)},
                    {"Stan", StanCheckBox.Checked},
                    {"DataNapraw", RepairTimePicker.Text.Trim()},
                    {"VIN", VIN_label.Text}
                };
            }
        private async Task SaveRepair()
            {
            var repairData = GetValue();

            await SqlCmd.AddRecordAsync("NaprawaSamochodu", repairData);
            Settings.ClearTextBox(panelDodatkowy);
            StanCheckBox.Checked = false;
            PriceNumericUpDown.Value = 0; IloscNumericUpDown.Value = 1;
            }
        private async Task LoadRepair()
            {
            await SqlCmd.LoadData($"SELECT ID, Typ, Nazwa, Opis, NumerCzęści, Cena, Ilość, Suma, Stan, DataNapraw FROM NaprawaSamochodu WHERE VIN LIKE '%{VIN_label.Text}'", ViewRepair, "Repair", "Load table Repair from DB");
            }

        private async void ViewRepair_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            
            string[] columnData = {"Type_Column", "Nazwa_Column_", "Opis_Column", "NrCzęści_Column", "Cena_Column", "Ilość_Column", "Suma_Column" };
            string[] sqlColumns = {"Typ", "Nazwa", "Opis", "NumerCzęści", "Cena", "Ilość", "Suma"};

            GetDataTable(ViewRepair, columnData);
            var warehouseData = new Dictionary<string, object>();


            for(byte i = 0;i < sqlColumns.Length;i++)
                {
                warehouseData.Add(sqlColumns[i], tranferData[i]);
                }
            bool IsSuccsesful = await SqlCmd.AddRecordAsync("Magazyn", warehouseData);
            if(IsSuccsesful)
                {
                await SqlCmd.DeleteDataTable(ViewRepair, e, "BtnDelete", "ID", "NaprawaSamochodu");
                await SqlCmd.LoadData("SELECT ID, Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość, Suma FROM Magazyn", WarehouseView, "Warehouse", "Load table Warehouse From DB");
                }
            tranferData.Clear();
            warehouseData.Clear();
            }

        private void ViewRepair_MouseDoubleClick(object sender, MouseEventArgs e)
            {
            if(VIN_label.Text != "Brak")
                {
                CollectDataFromTable();
                ButtonRepairSave.Text = "Odśwież";
                }
            }

        private void SumRepair()
            {
            decimal totalPrice = 0;
            foreach(DataGridViewRow row in ViewRepair.Rows)
                {
                if(row.Cells["Suma_Column"].Value != null && decimal.TryParse(row.Cells["Suma_Column"].Value.ToString(), out decimal price))
                    {
                    totalPrice += price;
                    }
                }

            pricePart = totalPrice.ToString();
            }

        private void VIN_label_Click(object sender, EventArgs e)
            {
            if(VIN_label.Text != "Brak")
                {
                SumRepair();
                }
            }

        private void PriceNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            Sum();
            }

        private void IloscNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            Sum();
            }
        private void Sum()
            {
            decimal sum = PriceNumericUpDown.Value * IloscNumericUpDown.Value;
            SumLabel.Text = sum.ToString();
            }

        private async void WarehouseView_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if(e.ColumnIndex == WarehouseView.Columns["SelectButton"].Index && WarehouseView.Rows[e.RowIndex].Cells["ID_Column_"].Value != DBNull.Value && VIN_label.Text != "Brak")
                {
                TransferData();

                await LoadRepair();
                await SqlCmd.LoadData("SELECT ID, Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość, Suma FROM Magazyn", WarehouseView, "Warehouse", "Load table Warehouse From DB");
                }
            else if(e.ColumnIndex == WarehouseView.Columns["BtnDelete_Warehouse"].Index && WarehouseView.Rows[e.RowIndex].Cells["ID_Column_"].Value != DBNull.Value)
                {
                await SqlCmd.DeleteDataTable(WarehouseView, e, "BtnDelete_Warehouse", "ID_Column_", "Magazyn");
                }
            }
        private void TransferData()
            {
            string[] data = { "ID_Column_", "TypCzesci_Column", "Nazwa_Column", "Opis_Column_", "NumerCzesci_Column", "Price_Column", "Quantity_Column", "Sum_Column" };
            GetDataTable(WarehouseView, data);
            tranferData.Add(DateTime.Now.ToString("D"));
            tranferData.Add(VIN_label.Text);

            if(Convert.ToByte(tranferData[6]) == 1)
                {
                TransferDataWithRemoveSQL();
                }
            else if(Convert.ToByte(tranferData[6]) > 1)
                {
                QuantityItemsWarehous quantityItemsMesssage = new();
                quantityItemsMesssage.TransferListData(tranferData);
                quantityItemsMesssage.ShowDialog();
                }
            tranferData.Clear();

            }
        private void GetDataTable(DataGridView dataGridView, string[] columnName)
            {
            foreach(string SaveData in columnName)
                tranferData.Add(dataGridView.CurrentRow.Cells[SaveData]?.Value?.ToString() ?? string.Empty);                
            }

        private async void TransferDataWithRemoveSQL()
            {
            string[] values = {"Typ", "Nazwa", "Opis", "NumerCzęści", "Cena", "Ilość", "Suma", "DataNapraw", "VIN" };

            var transferDataId = new Dictionary<string, object>
                {
                    {"ID", tranferData[0]}
                };
            tranferData.RemoveAt(0);

            var repairCarData = new Dictionary<string, object>();

            for(byte i = 0;i < tranferData.Count;i++)
                {
                repairCarData.Add(values[i], tranferData[i]);
                }

            await SqlCmd.AddRecordAsync("NaprawaSamochodu", repairCarData);
            await SqlCmd.DeleteRecordAsync("Magazyn", "ID=@ID", transferDataId);
            }
        }
    }