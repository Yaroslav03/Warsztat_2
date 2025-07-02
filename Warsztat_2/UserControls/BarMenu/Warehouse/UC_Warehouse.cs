using Warsztat_2.Models;

namespace Warsztat_2._0.UserControls.BarMenu.Warehouse {
    public partial class UC_Warehouse :UserControl {
        private WarehouseModel warehouseModel = new WarehouseModel();
        private readonly SqlCmd sqlCmd = new();
        public UC_Warehouse()
            {
            InitializeComponent();
            }
        private async void WarehouseAddButton_Click(object sender, EventArgs e)
            {
            WarehouseAddEdit warehouseAddEditNew = new();
            warehouseAddEditNew.ClearTextBox();
            warehouseAddEditNew.RefreshWarehouseTable = async () => await LoadTable();
            warehouseAddEditNew.ShowDialog();
            }

        private async void UC_Warehouse_Load(object sender, EventArgs e)
            {
            await LoadTable();
            await SqlCmd.ReadRecordListBoxAsync(CategorylistBox, "SELECT Typ FROM Kategorie", "Typ");
            }
        public async Task LoadTable()
            {
            await SqlCmd.LoadData("SELECT ID, Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość, Suma FROM Magazyn", WarehouseView, "Warehouse", "Load table Warehouse From DB");
            WarehouseView.Columns["ID_Column"].Visible = false;
            }
        private void PrepareDataToRead()
            {
            warehouseModel = new()
                {
                Id = Convert.ToUInt16(WarehouseView.CurrentRow.Cells["ID_Column"].Value.ToString()),
                Type = WarehouseView.CurrentRow.Cells["Typ_column"].Value.ToString(),
                PartNumber = WarehouseView.CurrentRow.Cells["NumerCzęści_column"].Value.ToString(),
                Name = WarehouseView.CurrentRow.Cells["Nazwa_column_"].Value.ToString(),
                Description = WarehouseView.CurrentRow.Cells["Opis_column_"].Value.ToString(),
                Price = Convert.ToDecimal(WarehouseView.CurrentRow.Cells["Cena_column"].Value.ToString()),
                Quantity = Convert.ToByte(WarehouseView.CurrentRow.Cells["Ilość_column"].Value.ToString()),
                Sum = WarehouseView.CurrentRow.Cells["Suma_Column"].Value.ToString()
                };
            }

        private async void AddCategoryButton_Click(object sender, EventArgs e)
            {
            if(!string.IsNullOrWhiteSpace(CategoryTextBox.Text))
                {
                await AddCategory();
                }
            }

        private async void RemoveCategoryButton_Click(object sender, EventArgs e)
            {
            await RemoveCategory();
            }

        #region Methods of 
        private async Task AddCategory()
            {
            var data = new Dictionary<string, object>
            {
                {"Typ", CategoryTextBox.Text.Trim() }
            };

            await SqlCmd.AddRecordAsync("WarsztatDB", "Kategorie", data);

            CategorylistBox.Items.Add(data["Typ"]);
            CategoryTextBox.Text = string.Empty;
            }
        private async Task RemoveCategory()
            {
            if(CategorylistBox.SelectedItem == null)
                {
                MessageBox.Show("Wybierz najpierw kategorię dla jej usunięcia :)", "Błąd spowodowany użytkownikiem a nie programistą", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }

            string categoryToRemove = CategorylistBox.SelectedItem.ToString();
            var whereParams = new Dictionary<string, object>
                {
                    { "Typ", categoryToRemove }
                };

            await SqlCmd.DeleteRecordAsync("WarsztatDB", "Kategorie", "Typ = @Typ", whereParams);
            CategorylistBox.Items.Remove(categoryToRemove);
            }

        #endregion

        private async void UpdateCategoryList_Click(object sender, EventArgs e)
            {
            await SqlCmd.ReadRecordListBoxAsync(CategorylistBox, "SELECT Typ FROM Kategorie", "Typ");
            }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
            {
            Settings.SearchTextBox(SearchTextBox, WarehouseView);
            }

        private void CategorylistBox_MouseClick(object sender, MouseEventArgs e)
            {
            using BindingSource bindingSource = new()
                {
                DataSource = WarehouseView.DataSource,
                Filter = $"{"Typ"} LIKE '%{CategorylistBox.SelectedItem}%'"
                };
            }

        private void CategorylistBox_MouseDoubleClick(object sender, MouseEventArgs e)
            {
            using BindingSource bindingSource = new()
                {
                DataSource = WarehouseView.DataSource
                };
            CategorylistBox.SelectedIndices.Clear();
            bindingSource.RemoveFilter();
            }

        private async void WarehouseView_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if(e.ColumnIndex == WarehouseView.Columns["BtnDelete_"].Index &&
                MessageBox.Show("Na pewno chcesz usunąć te dane?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                await SqlCmd.DeleteDataTable(WarehouseView, e, "BtnDelete_", "ID_Column", "Magazyn");
                }
            }

        private async void WarehouseView_DoubleClick(object sender, EventArgs e)
            {
            if(WarehouseView.CurrentRow != null && WarehouseView.CurrentRow.Cells["Typ_column"].Value != DBNull.Value)
                {
                WarehouseAddEdit warehouseAddEditNew = new();
                PrepareDataToRead();

                warehouseAddEditNew.SetDataEdit(warehouseModel);
                warehouseAddEditNew.RefreshWarehouseTable = async () => await LoadTable();
                warehouseAddEditNew.ShowDialog();
                }
            }
        }
    }