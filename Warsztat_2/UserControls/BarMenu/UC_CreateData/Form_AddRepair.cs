using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warsztat_2.UserControls.BarMenu.UC_CreateData
{
    public partial class Form_AddRepair : Form
    {
        #region variables
        private List<string> tranferData = new();
        Guid uniqueKey;
        private protected ushort Id_Repair;
        private string? pricePart;
        #endregion
        public Form_AddRepair()
        {
            InitializeComponent();
        }
        #region Event

        private async void ButtonRepairSave_Click(object sender, EventArgs e)
        {
            if (ButtonRepairSave.Text == "Zapisz")
            {
                await SaveRepair();
            }
            else if (ButtonRepairSave.Text == "Odśwież")
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
            NazwaTextBox.Text = GetCellValue("Nazwa_Column_");
            NrPartTextBox.Text = GetCellValue("NrCzęści_Column");
            PriceNumericUpDown.Text = GetCellValue("Cena_Column");
            IloscNumericUpDown.Text = GetCellValue("Ilość_Column");

            StanCheckBox.Checked = GetCellValue("Wykonane_Checked") == "1";
        }

        private async Task LoadCarData()
        {
            await SqlCmd.LoadData("SELECT ID, Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość, Suma FROM Magazyn", WarehouseView, "Warehouse", "Load table Warehouse From DB");
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
            await SqlCmd.LoadData($"SELECT ID, Typ, Nazwa, Opis, NumerCzęści, Cena, Ilość, Suma, Stan, DataNapraw FROM NaprawaSamochodu WHERE UniqueKey=@UniqueKey", ViewRepair, "Repair", "Load table Repair from DB", searchKey);
        }

        private async void ViewRepair_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string[] columnData = { "Type_Column", "Nazwa_Column", "Opis_Column", "NrCzęści_Column", "Cena_Column_", "Ilość_Column_", "Suma_Column" };
            string[] sqlColumns = { "Typ", "Nazwa", "Opis", "NumerCzęści", "Cena", "Ilość", "Suma" };

            GetDataTable(ViewRepair, columnData);
            var warehouseData = new Dictionary<string, object>();


            for (byte i = 0; i < sqlColumns.Length; i++)
            {
                warehouseData.Add(sqlColumns[i], tranferData[i]);
            }
            bool IsSuccsesful = await SqlCmd.AddRecordAsync("WarsztatDB", "Magazyn", warehouseData);
            if (IsSuccsesful)
            {
                await SqlCmd.DeleteDataTable(ViewRepair, e, "BtnDelete", "ID_Column_", "NaprawaSamochodu");
                await SqlCmd.LoadData("SELECT ID, Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość, Suma FROM Magazyn", WarehouseView, "Warehouse", "Load table Warehouse From DB");
            }
            tranferData.Clear();
            warehouseData.Clear();
        }

        private void ViewRepair_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CollectDataFromTable();
            ButtonRepairSave.Text = "Odśwież";
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
            if (e.ColumnIndex == WarehouseView.Columns["SelectButton"].Index && WarehouseView.Rows[e.RowIndex].Cells["ID_Column"].Value != DBNull.Value)
            {
                TransferData();

                await LoadRepair();
                await SqlCmd.LoadData("SELECT ID, Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość, Suma FROM Magazyn", WarehouseView, "Warehouse", "Load table Warehouse From DB");
            }
            else if (e.ColumnIndex == WarehouseView.Columns["BtnDelete_Warehouse_"].Index && WarehouseView.Rows[e.RowIndex].Cells["ID_Column"].Value != DBNull.Value)
            {
                await SqlCmd.DeleteDataTable(WarehouseView, e, "BtnDelete_Warehouse_", "ID_Column", "Magazyn");
            }
        }
        private void TransferData()
        {
            string[] data = { "ID_Column", "Typ_column", "Nazwa_column_", "Opis_Column_", "NumerCzęści_column", "Cena_column", "Ilość_column", "Sum_Column" };
            GetDataTable(WarehouseView, data);
            tranferData.Add(DateTime.Now.ToString("D"));


            if (Convert.ToByte(tranferData[6]) == 1)
            {
                TransferDataWithRemoveSQL();
            }
            else if (Convert.ToByte(tranferData[6]) > 1)
            {
                QuantityItemsWarehous quantityItemsMesssage = new();
                quantityItemsMesssage.TransferListData(tranferData, uniqueKey);
                quantityItemsMesssage.ShowDialog();
            }
            tranferData.Clear();

        }
        private void GetDataTable(DataGridView dataGridView, string[] columnName)
        {
            foreach (string SaveData in columnName)
                tranferData.Add(dataGridView.CurrentRow.Cells[SaveData]?.Value?.ToString() ?? string.Empty);
        }

        private async void TransferDataWithRemoveSQL()
        {
            string[] values = { "Typ", "Nazwa", "Opis", "NumerCzęści", "Cena", "Ilość", "Suma", "DataNapraw" };

            var transferDataId = new Dictionary<string, object>
                        {
                            {"ID", tranferData[0]}
                        };
            tranferData.RemoveAt(0);

            var repairCarData = new Dictionary<string, object>();

            for (byte i = 0; i < tranferData.Count; i++)
            {
                repairCarData.Add(values[i], tranferData[i]);
            }
            repairCarData.Add("UniqueKey", uniqueKey);

            bool isSucceed = await SqlCmd.AddRecordAsync("WarsztatDB", "NaprawaSamochodu", repairCarData);
            if (isSucceed)
            {
                await SqlCmd.DeleteRecordAsync("WarsztatDB", "Magazyn", "ID=@ID", transferDataId);
            }

        }

        private async void Form_AddRepair_Load(object sender, EventArgs e)
        {
            await LoadCarData();
        }

        private void Form_AddRepair_Leave(object sender, EventArgs e)
        {

        }
    }
}
