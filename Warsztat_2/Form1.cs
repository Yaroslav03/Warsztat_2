using Warsztat_2._0;
using Warsztat_2._0.UserControls;
using Warsztat_2._0.UserControls.BarMenu.Warehouse;
using Warsztat_2.UserControls.BarMenu.Archive;
using Warsztat_2.UserControls.BarMenu.ScheduleCar;
namespace Warsztat_2 {
    public partial class Form1 :Form {
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

            }

        private void LoadUserControl(UserControl control)
            {
            Settings.ChangeWindow(control, splitContainer1.Panel2);
            }
        }
    }