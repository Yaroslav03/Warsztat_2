using System.Data;
using System.Data.SQLite;

namespace Warsztat_2._0.UserControls.BarMenu.Warehouse
{
    public partial class UC_Warehouse : UserControl
    {
        private readonly string connection = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        private WarehouseData warehouseData = new();
        WarehouseAddEdit warehouseAddEdit = new();
        public UC_Warehouse()
        {
            InitializeComponent();
        }

        private void WarehouseView_DoubleClick(object sender, EventArgs e)
        {
            if (WarehouseView.CurrentRow.Cells["TypCzesci_Column_Main"].Value.ToString() != null)
            {
                return;
            }
            PrepareDataToRead();

            warehouseAddEdit.SetDataEdit(warehouseData);
            warehouseAddEdit.ClearTextBox();
            warehouseAddEdit.AutocompleteData();

            warehouseAddEdit.ShowDialog();

        }

        private void WarehouseAddButton_Click(object sender, EventArgs e)
        {
            warehouseAddEdit.ClearTextBox();
            warehouseAddEdit.ShowDialog();
        }

        private void UC_Warehouse_Load(object sender, EventArgs e)
        {
            LoadTable();

            UpdateList("Data_Warehouse", CategorylistBox);
        }
        private void LoadTable()
        {
            try
            {
                using SQLiteConnection conn = new(connection);
                conn.Open();
                using SQLiteDataAdapter adapter = new("SELECT ID, Typ, Nazwa, NumerCzęści, Opis, Cena, Ilość FROM Magazyn", conn);
                {
                    using DataTable dataTable = new();
                    dataTable.Clear();// Очищаємо дані, якщо вони вже були завантажені
                    adapter.Fill(dataTable);
                    WarehouseView.DataSource = dataTable;
                    WarehouseView.Columns["ID_Column_"].Visible = false;
                }
                ////if na perevirku danych////
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zczytywania rekordów: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrepareDataToRead()
        {
            warehouseData = new()
            {
                Id = Convert.ToUInt16(WarehouseView.CurrentRow.Cells["ID_Column_"].Value.ToString()),
                Type = WarehouseView.CurrentRow.Cells["TypCzesci_Column_Main"].Value.ToString(),
                PartNumber = WarehouseView.CurrentRow.Cells["NrCzesci_Column_Main"].Value.ToString(),
                Name = WarehouseView.CurrentRow.Cells["Nazwa_Column_Main"].Value.ToString(),
                Description = WarehouseView.CurrentRow.Cells["Opis_Column_Main"].Value.ToString(),
                Price = Convert.ToUInt16(WarehouseView.CurrentRow.Cells["Price_Column"].Value.ToString()),
                Quantity = Convert.ToUInt16(WarehouseView.CurrentRow.Cells["Quantity_Column"].Value.ToString())
            };
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            Add(CategoryTextBox.Text, "Data_Warehouse");
        }

        private void RemoveCategoryButton_Click(object sender, EventArgs e)
        {
            Remove("Data_Warehouse");
        }

        #region Methods of BinFile
        private void Add(string word, string fileName)
        {
            using BinaryWriter binWrite = new(File.Open(fileName + ".bin", FileMode.Append));

            binWrite.Write(word.Trim());

            CategorylistBox.Items.Add(word.Trim());

            CategoryTextBox.Text = "";
        }
        private void Remove(string fileName)
        {
            if (!File.Exists(fileName + ".bin") || CategorylistBox.SelectedItem == null)
            {
                return;
            }
            string wordToRemove = CategorylistBox.Text;
            //MessageBox.Show($"{listBox1.I} \n {wordToRemove}");
            try
            {
                using (BinaryReader binRead = new(File.Open(fileName + ".bin", FileMode.Open)))
                {
                    using BinaryWriter binWrite = new(File.Open(fileName + "_temp.bin", FileMode.Create));
                    while (binRead.BaseStream.Position < binRead.BaseStream.Length)
                    {
                        string word = binRead.ReadString();
                        if (word != wordToRemove)
                        {
                            binWrite.Write(word);
                        }
                    }
                }

                File.Delete(fileName + ".bin"); // Видалення вхідного файлу
                File.Move(fileName + "_temp.bin", fileName + ".bin"); // Перейменування тимчасового файлу на вхідний файл

                CategorylistBox.Items.Remove(wordToRemove);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static void UpdateList(string fileName, ListBox listBox)
        {
            if (!File.Exists(fileName + ".bin"))
            {
                return;
            }
            try
            {
                listBox.Items.Clear();
                using BinaryReader binRead = new(File.Open(fileName + ".bin", FileMode.Open));

                while (binRead.BaseStream.Position < binRead.BaseStream.Length)
                {
                    listBox.Items.Add(binRead.ReadString());
                }
            }
            catch (EndOfStreamException) { }
        }
        #endregion

        private void UpdateCategoryList_Click(object sender, EventArgs e)
        {
            UpdateList("Data_Warehouse", CategorylistBox);
        }

        private void WarehouseView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (e.ColumnIndex == WarehouseView.Columns["BtnDelete"].Index && WarehouseView.Rows[e.RowIndex].Cells["ID_Column_"].Value != DBNull.Value)
                {
                    long idToDelete = (long)WarehouseView.Rows[e.RowIndex].Cells["ID_Column_"].Value;

                    using SQLiteConnection conn = new(connection);
                    conn.Open();

                    using SQLiteCommand delete = new("DELETE FROM Magazyn WHERE ID=@ID", conn);
                    delete.Parameters.AddWithValue("ID", idToDelete);
                    delete.ExecuteNonQuery();

                    WarehouseView.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas usuwania rekordu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new()
            {
                DataSource = WarehouseView.DataSource
            };
            if (string.IsNullOrEmpty(SearchTextBox.Text))
            {
                bindingSource.RemoveFilter();
                CategorylistBox.SelectedIndices.Clear();
            }

            string[] search = SearchTextBox.Text.Split(',');

            string filter = string.Join(" AND ", search.Select(term => $"NumerCzęści LIKE '%{term}%' OR Nazwa LIKE '%{term}%' OR Opis LIKE '%{term}%'"));
            bindingSource.Filter = filter;
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
    }
}