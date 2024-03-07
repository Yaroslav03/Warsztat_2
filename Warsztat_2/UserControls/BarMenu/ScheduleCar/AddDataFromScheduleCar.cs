
namespace Warsztat_2.UserControls.BarMenu.ScheduleCar
{
    public partial class AddDataFromScheduleCar : Form
    {
        private Queue<string> data = new();
        public AddDataFromScheduleCar()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Event
        #endregion
        #region Method
        #endregion
        #region LoadData
        public void SetDataToLoad(TransferData transfer)
        {
            UC_ScheduleCar scheduleCar = new();
            data = transfer.data;

            AutocompleteData();
        }
        private void AutocompleteData()
        {
            NameLabel.Text = $"{NameLabel.Text}  {data.Dequeue()}";
            SurnameLabel.Text = $"{SurnameLabel.Text}  {data.Dequeue()}";
            labelTelephone.Text = $"{labelTelephone.Text}  {data.Dequeue()}";

            labelMarka.Text = $"{labelMarka.Text}  {data.Dequeue()}";
            labelModel.Text = $"{labelModel.Text}  {data.Dequeue()}";
            ProblemTextBox.Text = data.Dequeue();
        }
        #endregion

        private void AddDataFromScheduleCar_Load(object sender, EventArgs e)
        {
           
        }
    }
}
