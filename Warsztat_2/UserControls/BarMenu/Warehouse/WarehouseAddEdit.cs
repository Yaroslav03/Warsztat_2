using Warsztat_2.Models;

namespace Warsztat_2._0.UserControls.BarMenu.Warehouse {
    public partial class WarehouseAddEdit :Form {
        WarehouseModel warehouseModel = new();
        private readonly SqlCmd sqlCmd = new();
        decimal sum;
        private const decimal VAT_RATE = 0.23m;

        public WarehouseAddEdit()
            {
            InitializeComponent();
            }

        public Func<Task>? RefreshWarehouseTable;

        private async void AddEditWarehouseButton_Click(object sender, EventArgs e)
            {
            var data = new Dictionary<string, object>
                {
                    {"Typ",  CategoryComboBox.SelectedItem?.ToString() ?? "Brak"},
                    {"Nazwa", NameTextBox.Text.Trim()},
                    {"NumerCzęści", NumberPartTextBox.Text.Trim() },
                    {"Opis", DescriptionTextBox.Text.Trim()},
                    {"Cena",  PriceNumericUpDown.Value},
                    {"Ilość", QuantityNumericUpDown.Value},
                    {"ZarobekCzęści", EarningNumericUpDown.Value},
                    {"SumaZarobku", EarningNumericUpDown.Value * QuantityNumericUpDown.Value},
                    {"Suma", sum},                    
                };
            var dataId = new Dictionary<string, object>
                {
                    {"ID", warehouseModel.Id}
                };
            string[] magazyn = { $"{data["Nazwa"]}", $"{data["Opis"]}", $"{data["NumerCzęści"]}" };

            if (AddEditWarehouseButton.Text == "Zapisz")
            {
                await SqlCmd.AddRecordAsync("WarsztatDB", "Magazyn", data);
                if (RefreshWarehouseTable != null) await RefreshWarehouseTable();
                MessageBox.Show($"{magazyn[0]} ({magazyn[1]}) o numerze [{magazyn[2]}] został dodany do magazynu, kliknij OK żeby dodać kolejny", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                warehouseModel.Clear();
                return;
            }
            await SqlCmd.UpdateRecordAsync("Magazyn", data, "ID=@ID", dataId);
            warehouseModel.Clear();
            if (RefreshWarehouseTable != null) await RefreshWarehouseTable();
        }

        public void SetDataEdit(WarehouseModel Data)
            {//сетування даних при переході між класами
            warehouseModel = Data;
            }
        private void AutocompleteData()
            {
            CategoryComboBox.SelectedItem = warehouseModel.Type;
            NumberPartTextBox.Text = warehouseModel.PartNumber;
            NameTextBox.Text = warehouseModel.Name;
            DescriptionTextBox.Text = warehouseModel.Description;
            PriceNumericUpDown.Value = (decimal)warehouseModel.Price;
            EarningNumericUpDown.Value = (decimal)warehouseModel.EarningParts;
            QuantityNumericUpDown.Value = (byte)warehouseModel.Quantity;
            //label1.Text = warehouseModel.Sum;
            }
        public void ClearTextBox()
            {
            warehouseModel = new();
            NumberPartTextBox.Text = NameTextBox.Text = DescriptionTextBox.Text = String.Empty;
            PriceNumericUpDown.Value = EarningNumericUpDown.Value = 0;
            QuantityNumericUpDown.Value = 1;
            priceBRUTTO.Text = priceVAT.Text = priceNetto.Text = "0 PLN";
            }

        private void PriceNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            Sum();
            }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            Sum();
            }
        private void EarningNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            Sum();
            }
        private void Sum()
            {
            sum = Math.Round((PriceNumericUpDown.Value + EarningNumericUpDown.Value) * QuantityNumericUpDown.Value, 2,MidpointRounding.AwayFromZero);
            priceNetto.Text = $"{sum} PLN";

            decimal vat = 0.23m * sum;
            priceVAT.Text = $"{Math.Round(vat, 2, MidpointRounding.AwayFromZero)} PLN";
            priceBRUTTO.Text = $"{Math.Round(vat + sum, 2, MidpointRounding.AwayFromZero)} PLN";
            }

        private async void WarehouseAddEdit_Load(object sender, EventArgs e)
            {
            await SqlCmd.ReadRecordComboBoxAsync(CategoryComboBox, "SELECT Typ FROM Kategorie", "Typ");
            if(warehouseModel.Id == 0)
                {
                AddEditWarehouseButton.Text = "Zapisz";
                }
            else if(warehouseModel.Id > 0)
                {
                AutocompleteData();
                AddEditWarehouseButton.Text = "Odśwież";
                }
            }
        }
    }