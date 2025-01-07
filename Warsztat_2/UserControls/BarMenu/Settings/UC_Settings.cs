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
            await LoadData();
            }
        private async Task LoadData()
            {
            await LoadDataWarsztat();
            await SqlCmd.LoadData("SELECT ID, Imię, Nazwisko, Telefon, Stanowisko, Zarobek, DataZatrudnienia FROM Pracownicy", ViewEmployers, "ViewData", "error", null, "Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;");
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
        private async void EmployerAddButton_Click(object sender, EventArgs e)
            {
            var data = new Dictionary<string, object>
                {
                    {"Imię", ImiePracownikaTextBox.Text.Trim()},
                    {"Nazwisko", SurnameTextBox.Text.Trim()},
                    {"Telefon", NumerTelefonuTextBox.Text.Trim()},
                    {"Stanowisko", StanowiskoSelect.Text},
                    {"Zarobek", EarningPriceNumericUpDown.Value},
                    {"DataZatrudnienia", DateOfEmploymentTimePicker.Text}

                };
            await SqlCmd.AddRecordAsync("WarsztatDB", "Pracownicy", data);
            await SqlCmd.LoadData("SELECT ID, Imię, Nazwisko, Telefon, Stanowisko, Zarobek, DataZatrudnienia FROM Pracownicy", ViewEmployers, "ViewData", "error", null, "Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;");
            }
        #endregion

        private async void ViewEmployers_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            string? id = ViewEmployers.Rows[e.RowIndex].Cells["ID_Column"].Value.ToString();
            int selectedIndex = (int)ViewEmployers.CurrentRow.Index;

            if(ViewEmployers.Rows[e.RowIndex].Cells["ID_Column"].Value != DBNull.Value && id != null)
                {
                if(e.ColumnIndex == ViewEmployers.Columns["BtnDelete"].Index)
                    {
                    var idEmployer = new Dictionary<string, object>
                        {
                        {"ID", id}
                        };
                    bool isSucceed = await SqlCmd.DeleteRecordAsync("WarsztatDB", "Pracownicy", "ID=@ID", idEmployer);
                    if(isSucceed)
                        {
                        ViewEmployers.Rows.RemoveAt(selectedIndex);
                        }
                    }
                else if(e.ColumnIndex == ViewEmployers.Columns["ArchiveBtn"].Index)
                    {
                    await SqlCmd.SendToArchiveOneTable(id);
                    }
                }

            }
        }
    }