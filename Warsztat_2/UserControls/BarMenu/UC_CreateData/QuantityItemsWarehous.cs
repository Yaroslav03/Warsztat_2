using System.Globalization;

namespace Warsztat_2.UserControls.BarMenu.UC_CreateData
{
    public partial class QuantityItemsWarehous : Form
    {
        private Dictionary<string, object> Transfer { get; set; } = new();
        Guid uniqueKey;

        public QuantityItemsWarehous()
        {
            InitializeComponent();
        }

        #region Event

        // FIX: async void + await, żeby MessageBox i Close() czekały na zapis do DB
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            byte quantity = (byte)QuantityNumericUpDown.Value;
            Transfer.Add("Stan", 1);

            if (quantity == Convert.ToByte(Transfer["Ilość"]))
            {
                await TransferAllDataAsync();
            }
            else if (quantity < Convert.ToByte(Transfer["Ilość"]))
            {
                await TransferDataWithMinesAsync(quantity);
            }

            MessageBox.Show("Udało się");
            this.Close();
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            QuantityNumericUpDown.Maximum = Convert.ToByte(Transfer["Ilość"]);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        public void TransferDictionaryData(Dictionary<string, object> data)
        {
            Transfer = data;
        }

        private Dictionary<string, object> GetValueID()
        {
            return new Dictionary<string, object>
                {
                    {"ID", Transfer["ID"]}
                };
        }

        // FIX: zmieniono z async void na async Task
        private async Task TransferAllDataAsync()
        {
            var repairCarID = GetValueID();

            await SqlCmd.AddRecordAsync("WarsztatDB", "NaprawaSamochodu", Transfer);
            await SqlCmd.DeleteRecordAsync("WarsztatDB", "Magazyn", "ID=@ID", repairCarID);
        }

        // FIX: zmieniono z async void na async Task
        private async Task TransferDataWithMinesAsync(byte valueQuantity)
        {
            byte oldQuantity = Convert.ToByte(Transfer["Ilość"]);
            decimal price = Convert.ToDecimal(Transfer["Cena"], CultureInfo.InvariantCulture);
            decimal profitPerItem = Convert.ToDecimal(Transfer["ZarobekCzęści"], CultureInfo.InvariantCulture);

            byte newQuantity = (byte)(oldQuantity - valueQuantity);

            var updatedStock = new Dictionary<string, object>
            {
                ["Ilość"] = newQuantity,
                ["Suma"] = (price + profitPerItem) * newQuantity,
                ["SumaZarobku"] = profitPerItem * newQuantity
            };

            Transfer["Ilość"] = valueQuantity;
            Transfer["SumaZarobku"] = profitPerItem * valueQuantity;
            Transfer["Suma"] = (price + profitPerItem) * valueQuantity;

            var id = GetValueID();
            Transfer.Remove("ID");
            await SqlCmd.UpdateRecordAsync("Magazyn", updatedStock, "ID=@ID", id);
            await SqlCmd.AddRecordAsync("WarsztatDB", "NaprawaSamochodu", Transfer);
        }
    }
}
