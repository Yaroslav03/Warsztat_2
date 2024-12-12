//size: 1019; 580
using System.Data;

namespace Warsztat_2._0.UserControls.UC_CreateData {
    public partial class UC_AddClient :UserControl {
        Guid uniqueKey;
        public UC_AddClient()
            {
            InitializeComponent();
            }
        #region Event
        private async void ButtonClientSave_Click(object sender, EventArgs e)
            {
            await SaveClient();
            }

        private void TextBoxSearchClientData_TextChanged(object sender, EventArgs e)
            {
            Settings.SearchTextBox(TextBoxSearchClientData, ViewClients);
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

        private async void ViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
            // Метод для безпечного отримання значення з DataGridView
            string GetCellValue(string columnName) => ViewClients.CurrentRow.Cells[columnName]?.Value?.ToString() ?? string.Empty;

            ID_Client_label.Text = GetCellValue("ID_Column");
            NameTextBox.Text = GetCellValue("Name_Column");
            SurnameTextBox.Text = GetCellValue("Surname_Column");
            TelephoneTextBox.Text = GetCellValue("Telephone_Column");
            AdressCompanyTextBox.Text = GetCellValue("Adress_Column");
            NIPTextBox.Text = GetCellValue("NIP_Column");
            // Отримуємо рядкове значення UniqueKey з комірки
            byte[] uniqueKeyBytes = (byte[])ViewClients.CurrentRow.Cells["UniqueKey_Column"].Value;
            uniqueKey = new Guid(uniqueKeyBytes);

            ButtonClientUpdate.Show();
            label2.Show();
            }
 
        private async void ButtonClientUpdate_Click(object sender, EventArgs e)
            {
            try
                {
                await UpdateClient();
                }
            catch(Exception ex)
                {
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
                    {"AdresFirmy", AdressCompanyTextBox.Text.Trim()},
                    {"UniqueKey", uniqueKey}
                };
            }
        private async Task SaveClient()
            {
            uniqueKey = Guid.NewGuid();
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
            await SqlCmd.LoadData("SELECT ID, Imię, Nazwisko, NrTelefonu, AdresFirmy, NIP, UniqueKey FROM Klienty", ViewClients, "client", "Load table Clients From DB");
            }

        private async void UC_AddClient_Load(object sender, EventArgs e)
            {
            await LoadDataClient();

            ButtonClientUpdate.Hide();
            label2.Hide();
            }

        #endregion

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