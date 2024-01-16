namespace Warsztat_2._0.UserControls.UC_CreateData
{
    public partial class UC_AddOrderRepair : UserControl
    {
        public UC_AddOrderRepair()
        {
            InitializeComponent();
        }

        private void SaveToDataTable_Click(object sender, EventArgs e)
        {
            int rowCount = DataGridViewCar.RowCount;

            OrderRepair orderRepair = new()
            {
                Zlecenie = OrderTextBox.Text,
                Diagnostic = DiagnosticTextBox.Text,
                Repair = RepairTextBox.Text,
                Description = DescriptionTextBox.Text,
                NrPart = NrPartTextBox.Text,
                Price = (ushort)PriceNumericUpDown.Value,
                Ilość = (byte)IloscNumericUpDown.Value,
                Stan = StanCheckBox.Checked
            };
            if (rowCount >= 1)
            {
                rowCount++;
            }
            MessageBox.Show(rowCount.ToString());
            // DataGridViewCar.Rows[1].Cells["Stan_Column"].Value = orderRepair.Stan;
            //DataGridViewCar.Cells["Zlecenie_Column"].Value = orderRepair.Zlecenie;
            DataGridViewCar.Rows[rowCount].Cells["Diagnostyka_Column"].Value = orderRepair.Diagnostic;
            DataGridViewCar.Rows[rowCount].Cells["Naprawa_Column"].Value = orderRepair.Repair;
            DataGridViewCar.Rows[rowCount].Cells["Opis_Column"].Value = orderRepair.Description;
            DataGridViewCar.Rows[rowCount].Cells["NrCzęści_Column"].Value = orderRepair.NrPart;
            DataGridViewCar.Rows[rowCount].Cells["Cena_Column"].Value = orderRepair.Price;
            DataGridViewCar.Rows[rowCount].Cells["Ilość_Column"].Value = orderRepair.Ilość;
        }

        private void ButtonOrderRepairSave_Click(object sender, EventArgs e)
        {

        }
    }
}
