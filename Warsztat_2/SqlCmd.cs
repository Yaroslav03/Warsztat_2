using System.Data;
using System.Data.SQLite;
using System.Text;
using Warsztat_2;
using Warsztat_2._0;
internal class SqlCmd
{
    #region Read data 
    public static async Task LoadData(string path, string cmd, DataGridView view, string categoryError, string textError)
    {
        Cursor.Current = Cursors.WaitCursor;
        try
        {
            using SQLiteConnection conn = new(path);

            await conn.OpenAsync();

            using SQLiteDataAdapter adapter = new(cmd, conn);
            {
                using DataTable dataTable = new();
                dataTable.Clear();// Очищаємо дані, якщо вони вже були завантажені
                adapter.Fill(dataTable);
                view.DataSource = dataTable;
            }
        }
        catch (Exception ex)
        {
            Queue<string> dataError = new();
            await Settings.Error(ex, dataError, categoryError, textError);
        }
        Cursor.Current = Cursors.Default;
    }
    public static async Task ReadAddDataListBox(string connection, string sqlQuerry, string[] nameColumnsRead, ListBox listBox)
    {
        Cursor.Current = Cursors.WaitCursor;
        List<string> data = new(); // Створюємо новий список, щоб зберігати дані
        try
        {
            using SQLiteConnection conn = new(connection);
            await conn.OpenAsync();
            using SQLiteCommand readEmployer = new(sqlQuerry, conn);
            using SQLiteDataReader reader = readEmployer.ExecuteReader();
            while (reader.Read())
            {
                StringBuilder rowData = new();

                for (int i = 0; i < nameColumnsRead.Length; i++)
                {
                    rowData.Append(reader[nameColumnsRead[i]]);

                    if (i < nameColumnsRead.Length - 1)
                        rowData.Append(' ');
                }
                data.Add(rowData.ToString());
            }
            if (data.Count == 0)
            {
                MessageBox.Show("Brak recordów, Proszę dodać dane", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox.Items.Clear();
                return;
            }

            // Встановлюємо нові дані у ListBoxEmployer за допомогою властивості Items
            listBox.Items.Clear();
            listBox.Items.AddRange(data.ToArray());
        }
        catch (Exception ex)
        {
            MessageBox.Show("Nie przewidziany warunek: " + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        data.Clear();
        Cursor.Current = Cursors.Default;
    }
    #endregion
    #region delete data in DB
    public static async Task DeleteDataTable(DataGridView table, DataGridViewCellEventArgs e, string path, string nameButtonDel, string cellID, string nameTable)
    {
        Queue<string> dataError = new();
        Cursor.Current = Cursors.WaitCursor;
        string? idToDelete;
        try
        {
            if (e.ColumnIndex == table.Columns[$"{nameButtonDel}"].Index && table.Rows[e.RowIndex].Cells[$"{cellID}"].Value != DBNull.Value)
            {
                idToDelete = table.Rows[e.RowIndex].Cells[$"{cellID}"].Value.ToString();
                using SQLiteConnection conn = new(path);
                await conn.OpenAsync();

                using var transaction = conn.BeginTransaction();

                using SQLiteCommand delete = new($"DELETE FROM {nameTable} WHERE ID=@ID", conn);
                delete.Parameters.AddWithValue("ID", idToDelete);

                await delete.ExecuteNonQueryAsync();
                await transaction.CommitAsync();

                table.Rows.RemoveAt(e.RowIndex);
            }
        }
        catch (Exception ex)
        {
            dataError.Enqueue($"cellID:{cellID}");
            dataError.Enqueue($"nameTable:{nameTable}");
            dataError.Enqueue($"idToDelete:{table.Rows[e.RowIndex].Cells[$"{cellID}"].Value}");

            await Settings.Error(ex, dataError, $"{table}", "problem with deleting records");
        }
        Cursor.Current = Cursors.Default;
    }
    #endregion
    #region check data 
    public static bool DataExistsRead(SQLiteDataReader reader)
    {
        return reader.Read();
    }
    public static bool DataExists(SQLiteConnection conn, string table)
    {
        using SQLiteCommand cmd = new($"SELECT COUNT(*) FROM {table}", conn);
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        MessageBox.Show($"{count}");
        return count > 0;
    }
    public static async Task<bool> TableExist(string path, string tableName)
    {
        using SQLiteConnection conn = new(path);
        await conn.OpenAsync();
        using SQLiteCommand search = new($"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}'", conn);

        string? result = (string?)await search.ExecuteScalarAsync();
        return result != null && result.ToString() == tableName;
    }
    #endregion
    #region Send Data To Archive
    public static void SendDataToArchive(string vin, string[] connectionString)
    {
        Cursor.Current = Cursors.WaitCursor;
        TableData[] tableData = new TableData[] // Ініціалізація даних таблиць для зберігання даних
            {
                new() { TableName = "Klienty", Columns = new string[] { "Imię", "Nazwisko", "NrTelefonu", "AdresFirmy", "NIP", "VIN" }, Data = new string[6] },
                new() { TableName = "Samochód", Columns = new string[] { "Marka", "Model", "Silnik", "RokProdukcji", "VIN" }, Data = new string[5] },
                new() { TableName = "HistoriaNapraw", Columns = new string[] { "DataPrzyjęcia", "NrRejestracji", "Przebieg", "DokumentySamochodu", "KluczykiSamochodu", "TestDrive", "Zlecenie", "Diagnostyka", "Naprawa", "VIN" }, Data = new string[10] },
                new() { TableName = "NaprawaSamochodu", Columns = new string[] { "Opis", "NumerCzęści", "Cena", "Ilość", "Stan", "DataNapraw", "VIN" }, Data = new string[7] },
                new() { TableName = "ZarządzanieZleceniami", Columns = new string[] { "VIN", "Przyjęty", "OczekujeNaOdbiór", "DataPrzyjęcie", "DataOczekiwaniaOdbioru", "DataPłatności", "MetodaPłatności", "KosztSzacunkowy", "KosztKońcowy", "KosztZMarżą", "WykonanaPraca", "WykonawcaPracy" }, Data = new string[12] }
            };

        ReadData(vin, connectionString[0], tableData);
        SaveData(vin, connectionString, tableData);

        Cursor.Current = Cursors.Default;
        MessageBox.Show("Operacja przebiegła pomyślne i bez problemu");
    }
    private static async Task DeleteData(string vin, string connectionString)
    {
        string[] nameTable = { "Klienty", "Samochód", "HistoriaNapraw", "ZarządzanieZleceniami", "NaprawaSamochodu" };
        try
        {
            using SQLiteConnection conn = new(connectionString);
            await conn.OpenAsync();

            foreach (string table in nameTable)
            {
                SQLiteCommand delete = new($"DELETE FROM {table} WHERE VIN = @VIN", conn);
                delete.Parameters.AddWithValue("@VIN", vin);
                await delete.ExecuteNonQueryAsync();
            }
        }
        catch
        {
            MessageBox.Show("Błąd usunięcia tabeli");
        }
    }
    private static void ReadData(string vin, string connectionString, TableData[] tableData)
    {
        try
        {
            using SQLiteConnection conn = new(connectionString);

            conn.Open();

            foreach (var table in tableData)
            {
                string columns = string.Join(", ", table.Columns); // Формування SQL-запиту для кожної таблиці
                string querry = $"SELECT {columns} FROM {table.TableName} WHERE VIN LIKE '%{vin}'";

                using SQLiteCommand cmd = new(querry, conn);
                using SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    for (byte i = 0; i < table.Columns.Length; i++)
                    {
                        object columnValue = reader[table.Columns[i]];
                        table.Data[i] = columnValue?.ToString() ?? string.Empty;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Błąd pod czas odczytu bazy danych\n" + ex);
            throw;
        }
    }
    private static void SaveData(string vin, string[] connectionString, TableData[] tableData)
    {
        using SQLiteConnection conn = new(connectionString[1]);

        conn.Open();

        using var transaction = conn.BeginTransaction();
        try
        {
            foreach (var table in tableData)
            {
                string columns = string.Join(", ", table.Columns);
                string values = "@" + string.Join(", @", table.Columns);

                string query = $"INSERT INTO {table.TableName} ({columns}) VALUES ({values})";

                using SQLiteCommand cmd = new(query, conn);
                for (byte i = 0; i < table.Columns.Length; i++)
                {
                    cmd.Parameters.AddWithValue($"{table.Columns[i]}", table.Data[i]);
                }
                cmd.ExecuteNonQuery();
            }
            transaction.Commit();

            DeleteData(vin, connectionString[0]).Wait();
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            MessageBox.Show("Błąd pod czas archiwizacji bazy danych\n " + ex);
            throw;
        }
    }
#endregion
    public static void CheckScheduleCar()
    {
        string connection = "Data Source=Warsztat_2DB.db;Version=3;New=False;Compress=True;";
        Cursor.Current = Cursors.WaitCursor;
        string today = DateTime.Today.ToString("D");

        MessageBox.Show(today);
        try
        {
            using SQLiteConnection conn = new(connection);

            conn.Open();

            using SQLiteCommand cmd = new("SELECT Imię, Nazwisko, Telefon, Marka, Model, Problem, DataPrzyjęcia FROM ZaplanowaneSamochody WHERE DataPrzyjęcia = @DataPrzyjęcia", conn);

            cmd.Parameters.AddWithValue("@DataPrzyjęcia", today);

            using SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)//перевірка чи є стовпці в базі даних, якщо немає то код не буде засмічувати пам'ять коли не потрібно
            {
                while (reader.Read())
                {
                    ChceckSchedule chceckSchedule = new
                        (
                        reader["Imię"].ToString(), reader["Telefon"].ToString(),
                        reader["Marka"].ToString(), reader["Model"].ToString(),
                        reader["Problem"].ToString(), reader["DataPrzyjęcia"].ToString()
                        );

                    MessageBox.Show($"Uwaga na dzisiaj {chceckSchedule.ScheduleCar} zaplanowano {chceckSchedule.Marka} {chceckSchedule.Model} klienta {chceckSchedule.Name} ({chceckSchedule.PhoneNumber}). Klient ma następujący problem: {chceckSchedule.Problem}",
                        "Zaplanowana praca na dzisiaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Wystąpił błąd: " + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        Cursor.Current = Cursors.Default;
    }

    public class TableData
    {
        public string? TableName { get; set; }
        public string[] Columns { get; set; }
        public string[] Data { get; set; }
    }
}
