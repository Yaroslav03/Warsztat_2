using System.Data.SQLite;

namespace Warsztat_2._0.UserControls.BarMenu.ScheduleCar
{
    internal class EditDataScheduleCar
    {
        private readonly string path = "Data Source=WarsztatData.db;Version=3;New=False;Compress=True;";

        private Car car = new();
        private OrderRepair orderRepair = new();
        public Client client = new();


        public void SaveData(UC_ScheduleCarSelectTab selectTab)
        {
            Cursor.Current = Cursors.WaitCursor;
            ////////////////////////////////////

            /////////////////////////////////////
            try
            {
                PrepareData(selectTab);

                using SQLiteConnection conn = new(path);
                conn.Open();

                using SQLiteCommand insert = new("INSERT INTO ZaplanowaneSamochody (Imię, Nazwisko, Marka, Model, Problem, Telefon, DataPrzyjęcia) " +
                    "VALUES (@Imię, @Nazwisko, @Marka, @Model, @Problem, @Telefon, @DataPrzyjęcia)", conn);
                ValueDB(insert);

                insert.ExecuteNonQuery();

                MessageBox.Show($"Samochód został zaplanowany, kliknij OK żeby dodać kolejny", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Client.Reset();
                Car.Reset();
                OrderRepair.Reset();
                Cursor.Current = Cursors.Default;
            }
        }
        private void ValueDB(SQLiteCommand cmd)
        {
            cmd.Parameters.AddWithValue("@Imię", client.Name);
            cmd.Parameters.AddWithValue("@Nazwisko", client.Surname);
            cmd.Parameters.AddWithValue("@Telefon", client.PhoneNumber);

            cmd.Parameters.AddWithValue("@Marka", car.Marka);
            cmd.Parameters.AddWithValue("@Model", car.Model);
            cmd.Parameters.AddWithValue("@Problem", orderRepair.Problem);
            cmd.Parameters.AddWithValue("@DataPrzyjęcia", orderRepair.ScheduleCar);
        }
        public void UpdateData(UC_ScheduleCarSelectTab selectTab)
        {
            Cursor.Current = Cursors.WaitCursor;

            PrepareData(selectTab);
            try
            {
                using SQLiteConnection conn = new(path);
                conn.Open();
                using SQLiteCommand update = new("UPDATE ZaplanowaneSamochody SET Imię = @Imię, Nazwisko = @Nazwisko, Telefon = @Telefon, Marka = @Marka, Model = @Model, Problem = @Problem, DataPrzyjęcia = @DataPrzyjęcia WHERE ID = @ID", conn);

                // Встановіть значення параметрів перед виконанням запиту
                update.Parameters.AddWithValue("@ID", client.ID);
                ValueDB(update);

                int rowsUpdate = update.ExecuteNonQuery();

                if (!(rowsUpdate > 0))
                {
                    MessageBox.Show($"Zapłanowany samochód nie został odświeżony", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MessageBox.Show($"Zapłanowany samochód został odświeżony", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Client.Reset();
                Car.Reset();
                OrderRepair.Reset();
                Cursor.Current = Cursors.Default;
            }
        }
        private void PrepareData(UC_ScheduleCarSelectTab selectTab)
        {
            client = new Client
            {
                ID = Convert.ToByte(selectTab.ID_label.Text),
                Name = selectTab.NameTextBox.Text,
                Surname = selectTab.SurnameTextBox.Text,
                PhoneNumber = selectTab.TelephonTextBox.Text
            };
            car = new Car
            {
                Marka = selectTab.CarComboBox.Text,
                Model = selectTab.ScheduleModelTextBox0.Text,
            };
            orderRepair = new OrderRepair
            {
                Problem = selectTab.ProblemCar.Text,
                ScheduleCar = selectTab.ScheduleTimePicker.Text
            };
        }
        public void SetDataEdit(Client clientToEdit, Car carToEdit, OrderRepair orderRepairToEdit)
        {//сетування даних при переході між класами
            client = clientToEdit;
            car = carToEdit;
            orderRepair = orderRepairToEdit;

        }
        public void AutocompleteData(UC_ScheduleCarSelectTab selectTab)
        {
            selectTab.ID_label.Text = client.ID.ToString();

            selectTab.NameTextBox.Text = client.Name;
            selectTab.SurnameTextBox.Text = client.Surname;
            selectTab.TelephonTextBox.Text = client.PhoneNumber;

            selectTab.CarComboBox.SelectedItem = car.Marka;
            selectTab.ScheduleModelTextBox0.Text = car.Model;

            selectTab.ProblemCar.Text = orderRepair.Problem;

            selectTab.ScheduleTimePicker.Text = orderRepair.ScheduleCar;
        }
        public static void ClearTextBox(UC_ScheduleCarSelectTab editData)
        {
            editData.NameTextBox.Text = editData.SurnameTextBox.Text = editData.TelephonTextBox.Text = string.Empty;

            editData.CarComboBox.SelectedItem = editData.ScheduleModelTextBox0.Text = editData.ProblemCar.Text = string.Empty;

            editData.ScheduleTimePicker.Text = DateTime.Today.ToString("D");

            editData.ID_label.Text = "0";
        }
    }
}