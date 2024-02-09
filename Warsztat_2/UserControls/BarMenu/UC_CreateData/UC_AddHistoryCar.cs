using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Warsztat_2._0;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Warsztat_2.UserControls.BarMenu.UC_CreateData
{
    public partial class UC_AddHistoryCar : UserControl
    {

        #region variables
        readonly string pathHistoryRepair = "Data Source=Warsztat_HistoryRepair.db;Version=3;New=False;Compress=True;";
        readonly string pathAddClient = "Data Source=Warsztat_CarClients.db;Version=3;New=False;Compress=True;";

        private HistoryCar historyCar = new();

        private Queue<string> dataError = new();

        private protected ushort Id_Car;
        #endregion
        public UC_AddHistoryCar()
        {
            InitializeComponent();
        }
        #region Event

        private async void SaveHistoryButton_Click(object sender, EventArgs e)
        {

            if (SaveHistoryButton.Text == "Zapisz")
            {
                await SaveHistory();
            }
            else if (SaveHistoryButton.Text == "Odśwież")
            {
                await UpdateHistory();
                SaveHistoryButton.Text = "Zapisz";
            }
        }
        private async void UC_AddHistoryCar_Load(object sender, EventArgs e)
        {
            await LoadDataCar();
        }
        private async void ViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VINTextBox.Text = ViewAllCar.CurrentRow.Cells["VIN_Car_Column"].Value.ToString();
            await LoadOfHistoryCar();
        }
        private void VINTextBox_TextChanged(object sender, EventArgs e)
        {
            VINTextBox.MaxLength = 17;
            VINTextBox.Text = String.Concat(VINTextBox.Text.Where(char.IsLetterOrDigit));
            NumLenghtNadwoziaLabel.Text = VINTextBox.Text.Length.ToString();
        }
        #endregion
        #region Methods
        private void CollectData()
        {
            historyCar = new()
            {
                NumberofRegister = RegistrationNumberTextBox.Text,
                Mileage = MileageTextBox.Text,
                VIN = VINTextBox.Text,
                Zlecenie = OrderTextBox.Text,
                Diagnostic = DiagnosticTextBox.Text,
                Repair = RepairTextBox.Text,

                LeftDocument = LeftDocumentsCheck.Checked,
                KeyCar = LeftKeyChceck.Checked,
                TestDrive = TestDriveChceck.Checked,

                DateOfAcceptance = ScheduleTimePicker.Text.ToString()
            };
        }
        private void ReadData()
        {
            Id_Car = Convert.ToByte(ViewHistory.CurrentRow.Cells["ID_Column"].Value.ToString());

            RegistrationNumberTextBox.Text = ViewHistory.CurrentRow.Cells["NrRejestracji_Column"].Value.ToString();
            MileageTextBox.Text = ViewHistory.CurrentRow.Cells["Przebieg_Column"].Value.ToString();
            OrderTextBox.Text = ViewHistory.CurrentRow.Cells["Zlecenie_Column"].Value.ToString();
            DiagnosticTextBox.Text = ViewHistory.CurrentRow.Cells["Diagnostic_Column"].Value.ToString();
            RepairTextBox.Text = ViewHistory.CurrentRow.Cells["Repair_Column"].Value.ToString();

            LeftDocumentsCheck.Checked = ViewHistory.CurrentRow.Cells["Documents_Column"].Value.ToString() == "1";
            LeftKeyChceck.Checked = ViewHistory.CurrentRow.Cells["Key_Column"].Value.ToString() == "1";
            TestDriveChceck.Checked = ViewHistory.CurrentRow.Cells["TestDrive_Column"].Value.ToString() == "1";

            ScheduleTimePicker.Text = ViewHistory.CurrentRow.Cells["DataPrzyjęcia_Column"].Value.ToString();  //ViewHistory.CurrentRow.Cells["DataPrzyjęcia_Column"].Value.ToString();
        }
        private async Task UpdateHistory()
        {
            CollectData();

            using SQLiteConnection conn = new(pathHistoryRepair);

            await conn.OpenAsync();

            using var transaction = conn.BeginTransaction();

            try
            {
                // Використовуйте IF NOT EXISTS для створення таблиці лише у випадку, якщо вона не існує
                using SQLiteCommand update = new($"UPDATE _{historyCar.VIN} SET DataPrzyjęcia = @DataPrzyjęcia, NrRejestracji = @NrRejestracji, Przebieg = @Przebieg, DokumentySamochodu = @DokumentySamochodu, KluczykiSamochodu = @KluczykiSamochodu, TestDrive = @TestDrive, Zlecenie = @Zlecenie, Diagnostyka = @Diagnostyka, Naprawa = @Naprawa WHERE ID = @ID", conn);

                update.Parameters.AddWithValue("@ID", Id_Car);
                update.Parameters.AddWithValue("@NrRejestracji", historyCar.NumberofRegister);
                update.Parameters.AddWithValue("@Przebieg", historyCar.Mileage);
                update.Parameters.AddWithValue("@DokumentySamochodu", historyCar.LeftDocument);
                update.Parameters.AddWithValue("@KluczykiSamochodu", historyCar.KeyCar);
                update.Parameters.AddWithValue("@TestDrive", historyCar.TestDrive);
                update.Parameters.AddWithValue("@Zlecenie", historyCar.Zlecenie);
                update.Parameters.AddWithValue("@Diagnostyka", historyCar.Diagnostic);
                update.Parameters.AddWithValue("@Naprawa", historyCar.Repair);
                update.Parameters.AddWithValue("@DataPrzyjęcia", historyCar.DateOfAcceptance);

                await update.ExecuteNonQueryAsync();

                await transaction.CommitAsync();

                await LoadOfHistoryCar();
                Id_Car = 0;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                dataError.Enqueue($"VIN:{historyCar.VIN}");
                dataError.Enqueue($"NrRejestracji:{historyCar.NumberofRegister}");
                dataError.Enqueue($"Przebieg:{historyCar.Mileage}");
                dataError.Enqueue($"DokumentySamochodu:{historyCar.LeftDocument}");
                dataError.Enqueue($"KluczykiSamochodu:{historyCar.KeyCar}");
                dataError.Enqueue($"TestDrive:{historyCar.TestDrive}");
                dataError.Enqueue($"Zlecenie:{historyCar.Zlecenie}");
                dataError.Enqueue($"Diagnostyka:{historyCar.Diagnostic}");
                dataError.Enqueue($"Naprawa:{historyCar.Repair}");
                dataError.Enqueue($"DataPrzyjęcia:{historyCar.DateOfAcceptance}");

                await Settings.Error(ex, dataError, "AddHistory", "problem with saving data or cmd SQL to History Repair");
                throw;
            }
            finally
            {

                HistoryCar.Reset();
            }
        }
        private async Task SaveHistory()
        {
            CollectData();

            using SQLiteConnection conn = new(pathHistoryRepair);

            await conn.OpenAsync();

            using var transaction = conn.BeginTransaction();

            try
            {
                // Використовуйте IF NOT EXISTS для створення таблиці лише у випадку, якщо вона не існує
                using SQLiteCommand createTable = new($"CREATE TABLE IF NOT EXISTS _{VINTextBox.Text.Trim()} (ID INTEGER PRIMARY KEY AUTOINCREMENT, DataPrzyjęcia TEXT, NrRejestracji TEXT, Przebieg INTEGER, DokumentySamochodu TEXT, KluczykiSamochodu TEXT, TestDrive TEXT, Zlecenie TEXT, Diagnostyka TEXT, Naprawa TEXT);", conn);

                await createTable.ExecuteNonQueryAsync();


                using SQLiteCommand insert = new($"INSERT INTO _{historyCar.VIN} (DataPrzyjęcia, NrRejestracji, Przebieg, DokumentySamochodu, KluczykiSamochodu, TestDrive, Zlecenie, Diagnostyka, Naprawa)" +
                        "VALUES (@DataPrzyjęcia, @NrRejestracji, @Przebieg, @DokumentySamochodu, @KluczykiSamochodu, @TestDrive, @Zlecenie, @Diagnostyka, @Naprawa)", conn);

                insert.Parameters.AddWithValue("@NrRejestracji", historyCar.NumberofRegister);
                insert.Parameters.AddWithValue("@Przebieg", historyCar.Mileage);
                insert.Parameters.AddWithValue("@DokumentySamochodu", historyCar.LeftDocument);
                insert.Parameters.AddWithValue("@KluczykiSamochodu", historyCar.KeyCar);
                insert.Parameters.AddWithValue("@TestDrive", historyCar.TestDrive);
                insert.Parameters.AddWithValue("@Zlecenie", historyCar.Zlecenie);
                insert.Parameters.AddWithValue("@Diagnostyka", historyCar.Diagnostic);
                insert.Parameters.AddWithValue("@Naprawa", historyCar.Repair);
                insert.Parameters.AddWithValue("@DataPrzyjęcia", historyCar.DateOfAcceptance);

                await insert.ExecuteNonQueryAsync();

                await transaction.CommitAsync();

                await LoadOfHistoryCar();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                dataError.Enqueue($"VIN:{historyCar.VIN}");
                dataError.Enqueue($"NrRejestracji:{historyCar.NumberofRegister}");
                dataError.Enqueue($"Przebieg:{historyCar.Mileage}");
                dataError.Enqueue($"DokumentySamochodu:{historyCar.LeftDocument}");
                dataError.Enqueue($"KluczykiSamochodu:{historyCar.KeyCar}");
                dataError.Enqueue($"TestDrive:{historyCar.TestDrive}");
                dataError.Enqueue($"Zlecenie:{historyCar.Zlecenie}");
                dataError.Enqueue($"Diagnostyka:{historyCar.Diagnostic}");
                dataError.Enqueue($"Naprawa:{historyCar.Repair}");
                dataError.Enqueue($"DataPrzyjęcia:{historyCar.DateOfAcceptance}");

                await Settings.Error(ex, dataError, "AddHistory", "problem with saving data or cmd SQL to History Repair");
                throw;
            }
            finally
            {
                HistoryCar.Reset();
            }
        }
        private async Task LoadDataCar()
        {
            await Settings.LoadData(pathAddClient, "SELECT ID, Marka, Model, RokProdukcji, VIN FROM Samochód", ViewAllCar, "history", "Load table Car From DB");
        }
        private async Task LoadOfHistoryCar()
        {
            // ViewHistory.DataSource = null;
            if (await Settings.TableExistHistory(pathHistoryRepair, VINTextBox.Text))
            {
                await Settings.LoadData(pathHistoryRepair, $"SELECT ID, DataPrzyjęcia, NrRejestracji, Przebieg, DokumentySamochodu, KluczykiSamochodu, TestDrive, Zlecenie, Diagnostyka, Naprawa FROM _{VINTextBox.Text}", ViewHistory, "history", "Load table history from DB");
            }
            else if (ViewHistory.DataSource != null)
            {
                ((DataTable)ViewHistory.DataSource).Clear();
            }
        }
        
        #endregion



        private async void ViewHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                await DeleteHistory(e);
            }
            catch
            {

            } 
        }

        private void ViewHistory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ReadData();
            SaveHistoryButton.Text = "Odśwież";
        }
        private async Task DeleteHistory(DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.ColumnIndex == ViewHistory.Columns["BtnDelete"].Index && ViewHistory.Rows[e.RowIndex].Cells["ID_Column"].Value != DBNull.Value)
            {
                long idToDelete = (long)ViewHistory.Rows[e.RowIndex].Cells["ID_Column"].Value;
                using SQLiteConnection conn = new(pathAddClient);
                await conn.OpenAsync();

                using var transaction = conn.BeginTransaction();

                using SQLiteCommand delete = new("DELETE FROM Klienty WHERE ID=@ID", conn);
                delete.Parameters.AddWithValue("ID", idToDelete);

                await delete.ExecuteNonQueryAsync();
                await transaction.CommitAsync();

                ViewHistory.Rows.RemoveAt(e.RowIndex);
                
                idToDelete = 0;
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
