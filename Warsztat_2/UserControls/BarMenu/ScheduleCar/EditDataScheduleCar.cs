using System.Data.SQLite;
using Warsztat_2.UserControls.BarMenu.ScheduleCar;

namespace Warsztat_2._0.UserControls.BarMenu.ScheduleCar {
    internal class EditDataScheduleCar {

        private Car car = new();
        private Repair repair = new();
        public Client client = new();


        public async void SaveData(UC_ScheduleCar selectTab)
            {
            var scheduleCarData = GetScheduleCar(selectTab);

            bool isSucced = await SqlCmd.AddRecordAsync("WarsztatDB", "ZaplanowaneSamochody", scheduleCarData);
            if(isSucced)
                {
                MessageBox.Show($"Samochód został zaplanowany, kliknij OK żeby dodać kolejny", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        private Dictionary<string, object> GetScheduleCar(UC_ScheduleCar selectTab)
            {
            return new Dictionary<string, object>
                {
                    {"Imię",  selectTab.NameTextBox.Text.Trim()},
                    {"Nazwisko",  selectTab.SurnameTextBox.Text.Trim()},

                    {"Telefon",  selectTab.TelephonTextBox.Text.Trim()},
                    {"Marka",  selectTab.CarComboBox.Text.Trim()},

                    {"Model",  selectTab.ScheduleModelTextBox0.Text.Trim()},
                    {"Problem",  selectTab.ProblemCar.Text.Trim()},

                    {"DataPrzyjęcia",  selectTab.ScheduleTimePicker.Text},
                };
            }

        /*ID = Convert.ToByte(selectTab.ID_label.Text),*/

        public async void UpdateData(UC_ScheduleCar selectTab)
            {
            var scheduleCarData = GetScheduleCar(selectTab);
            var scheduleCarID = new Dictionary<string, object>
                {
                    {"ID", selectTab.ID_label.Text}
                };
            await SqlCmd.UpdateRecordAsync("ZaplanowaneSamochody", scheduleCarData, "ID=@ID", scheduleCarID);

            }

        public void SetDataEdit(Client clientToEdit, Car carToEdit, Repair repairToEdit)
            {//сетування даних при переході між класами
            client = clientToEdit;
            car = carToEdit;
            repair = repairToEdit;

            }
        public void AutocompleteDataSQL(UC_ScheduleCar UC, string telephone)
            {
            List<string> SQLResult = new();
            string[] data = { "Imię", "Nazwisko", "NrTelefonu", "VIN", "Marka", "Model" };
            try
                {

                using SQLiteConnection sqlConn = new("Data Source=Archive.db;Version=3;New=False;Compress=True;");
                sqlConn.Open();
                using SQLiteCommand search = new(@"SELECT K.Imię, K.Nazwisko, K.NrTelefonu, K.VIN, S.Marka, S.Model 
                                                    FROM Klienty K 
                                                    LEFT JOIN Samochód S ON K.VIN = S.VIN 
                                                    WHERE K.NrTelefonu LIKE @Telephone", sqlConn);

                search.Parameters.AddWithValue("@Telephone", "%" + telephone + "%");

                using SQLiteDataReader reader = search.ExecuteReader();

                while(reader.Read())
                    {
                    foreach(string s in data)
                        SQLResult.Add($"{reader[s]}");
                    }

                UC.label17.Text = $"{SQLResult[0]} {SQLResult[1]}";
                UC.label23.Text = $"{SQLResult[2]}";
                UC.label25.Text = $"{SQLResult[4]} {SQLResult[5]}";
                }
            catch
                {

                }
            SQLResult.Clear();
            }
        public void AutocompleteData(UC_ScheduleCar selectTab)
            {
            selectTab.ID_label.Text = client.ID.ToString();

            selectTab.NameTextBox.Text = client.Name;
            selectTab.SurnameTextBox.Text = client.Surname;
            selectTab.TelephonTextBox.Text = client.PhoneNumber;

            selectTab.CarComboBox.SelectedItem = car.Marka;
            selectTab.ScheduleModelTextBox0.Text = car.Model;

            selectTab.ProblemCar.Text = repair.Problem;

            selectTab.ScheduleTimePicker.Text = repair.ScheduleCar;
            }
        public static void ClearTextBox(UC_ScheduleCar editData)
            {
            editData.NameTextBox.Text = editData.SurnameTextBox.Text = editData.TelephonTextBox.Text = string.Empty;

            editData.CarComboBox.SelectedItem = editData.ScheduleModelTextBox0.Text = editData.ProblemCar.Text = string.Empty;

            editData.ScheduleTimePicker.Text = DateTime.Today.ToString("D");

            editData.ID_label.Text = "0";
            }
        }
    }