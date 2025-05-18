using Warsztat_2._0.UserControls.BarMenu.Warehouse;
using Warsztat_2._0.UserControls;
using Warsztat_2._0;
using Warsztat_2.UserControls.BarMenu.Archive;
using Warsztat_2.UserControls.BarMenu.Company;
using Warsztat_2.UserControls.BarMenu.ScheduleCar;
using Warsztat_2.UserControls.BarMenu.UC_CreateData;

namespace Warsztat_2
{
    public partial class Form2 : Form
    {
        private uint clientCount, carCount, scheduleCount;
        private decimal sumEarnings, earningOnParts, dependecisOfEmployer, costOfDependecis, earningService;
        private UC_ViewDataCar viewDataCar;
        private UC_AddAllData addAllData;
        public Form2()
        {
            InitializeComponent();

            viewDataCar = new UC_ViewDataCar();
            addAllData = new UC_AddAllData();
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(viewDataCar);
            viewDataCar.CarSelected += ViewDataCar_CarSelected;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            //LoadUserControl(new UC_AddData());
            LoadUserControl(new UC_AddAllData());
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
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(viewDataCar);
            }

        private void ArchiveButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Archive());
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            await SqlCmd.CheckScheduleCar();

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
            var (clientCount, carCount, scheduleCount) = await SqlCmd.CountTablesDataAsync();

            costOfDependecis = await SqlCmd.GetTotalDependecisForCurrentMonthAsync();
            dependecisOfEmployer = await SqlCmd.GetTotalDependecisOfEmployerForCurrentMonthAsync();

            decimal sum = await SqlCmd.GetTotalEarningsForCurrentMonthAsync();

            if (companyData.ContainsKey("NazwaFirmy"))
            {
                companyNameLabel.Text = companyData["NazwaFirmy"].ToString();
            }
            label9.Text += carCount.ToString();
            label5.Text += scheduleCount.ToString();
            label8.Text += clientCount.ToString();
            label4.Text += sum + "zł";
            label3.Text += (costOfDependecis + dependecisOfEmployer).ToString() + "zł";
            label2.Text += (sum- costOfDependecis - dependecisOfEmployer) + "zł";
        }
        private async Task DateHistory()
        {
            var historyData = await SqlCmd.LoadDataAsync("WarsztatDB", "HistoriaWarsztatu");
            // Перевірка на null і наявність ключа "Data"
            if (historyData == null || !historyData.ContainsKey("Data") || historyData["Data"]?.ToString() != DateTime.Now.ToString("MM.yyyy"))
            {
                DateHistoryInsert();
            }
            else if (historyData.ContainsKey("Data") && historyData["Data"]?.ToString() == DateTime.Now.ToString("MM.yyyy"))
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

        private void CompanyBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Company());
        }
        private void ViewDataCar_CarSelected(object sender, Guid carGuid)
            {
            addAllData.SetCarGuid(carGuid); 
            LoadUserControl(addAllData);
            }
        }
}
