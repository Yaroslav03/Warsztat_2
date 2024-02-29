using System.Data.SQLite;


namespace Warsztat_2._0.UserControls.UC_CreateData
{
    public partial class UC_AddRepair : UserControl
    {
        #region variables
        private readonly string connection = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        private readonly Queue<string> dataError = new();
        Repair repair = new();

        private protected ushort Id_Repair;

        #endregion
        #region Event
        public event EventHandler<string> VINChanged;
        public event EventHandler<ushort> Price;
        private ushort pricePart;
        private async void UC_AddOrderRepair_Load(object sender, EventArgs e)
        {
            await LoadCarData();
            GC.Collect();
        }

        private async void ViewCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VIN_label.Text = ViewCar.CurrentRow.Cells["VIN_Column"].Value.ToString();

            await LoadRepair();
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
                Ilość = (byte)IloscNumericUpDown.Value,
                Stan = StanCheckBox.Checked,
                DateOfAcceptance = RepairTimePicker.Text.ToString()

            };
        }
        private void CollectDataFromTable()
        {
            Id_Repair = Convert.ToUInt16(ViewRepair.CurrentRow.Cells["ID"].Value.ToString());

            DescriptionTextBox.Text = ViewRepair.CurrentRow.Cells["Opis_Column"].Value.ToString();
            NrPartTextBox.Text = ViewRepair.CurrentRow.Cells["NrCzęści_Column"].Value.ToString();
            PriceNumericUpDown.Text = ViewRepair.CurrentRow.Cells["Cena_Column"].Value.ToString();
            IloscNumericUpDown.Text = ViewRepair.CurrentRow.Cells["Ilość_Column"].Value.ToString();

            StanCheckBox.Checked = ViewRepair.CurrentRow.Cells["Wykonane_Checked"].Value.ToString() == "1";

            RepairTimePicker.Text = ViewRepair.CurrentRow.Cells["DateRepair"].Value.ToString();
        }
        /*private void SaveData()
        {
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
            Cursor.Current = Cursors.Default;
            ViewHistoriRepair.Rows.Add(orderRepair)
            ViewHistoriRepair.Rows.Add.Cells["Diagnostyka_Column"].Value = orderRepair.Diagnostic;
            ViewHistoriRepair.Rows[rowCount].Cells["Naprawa_Column"].Value = orderRepair.Repair;
            ViewHistoriRepair.Rows[rowCount].Cells["Opis_Column"].Value = orderRepair.Description;
            ViewHistoriRepair.Rows[rowCount].Cells["NrCzęści_Column"].Value = orderRepair.NrPart;
            ViewHistoriRepair.Rows[rowCount].Cells["Cena_Column"].Value = orderRepair.Price;
            ViewHistoriRepair.Rows[rowCount].Cells["Ilość_Column"].Value = orderRepair.Ilość;
        }*/

        private async Task LoadCarData()
        {
            await SqlCmd.LoadData(connection, "SELECT ID, Marka, Model, RokProdukcji, VIN FROM Samochód", ViewCar, "history", "Load table Car From DB");
        }

        /*private async Task LoadHistoryRepair()
        {
            if (await Settings.TableExistHistory(pathHistoryRepair, VIN_label.Text))
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

            }

        }*/
        #endregion
        public UC_AddRepair()
        {
            InitializeComponent();
        }

        private async void ButtonOrderRepairSave_Click(object sender, EventArgs e)
        {
            if (ButtonRepairSave.Text == "Zapisz")
            {
                await SaveRepair();
            }
            else if (ButtonRepairSave.Text == "Odśwież")
            {
                await UpdateRepair();
                ButtonRepairSave.Text = "Zapisz";
            }
            await LoadRepair();
        }
        private async Task UpdateRepair()
        {
            CollectData();

            using SQLiteConnection conn = new(connection);

            await conn.OpenAsync();

            using var transaction = conn.BeginTransaction();
            try
            {
                using SQLiteCommand update = new($"UPDATE NaprawaSamochodu SET Opis=@Opis, NumerCzęści=@NumerCzęści, Cena=@Cena, Ilość=@Ilość, Stan=@Stan, DataNapraw=@DataNapraw WHERE  ID=@ID", conn);

                update.Parameters.AddWithValue("@ID", Id_Repair);
                update.Parameters.AddWithValue("@Opis", repair.Description);
                update.Parameters.AddWithValue("@NumerCzęści", repair.NrPart);
                update.Parameters.AddWithValue("@Cena", repair.Price);
                update.Parameters.AddWithValue("@Ilość", repair.Ilość);
                update.Parameters.AddWithValue("@Stan", repair.Stan);
                update.Parameters.AddWithValue("@DataNapraw", repair.DateOfAcceptance);

                await update.ExecuteNonQueryAsync();

                await transaction.CommitAsync();

                await conn.CloseAsync();
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
                dataError.Enqueue($"Data:{repair.DateOfAcceptance}");

                await Settings.Error(ex, dataError, "AddRepair", "problem with saving data or cmd SQL to Repair");
                throw;
            }
            finally
            {
                Id_Repair = 0;
                Repair.Reset();
                Settings.ClearTextBox(panelDodatkowy);
                StanCheckBox.Checked = false;
                ButtonRepairSave.Text = "Zapisz";
                PriceNumericUpDown.Value = IloscNumericUpDown.Value = 0;
            }
        }
        private async Task SaveRepair()
        {
            CollectData();

            using SQLiteConnection conn = new(connection);

            await conn.OpenAsync();

            using var transaction = conn.BeginTransaction();

            try
            {
                // Використовуйте IF NOT EXISTS для створення таблиці лише у випадку, якщо вона не існує
                using SQLiteCommand createTable = new($"CREATE TABLE IF NOT EXISTS NaprawaSamochodu (ID INTEGER PRIMARY KEY AUTOINCREMENT, Opis TEXT, NumerCzęści TEXT, Cena INTEGER, Ilość INTEGER, Stan TEXT, DataNapraw TEXT, VIN TEXT);", conn);

                await createTable.ExecuteNonQueryAsync();


                using SQLiteCommand insert = new($"INSERT INTO NaprawaSamochodu (Opis, NumerCzęści, Cena, Ilość, Stan, DataNapraw, VIN)" +
                        "VALUES (@Opis, @NumerCzęści, @Cena, @Ilość, @Stan, @DataNapraw, @VIN)", conn);

                insert.Parameters.AddWithValue("@VIN", VIN_label.Text);
                insert.Parameters.AddWithValue("@Opis", repair.Description);
                insert.Parameters.AddWithValue("@NumerCzęści", repair.NrPart);
                insert.Parameters.AddWithValue("@Cena", repair.Price);
                insert.Parameters.AddWithValue("@Ilość", repair.Ilość);
                insert.Parameters.AddWithValue("@Stan", repair.Stan);
                insert.Parameters.AddWithValue("@DataNapraw", repair.DateOfAcceptance);

                await insert.ExecuteNonQueryAsync();

                await transaction.CommitAsync();

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
                dataError.Enqueue($"Data:{repair.DateOfAcceptance}");

                await Settings.Error(ex, dataError, "AddRepair", "problem with saving data or cmd SQL to Repair");
                throw;
            }
            finally
            {
                HistoryCar.Reset();
                Settings.ClearTextBox(panelDodatkowy);
                StanCheckBox.Checked = false;
                PriceNumericUpDown.Value = 0; IloscNumericUpDown.Value = 1;
            }

        }
        private async Task LoadRepair()
        {
            //if (await SqlCmd.TableExistHistory(connection, VIN_label.Text))
            //{
            await SqlCmd.LoadData(connection, $"SELECT ID, Opis, NumerCzęści, Cena, Ilość, Stan FROM NaprawaSamochodu WHERE VIN LIKE '%{VIN_label.Text}'", ViewRepair, "Repair", "Load table Repair from DB");
            //}
            /*            else if (ViewRepair.DataSource != null)
                        {
                            ((DataTable)ViewRepair.DataSource).Clear();
                        }*/
        }

        private async void ViewRepair_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                await DeleteRepair(e);
            }
            catch
            {

            }
        }
        private async Task DeleteRepair(DataGridViewCellEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.ColumnIndex == ViewRepair.Columns["BtnDelete"].Index && ViewRepair.Rows[e.RowIndex].Cells["ID"].Value != DBNull.Value)
            {
                long idToDelete = (long)ViewRepair.Rows[e.RowIndex].Cells["ID"].Value;
                using SQLiteConnection conn = new(connection);
                await conn.OpenAsync();

                using var transaction = conn.BeginTransaction();

                using SQLiteCommand delete = new($"DELETE FROM NaprawaSamochodu WHERE ID=@ID", conn);
                delete.Parameters.AddWithValue("ID", idToDelete);

                await delete.ExecuteNonQueryAsync();
                await transaction.CommitAsync();

                ViewRepair.Rows.RemoveAt(e.RowIndex);

                idToDelete = 0;
            }
            Cursor.Current = Cursors.Default;
        }

        private void ViewRepair_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CollectDataFromTable();
            ButtonRepairSave.Text = "Odśwież";
        }

        private void SumRepair()
        {
            decimal totalPrice = 0;
            foreach (DataGridViewRow row in ViewRepair.Rows)
            {
                if (row.Cells["Cena_Column"].Value != null && decimal.TryParse(row.Cells["Cena_Column"].Value.ToString(), out decimal price))
                {
                    totalPrice += price;
                }
            }
            pricePart = (ushort)totalPrice;
            //MessageBox.Show("1"+pricePart);
        }

        private void VIN_label_Click(object sender, EventArgs e)
        {
            if (VIN_label.Text != "Brak")
            {
                SumRepair();
                VINChanged?.Invoke(this, VIN_label.Text);
                //MessageBox.Show("2" + pricePart);
                Price?.Invoke(this, pricePart);
            }

        }
    }
}
