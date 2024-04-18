using System.Data.SQLite;

namespace Warsztat_2._0.UserControls.BarMenu.Warehouse
{
    public partial class WarehouseAddEdit : Form
    {
        private readonly string connection = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        WarehouseData warehouse = new();

        public WarehouseAddEdit()
        {
            InitializeComponent();
        }

        private async void AddEditWarehouseButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                PrepareDataToSave();

                using SQLiteConnection conn = new(connection);
                await conn.OpenAsync();
                using SQLiteCommand add = new("INSERT INTO Magazyn (Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość) " +
                    "VALUES (@Typ, @Nazwa, @NumerCzęści, @Opis, @Cena, @Ilość)", conn);

                add.Parameters.AddWithValue("@Typ", warehouse.Type);
                add.Parameters.AddWithValue("@Nazwa", warehouse.Name);
                add.Parameters.AddWithValue("@NumerCzęści", warehouse.PartNumber);
                add.Parameters.AddWithValue("@Opis", warehouse.Description);
                add.Parameters.AddWithValue("@Cena", warehouse.Price);
                add.Parameters.AddWithValue("@Ilość", warehouse.Quantity);
                add.ExecuteNonQuery();

                MessageBox.Show($"{warehouse.Name} ({warehouse.Description}) o numerze [{warehouse.PartNumber}] został dodany do magazynu, kliknij OK żeby dodać kolejny", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                WarehouseData.Reset();
                Cursor.Current = Cursors.Default;
            }
        }
        private void PrepareDataToSave()
        {
            string type = CategoryListBox.SelectedItem?.ToString() ?? "Brak";

            warehouse = new WarehouseData
            {
                Type = type,
                PartNumber = NumberPartTextBox.Text,
                Name = NameTextBox.Text,
                Description = DescriptionTextBox.Text,
                Price = Convert.ToUInt16(PriceNumericUpDown.Value),
                Quantity = Convert.ToUInt16(QuantityNumericUpDown.Value)
            };
        }
        public void SetDataEdit(WarehouseData Data)
        {//сетування даних при переході між класами
            warehouse = Data;
        }
        public void AutocompleteData()
        {
            CategoryListBox.SelectedItem = warehouse.Type;
            NumberPartTextBox.Text = warehouse.PartNumber;
            NameTextBox.Text = warehouse.Name;
            DescriptionTextBox.Text = warehouse.Description;
            PriceNumericUpDown.Value = (ushort)warehouse.Price;
            QuantityNumericUpDown.Value = (ushort)warehouse.Quantity;
        }
        public void ClearTextBox()
        {
            NumberPartTextBox.Text = String.Empty;
            NameTextBox.Text = String.Empty;
            DescriptionTextBox.Text = String.Empty;
            PriceNumericUpDown.Value = 0;
            QuantityNumericUpDown.Value = 0;
        }

        private void WarehouseAddEdit_Load(object sender, EventArgs e)
        {
            UC_Warehouse.UpdateList("Data_Warehouse", CategoryListBox);
        }
    }
}