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
    public partial class UC_AddRepair : UserControl
    {
        #region variables
        readonly string pathCarClients = "Data Source=Warsztat_CarClients.db;Version=3;New=False;Compress=True;";
        readonly string pathHistoryRepair = "Data Source=Warsztat_HistoryRepair.db;Version=3;New=False;Compress=True;";
        private Queue<string> dataError = new();
        Repair repair = new();

        #endregion
        #region Event
        private async void UC_AddOrderRepair_Load(object sender, EventArgs e)
        {
            await LoadCarData();
        }

        private void ViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
            repair = new()
            {
                Description = DescriptionTextBox.Text,
                NrPart = NrPartTextBox.Text,
                Price = (ushort)PriceNumericUpDown.Value,
                Stan = StanCheckBox.Checked
            };

        }
        private async void SaveData()
        {/*
            Cursor.Current = Cursors.WaitCursor;

            CollectData();

            using SQLiteConnection conn = new(pathHistoryRepair);

            await conn.OpenAsync();

            using var transaction = conn.BeginTransaction();
            try
            {
                SQLiteCommand add = new($"INSERT INTO {VIN_label.Text} (Zlecenie, Diagnostyka, Naprawa, Opis, NumerCzęści, Cena, Ilość, Wykonane) VALUES(@Zlecenie, @Diagnostyka, @Naprawa, @Opis, @NumerCzęści, @Cena, @Ilość, @Wykonane)", conn);

                add.Parameters.AddWithValue("@Zlecenie", repair.Zlecenie);
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
            Cursor.Current = Cursors.Default;*/
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
            await Settings.LoadData(pathCarClients, "SELECT ID, Marka, Model, RokProdukcji, VIN FROM Samochód", ViewCar, "history", "Load table Car From DB");
        }

        private async Task LoadHistoryRepair()
        {
            /*if (await Settings.TableExistHistory(pathHistoryRepair, VIN_label.Text))
            {
                await Settings.LoadData(pathHistoryRepair, $"SELECT ID, Zlecenie, Diagnostyka, Naprawa, Opis, NumerCzęści, Cena, Ilość, Wykonane FROM {VIN_label.Text}", ViewRepair, "history repair", "Load table form History repair from DB");
            }
            else
            {
                AttentionLabel.Text = "Takiego pojazdu z podanym numrerm VIN nie istnieje w bazie danych. \nProszę jeszcze raz spróbować dodać ten samochód a stary usunąć.";

                await Task.Delay(5000);

                this.Invoke((MethodInvoker)delegate
                {
                    AttentionLabel.Text = string.Empty;
                });

            }*/
            
        }
        #endregion
        public UC_AddRepair()
        {
            InitializeComponent();
        }

        private async void ButtonOrderRepairSave_Click(object sender, EventArgs e)
        {
            await SaveRepair();
        }
        private async Task SaveRepair()
        {
            CollectData();

            using SQLiteConnection conn = new(pathHistoryRepair);

            await conn.OpenAsync();

            using var transaction = conn.BeginTransaction();

            try
            {
                // Використовуйте IF NOT EXISTS для створення таблиці лише у випадку, якщо вона не існує
                using SQLiteCommand createTable = new($"CREATE TABLE IF NOT EXISTS Repair_{VIN_label.Text} (ID INTEGER PRIMARY KEY AUTOINCREMENT, Opis TEXT, NumerCzęści TEXT, Cena INTEGER, Ilość INTEGER, Stan TEXT);", conn);

                await createTable.ExecuteNonQueryAsync();


                using SQLiteCommand insert = new($"INSERT INTO Repair_{VIN_label.Text} (Opis, NumerCzęści, Cena, Ilość, Stan)" +
                        "VALUES (@Opis, @NumerCzęści, @Cena, @Ilość, @Stan)", conn);

                insert.Parameters.AddWithValue("@Opis", repair.Description);
                insert.Parameters.AddWithValue("@NumerCzęści", repair.NrPart);
                insert.Parameters.AddWithValue("@Cena", repair.Price);
                insert.Parameters.AddWithValue("@Ilość", repair.Ilość);
                insert.Parameters.AddWithValue("@Stan", repair.Stan);

                await insert.ExecuteNonQueryAsync();

                await transaction.CommitAsync();

                await LoadRepair();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                dataError.Enqueue($"VIN:{VIN_label.Text}");
                dataError.Enqueue($"Opis:{repair.Description}");
                dataError.Enqueue($"Numer części:{repair.NrPart}");
                dataError.Enqueue($"Cena:{repair.Price}");
                dataError.Enqueue($"Ilość:{repair.Ilość}");
                dataError.Enqueue($"Stan:{repair.Stan}");

                await Settings.Error(ex, dataError, "AddRepair", "problem with saving data or cmd SQL to Repair");
                throw;
            }
            finally
            {
                HistoryCar.Reset();
            }

        }
        private async Task LoadRepair()
        {
            if (await Settings.TableExistHistory(pathHistoryRepair, VIN_label.Text))
            {
                await Settings.LoadData(pathHistoryRepair, $"SELECT ID, DataPrzyjęcia, NrRejestracji, Przebieg, DokumentySamochodu, KluczykiSamochodu, TestDrive, Zlecenie, Diagnostyka, Naprawa FROM Repair_{VIN_label.Text}", ViewRepair, "history", "Load table history from DB");
            }
        }

    }
}
