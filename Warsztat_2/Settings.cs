using System.Data;
using System.Data.SQLite;

namespace Warsztat_2._0
{
    internal class Settings
    {
        public static void ChangeWindow(UserControl userControl, Panel panel)
        {
            // Відключаємо перередження для оптимізації відображення
            panel.SuspendLayout();

            // Очищаємо вміст панелі
            panel.Controls.Clear();

            // Встановлюємо DockStyle перед додаванням до панелі
            userControl.Dock = DockStyle.Fill;

            // Додаємо контрол до панелі
            panel.Controls.Add(userControl);

            // Переносимо контрол вгору
            userControl.BringToFront();

            // Увімкнемо перередження після додавання контрола
            panel.ResumeLayout();
        }
        public static void CheckScheduleCar()
        {
            string path = "Data Source=WarsztatData.db;Version=3;New=False;Compress=True;";

            Cursor.Current = Cursors.WaitCursor;
            string today = DateTime.Today.ToString("dddd, dd MMMM yyyy");

            MessageBox.Show(today);
            try
            {
                using SQLiteConnection conn = new(path);

                conn.Open();

                using SQLiteCommand cmd = new("SELECT Imię, Nazwisko, Telefon, Marka, Model, Problem, DataPrzyjęcia FROM ZaplanowaneSamochody WHERE DataPrzyjęcia = @DataPrzyjęcia", conn);

                cmd.Parameters.AddWithValue("@DataPrzyjęcia", today);

                using SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)//перевірка чи є стовпці в базі даних, якщо немає то код не буде засмічувати пам'ять коли не потрібно
                {
                    while (reader.Read())
                    {
                        Client client = new()
                        {
                            Name = reader["Imię"].ToString(),
                            Surname = reader["Nazwisko"].ToString(),
                            PhoneNumber = reader["Telefon"].ToString()
                        };

                        Car car = new()
                        {
                            Marka = reader["Marka"].ToString(),
                            Model = reader["Model"].ToString(),
                        };

                        Repair order = new()
                        {
                            Problem = reader["Problem"].ToString(),
                            ScheduleCar = reader["DataPrzyjęcia"].ToString()
                        };

                        MessageBox.Show($"Uwaga na dzisiaj {order.ScheduleCar} zaplanowano {car.Marka} {car.Model} klienta {client.Name} ({client.PhoneNumber}). Klient ma następujący problem: {order.Problem}",
                            "Zaplanowana praca na dzisiaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Car.Reset();
                Client.Reset();
                Repair.Reset();
                Cursor.Current = Cursors.Default;
                //GC.Collect();
            }
        }
        public static async Task Error(Exception ex, Queue<string> dataValue, string title_log, string category_log)
        {
            MessageBox.Show("Coś poszło nie tak: " + ex);
            if (!File.Exists("Error"))
            {
                Directory.CreateDirectory("Error");
            }
            string Time = DateTime.Now.ToString("dd.MM.yyyy.H.mm");
            await using StreamWriter sw = File.AppendText($"Error/{title_log}_log_{Time}.txt");

            sw.WriteLine($"=================================================={category_log.ToUpper()}==================================================");
            sw.WriteLine($"Timestamp: {Time}");
            sw.WriteLine("----------------------------------------------------------------------------------------------------");
            if (dataValue != null && dataValue.Count > 0)
            {
                sw.WriteLine("Data:");
                while (dataValue.Count > 0)
                {
                    sw.WriteLine(dataValue.Dequeue());
                }

                sw.WriteLine("----------------------------------------------------------------------------------------------------");
            }
            sw.WriteLine($"Error Message: {ex.Message}");
            sw.WriteLine("----------------------------------------------------------------------------------------------------");
            sw.WriteLine($"StackTrace:\n{ex.StackTrace}");
            sw.WriteLine("====================================================================================================");
        }
        public static void ClearTextBox(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear();
                else if (control is MaskedTextBox)
                    ((MaskedTextBox)control).Clear();
            }
        }
        public static async Task LoadData(string path, string cmd, DataGridView view, string categoryError, string textError)
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

        public static async Task<bool> TableExistHistory(string path, string tableName)
        {
            using SQLiteConnection conn = new(path);
            await conn.OpenAsync();
            using SQLiteCommand search = new($"SELECT name FROM sqlite_master WHERE type='table' AND name='_{tableName}'", conn);

            string? result = (string?)await search.ExecuteScalarAsync();
            return result != null && result.ToString() == "_" + tableName;
        }
        public static async Task<bool> TableExist(string path, string tableName)
        {
            using SQLiteConnection conn = new(path);
            await conn.OpenAsync();
            using SQLiteCommand search = new($"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}'", conn);

            string? result = (string?)await search.ExecuteScalarAsync();
            return result != null && result.ToString() == tableName;
        }

    }
}