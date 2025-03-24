using System.Data;
using Warsztat_2._0.UserControls.BarMenu.ScheduleCar;

namespace Warsztat_2.UserControls.BarMenu.ScheduleCar
{
    public partial class UC_ScheduleCar : UserControl
    {
        private Client client = new();
        private Car car = new();
        private Repair repair = new();

        public UC_ScheduleCar()
        {
            InitializeComponent();
        }
        #region Event
        private async void UC_ScheduleCarSelectTab_Load(object sender, EventArgs e)
        {
            ControlPanel(ViewData, EditData);
            await SqlCmd.LoadData("SELECT ID, DataPrzyjęcia ,Telefon, Imię, Nazwisko, Marka, Model, Problem FROM ZaplanowaneSamochody", DataScheduleView, "ZaplanowaneSamochody", "Load table ZaplanowaneSamochody From DB");
            /////Update data time
            ScheduleTimePicker.Text = DateTime.Today.ToString();
        }

        public void ScheduleCarAddButton_Click(object sender, EventArgs e)
        {
            ControlPanel(EditData, ViewData);
            ScheduleCarButton.Text = "Zapłanuj samochód";
        }

        private async void ViewScheduleCarButton_Click(object sender, EventArgs e)
        {
            ControlPanel(ViewData, EditData);
            await SqlCmd.LoadData("SELECT ID, DataPrzyjęcia ,Telefon, Imię, Nazwisko, Marka, Model, Problem FROM ZaplanowaneSamochody", DataScheduleView, "ZaplanowaneSamochody", "Load table ZaplanowaneSamochody From DB");

            EditDataScheduleCar.ClearTextBox(this);
        }
        private void DataScheduleView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataScheduleView.CurrentRow.Cells["DataPrzyjecia_Column"].Value.ToString() != "")//  Якщо дата не відсутня тоді можна виконувати наступний код
            {
                EditDataScheduleCar edit = new();

                PrepareDataToEdit();
                edit.SetDataEdit(client, car, repair);
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

        private async void DataScheduleView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            await SqlCmd.DeleteDataTable(DataScheduleView, e, "BtnDelete", "ID_Column", "ZaplanowaneSamochody");
            if (e.ColumnIndex == DataScheduleView.Columns["btnAdd"].Index && DataScheduleView.Rows[e.RowIndex].Cells["ID_Column"].Value != DBNull.Value)
            {
                LoadDataToDB();
            }

            Cursor.Current = Cursors.Default;
        }
        private async void LoadDataToDB()
        {
            try
            {
                AddDataFromScheduleCar addData = new();
                TransferData transferData = new();

                ////CopyDataToNewWindow
                transferData.Data.Enqueue($"{DataScheduleView.CurrentRow.Cells["ID_Column"].Value.ToString()}");
                transferData.Data.Enqueue($"{DataScheduleView.CurrentRow.Cells["Imie_Column"].Value.ToString()}");

                transferData.Data.Enqueue($"{DataScheduleView.CurrentRow.Cells["Nazwisko_Column"].Value.ToString()}");
                transferData.Data.Enqueue($"{DataScheduleView.CurrentRow.Cells["Telefon_Column"].Value.ToString()}");

                transferData.Data.Enqueue($"{DataScheduleView.CurrentRow.Cells["Marka_Column"].Value.ToString()}");
                transferData.Data.Enqueue($"{DataScheduleView.CurrentRow.Cells["Model_Column"].Value.ToString()}");

                transferData.Data.Enqueue($"{DataScheduleView.CurrentRow.Cells["DataPrzyjecia_Column"].Value.ToString()}");
                transferData.Data.Enqueue($"{DataScheduleView.CurrentRow.Cells["Problem_Column"].Value.ToString()}");

                addData.SetDataToLoad(transferData);

                addData.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas Dodawania daynych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /////////////////////
            await SqlCmd.LoadData("SELECT ID, DataPrzyjęcia ,Telefon, Imię, Nazwisko, Marka, Model, Problem FROM ZaplanowaneSamochody", DataScheduleView, "ZaplanowaneSamochody", "Load table ZaplanowaneSamochody From DB");
        }
        #endregion

        private static void ControlPanel(Panel Show, Panel Hide)
        {
            Show.Show();
            Hide.Hide();
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

            repair = new Repair
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

        private async void AutocompleteButton_Click(object sender, EventArgs e)
        {
            var data = await SqlCmd.LoadDataAsync("Archive", "Klienty", null, "NrTelefonu", TelephonTextBox.Text);
            if (data.Count > 0)
            {
                var carData = await SqlCmd.LoadDataAsync("Archive", "Samochód", null, "UniqueKey", data["UniqueKey"]);
                NameTextBox.Text = data["Imię"].ToString();
                SurnameTextBox.Text = data["Nazwisko"].ToString();
                TelephonTextBox.Text = data["NrTelefonu"].ToString();
                CarComboBox.Text = carData["Marka"].ToString();
                ScheduleModelTextBox0.Text = carData["Model"].ToString();
            }
        }

        private async void TelephonTextBox_TextChanged(object sender, EventArgs e)
        {
            var data = await SqlCmd.LoadDataAsync("Archive", "Klienty", null, "NrTelefonu", TelephonTextBox.Text);
            if (data.Count > 0)
            {
                var carData = await SqlCmd.LoadDataAsync("Archive", "Samochód", null, "UniqueKey", data["UniqueKey"]);
                label16.Text += $"{data["Imię"]} {data["Nazwisko"]}";
                label21.Text += data["NrTelefonu"];
                label24.Text += $"{carData["Marka"]} {carData["Model"]}";
                return;
            }
            label16.Text = "Imię i Nazwisko:";
            label21.Text = "nr. Telefonu:";
            label24.Text = "Marka i model:";
        }
    }
}
public class TransferData
{
    public Queue<string> Data { get; set; } = new();
}
