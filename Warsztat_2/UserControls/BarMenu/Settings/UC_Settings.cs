using System.Data.SQLite;

namespace Warsztat_2._0.UserControls {
    public partial class UC_Settings :UserControl {
        // Змінна для збереження рядка підключення до бази даних
        readonly List<string> Employer = new();
        private readonly string[] nameColumns = { "Imie", "Stanowisko", "Telefon" };
        private byte id;
        public UC_Settings()
            {
            InitializeComponent();
            }
        #region Event
        private async void SaveDataButton_Click(object sender, EventArgs e)
            {
            var data = new Dictionary<string, object>
                {
                    {"NazwaFirmy",   NazwaFirmyTextBox.Text.Trim()},
                    {"AdresFirmy", AdresFirmyTextBox.Text.Trim()},
                    {"NIP", NIPTextBox.Text.Trim() },
                    {"NrTelefonu", NrTelefonuTextBox.Text.Trim()},
                    {"BDO",  NumerBDOTextBox.Text.Trim()},
                    {"KontoBankowe", KontoBankoweTextBox.Text.Trim()},
                    {"Marża",MarzaTextBox.Text.Trim()},
                };
            var whereParams = new Dictionary<string, object>
                 {
                     {"ID", id} // Тут можна використовувати фактичний ID, який вам потрібен
                };
            if(SaveDataButton.Text == "Zapisz")
                {
                await SqlCmd.AddRecordAsync("WarsztatDB", "DaneFirmy", data);
                }
            else if(SaveDataButton.Text == "Odśwież")
                {
                await SqlCmd.UpdateRecordAsync("DaneFirmy", data, "ID = @ID", whereParams);
                }
            SaveDataButton.Text = "Odśwież";
            }

        private async void UC_Settings_Load(object sender, EventArgs e)
            {
            EmployerAddButton.Enabled = false;
            await LoadData();
            }
        private async Task LoadData()
            {
            await LoadDataWarsztat();
            await SqlCmd.ReadAddDataListBox("SELECT Imie, Stanowisko, Telefon FROM Pracownicy", nameColumns, ListBoxEmployer);
            await SqlCmd.LoadData("SELECT ID, NazwaWydatku, CenaWydatku, DataPotrącenia FROM WydatkiFirmy", ViewDataOfDeduction, "WydatkiFirmy", "Load table WydatkiFirmy From DB");
            }
        private async Task LoadDataWarsztat()
            {
            var data = await SqlCmd.LoadDataAsync("WarsztatDB", "DaneFirmy", SaveDataButton);

            if(data.Count > 0)
                {
                id = Convert.ToByte(data["ID"].ToString());
                NazwaFirmyTextBox.Text = data["NazwaFirmy"].ToString();
                AdresFirmyTextBox.Text = data["AdresFirmy"].ToString();
                NIPTextBox.Text = data["NIP"].ToString();
                NrTelefonuTextBox.Text = data["NrTelefonu"].ToString();
                NumerBDOTextBox.Text = data["BDO"].ToString();
                KontoBankoweTextBox.Text = data["KontoBankowe"].ToString();
                MarzaTextBox.Text = data["Marża"].ToString();
                }
            }
        // Метод для перевірки текстового поля чи він пустий, запобігаючи записанню пустих даних

        private void NumerTelefonuTextBox_TextChanged(object sender, EventArgs e)
            {
            EmployerAddButton.Enabled = !string.IsNullOrEmpty(NumerTelefonuTextBox.Text);
            }
        private async void EmployerAddButton_Click(object sender, EventArgs e)
            {
            var data = new Dictionary<string, object>
                {
                    {"Imie", ImiePracownikaTextBox.Text.Trim()},
                    {"Stanowisko", StanowiskoSelect.Text},
                    {"Telefon", NumerTelefonuTextBox.Text.Trim()}
                };
            await SqlCmd.AddRecordAsync("WarsztatDB", "Pracownicy", data);
            await SqlCmd.ReadAddDataListBox("SELECT Imie, Stanowisko, Telefon FROM Pracownicy", nameColumns, ListBoxEmployer);
            }

        private async void RemoveEmployerButton_Click(object sender, EventArgs e)
            {
            string? selectEmployer = (ListBoxEmployer.SelectedItem ?? "").ToString();
            // Переконатися, що є вибраний елемент у ListBoxEmployer
            if(ListBoxEmployer.SelectedIndex >= 0 && selectEmployer != null)
                {
                //string? selectEmployer = ListBoxEmployer.SelectedItem.ToString();

                // Розділити рядок за допомогою коми
                string[] rowData = selectEmployer.Split(' ');

                // Переконатися, що масив містить принаймні 3 елементи (Ім'я, Становище, Номер телефону)
                if(rowData.Length == 3)
                    {
                    // Отримати номер телефону (третій елемент масиву після розділу)
                    string phoneNumber = rowData[2].Trim();

                    using SQLiteConnection conn = new("Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;");
                    conn.Open();

                    using SQLiteCommand deletecmd = new("DELETE FROM Pracownicy WHERE Telefon = @Telefon", conn);
                    deletecmd.Parameters.AddWithValue("@Telefon", phoneNumber);
                    deletecmd.ExecuteNonQuery();

                    phoneNumber = selectEmployer = string.Empty;
                    }
                else
                    {
                    MessageBox.Show("Обраний рядок не містить необхідних даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            else
                {
                MessageBox.Show("Brak danych, Proszę dodać pracowników zanim usuwać :D", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            await SqlCmd.ReadAddDataListBox("SELECT Imie, Stanowisko, Telefon FROM Pracownicy", nameColumns, ListBoxEmployer);
            }

        private async void UpdateEmployerButton_Click(object sender, EventArgs e)
            {
            await SqlCmd.ReadAddDataListBox("SELECT Imie, Stanowisko, Telefon FROM Pracownicy", nameColumns, ListBoxEmployer);
            }
        #endregion

        private void label3_Click(object sender, EventArgs e)
            {

            }

        private async void BtnSaveDateOfDeduction_Click(object sender, EventArgs e)
            {
            var data = new Dictionary<string, object>
                {
                    {"NazwaWydatku", ExpenseNameTextBox.Text.Trim()},
                    {"CenaWydatku", PriceNumericUpDown.Value},
                    {"DataPotrącenia", DateOfDeductionCalendar.Text}
                };
            await SqlCmd.AddRecordAsync("WarsztatDB", "WydatkiFirmy", data);
            await SqlCmd.LoadData("SELECT ID, NazwaWydatku, CenaWydatku, DataPotrącenia FROM WydatkiFirmy", ViewDataOfDeduction, "WydatkiFirmy", "Load table WydatkiFirmy From DB");
            PriceNumericUpDown.Value = 0;
            ExpenseNameTextBox.Text = string.Empty;
            }

        private async void ViewDataOfDeduction_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            await SqlCmd.DeleteDataTable(ViewDataOfDeduction, e, "BtnDelete", "ID_Column", "WydatkiFirmy");
            }
        }
    }