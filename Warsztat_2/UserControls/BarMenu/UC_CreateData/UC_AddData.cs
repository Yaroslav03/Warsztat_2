using Warsztat_2._0.UserControls.UC_CreateData;
using Warsztat_2.UserControls.BarMenu.UC_CreateData;

namespace Warsztat_2._0.UserControls {
    public partial class UC_AddData :UserControl {
        readonly UC_AddCar addCar = new();
        readonly UC_AddClient addClient = new();
        readonly UC_AddRepair addRepair = new();
        readonly UC_AddHistoryCar addHistoryCar = new();

        public UC_AddData()
            {
            InitializeComponent();
            }


        private void CarButton_Click(object sender, EventArgs e)
            {
            Settings.ChangeWindow(addCar, splitContainer1.Panel2);
            }

        private void UC_AddClient_Load(object sender, EventArgs e)
            {
            Settings.ChangeWindow(addClient, splitContainer1.Panel2);
            }

        private void RepairButton_Click(object sender, EventArgs e)
            {
            Settings.ChangeWindow(addRepair, splitContainer1.Panel2);
            }

        private void CustommerButton_Click(object sender, EventArgs e)
            {
            Settings.ChangeWindow(addClient, splitContainer1.Panel2);
            }

        private void HistoryButton_Click(object sender, EventArgs e)
            {
            Settings.ChangeWindow(addHistoryCar, splitContainer1.Panel2);
            }
        }
    }