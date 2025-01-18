using Warsztat_2._0;
using Warsztat_2._0.UserControls;
using Warsztat_2._0.UserControls.BarMenu.Warehouse;
using Warsztat_2.Models;
using Warsztat_2.UserControls.BarMenu.Archive;
using Warsztat_2.UserControls.BarMenu.ScheduleCar;
using Warsztat_2.UserControls.BarMenu.Settings;
namespace Warsztat_2 {
    public partial class Form1 :Form {
        private uint clientCount, carCount, scheduleCount;
        private decimal sumEarnings, earningOnParts, dependecisOfEmployer, costOfDependecis;
        public Form1()
            {
            InitializeComponent();
            }
        private void AddButton_Click(object sender, EventArgs e)
            {
            LoadUserControl(new UC_AddData());
            }

        private void SettingsButton_Click(object sender, EventArgs e)
            {
            LoadUserControl(new UC_Settings());
            }

        private void WarehouseButton_Click(object sender, EventArgs e)
            {
            LoadUserControl(new UC_Warehouse());
            }

        private void ScheduleCarButton_Click(object sender, EventArgs e)
            {
            LoadUserControl(new UC_ScheduleCar());
            }

        private void ViewAllCar_Click(object sender, EventArgs e)
            {
            LoadUserControl(new UC_ViewDataCar());
            }

        private void ArchiveButton_Click(object sender, EventArgs e)
            {
            LoadUserControl(new UC_Archive());
            }

        private async void Form1_Load(object sender, EventArgs e)
            {
            await SqlCmd.CheckScheduleCar();

            LoadUserControl(new UC_ViewDataCar());

            await LoadDataInterface();

            await DateHistory();
            }

        private void LoadUserControl(UserControl control)
            {
            Settings.ChangeWindow(control, splitContainer1.Panel2);
            }
        private async Task LoadDataInterface()
            {
            var companyData = await SqlCmd.LoadDataAsync("WarsztatDB", "DaneFirmy");
            clientCount = await SqlCmd.CountDataAsync("Klienty");
            carCount = await SqlCmd.CountDataAsync("Samochód");
            scheduleCount = await SqlCmd.CountDataAsync("ZaplanowaneSamochody");
            costOfDependecis = await SqlCmd.GetTotalDependecisForCurrentMonthAsync();
            dependecisOfEmployer = await SqlCmd.GetTotalDependecisOfEmployerForCurrentMonthAsync();
            sumEarnings = await SqlCmd.GetTotalEarningsForCurrentMonthAsync();
            earningOnParts = await SqlCmd.GetTotalEarningsOnPartsForCurrentMonthAsync();

            if(companyData.ContainsKey("NazwaFirmy"))
                {
                companyNameLabel.Text = companyData["NazwaFirmy"].ToString();
                }
            label4.Text += carCount.ToString();
            label5.Text += scheduleCount.ToString();
            label1.Text += clientCount.ToString();
            label7.Text += sumEarnings + earningOnParts + "zł";
            label8.Text += (costOfDependecis + dependecisOfEmployer).ToString() + "zł";
            label9.Text += (sumEarnings + earningOnParts - costOfDependecis - dependecisOfEmployer) + "zł";
            }
        private async Task DateHistory()
            {
            var historyData = await SqlCmd.LoadDataAsync("WarsztatDB", "HistoriaWarsztatu");
            // Перевірка на null і наявність ключа "Data"
            if(historyData == null || !historyData.ContainsKey("Data") || historyData["Data"]?.ToString() != DateTime.Now.ToString("MM.yyyy"))
                {
                 DateHistoryInsert();
                }
            else if(historyData.ContainsKey("Data") && historyData["Data"]?.ToString() == DateTime.Now.ToString("MM.yyyy"))
                {
                 DateHistoryUpdate(historyData["Id"].ToString());
                }
            }
        private Dictionary<string, object> GetDataHistory()
            {
            return new Dictionary<string, object>
                {
                    {"Dochód", sumEarnings + earningOnParts},
                    {"Wydatki", costOfDependecis + dependecisOfEmployer},
                    {"Ilość_Samochodów", carCount},
                    {"Ilość_Klientów", clientCount},
                    {"Ilość_Zaplanowanych_Klientów", scheduleCount},
                    {"Data", DateTime.Now.ToString("MM.yyyy")}
                };
            }
        private async void DateHistoryInsert()
            {
            var historyWarsztat = GetDataHistory();

            await SqlCmd.AddRecordAsync("WarsztatDB", "HistoriaWarsztatu", historyWarsztat);
            }

        private async void DateHistoryUpdate(string IdValue)
            {
            var historyWarsztat = GetDataHistory();
            var id = new Dictionary<string, object>
                {
                    {"Id", IdValue}
                };
            await SqlCmd.UpdateRecordAsync("HistoriaWarsztatu", historyWarsztat, "Id=@Id", id);
            }

        private void CompanyExpensesBtn_Click(object sender, EventArgs e)
            {
            LoadUserControl(new UC_CompanyExpenses());
            }
        }
    }
