namespace Warsztat_2.UserControls.BarMenu.Settings {
    public partial class UC_CompanyExpenses :UserControl {
        public UC_CompanyExpenses()
            {
            InitializeComponent();
            }

        private async void SaveButton_Click(object sender, EventArgs e)
            {
            var data = new Dictionary<string, object>
                {
                    {"NazwaWydatku", textBox1.Text.Trim()},
                    {"CenaWydatku", numericUpDown1.Value},
                    {"DataPotrącenia", dateTimePicker1.Text}
                };
            await SqlCmd.AddRecordAsync("WarsztatDB", "WydatkiFirmy", data);
            await LoadDataActualMonth();
            PriceNumericUpDown.Value = 0;
            ExpenseNameTextBox.Text = string.Empty;
            }

        private async void BtnSaveDateOfDeduction_Click(object sender, EventArgs e)
            {
            var data = new Dictionary<string, object>
                {
                    {"NazwaWydatku", ExpenseNameTextBox.Text.Trim()},
                    {"CenaWydatku", PriceNumericUpDown.Value},
                    {"DataPotrącenia", DateOfDeductionCalendar.Text}
                };
            await SqlCmd.AddRecordAsync("WarsztatDB", "StałeWydatkiFirmy", data);
            await SqlCmd.LoadData("SELECT ID, NazwaWydatku, CenaWydatku, DataPotrącenia FROM StałeWydatkiFirmy", ViewDataOfDeduction, "StałeWydatkiFirmy", "Load table WydatkiFirmy From DB");
            PriceNumericUpDown.Value = 0;
            ExpenseNameTextBox.Text = string.Empty;
            }

        private async void ViewDataOfDeduction_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            await SqlCmd.DeleteDataTable(ViewDataOfDeduction, e, "BtnDelete", "ID_Column", "StałeWydatkiFirmy");
            }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            await SqlCmd.DeleteDataTable(dataGridView1, e, "BtnDelete_", "ID_Column_", "WydatkiFirmy");
            }

        private async void UC_CompanyExpenses_Load(object sender, EventArgs e)
            {
            await SqlCmd.LoadData("SELECT ID, NazwaWydatku, CenaWydatku, DataPotrącenia FROM StałeWydatkiFirmy", ViewDataOfDeduction, "WydatkiFirmy", "Load table WydatkiFirmy From DB");
            await LoadDataActualMonth();
            }

        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
            if(checkBox1.Checked == true)
                {
                await SqlCmd.LoadData(@"SELECT ID, NazwaWydatku, CenaWydatku, DataPotrącenia FROM WydatkiFirmy", dataGridView1, "WydatkiFirmy", "Load table WydatkiFirmy From DB");
                }
            else
                {
                await LoadDataActualMonth();
                }
            }
        private async Task LoadDataActualMonth()
            {
            await SqlCmd.LoadData(@"SELECT ID, NazwaWydatku, CenaWydatku, DataPotrącenia FROM WydatkiFirmy 
      WHERE date(
              substr(DataPotrącenia, 7, 4) || '-' ||
              substr(DataPotrącenia, 4, 2) || '-' ||
              substr(DataPotrącenia, 1, 2)
            ) >= date('now', 'start of month')
        AND date(
              substr(DataPotrącenia, 7, 4) || '-' ||
              substr(DataPotrącenia, 4, 2) || '-' ||
              substr(DataPotrącenia, 1, 2)
            ) < date('now', 'start of month', '+1 month')",
    dataGridView1, "WydatkiFirmy", "Load table WydatkiFirmy From DB");
            }
        }
    }
