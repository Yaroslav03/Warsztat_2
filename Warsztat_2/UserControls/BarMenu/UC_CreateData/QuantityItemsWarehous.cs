using System.Globalization;

namespace Warsztat_2.UserControls.BarMenu.UC_CreateData {
    public partial class QuantityItemsWarehous :Form {
        private Dictionary<string, object> Transfer { get; set; } = new();
        Guid uniqueKey;
        //string[] values = { "Typ", "Nazwa", "Opis", "NumerCzęści", "Cena", "Ilość", "ZarobekCzęści", "SumaZarobku", "Suma" };

        public QuantityItemsWarehous()
            {
            InitializeComponent();
            }

        #region Event
        private void SaveButton_Click(object sender, EventArgs e)
            {
            byte quantity = (byte)QuantityNumericUpDown.Value;
            Transfer.Add("Stan", 1);
            if(quantity == Convert.ToByte(Transfer["Ilość"]))
                {
                TransferAllData();
                }

            else if(quantity < Convert.ToByte(Transfer["Ilość"]))
                {
                TransferDataWithMines(quantity);
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
        private async void TransferAllData()
            {

            var repairCarID = GetValueID();

            await SqlCmd.AddRecordAsync("WarsztatDB", "NaprawaSamochodu", Transfer);

            await SqlCmd.DeleteRecordAsync("WarsztatDB", "Magazyn", "ID=@ID", repairCarID);
            }
        private async void TransferDataWithMines(byte valueQuantity)
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

            // Оновлюємо дані для історії ремонту
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