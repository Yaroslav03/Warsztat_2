using System.Collections.Generic;
using System.Data.SQLite;
using System.Transactions;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Warsztat_2._0.UserControls.UC_CreateData
{
    public partial class UC_AddOrderRepair : UserControl
    {
        #region variables
        readonly string pathCarClients = "Data Source=Warsztat_CarClients.db;Version=3;New=False;Compress=True;";
        readonly string pathHistoryRepair = "Data Source=Warsztat_HistoryRepair.db;Version=3;New=False;Compress=True;";
        OrderRepair orderRepair = new();
        #endregion
        #region Event
        private async void UC_AddOrderRepair_Load(object sender, EventArgs e)
        {
            await LoadCarData();
        }

        private void ViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_label.Text = ViewCar.CurrentRow.Cells["ID_Column"].Value.ToString();
            VIN_label.Text = ViewCar.CurrentRow.Cells["VIN_Column"].Value.ToString();
        }

        private async void VIN_label_TextChanged(object sender, EventArgs e)
        {
            if (VIN_label.Text != "Brak")
            {
                await LoadHistoryRepair();
            }
        }
        #endregion
        #region Methods

        private void CollectData()
        {
            orderRepair = new()
            {
                Zlecenie = OrderTextBox.Text,
                Diagnostic = DiagnosticTextBox.Text,
                Repair = RepairTextBox.Text,
                Description = DescriptionTextBox.Text,
                NrPart = NrPartTextBox.Text,
                Price = (ushort)PriceNumericUpDown.Value,
                Stan = StanCheckBox.Checked
            };

        }
        private async void SaveData()
        {
            Cursor.Current = Cursors.WaitCursor;

            CollectData();

            using SQLiteConnection conn = new(pathHistoryRepair);

            await conn.OpenAsync();

            using var transaction = conn.BeginTransaction();
            try
            {
                SQLiteCommand add = new($"INSERT INTO {VIN_label.Text} (Zlecenie, Diagnostyka, Naprawa, Opis, NumerCzęści, Cena, Ilość, Wykonane) VALUES(@Zlecenie, @Diagnostyka, @Naprawa, @Opis, @NumerCzęści, @Cena, @Ilość, @Wykonane)", conn);

                add.Parameters.AddWithValue("@Zlecenie", orderRepair.Zlecenie);
                add.Parameters.AddWithValue("@Diagnostyka", orderRepair.Diagnostic);
                add.Parameters.AddWithValue("@Naprawa", orderRepair.Repair);
                add.Parameters.AddWithValue("@Opis", orderRepair.Description);
                add.Parameters.AddWithValue("@NumerCzęści", orderRepair.NrPart);
                add.Parameters.AddWithValue("@Cena", orderRepair.Price);
                add.Parameters.AddWithValue("@Ilość", orderRepair.Ilość);
                add.Parameters.AddWithValue("@Wykonane", orderRepair.Stan);

                await add.ExecuteNonQueryAsync();
                await transaction.CommitAsync();

                await LoadCarData();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw;
            }
            Cursor.Current = Cursors.Default;
            /*ViewHistoriRepair.Rows.Add(orderRepair)
            ViewHistoriRepair.Rows.Add.Cells["Diagnostyka_Column"].Value = orderRepair.Diagnostic;
            ViewHistoriRepair.Rows[rowCount].Cells["Naprawa_Column"].Value = orderRepair.Repair;
            ViewHistoriRepair.Rows[rowCount].Cells["Opis_Column"].Value = orderRepair.Description;
            ViewHistoriRepair.Rows[rowCount].Cells["NrCzęści_Column"].Value = orderRepair.NrPart;
            ViewHistoriRepair.Rows[rowCount].Cells["Cena_Column"].Value = orderRepair.Price;
            ViewHistoriRepair.Rows[rowCount].Cells["Ilość_Column"].Value = orderRepair.Ilość;*/
        }

        private async Task LoadCarData()
        {
            await Settings.LoadData(pathCarClients, "SELECT ID, Marka, Model, Silnik, RokProdukcji, VIN FROM Samochód", ViewCar, "client", "Load table Car From DB");
            await Settings.LoadData(pathHistoryRepair, "SELECT NrRejestracji, Przebieg, DokumentySamochodu, KluczykiSamochodu, TestDrive",,)
        }
        private async Task LoadDoubleTableToOne()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using SQLiteConnection conn = new(path);

                await conn.OpenAsync();

                using SQLiteDataAdapter adapter = new(cmd, conn);
                {
                    using DataTable dataTable = new();
                    dataTable.Clear();// Очищаємо дані, якщо вони вже були завантажені
                    adapter.Fill(dataTable);
                    view.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                await Settings.Error(ex, null, categoryError, textError);
            }
            Cursor.Current = Cursors.Default;
        }
        private async Task LoadHistoryRepair()
        {
            if (Settings.TableExists(pathHistoryRepair, VIN_label.Text))
            {
                await Settings.LoadData(pathHistoryRepair, $"SELECT ID, Zlecenie, Diagnostyka, Naprawa, Opis, NumerCzęści, Cena, Ilość, Wykonane FROM {VIN_label.Text}", ViewHistoriRepair, "history repair", "Load table form History repair from DB");
            }
            else
            {
                AttentionLabel.Text = "Takiego pojazdu z podanym numrerm VIN nie istnieje w bazie danych. \nProszę jeszcze raz spróbować dodać ten samochód a stary usunąć.";

                await Task.Delay(5000);

                this.Invoke((MethodInvoker)delegate
                {
                    AttentionLabel.Text = string.Empty;
                });

            }
            
        }
        #endregion
        public UC_AddOrderRepair()
        {
            InitializeComponent();
        }

        private void ButtonOrderRepairSave_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
