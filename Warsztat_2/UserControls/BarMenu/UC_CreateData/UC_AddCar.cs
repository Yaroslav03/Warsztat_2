using System.Data.SQLite;
using System.Windows.Forms;

namespace Warsztat_2._0.UserControls;
public partial class UC_AddCar : UserControl
{
    #region variables
    readonly string pathDBCAR = "Data Source=DBCar.db;Version=3;New=False;Compress=True;";
    readonly string pathCarClients = "Data Source=Warsztat_CarClients.db;Version=3;New=False;Compress=True;";


    private List<string?> carData = new();
    private Queue<string> dataError = new();

    private Car car = new();
    private Repair orderRepair = new();
    private HistoryCar HistoryCar = new();

    #endregion

    #region Events
    public UC_AddCar() => InitializeComponent();
    private async void UC_AddCar_Load(object sender, EventArgs e)
    {
        AttachEventHandlers();
        //LoadData();
        await LoadDataClient();
        Verefy();
    }

    private async void ButtoCarSave_Click(object sender, EventArgs e)
    {

        Cursor.Current = Cursors.WaitCursor;
        try
        {
            await SaveCar();

        }
        catch (Exception ex)
        {
            await Settings.Error(ex, dataError, "AddCar", "problem with opening db car");
        }

        Cursor.Current = Cursors.Default;
    }
    private async void MarkaListBox_Click(object sender, EventArgs e)
    {
      /*  if (MarkaListBox.SelectedItem.ToString() != "")
        {
            if (await Settings.TableExist(pathDBCAR, MarkaListBox.Text.ToString()))
            {
                SearchData(MarkaListBox, ModelListBox, "Model");
            }
            else
            {
                ModelListBox.Items.Clear();
            }
        }*/


    }
    private async void ModelListBox_Click(object sender, EventArgs e)
    {
        if (await SqlCmd.TableExist(pathDBCAR, MarkaListBox.Text.ToString()))
        {
            SearchDataEngine();
        }

        else
        {

        }
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
    private void CollectCarData()
    {
        List<string?> carData = new();
        carData.Add(string.IsNullOrEmpty(MarkaSearch.Text) ? MarkaListBox.SelectedItem?.ToString() : MarkaSearch.Text);        
        carData.Add(string.IsNullOrEmpty(ModelSearch.Text) ? ModelListBox.SelectedItem?.ToString() : ModelSearch.Text);
        carData.Add(string.IsNullOrEmpty(PojemnośćSilnikaSearch.Text) ? EngineListBox.SelectedItem?.ToString() : PojemnośćSilnikaSearch.Text);
        carData.Add(string.IsNullOrEmpty(RokProdukcjitextBox.Text) ? RokProdukcjiListBox.SelectedItem?.ToString() : RokProdukcjitextBox.Text);
        car = new()
        {
            Marka = carData[0],
            Model = carData[1],
            Engine = carData[2],
            YearOfProduktion = carData[3],

            VIN = VINTextBox.Text
        };
        // File.ReadAllText("tempFile.txt")

    }
    private async Task SaveCar()
    {
        CollectCarData();

        using SQLiteConnection conn = new(pathCarClients);

        await conn.OpenAsync();

        using var transaction = conn.BeginTransaction();
        try
        {
            using SQLiteCommand insert = new("INSERT INTO Samochód (Marka, Model, Silnik, RokProdukcji, VIN)" +
                "VALUES (@Marka, @Model, @Silnik, @RokProdukcji, @VIN)", conn);

            insert.Parameters.AddWithValue("@Marka", car.Marka);
            insert.Parameters.AddWithValue("@Model", car.Model);
            insert.Parameters.AddWithValue("@Silnik", car.Engine);
            insert.Parameters.AddWithValue("@RokProdukcji", car.YearOfProduktion);
            insert.Parameters.AddWithValue("@VIN", car.VIN);

            await insert.ExecuteNonQueryAsync();

            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            MessageBox.Show("Coś poszło nie tak w czasie zapisu samochodu: " + ex);
            throw;
        }
        finally
        {
            Car.Reset();
            carData.Clear();
        }
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
        try
        {
            using SQLiteConnection conn = new(pathDBCAR);
            conn.Open();
            using SQLiteCommand readCar = new($"SELECT Marka FROM Cars", conn);

            using SQLiteDataReader dataReader = readCar.ExecuteReader();
            while (dataReader.Read())
                MarkaListBox.Items.Add(dataReader.GetString(0));
        }
        catch (Exception ex)
        {
            await Settings.Error(ex, dataError, "AddCar", "Load all marka from DB");
        }
    }
    private async void SearchData(ListBox SelectlistBox, ListBox AddList, string Search)
    {
        HashSet<string> uniqueData = new();
        EngineListBox.Items.Clear();
        AddList.Items.Clear();
        try
        {
            using SQLiteConnection conn = new(pathDBCAR);
            conn.Open();
            using SQLiteCommand readModel = new($"SELECT {Search} FROM {SelectlistBox.SelectedItem}", conn);
            using SQLiteDataReader dataReader = readModel.ExecuteReader();

            while (dataReader.Read())
                uniqueData.Add(dataReader.GetString(0));

            foreach (string uniqueValue in uniqueData)
                ModelListBox.Items.Add(uniqueValue);
        }
        catch (Exception ex)
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
            using SQLiteConnection conn = new(pathDBCAR);
            conn.Open();
            using SQLiteCommand readModel = new($"SELECT Silnik FROM {MarkaListBox.SelectedItem} WHERE Model=@Model", conn);
            readModel.Parameters.AddWithValue("@Model", ModelListBox.SelectedItem);
            using SQLiteDataReader dataReader = readModel.ExecuteReader();

            while (dataReader.Read())
                EngineListBox.Items.Add(dataReader.GetString(0));
        }
        catch (Exception ex)
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

    private async Task AddVINToClient()
    {
        if (ClientsList.SelectedIndex >= 0 && VINTextBox.Text.Length == 17)
        {
            // Отримати текст виділеного рядка
            string? selectedRow = ClientsList.SelectedItem.ToString();

            // Розділити рядок за допомогою коми
            string[] rowData = selectedRow.Split(' ');

            // Переконатися, що масив містить принаймні 3 елементи (Ім'я, Становище, Номер телефону)
            if (rowData.Length >= 4)
            {
                // Отримати номер телефону (четвертий елемент масиву після розділу)
                string iD = rowData[3].Trim();

                using SQLiteConnection conn = new(pathCarClients);
                await conn.OpenAsync();

                // Початок транзакції
                using SQLiteTransaction transaction = conn.BeginTransaction();

                try
                {
                    using SQLiteCommand update = new SQLiteCommand("UPDATE Klienty SET VIN_Samochodu = @VIN_Samochodu WHERE ID = @ID", conn, transaction);
                    update.Parameters.AddWithValue("@VIN_Samochodu", VINTextBox.Text.ToString());
                    update.Parameters.AddWithValue("@ID", iD);

                    await update.ExecuteNonQueryAsync();

                    // Завершення транзакції (збереження змін у базі даних)
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Виникла помилка, скасовуємо транзакцію
                    transaction.Rollback();
                    dataError.Enqueue($"VIN:{VINTextBox.Text}");
                    dataError.Enqueue($"ID:{iD}");
                    await Settings.Error(ex, dataError, "AddCar", "Add VIN to client");
                    throw;
                }
            }
        }
    }
    private async Task LoadDataClient()
    {
        Cursor.Current = Cursors.WaitCursor;
        try
        {
            ClientsList.Items.Clear();

            List<string> Client = new();

            using SQLiteConnection conn = new(pathCarClients);

            await conn.OpenAsync();

            using SQLiteCommand cmd = new("SELECT Imię, Nazwisko, NrTelefonu, ID FROM Klienty", conn);

            using SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Client.Add($"{reader["Imię"]} {reader["Nazwisko"]} {reader["NrTelefonu"]} {reader["ID"]}");
            }
            ClientsList.Items.AddRange(Client.ToArray());

            Client.Clear();
        }
        catch (Exception ex)
        {
            await Settings.Error(ex, dataError, "AddCar", "Read data db");
        }


        Cursor.Current = Cursors.Default;
    }
    #endregion


    private async void AddVinToClient_Click(object sender, EventArgs e)
    {
        try
        {
            await AddVINToClient();
        }

        catch (Exception ex)
        {
            await Settings.Error(ex, dataError, "AddCar", "Add VIN To Client");
        }
    }

    private void VINTextBox_TextChanged(object sender, EventArgs e)
    {
        VINTextBox.MaxLength = 17;
        VINTextBox.Text = String.Concat(VINTextBox.Text.Where(char.IsLetterOrDigit));
        NumLenghtNadwoziaLabel.Text = VINTextBox.Text.Length.ToString();
        Verefy();
    }

    private void MarkaSearch_TextChanged(object sender, EventArgs e)
    {
        // Очистити виділення у списку

        if (MarkaSearch.Text == string.Empty)
        {
            MarkaListBox.ClearSelected();
        }
        // Пройтися по кожному елементу списку
        for (int i = 0; i < MarkaListBox.Items.Count; i++)
        {
            // Перевірити, чи містить елемент текст з текстового поля
            if (MarkaListBox.Items[i].ToString().ToLower().Contains(MarkaSearch.Text.ToLower()))
            {
                // Якщо так, вибрати елемент у списку
                MarkaListBox.SetSelected(i, true);
            }
        }

    }

    private void MarkaListBox_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            MarkaListBox.ClearSelected();
        }
    }

    private async void MarkaListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (await SqlCmd.TableExist(pathDBCAR, MarkaListBox.Text.ToString()))
        {
            SearchData(MarkaListBox, ModelListBox, "Model");
        }
        else
        {
            ModelListBox.Items.Clear();
        }
    }
}