using System.Data;
using System.Data.SQLite;

/// LOCATION 0; 48 ViewData
/// LOCATION 0; 48 EditData

namespace Warsztat_2._0.UserControls.BarMenu.ScheduleCar
{
    public partial class UC_ScheduleCarSelectTab : UserControl
    {
        private readonly string path = "Data Source=WarsztatData.db;Version=3;New=False;Compress=True;";

        private Client client = new();
        private Car car = new();
        private OrderRepair orderRepair = new();

        public UC_ScheduleCarSelectTab()
        {
            InitializeComponent();
        }
        #region Event
        private void UC_ScheduleCarSelectTab_Load(object sender, EventArgs e)
        {
            ControlPanel(ViewData, EditData);
            LoadTable();
            /////Update data time
            ScheduleTimePicker.Text = DateTime.Today.ToString();
        }

        public void ScheduleCarAddButton_Click(object sender, EventArgs e)
        {
            ControlPanel(EditData, ViewData);

            ScheduleCarButton.Text = "Zapłanuj samochód";
        }

        private void ViewScheduleCarButton_Click(object sender, EventArgs e)
        {
            ControlPanel(ViewData, EditData);
            LoadTable();

            EditDataScheduleCar.ClearTextBox(this);
        }
        private void DataScheduleView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataScheduleView.CurrentRow.Cells["DataPrzyjecia_Column"].Value.ToString() != "")//  Якщо дата не відсутня тоді можна виконувати наступний код
            {
                EditDataScheduleCar edit = new();

                PrepareDataToEdit();
                edit.SetDataEdit(client, car, orderRepair);
                edit.AutocompleteData(this);

                ControlPanel(EditData, ViewData);

                ScheduleCarButton.Text = "Odśwież zapłanowany samochód";
            }

        }

        private void ScheduleCarButton_Click(object sender, EventArgs e)
        {
            EditDataScheduleCar editData = new();
            if (ScheduleCarButton.Text == "Odśwież zapłanowany samochód")
            {
                editData.UpdateData(this);
                return;
            }
            editData.SaveData(this);
            ControlPanel(EditData, ViewData);
        }

        private void DataScheduleView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            long idToDelete;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // Перевіряємо, чи подія спровокована натисканням на кнопку "Видалити" (за допомогою ColumnIndex) і чи є значення в стовпці "ID_Column" не DBNull.
                if (e.ColumnIndex == DataScheduleView.Columns["BtnDelete"].Index && DataScheduleView.Rows[e.RowIndex].Cells["ID_Column"].Value != DBNull.Value)
                {
                    idToDelete = (long)DataScheduleView.Rows[e.RowIndex].Cells["ID_Column"].Value; // Cast to long

                    using SQLiteConnection conn = new(path);
                    conn.Open();

                    using SQLiteCommand deleteCMD = new("DELETE FROM ZaplanowaneSamochody WHERE ID=@ID", conn);

                    deleteCMD.Parameters.AddWithValue("@ID", idToDelete);
                    deleteCMD.ExecuteNonQuery();

                    DataScheduleView.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas usuwania rekordu: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        private static void ControlPanel(Panel Show, Panel Hide)
        {
            Show.Show();
            Hide.Hide();
        }

        private void LoadTable()
        {
            try
            {
                using SQLiteConnection conn = new(path);
                conn.Open();
                using SQLiteDataAdapter adapter = new("SELECT ID, DataPrzyjęcia ,Telefon, Imię, Nazwisko, Marka, Model, Problem FROM ZaplanowaneSamochody", conn);
                {
                    using DataTable dataTable = new();
                    dataTable.Clear();// Очищаємо дані, якщо вони вже були завантажені
                    adapter.Fill(dataTable);
                    DataScheduleView.DataSource = dataTable;
                    DataScheduleView.Columns["ID_Column"].Visible = false;
                }
                ////if na perevirku danych////
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zczytywania rekordów: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrepareDataToEdit()
        {
            client = new Client
            {
                ID = Convert.ToByte(DataScheduleView.CurrentRow.Cells["ID_Column"].Value.ToString()),
                Name = DataScheduleView.CurrentRow.Cells["Imie_Column"].Value.ToString(),
                Surname = DataScheduleView.CurrentRow.Cells["Nazwisko_Column"].Value.ToString(),
                PhoneNumber = DataScheduleView.CurrentRow.Cells["Telefon_Column"].Value.ToString()
            };

            car = new Car
            {
                Marka = DataScheduleView.CurrentRow.Cells["Marka_Column"].Value.ToString(),
                Model = DataScheduleView.CurrentRow.Cells["Model_Column"].Value.ToString()
            };

            orderRepair = new OrderRepair
            {
                Problem = DataScheduleView.CurrentRow.Cells["Problem_Column"].Value.ToString(),
                ScheduleCar = DataScheduleView.CurrentRow.Cells["DataPrzyjecia_Column"].Value.ToString()
            };
        }

        private void SearchScheduleCar_TextChanged(object sender, EventArgs e)
        {

            BindingSource bindingSource = new()
            {
                DataSource = DataScheduleView.DataSource
            };
            DataScheduleView.DataSource = bindingSource;

            if (string.IsNullOrWhiteSpace(SearchScheduleCar.Text))
            {
                bindingSource.RemoveFilter();
            }
            // Використання параметрів для фільтрації
            string[] searchTerms = SearchScheduleCar.Text.Split(','); // Розділити введений текст на окремі слова
                                                                      // Фільтр за умовами
            string filter = string.Join(" AND ", searchTerms.Select(term => $"Imię LIKE '%{term}%' OR Nazwisko LIKE '%{term}%' OR Marka LIKE '%{term}%' OR Model LIKE '%{term}%' OR DataPrzyjęcia LIKE '%{term}%' OR Telefon LIKE '%{term}%'"));
            bindingSource.Filter = filter;
        }

        private void SearchScheduleCar_MouseHover(object sender, EventArgs e)
        {
            helpingLabel.Text = "* Wpisz [,] dla wyszukiwaniu kilku słów";
        }

        private void SearchScheduleCar_MouseLeave(object sender, EventArgs e)
        {
            helpingLabel.Text = "*";
        }

        private void TelephonTextBox_MouseHover(object sender, EventArgs e)
        {
            helpTelephoneLabel.Text = "* Dla wygody czytania polecam np. 945-342-234, pisząc co czwarty symbol [-]";
        }

        private void TelephonTextBox_MouseLeave(object sender, EventArgs e)
        {
            helpTelephoneLabel.Text = "*";
        }
    }
}