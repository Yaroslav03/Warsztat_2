//size: 1019; 580
using System.Data;

namespace Warsztat_2._0.UserControls.UC_CreateData {
    public partial class UC_AddClient :UserControl {
        //Client client = new();
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
            catch(Exception ex)
                {
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
            if(string.IsNullOrEmpty(TextBoxSearchClientData.Text))
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
            string[] searchTerms = SearchCarTextBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if(searchTerms.Length == 0)
                {
                // Якщо поле пошуку порожнє, знімаємо вибір з усіх осередків
                foreach(DataGridViewRow row in ViewCar.Rows)
                    {
                    foreach(DataGridViewCell cell in row.Cells)
                        {
                        cell.Selected = false;
                        }
                    }
                return;
                }

            // Виділення відповідних осередків у таблиці
            foreach(DataGridViewRow row in ViewCar.Rows)
                {
                foreach(DataGridViewCell cell in row.Cells)
                    {
                    // Перевіряємо, чи значення осередку відповідає хоча б одному терміну
                    if(cell.Value != null && searchTerms.Any(term => cell.Value.ToString().Contains(term, StringComparison.OrdinalIgnoreCase)))
                        {
                        cell.Selected = true;
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
            await SqlCmd.DeleteDataTable(ViewClients, e, "BtnDelete", "ID_Column", "Klienty");
            }
        private void ClearPanel_Click(object sender, EventArgs e)
            {
            Settings.ClearTextBox(panelKontaktowy);
            Settings.ClearTextBox(panelDodatkowy);
            }

        private void ViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {

            // Метод для безпечного отримання значення з DataGridView
            string GetCellValue(string columnName) => ViewClients.CurrentRow.Cells[columnName]?.Value?.ToString() ?? string.Empty;

            ID_Client_label.Text = GetCellValue("ID_Column");
            NameTextBox.Text = GetCellValue("Name_Column");
            SurnameTextBox.Text = GetCellValue("Surname_Column");
            TelephoneTextBox.Text = GetCellValue("Telephone_Column");
            AdressCompanyTextBox.Text = GetCellValue("Adress_Column");
            NIPTextBox.Text = GetCellValue("NIP_Column");

            ButtonClientUpdate.Show();
            label2.Show();

            if(SetCarToClientCheckBox.Checked == true && ID_Client_label.Text != "0" && setCarToClient.Count == 0 && ID_Client_label.Text != null) // Ця умова не дає можливості записати автомобіль до не існуючого клієнта
                {
                setCarToClient.Add(ID_Client_label.Text.ToString());

                MessageBox.Show(setCarToClient[0]);//показати користувачу що він вибрав  
                }
            else if(setCarToClient.Count >= 1 && ID_Client_label.Text != null)// можливість перевибору даних. Якщо користувач помилився або вирішив вибрати іншого клієнта
                {
                setCarToClient[0] = ID_Client_label.Text.ToString();
                MessageBox.Show(setCarToClient[0]);//показати користувачу що він вибрав  
                }
            //MessageBox.Show("Ilość danych:" + setCarToClient.Count);
            }
        private async void ViewCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            if(SetCarToClientCheckBox.Checked == true)
                {
                if(ID_Client_label.Text != "0" && setCarToClient.Count == 1) // Ця умова не дає можливості записати автомобіль до не існуючого клієнта
                    {
                    setCarToClient.Add(ViewCar.CurrentRow.Cells["VIN_Column"].Value.ToString());
                    MessageBox.Show(setCarToClient[1]);//показати користувачу що він вибрав  

                    }
                else if(setCarToClient.Count == 2) // можливість перевибору даних. Якщо користувач помилився або вирішив вибрати іншого клієнта
                    {
                    setCarToClient[1] = ViewCar.CurrentRow.Cells["VIN_Column"].Value.ToString();
                    MessageBox.Show(setCarToClient[1]); //показати користувачу що він вибрав              
                    }
                setCarToClientButton.Show();
                }
            await SqlCmd.DeleteDataTable(ViewCar, e, "BtnDeleteCar", "ID_CAR", "Samochód");
            }
        private async void ButtonClientUpdate_Click(object sender, EventArgs e)
            {
            try
                {
                await UpdateClient();
                }
            catch(Exception ex)
                {
                /*                Queue<string> value = new();
                                value.Enqueue($"\n\tID:{ID_Client_label.Text}");
                                value.Enqueue($"\n\tName:{client.Name}");
                                value.Enqueue($"\n\tSurname:{client.Surname}");
                                value.Enqueue($"\n\tAdress:{client.AdressCompany}");
                                value.Enqueue($"\n\tPhone Number:{client.PhoneNumber}");
                                value.Enqueue($"\n\tNIP:{client.NIP}");

                                await Settings.Error(ex, value, "client", "Update CLient to DB");*/
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
        private Dictionary<string, object> GetClientData()
            {
            return new Dictionary<string, object>
                {
                    {"Imię", NameTextBox.Text.Trim()},
                    {"Nazwisko", SurnameTextBox.Text.Trim()},
                    {"NrTelefonu", TelephoneTextBox.Text.Trim()},
                    {"NIP", NIPTextBox.Text.Trim()},
                    {"AdresFirmy", AdressCompanyTextBox.Text.Trim()}
                };
            }
        private async Task SaveClient()
            {
            var client = GetClientData();

            await SqlCmd.AddRecordAsync("Klienty", client);

            await LoadDataClient();
            }
        private async Task UpdateClient()
            {
            var client = GetClientData();

            var clientId = new Dictionary<string, object>
                {
                    {"ID",  ID_Client_label.Text}
                };

            await SqlCmd.UpdateRecordAsync("Klienty", client, "ID = @ID", clientId);
            await LoadDataClient();
            }
        private async Task LoadDataClient()
            {
            await SqlCmd.LoadData("SELECT ID, Imię, Nazwisko, NrTelefonu, AdresFirmy, NIP, VIN FROM Klienty", ViewClients, "client", "Load table Clients From DB");
            }
        private async Task LoadDataCar()
            {
            await SqlCmd.LoadData("SELECT ID, Marka, Model, Silnik, RokProdukcji, VIN FROM Samochód", ViewCar, "client", "Load table Car From DB");
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
            if(SetCarToClientCheckBox.Checked == false)
                {
                MessageBox.Show("Ilość danych:" + setCarToClient.Count);
                setCarToClientButton.Hide();
                setCarToClient.Clear();
                MessageBox.Show("Ilość danych:" + setCarToClient.Count);
                }
            }

        private async void SetCarToClientButton_Click(object sender, EventArgs e)
            {
            try
                {
                await AddCarToClient();
                }
            catch(Exception ex)
                {
                Queue<string> value = new();
                if(setCarToClient.Count == 0)
                    {
                    value.Enqueue("Brak zmiennych, dane zostali usunięte");
                    }
                else if(setCarToClient.Count > 0)
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
            var AddCarToClient = new Dictionary<string, object>
                {
                    {"ID", setCarToClient[0]},
                    {"VIN", setCarToClient[1] }
                };
            var AddCarToClientID = new Dictionary<string, object>
                {
                    {"ID", setCarToClient[0]}
                };

            await SqlCmd.UpdateRecordAsync("Klienty", AddCarToClient, "ID = @ID", AddCarToClientID);
            await LoadDataClient();
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