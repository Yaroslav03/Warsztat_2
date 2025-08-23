using System.Globalization;
using System.Windows.Forms;

namespace Warsztat_2.UserControls.BarMenu.UC_CreateData {
    public partial class Form_AddRepair :Form {
        #region variables
        //private List<string> tranferData = new();
        private Dictionary<string, object> Transfer { get; set; } = new();

        string[] columnWarehouse = { "ID_Column", "Typ_column", "Nazwa_column_", "Opis_Column_", "NumerCzęści_column", "Cena_column", "Ilość_column", "Sum_Column", "EarningParts_Column", "SumaZarobku_Column_Warehouse" };
        string[] columnRepair = { "ID_Column_", "Type_Column", "Nazwa_Column", "Opis_Column", "NrCzęści_Column", "Cena_Column_", "Ilość_Column_", "Suma_Column", "EarningParts_Column_", "SumaZarobku_Column" };
        Guid uniqueKey;
        private protected ushort Id_Repair;
        #endregion
        public Form_AddRepair()
            {
            InitializeComponent();
            }
        #region Event

        private async void ButtonRepairSave_Click(object sender, EventArgs e)
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
        #endregion
        #region Methods

        private void CollectDataFromTable()
            {
            string GetCellValue(string columnName) => ViewRepair.CurrentRow.Cells[columnName]?.Value?.ToString() ?? string.Empty;
            Id_Repair = Convert.ToUInt16(GetCellValue("ID_Column_"));

            DescriptionTextBox.Text = GetCellValue("Opis_Column");
            NazwaTextBox.Text = GetCellValue("Nazwa_Column");
            NrPartTextBox.Text = GetCellValue("NrCzęści_Column");
            PriceNumericUpDown.Text = GetCellValue("Cena_Column_");
            PriceEarningNumericUpDown.Value = Convert.ToDecimal(GetCellValue("EarningParts_Column_"));
            IloscNumericUpDown.Text = GetCellValue("Ilość_Column_");
            TypeTextBox.Text = GetCellValue("Type_Column");

            StanCheckBox.Checked = GetCellValue("Wykonane_Checked") == "1";
            }

        private async Task LoadCarData()
            {
            await SqlCmd.LoadData("SELECT ID, Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość, ZarobekCzęści, SumaZarobku, Suma FROM Magazyn", WarehouseView, "Warehouse", "Load table Warehouse From DB");
            }
        public void TransferUniqueKey(Guid key)
            {
            uniqueKey = key;
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


            foreach(TextBox tb in panel1.Controls.OfType<TextBox>())
                {
                tb.Clear();
                }
            Id_Repair = 0;
            StanCheckBox.Checked = false;
            ButtonRepairSave.Text = "Zapisz";
            PriceNumericUpDown.Value = 0; IloscNumericUpDown.Value = 1;
            }
        private Dictionary<string, object> GetValue()
            {
            return new Dictionary<string, object>
                        {
                            {"Typ", TypeTextBox.Text.Trim() },
                            {"Nazwa", NazwaTextBox.Text.Trim()},
                            {"Opis", DescriptionTextBox.Text.Trim()},
                            {"NumerCzęści", NrPartTextBox.Text.Trim()},
                            {"Cena", PriceNumericUpDown.Value },
                            {"Ilość", (byte)IloscNumericUpDown.Value},
                            {"Suma", Convert.ToDecimal(SumLabel.Text)},
                            {"Stan", StanCheckBox.Checked},
                            {"ZarobekCzęści", PriceEarningNumericUpDown.Value },
                            {"SumaZarobku", PriceEarningNumericUpDown.Value * IloscNumericUpDown.Value },
                            {"UniqueKey", uniqueKey }
                        };
            }
        private async Task SaveRepair()
            {
            var repairData = GetValue();

            await SqlCmd.AddRecordAsync("WarsztatDB", "NaprawaSamochodu", repairData);
            StanCheckBox.Checked = false;
            PriceNumericUpDown.Value = 0; IloscNumericUpDown.Value = 1;
            }
        private async Task LoadRepair()
            {
            var searchKey = new Dictionary<string, object>
                {
                    {"UniqueKey", uniqueKey }
                };
            await SqlCmd.LoadData($"SELECT ID, Typ, Nazwa, Opis, NumerCzęści, Cena, Ilość, ZarobekCzęści, SumaZarobku, Suma, Stan FROM NaprawaSamochodu WHERE UniqueKey=@UniqueKey", ViewRepair, "Repair", "Load table Repair from DB", searchKey);
            }

        private async void ViewRepair_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if(e.ColumnIndex == ViewRepair.Columns["BtnDelete"].Index)
                {
                Transfer = ReadDataTable(ViewRepair, columnRepair);
                Transfer.Remove("ID");

                bool IsSuccsesful = await SqlCmd.AddRecordAsync("WarsztatDB", "Magazyn", Transfer);
                if(IsSuccsesful)
                    {
                    await SqlCmd.DeleteDataTable(ViewRepair, e, "BtnDelete", "ID_Column_", "NaprawaSamochodu");
                    await SqlCmd.LoadData("SELECT ID, Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość, ZarobekCzęści, SumaZarobku, Suma FROM Magazyn", WarehouseView, "Warehouse", "Load table Warehouse From DB");
                    }
                Transfer.Clear();
                }            
            }

        private void ViewRepair_MouseDoubleClick(object sender, MouseEventArgs e)
            {
            CollectDataFromTable();
            ButtonRepairSave.Text = "Odśwież";
            }

        private void PriceNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            Sum();
            }

        private void IloscNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            Sum();
            }
        private void PriceEarningNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            Sum();
            }
        private void Sum()
            {
            decimal sum = (PriceNumericUpDown.Value + PriceEarningNumericUpDown.Value) * IloscNumericUpDown.Value;
            SumLabel.Text = sum.ToString();
            }

        private async void WarehouseView_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if(e.ColumnIndex == WarehouseView.Columns["SelectButton"].Index && WarehouseView.Rows[e.RowIndex].Cells["ID_Column"].Value != DBNull.Value)
                {
                TransferData();

                await LoadRepair();
                await SqlCmd.LoadData("SELECT ID, Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość, ZarobekCzęści, SumaZarobku, Suma FROM Magazyn", WarehouseView, "Warehouse", "Load table Warehouse From DB");
                }
            else if(e.ColumnIndex == WarehouseView.Columns["BtnDelete_Warehouse_"].Index && WarehouseView.Rows[e.RowIndex].Cells["ID_Column"].Value != DBNull.Value)
                {
                await SqlCmd.DeleteDataTable(WarehouseView, e, "BtnDelete_Warehouse_", "ID_Column", "Magazyn");
                }
            }
        private void TransferData()
            {
            Transfer = ReadDataTable(WarehouseView, columnWarehouse);
            if(Convert.ToByte(Transfer["Ilość"]) == 1)
                {
                TransferDataWithRemoveSQL();
                }
            else if(Convert.ToByte(Transfer["Ilość"]) > 1)
                {
                Transfer.Add("UniqueKey", uniqueKey);
                QuantityItemsWarehous quantityItemsMesssage = new();
                quantityItemsMesssage.TransferDictionaryData(Transfer);
                quantityItemsMesssage.ShowDialog();
                }
            Transfer.Clear();
            }

        private Dictionary<string, object> ReadDataTable(DataGridView table, string[] columnName)
            {
            Transfer.Clear();

            Dictionary<string, object> rowData = new();

            foreach(string column in columnName)
                {
                object cellValue = table.CurrentRow.Cells[column]?.Value;
                string key = table.Columns[column].DataPropertyName;

                if(cellValue is decimal dec)
                    rowData.Add(key, dec.ToString(CultureInfo.InvariantCulture));
                else
                    rowData.Add(key, cellValue?.ToString() ?? string.Empty);
                }
            return rowData;
            }

        private async void TransferDataWithRemoveSQL()
            {
            var transferDataId = new Dictionary<string, object>
                {
                    {"ID", Transfer["ID"]}
                };

            Transfer.Remove("ID");
            Transfer.Add("Stan", 1);
            Transfer.Add("UniqueKey", uniqueKey);

            bool isSucceed = await SqlCmd.AddRecordAsync("WarsztatDB", "NaprawaSamochodu", Transfer);
            if(isSucceed)
                {
                await SqlCmd.DeleteRecordAsync("WarsztatDB", "Magazyn", "ID=@ID", transferDataId);
                }
            Transfer.Clear();
            }

        private async void Form_AddRepair_Load(object sender, EventArgs e)
            {
            await LoadCarData();
            if(uniqueKey != Guid.Empty)
                {
                await LoadRepair();
                }
            }


        }
    }