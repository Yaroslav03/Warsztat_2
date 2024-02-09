//size: 1019; 580
using System.Data;
using System.Data.SQLite;

namespace Warsztat_2._0.UserControls.UC_CreateData
{
    public partial class UC_AddClient : UserControl
    {
        readonly string pathAddClient = "Data Source=Warsztat_CarClients.db;Version=3;New=False;Compress=True;";
        Client client = new();
        List<string> setCarToClient = new();
        public UC_AddClient()
        {
            InitializeComponent();
        }
        #region Event
        private async void ButtonClientSave_Click(object sender, EventArgs e)
        {
            try
            {
                await SaveClient();
            }
            catch (Exception ex)
            {
                Queue<string> value = new();
                value.Enqueue($"\n\tName:{client.Name}");
                value.Enqueue($"\n\tSurname:{client.Surname}");
                value.Enqueue($"\n\tAdress:{client.AdressCompany}");
                value.Enqueue($"\n\tPhone Number:{client.PhoneNumber}");
                value.Enqueue($"\n\tNIP:{client.NIP}");

                await Settings.Error(ex, value, "client", "Save data to DB");
            }
        }
        private void TextBoxSearchClientData_TextChanged(object sender, EventArgs e)
        {
            string filter;
            string[] search;
            BindingSource bindingSource = new()
            {
                DataSource = ViewClients.DataSource
            };
            if (string.IsNullOrEmpty(TextBoxSearchClientData.Text))
            {
                bindingSource.RemoveFilter();
                filter = string.Empty;
            }

            search = TextBoxSearchClientData.Text.Split(' ');

            filter = string.Join(" AND ", search.Select(term => $"Imię LIKE '%{term}%' OR Nazwisko LIKE '%{term}%' OR NIP LIKE '%{term}%' OR NrTelefonu LIKE '%{term}%' OR Imię LIKE '%{term}%' OR Nazwisko LIKE '%{term}%' OR NIP LIKE '%{term}%' OR NrTelefonu LIKE '%{term}%' "));
            bindingSource.Filter = filter;
        }

        private void SearchCarTextBox_TextChanged(object sender, EventArgs e)
        {
            string filter;
            string[] search;
            BindingSource bindingSource = new()
            {
                DataSource = ViewCar.DataSource
            };
            if (string.IsNullOrEmpty(SearchCarTextBox.Text))
            {
                bindingSource.RemoveFilter();
                filter = string.Empty;
            }

            search = SearchCarTextBox.Text.Split(' ');

            filter = string.Join(" AND ", search.Select(term => $"Marka LIKE '%{term}%' OR Model LIKE '%{term}%' OR Silnik LIKE '%{term}%' OR RokProdukcji LIKE '%{term}%' OR Marka LIKE '%{term}%' OR Model LIKE '%{term}%' OR Silnik LIKE '%{term}%' OR RokProdukcji LIKE '%{term}%' OR VIN LIKE'%{term}' "));
            bindingSource.Filter = filter;


            foreach (DataGridViewRow row in ViewCar.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    bool searchText = filter.Any();
                    if (cell.Value != null && searchText == true)
                    {
                        cell.Selected = true;
                        //return;
                    }
                    else
                    {
                        cell.Selected = false;
                    }
                }
            }
        }



        private async void ViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                await SqlCmd.DeleteDataTable(ViewClients, e, pathAddClient, "BtnDelete", "ID_Column", "Klienty");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void ClearPanel_Click(object sender, EventArgs e)
        {
            Settings.ClearTextBox(panelKontaktowy);
            Settings.ClearTextBox(panelDodatkowy);
        }

        private void ViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Client_label.Text = ID_Client_label_0.Text = ViewClients.CurrentRow.Cells["ID_Column"].Value.ToString();
            NameTextBox.Text = ViewClients.CurrentRow.Cells["Name_Column"].Value.ToString();
            SurnameTextBox.Text = ViewClients.CurrentRow.Cells["Surname_Column"].Value.ToString();
            TelephoneTextBox.Text = ViewClients.CurrentRow.Cells["Telephone_Column"].Value.ToString();
            AdressCompanyTextBox.Text = ViewClients.CurrentRow.Cells["Adress_Column"].Value.ToString();
            NIPTextBox.Text = ViewClients.CurrentRow.Cells["NIP_Column"].Value.ToString();

            ButtonClientUpdate.Show();
            label2.Show();

            if (SetCarToClientCheckBox.Checked == true && ID_Client_label.Text != "0" && setCarToClient.Count == 0) // Ця умова не дає можливості записати автомобіль до не існуючого клієнта
            {
                setCarToClient.Add(ID_Client_label.Text.ToString());

                MessageBox.Show(setCarToClient[0]);//показати користувачу що він вибрав  
            }
            else if (setCarToClient.Count >= 1)// можливість перевибору даних. Якщо користувач помилився або вирішив вибрати іншого клієнта
            {
                setCarToClient[0] = ID_Client_label.Text.ToString();
                MessageBox.Show(setCarToClient[0]);//показати користувачу що він вибрав  
            }
            //MessageBox.Show("Ilość danych:" + setCarToClient.Count);
        }
        private async void ViewCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SetCarToClientCheckBox.Checked == true)
            {
                if (ID_Client_label.Text != "0" && setCarToClient.Count == 1) // Ця умова не дає можливості записати автомобіль до не існуючого клієнта
                {
                    setCarToClient.Add(ViewCar.CurrentRow.Cells["VIN_Column"].Value.ToString());
                    MessageBox.Show(setCarToClient[1]);//показати користувачу що він вибрав  

                }
                else if (setCarToClient.Count == 2) // можливість перевибору даних. Якщо користувач помилився або вирішив вибрати іншого клієнта
                {
                    setCarToClient[1] = ViewCar.CurrentRow.Cells["VIN_Column"].Value.ToString();
                    MessageBox.Show(setCarToClient[1]); //показати користувачу що він вибрав              
                }
                setCarToClientButton.Show();
            }

            
            try
            {
                await SqlCmd.DeleteDataTable(ViewCar, e, pathAddClient, "BtnDeleteCar", "ID_CAR", "Samochód");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private async void ButtonClientUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                await UpdateClient();
            }
            catch (Exception ex)
            {
                Queue<string> value = new();
                value.Enqueue($"\n\tID:{ID_Client_label.Text}");
                value.Enqueue($"\n\tName:{client.Name}");
                value.Enqueue($"\n\tSurname:{client.Surname}");
                value.Enqueue($"\n\tAdress:{client.AdressCompany}");
                value.Enqueue($"\n\tPhone Number:{client.PhoneNumber}");
                value.Enqueue($"\n\tNIP:{client.NIP}");

                await Settings.Error(ex, value, "client", "Update CLient to DB");
            }
            finally
            {
                Settings.ClearTextBox(panelKontaktowy);
                Settings.ClearTextBox(panelDodatkowy);
                ButtonClientUpdate.Hide();
                label2.Hide();
            }
        }

        #endregion
        #region methods
        private void CollectData()
        {
            client = new()
            {
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                PhoneNumber = TelephoneTextBox.Text,
                NIP = NIPTextBox.Text,
                AdressCompany = AdressCompanyTextBox.Text
            };
        }
        private void ValueDB(SQLiteCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Imię", client.Name);
            cmd.Parameters.AddWithValue("@Nazwisko", client.Surname);
            cmd.Parameters.AddWithValue("@NrTelefonu", client.PhoneNumber);
            cmd.Parameters.AddWithValue("@AdresFirmy", client.AdressCompany);
            cmd.Parameters.AddWithValue("@NIP", client.NIP);
        }
        private async Task SaveClient()
        {
            Cursor.Current = Cursors.WaitCursor;

            CollectData();

            using SQLiteConnection connection = new(pathAddClient);

            await connection.OpenAsync();

            using var transaction = connection.BeginTransaction();
            try
            {
                using SQLiteCommand add = new("INSERT INTO Klienty (Imię, Nazwisko, NrTelefonu, AdresFirmy, NIP) VALUES(@Imię, @Nazwisko, @NrTelefonu, @AdresFirmy, @NIP)", connection, transaction);

                ValueDB(add);

                await add.ExecuteNonQueryAsync();

                await transaction.CommitAsync();

                await LoadDataClient();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                Client.Reset();
                Cursor.Current = Cursors.Default;
            }
        }
        private async Task UpdateClient()
        {
            Cursor.Current = Cursors.WaitCursor;

            CollectData();

            using SQLiteConnection connection = new(pathAddClient);

            await connection.OpenAsync();

            using var transaction = connection.BeginTransaction();
            try
            {

                using SQLiteCommand update = new("UPDATE Klienty SET Imię = @Imię, Nazwisko = @Nazwisko, NrTelefonu= @NrTelefonu, AdresFirmy = @AdresFirmy, NIP = @NIP WHERE ID = @ID", connection, transaction);
                update.Parameters.AddWithValue("@ID", ID_Client_label.Text);
                ValueDB(update);

                await update.ExecuteNonQueryAsync();

                await transaction.CommitAsync();

                await LoadDataClient();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                Client.Reset();
                Cursor.Current = Cursors.Default;
            }
        }
        private async Task LoadDataClient()
        {
            await Settings.LoadData(pathAddClient, "SELECT ID, Imię, Nazwisko, NrTelefonu, AdresFirmy, NIP, VIN_Samochodu FROM Klienty", ViewClients, "client", "Load table Clients From DB");
        }
        private async Task LoadDataCar()
        {
            await Settings.LoadData(pathAddClient, "SELECT ID, Marka, Model, Silnik, RokProdukcji, VIN FROM Samochód", ViewCar, "client", "Load table Car From DB");
        }

        private async void UC_AddClient_Load(object sender, EventArgs e)
        {
            await LoadDataClient();
            await LoadDataCar();

            ButtonClientUpdate.Hide();
            setCarToClientButton.Hide();
            label2.Hide();
        }

        #endregion

        private void SetCarToClientCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SetCarToClientCheckBox.Checked == false)
            {
                MessageBox.Show("Ilość danych:" + setCarToClient.Count);
                setCarToClientButton.Hide();
                setCarToClient.Clear();
                MessageBox.Show("Ilość danych:" + setCarToClient.Count);
            }
        }

        private async void setCarToClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                await AddCarToClient();
            }
            catch (Exception ex)
            {
                Queue<string> value = new();
                if (setCarToClient.Count == 0)
                {
                    value.Enqueue("Brak zmiennych, dane zostali usunięte");
                }
                else if (setCarToClient.Count > 0)
                {
                    value.Enqueue($"\n\tID_CLient:{setCarToClient[0]}");
                    value.Enqueue($"\n\tVIN:{setCarToClient[1]}");
                }

                await Settings.Error(ex, value, "client", "set car to client");
            }
            setCarToClient.Clear();
            setCarToClientButton.Hide();
            SetCarToClientCheckBox.Checked = false;

        }
        private async Task AddCarToClient()
        {
            Cursor.Current = Cursors.WaitCursor;

            using SQLiteConnection connection = new(pathAddClient);

            await connection.OpenAsync();

            using var transaction = connection.BeginTransaction();
            try
            {

                using SQLiteCommand addCarToClient = new("UPDATE Klienty SET VIN_Samochodu = @VIN_Samochodu WHERE ID = @ID", connection, transaction);
                addCarToClient.Parameters.AddWithValue("@ID", setCarToClient[0]);

                addCarToClient.Parameters.AddWithValue("@VIN_Samochodu", setCarToClient[1]);

                await addCarToClient.ExecuteNonQueryAsync();

                await transaction.CommitAsync();

                await LoadDataClient();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            Cursor.Current = Cursors.Default;
        }

        private void HelpMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Żeby przypisać samochód potrzebno wykonać następujące czyności:\n" +
                "\n [1]Ustawić flagę [Przypisz samochód do klienta]" +
                "\n [2]Kliknąć x2 razy po wybranym kliencie, wtedy wyskoczy powiadomienie o wybranym kliencie." +
                "\n [3]Kliknąć wybrany samochód wtedy pojawi się przycisk [Przypisz], wtedy wyskoczy powiadomienie o wybranym samochodzie." +
                "\n\n Żeby pokasować zmienne w pamięci programu należy usunąć flagę z [Przypisz samochód do klienta]");
        }
    }
}