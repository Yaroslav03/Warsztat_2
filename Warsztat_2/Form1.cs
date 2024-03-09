using Warsztat_2._0;
using Warsztat_2._0.UserControls;
using Warsztat_2._0.UserControls.BarMenu.Warehouse;
using Warsztat_2.UserControls.BarMenu.ScheduleCar;
namespace Warsztat_2


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            UC_AddData addData = new();

            Settings.ChangeWindow(addData, splitContainer1.Panel2);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            UC_Settings UC_settings = new();
            Settings.ChangeWindow(UC_settings, splitContainer1.Panel2);
        }

        private void WarehouseButton_Click(object sender, EventArgs e)
        {
            UC_Warehouse warehouse = new();
            Settings.ChangeWindow(warehouse, splitContainer1.Panel2);
        }

        private void ScheduleCarButton_Click(object sender, EventArgs e)
        {
            UC_ScheduleCar scheduleCar = new();
            Settings.ChangeWindow(scheduleCar, splitContainer1.Panel2);
        }

        private void ViewAllCar_Click(object sender, EventArgs e)
        {
            UC_ViewDataCar viewDataCar = new();
            Settings.ChangeWindow(viewDataCar, splitContainer1.Panel2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Потік 1 для виконання Settings.CheckScheduleCar()
            Task task1 = Task.Run(() =>
            {
                Settings.CheckScheduleCar();
            });

            // Очікуємо завершення обох завдань
            Task.WaitAll(task1);
            UC_ViewDataCar viewDataCar = new();
            Settings.ChangeWindow(viewDataCar, splitContainer1.Panel2);
            // Операції завершені
        }
    }
}
