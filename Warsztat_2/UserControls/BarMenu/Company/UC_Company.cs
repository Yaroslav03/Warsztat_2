using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warsztat_2.UserControls.BarMenu.Company
{
    public partial class UC_Company : UserControl
    {
        private byte id;
        public UC_Company()
        {
            InitializeComponent();
        }

        #region Event
        private async void SaveCompanyExpensesMonthBtn_Click(object sender, EventArgs e)
        {
            var data = new Dictionary<string, object>
                {
                    {"NazwaWydatku", NameExpencess.Text.Trim()},
                    {"CenaWydatku", PriceExpencessNumericUpDown.Value},
                    {"DataPotrącenia", dateTimePicker3.Text}
                };
            await SqlCmd.AddRecordAsync("WarsztatDB", "WydatkiFirmy", data);
            await LoadDataActualMonth();
            PriceExpencessNumericUpDown.Value = 0;
            NameExpencess.Text = string.Empty;
        }
        private async void BtnSaveDateOfDeduction_Click(object sender, EventArgs e)
        {
            var data = new Dictionary<string, object>
                {
                    {"NazwaWydatku", ExpenseNameTextBox.Text.Trim()},
                    {"CenaWydatku", PriceNumericUpDown.Value},
                    {"DataPotrącenia", DateOfDeductionCalendar.Text}
                };
            await SqlCmd.AddRecordAsync("WarsztatDB", "StałeWydatkiFirmy", data);
            await SqlCmd.LoadData("SELECT ID, NazwaWydatku, CenaWydatku, DataPotrącenia FROM StałeWydatkiFirmy", ViewDataOfDeduction, "StałeWydatkiFirmy", "Load table WydatkiFirmy From DB");
            PriceNumericUpDown.Value = 0;
            ExpenseNameTextBox.Text = string.Empty;
        }
        private async void ViewDataOfDeduction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            await SqlCmd.DeleteDataTable(ViewDataOfDeduction, e, "BtnDelete", "ID_Column", "StałeWydatkiFirmy");
        }
        private async void ViewCompanyExpensesMonth_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            await SqlCmd.DeleteDataTable(ViewCompanyExpensesMonth, e, "BtnDelete_", "ID_Column_", "WydatkiFirmy");
        }
        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                await SqlCmd.LoadData(@"SELECT ID, NazwaWydatku, CenaWydatku, DataPotrącenia FROM WydatkiFirmy", ViewCompanyExpensesMonth, "WydatkiFirmy", "Load table WydatkiFirmy From DB");
            }
            else
            {
                await LoadDataActualMonth();
            }
        }
        private async void UC_Company_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async void SaveCompanyDataButton_Click(object sender, EventArgs e)
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
            if (SaveCompanyDataButton.Text == "Zapisz")
            {
                await SqlCmd.AddRecordAsync("WarsztatDB", "DaneFirmy", data);
            }
            else if (SaveCompanyDataButton.Text == "Odśwież")
            {
                await SqlCmd.UpdateRecordAsync("DaneFirmy", data, "ID = @ID", whereParams);
            }
            SaveCompanyDataButton.Text = "Odśwież";
        }
        private async void ViewEmployers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string? id = ViewEmployers.Rows[e.RowIndex].Cells["ID_Column_Employer"].Value.ToString();
            int selectedIndex = (int)ViewEmployers.CurrentRow.Index;

            if (ViewEmployers.Rows[e.RowIndex].Cells["ID_Column_Employer"].Value != DBNull.Value && id != null)
            {
                if (e.ColumnIndex == ViewEmployers.Columns["BtnDeleteEmployer"].Index)
                {
                    var idEmployer = new Dictionary<string, object>
                        {
                        {"ID", id}
                        };
                    bool isSucceed = await SqlCmd.DeleteRecordAsync("WarsztatDB", "Pracownicy", "ID=@ID", idEmployer);
                    if (isSucceed)
                    {
                        ViewEmployers.Rows.RemoveAt(selectedIndex);
                    }
                }
                else if (e.ColumnIndex == ViewEmployers.Columns["ArchiveBtn"].Index)
                {
                    await SqlCmd.SendToArchiveOneTable(id);
                }
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
        #region Method
        private async Task LoadDataActualMonth()
        {
            await SqlCmd.LoadData(@"SELECT ID, NazwaWydatku, CenaWydatku, DataPotrącenia FROM WydatkiFirmy 
      WHERE date(
              substr(DataPotrącenia, 7, 4) || '-' ||
              substr(DataPotrącenia, 4, 2) || '-' ||
              substr(DataPotrącenia, 1, 2)
            ) >= date('now', 'start of month')
        AND date(
              substr(DataPotrącenia, 7, 4) || '-' ||
              substr(DataPotrącenia, 4, 2) || '-' ||
              substr(DataPotrącenia, 1, 2)
            ) < date('now', 'start of month', '+1 month')",
    ViewCompanyExpensesMonth, "WydatkiFirmy", "Load table WydatkiFirmy From DB");
        }
        private async Task LoadData()
        {
            await SqlCmd.LoadData("SELECT ID, NazwaWydatku, CenaWydatku, DataPotrącenia FROM StałeWydatkiFirmy", ViewDataOfDeduction, "StałeWydatkiFirmy", "Load table WydatkiFirmy From DB");
            await LoadDataActualMonth();
            await SqlCmd.LoadData("SELECT ID, Imię, Nazwisko, Telefon, Stanowisko, Zarobek, DataZatrudnienia FROM Pracownicy", ViewEmployers, "ViewData", "error", null, "Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;");
            var data = await SqlCmd.LoadDataAsync("WarsztatDB", "DaneFirmy", SaveCompanyDataButton);

            if (data.Count > 0)
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
        #endregion
    }
}
