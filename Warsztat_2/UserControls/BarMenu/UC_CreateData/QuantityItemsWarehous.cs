using System.Globalization;

namespace Warsztat_2.UserControls.BarMenu.UC_CreateData {
    public partial class QuantityItemsWarehous :Form {
        private List<string> transferData = new();
        private string id;
        Guid uniqueKey;
        string[] values = { "Typ", "Nazwa", "Opis", "NumerCzęści", "Cena", "Ilość", "Suma" };


        public QuantityItemsWarehous()
            {
            InitializeComponent();
            }
        #region Event
        private void SaveButton_Click(object sender, EventArgs e)
            {
            byte quantity = (byte)QuantityNumericUpDown.Value;
            if(quantity == Convert.ToUInt32(transferData[5]))
                {
                TransferAllData();
                }

            else if(quantity < Convert.ToByte(transferData[5]))
                {

                TransferDataWithMines(quantity);
                }
            MessageBox.Show("Udało się");
            this.Close();
            }
        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
            {
            QuantityNumericUpDown.Maximum = Convert.ToDecimal(transferData[5]);
            }
        private void CancelButton_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        #endregion

        public void TransferListData(List<string> tranferListData, Guid key)
            {
            transferData = tranferListData;
            uniqueKey = key;

            }
        private Dictionary<string, object> GetValue()
            {
            var repairCarData = new Dictionary<string, object>();

            for(byte i = 0;i < transferData.Count;i++)
                {
                string value = transferData[i];

                // Якщо це поле "Cena" або "Suma" — обробляємо як десяткове число
                if(values[i] == "Cena" || values[i] == "Suma")
                    {
                    if(decimal.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal decValue))
                        {
                        // Перетворюємо в рядок із крапкою як роздільником (інваріантна культура)
                        value = decValue.ToString(CultureInfo.InvariantCulture);
                        }
                    }

                repairCarData.Add(values[i], value);
                }
            repairCarData.Add("UniqueKey", uniqueKey);
            return repairCarData;
            }
        private Dictionary<string, object> GetValueID()
            {
            return new Dictionary<string, object>
                {
                    {"ID", id }
                };
            }
        private async void TransferAllData()
            {
            var repairCarData = GetValue();

            var repairCarID = GetValueID();

            await SqlCmd.AddRecordAsync("WarsztatDB", "NaprawaSamochodu", repairCarData);

            await SqlCmd.DeleteRecordAsync("WarsztatDB", "Magazyn", "ID=@ID", repairCarID);
            }
        private async void TransferDataWithMines(byte valueQuantity)
            {
            byte maxQuantityNumber = Convert.ToByte(transferData[5]);
            decimal price = Convert.ToDecimal(transferData[4]);

            byte x = (byte)(maxQuantityNumber - valueQuantity);

            decimal sum = price * x;
            var transfertDataWithMines = new Dictionary<string, object>
                {
                    {"Ilość", x},
                    {"Suma", sum }
                };
            transferData[5] = valueQuantity.ToString();
            maxQuantityNumber = Convert.ToByte(transferData[5]);
            transferData[6] = (price * maxQuantityNumber).ToString();

            var transferDataID = GetValueID();
            var repairCarData = GetValue();

            await SqlCmd.UpdateRecordAsync("Magazyn", transfertDataWithMines, "ID=@ID", transferDataID);
            await SqlCmd.AddRecordAsync("WarsztatDB", "NaprawaSamochodu", repairCarData);
            }

        private void QuantityItemsWarehous_Load(object sender, EventArgs e)
            {
            id = transferData[0];
            transferData.RemoveAt(0);
            /*            if(byte.TryParse(, out byte maxQuantity))
                            {
                            QuantityNumericUpDown.Maximum = maxQuantity;
                            return;
                            }*/
            /*            byte maxValue = Convert.ToByte(transferData[7]);
                        QuantityNumericUpDown.Maximum = maxValue;*/
            }
        }
    }