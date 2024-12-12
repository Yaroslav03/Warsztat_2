using System.Data.SQLite;
using Warsztat_2.Models;

namespace Warsztat_2._0.UserControls;
public partial class UC_AddCar :UserControl {
    #region variables
    private readonly string connection = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
    private readonly string carDB = "Data Source=DBCar.db;Version=3;New=False;Compress=True;";

    private readonly Queue<string> dataError = new();

    Guid uniqueKey = new();

    #endregion

    #region Events
    public UC_AddCar() => InitializeComponent();
    private async void UC_AddCar_Load(object sender, EventArgs e)
        {
        string[] nameColumns = { "Imię", "Nazwisko", "NrTelefonu", "ID" };
        AttachEventHandlers();
        LoadData();
        await SqlCmd.ReadAddDataListBox("SELECT Imię, Nazwisko, NrTelefonu, ID FROM Klienty", nameColumns, ClientsList);
        Verefy();
        }

    private async void ButtoCarSave_Click(object sender, EventArgs e)
        {
        await SaveCar();
        }
    private void HandleTextBoxChanged(object? sender, EventArgs e)
        {
        Verefy();
        }
    private void HandleListBoxMouseClick(object? sender, EventArgs e)
        {
        Verefy();
        }
    #endregion

    #region methods

    private async Task SaveCar()
        {
        CarModel carModel = new()
            {
            Marka = string.IsNullOrEmpty(MarkaSearch.Text) ? MarkaListBox.SelectedItem?.ToString() : MarkaSearch.Text.Trim(),
            Model = string.IsNullOrEmpty(ModelSearch.Text) ? ModelListBox.SelectedItem?.ToString() : ModelSearch.Text.Trim(),
            Engine = string.IsNullOrEmpty(PojemnośćSilnikaSearch.Text) ? EngineListBox.SelectedItem?.ToString() : PojemnośćSilnikaSearch.Text.Trim(),
            YearOfProduktion = string.IsNullOrEmpty(RokProdukcjitextBox.Text) ? RokProdukcjiListBox.SelectedItem?.ToString() : RokProdukcjitextBox.Text.Trim(),
            VIN = VINTextBox.Text.Trim()
            };
        if(carModel.Marka == null || carModel.Model == null || carModel.Engine == null || carModel.YearOfProduktion == null || uniqueKey == Guid.Empty)
            {
            MessageBox.Show($"Proszę wpisać wszystkie dane samochodu");
            return;
            }
        var CarData = new Dictionary<string, object>
            {
                {"Marka", carModel.Marka},
                {"Model", carModel.Model},
                {"Silnik", carModel.Engine},
                {"RokProdukcji", carModel.YearOfProduktion},
                {"VIN", carModel.VIN},
                {"UniqueKey", uniqueKey}
            };
        await SqlCmd.AddRecordAsync("Samochód", CarData);
        }


    private void AttachEventHandlers()
        {
        MarkaSearch.TextChanged += HandleTextBoxChanged;
        ModelSearch.TextChanged += HandleTextBoxChanged;
        PojemnośćSilnikaSearch.TextChanged += HandleTextBoxChanged;

        MarkaListBox.MouseClick += HandleListBoxMouseClick;
        ModelListBox.MouseClick += HandleListBoxMouseClick;
        EngineListBox.MouseClick += HandleListBoxMouseClick;

        UC_AddCar ucAddCarInstance = this;

        ucAddCarInstance.Load += (sender, e) => { LoadData(); Verefy(); };
        }

    private async void LoadData()
        {
        var DataNull = new Dictionary<string, object>
            {
                {string.Empty, null}
            };
        await SqlCmd.CarReadListBoxAsync(MarkaListBox, "SELECT Marka FROM Cars", "Marka", DataNull);
        }
    private async void SearchData(ListBox SelectlistBox, ListBox AddList, string Search)
        {
        HashSet<string> uniqueData = new();
        EngineListBox.Items.Clear();
        AddList.Items.Clear();
        try
            {
            using SQLiteConnection conn = new(carDB);
            conn.Open();
            using SQLiteCommand readModel = new($"SELECT {Search} FROM {SelectlistBox.SelectedItem}", conn);
            using SQLiteDataReader dataReader = readModel.ExecuteReader();

            while(dataReader.Read())
                uniqueData.Add(dataReader.GetString(0));

            foreach(string uniqueValue in uniqueData)
                ModelListBox.Items.Add(uniqueValue);
            }
        catch(Exception ex)
            {
            dataError.Enqueue($"Select DB:{Search}");
            dataError.Enqueue($"From DB:{SelectlistBox.SelectedItem}");
            await Settings.Error(ex, dataError, "AddCar", "Search Data model");
            }
        finally
            {
            uniqueData.Clear();
            }
        }
    private async void SearchDataEngine()
        {
        EngineListBox.Items.Clear();
        try
            {
            using SQLiteConnection conn = new(carDB);
            conn.Open();
            using SQLiteCommand readModel = new($"SELECT Silnik FROM {MarkaListBox.SelectedItem} WHERE Model=@Model", conn);
            readModel.Parameters.AddWithValue("@Model", ModelListBox.SelectedItem);
            using SQLiteDataReader dataReader = readModel.ExecuteReader();

            while(dataReader.Read())
                EngineListBox.Items.Add(dataReader.GetString(0));
            }
        catch(Exception ex)
            {
            dataError.Enqueue($"Search model:{ModelListBox.SelectedItem}");
            dataError.Enqueue($"From DB:{MarkaListBox.SelectedItem}");
            await Settings.Error(ex, dataError, "AddCar", "Search Data Engine");
            }
        }
    private void Verefy()
        {
        // bool VIN17 = false;
        bool isMarkaEmpty = string.IsNullOrEmpty(MarkaSearch.Text) && string.IsNullOrEmpty(MarkaListBox.SelectedItem?.ToString());
        bool isModelEmpty = string.IsNullOrEmpty(ModelSearch.Text) && string.IsNullOrEmpty(ModelListBox.SelectedItem?.ToString());
        bool isEngineEmpty = string.IsNullOrEmpty(PojemnośćSilnikaSearch.Text) && string.IsNullOrEmpty(EngineListBox.SelectedItem?.ToString());
        bool VIN17 = (VINTextBox.Text.Length == 17);
        bool test = !isMarkaEmpty && !isModelEmpty && !isEngineEmpty && VIN17;
        ButtoCarSave.Enabled = test;
        }
    #endregion

    private void VINTextBox_TextChanged(object sender, EventArgs e)
        {
        VINTextBox.MaxLength = 17;
        VINTextBox.Text = String.Concat(VINTextBox.Text.Where(char.IsLetterOrDigit));
        NumLenghtNadwoziaLabel.Text = VINTextBox.Text.Length.ToString();
        Verefy();
        }

    private void MarkaListBox_MouseUp(object sender, MouseEventArgs e)
        {
        if(e.Button == MouseButtons.Right)
            {
            MarkaListBox.ClearSelected();
            }
        }

    private async void MarkaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        if(await SqlCmd.TableExist(carDB, MarkaListBox.Text.ToString()))
            {
            SearchData(MarkaListBox, ModelListBox, "Model");
            }
        else
            {
            ModelListBox.Items.Clear();
            }
        }

    private async void ModelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        if(await SqlCmd.TableExist(carDB, MarkaListBox.Text.ToString()))
            {
            SearchDataEngine();
            }
        }

    private async void ClientsList_DoubleClick(object sender, EventArgs e)
        {
        string? selectedRow = ClientsList.SelectedItem.ToString();
        if(selectedRow != null)
            {
            // Розділити рядок за допомогою коми
            string[] rowData = selectedRow.Split(' ');

            // Переконатися, що масив містить принаймні 3 елементи (Ім'я, Становище, Номер телефону)
            if(rowData.Length >= 4)
                {
                // Отримати номер телефону (четвертий елемент масиву після розділу)
                string iD = rowData[3].Trim();

                uniqueKey = await SqlCmd.GetUniqueKey(iD, "Klienty");

                MessageBox.Show("Samochód został przypisany do klienta");

                }
            }
        }
    }