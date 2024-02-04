using System.Data.SQLite;

namespace Warsztat_2._0.UserControls.BarMenu.ScheduleCar
{
    public partial class UC_ScheduleCar : UserControl
    {
        private readonly string path = "Data Source=WarsztatData.db;Version=3;New=False;Compress=True;";
        private Car car = new();
        private Repair repair = new();
        public Client client = new();
        public UC_ScheduleCar()
        {
            InitializeComponent();
        }

        private void ScheduleCarButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ////////////////////////////////////
            PrepareData();
            /////////////////////////////////////
            try
            {
                using SQLiteConnection conn = new(path);
                conn.Open();

                using SQLiteCommand cmd = new("INSERT INTO ZaplanowaneSamochody (Imię, Nazwisko, Marka, Model, Problem, Telefon, DataPrzyjęcia) " +
                    "VALUES (@Imię, @Nazwisko, @Marka, @Model, @Problem, @Telefon, @DataPrzyjęcia)", conn);

                cmd.Parameters.AddWithValue("@Imię", client.Name);
                cmd.Parameters.AddWithValue("@Nazwisko", client.Surname);
                cmd.Parameters.AddWithValue("@Telefon", client.PhoneNumber);

                cmd.Parameters.AddWithValue("@Marka", car.Marka);
                cmd.Parameters.AddWithValue("@Model", car.Model);
                cmd.Parameters.AddWithValue("@Problem", repair.Problem);
                cmd.Parameters.AddWithValue("@DataPrzyjęcia", repair.ScheduleCar);

                cmd.ExecuteNonQuery();

                MessageBox.Show($"Samochód został zaplanowany, kliknij OK żeby dodać kolejny", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // client.Reset();
                Car.Reset();
                Repair.Reset();
                Cursor.Current = Cursors.Default;
            }
        }
        private void PrepareData()
        {
            client = new Client
            {
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                PhoneNumber = TelephonTextBox.Text
            };
            car = new Car
            {
                Marka = CarComboBox1.Text,
                Model = ModelTextBox.Text,
            };
            repair = new Repair
            {
                Problem = ProblemCar.Text,
                ScheduleCar = ScheduleTime.Text
            };
        }

        private void UC_ScheduleCar_Load(object sender, EventArgs e)
        {

        }

        private void CarButton_Click(object sender, EventArgs e)
        {
        }
        public void SetDataEdit(Client clientToEdit, Car carToEdit, Repair repairToEdit)
        {//сетування даних при переході між класами
            client = clientToEdit;
            car = carToEdit;
            repair = repairToEdit;

            AutocompleteData();
        }
        private void AutocompleteData()
        {
            NameTextBox.Text = client.Name;
            SurnameTextBox.Text = client.Surname;
            TelephonTextBox.Text = client.PhoneNumber;

            CarComboBox1.SelectedItem = car.Marka;
            ModelTextBox.Text = car.Model;

            ProblemCar.Text = repair.Problem;

            //ScheduleTime.Text = orderRepair.ScheduleCar;
        }
    }
}