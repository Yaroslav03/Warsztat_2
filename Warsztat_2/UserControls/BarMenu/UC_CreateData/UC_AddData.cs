using Warsztat_2._0.UserControls.UC_CreateData;
using Warsztat_2.UserControls.BarMenu.UC_CreateData;

namespace Warsztat_2._0.UserControls
{
    public partial class UC_AddData : UserControl
    {
        readonly UC_AddCar addCar = new();
        readonly UC_AddClient addClient = new();
        readonly UC_AddRepair addRepair = new();
        readonly UC_AddOrderManagement addOrderManagement = new();
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

        private void OrderManagementButton_Click(object sender, EventArgs e)
        {
            // Використовуємо існуючий екземпляр UC_AddRepair

            if (addRepair != null)
            {
                addRepair.VINChanged += AddRepairVinChanged;
                addRepair.Price += TransferData;
            }
            Settings.ChangeWindow(addOrderManagement, splitContainer1.Panel2);
        }

        private void AddRepair_Price(object? sender, ushort e)
        {
            throw new NotImplementedException();
        }

        private void CustommerButton_Click(object sender, EventArgs e)
        {
            Settings.ChangeWindow(addClient, splitContainer1.Panel2);
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            Settings.ChangeWindow(addHistoryCar, splitContainer1.Panel2);
        }


        public void AddRepairVinChanged(object sender, string VIN)
        {

            addOrderManagement.UpdateVIN(VIN);

        }
        public void TransferData(object sender, ushort pricePart)
        {
            addOrderManagement.AddPricePart(pricePart);
        }
        public void ChangeWindowToOrderManagement()
        {
            //addRepair.VINChanged += UpdateOrderManagementVIN;
        }
    }
}