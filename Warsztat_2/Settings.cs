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
                if (control is TextBox box)
                    box.Clear();
                else if (control is MaskedTextBox box1)
                    box1.Clear();
            }
        }
        public static void SearchTextBox(TextBox textBox, DataGridView table)
        {
            string[] searchTerms = textBox.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (searchTerms.Length == 0)
            {
                // Якщо поле пошуку порожнє, знімаємо вибір з усіх осередків
                foreach (DataGridViewRow row in table.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Selected = false;
                    }
                }
                return;
            }

            // Виділення відповідних осередків у таблиці
            foreach (DataGridViewRow row in table.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Перевіряємо, чи значення осередку відповідає хоча б одному терміну
                    if (cell.Value != null && searchTerms.Any(term => cell.Value.ToString().Contains(term, StringComparison.OrdinalIgnoreCase)))
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
    }
}