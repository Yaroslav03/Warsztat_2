using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Text;
using Warsztat_2;
using Warsztat_2._0;
internal class SqlCmd {
    private static readonly string _connectionString = "Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;";
    private static readonly string _connectionStringCarDB = "Data Source=DBCar.db;Version=3;New=False;Compress=True;";
    List<string>  dataIdOwner= new();
    #region CRUD SQL
    public static async Task<bool> AddRecordAsync(string tableName, Dictionary<string, object> columns)
        {
        Cursor.Current = Cursors.WaitCursor;

        var columnNames = string.Join(", ", columns.Keys);
        var parameterNames = string.Join(", ", columns.Keys.Select(k => "@" + k));

        using SQLiteConnection conn = new(_connectionString);
        await conn.OpenAsync();

        var query = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameterNames})";

        using var transaction = await conn.BeginTransactionAsync();
        try
            {
            using SQLiteCommand cmd = new(query, conn);
            foreach(var column in columns)
                {
                cmd.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);
                }
            await cmd.ExecuteNonQueryAsync();
            await transaction.CommitAsync();
            return true;  // Запис успішний
            }
        catch(Exception ex)
            {
            MessageBox.Show($"Nie przewidziany warunek w czasie zapisu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            transaction.Rollback();
            return false;
            throw;
            }
        finally
            {
            Cursor.Current = Cursors.Default;
            }
        }
    public static async Task<Dictionary<string, object>> LoadDataAsync(Button button, string tableName, string keyColumnName = null, object keyValue = null)
        {
        Cursor.Current = Cursors.WaitCursor;
        var data = new Dictionary<string, object>();
        string query = "";
        try
            {
            using SQLiteConnection conn = new(_connectionString);
            await conn.OpenAsync();

            if(!string.IsNullOrEmpty(keyColumnName) && keyValue != null)
                {
                query = $"SELECT * FROM {tableName} WHERE {keyColumnName} = @KeyValue";
                }
            else
                {
                query = $"SELECT * FROM {tableName}";
                }

            using SQLiteCommand cmd = new(query, conn);

            if(!string.IsNullOrEmpty(keyColumnName) && keyValue != null)
                {
                cmd.Parameters.AddWithValue("@KeyValue", keyValue);
                }

            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            if(!reader.HasRows)
                {
                button.Text = "Zapisz";
                return data;
                }

            if(await reader.ReadAsync())
                {
                for(int i = 0;i < reader.FieldCount;i++)
                    {
                    string columnName = reader.GetName(i);
                    object value = reader.GetValue(i);
                    data[columnName] = value;
                    }
                }
            }
        catch(Exception ex)
            {
            MessageBox.Show("Nie przewidziany warunek, proszę zrobić zdjęcie błędu i wysłać na adres yaroslavturbo13@gmail.com: \n" + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        finally
            {
            Cursor.Current = Cursors.Default;
            }

        button.Text = "Odśwież";
        return data;
        }
    public static async Task<decimal> GetMarzaAsync()
        {
        decimal marzha = 0;

        try
            {
            using SQLiteConnection conn = new(_connectionString);
            await conn.OpenAsync();

            using SQLiteCommand cmd = new("SELECT Marża FROM DaneFirmy", conn);
            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            if(await reader.ReadAsync()) // Перевірка, чи є дані
                {
                marzha = Convert.ToDecimal(reader["Marża"]); // Отримання значення
                }
            }
        catch(Exception ex)
            {
            // Обробка виключення
            MessageBox.Show("Wystąpił błąd podczas pobierania wartości 'Marża': " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        return marzha;
        }
    public static async Task<Guid> GetUniqueKey(string id, string table)
        {
        Guid uniqueKey = new();

        try
            {
            using SQLiteConnection conn = new(_connectionString);
            await conn.OpenAsync();

            using SQLiteCommand cmd = new($"SELECT UniqueKey FROM {table} WHERE ID=@ID", conn);

            cmd.Parameters.AddWithValue("@ID", id);
            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            if(await reader.ReadAsync()) // Перевірка, чи є дані
                {
                //string uniqueKeyString = reader["UniqueKey"].ToString();
                //MessageBox.Show($"{uniqueKeyString}");

                byte[] uniqueKeyBytes = (byte[])reader["UniqueKey"];
                uniqueKey = new Guid(uniqueKeyBytes);
                }
            }
        catch(Exception ex)
            {
            // Обробка виключення
            MessageBox.Show("Wystąpił błąd podczas pobierania wartości 'UniqueKey': " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        return uniqueKey;
        }


    // Універсальний метод для оновлення запису в будь-якій таблиці
    public static async Task<bool> UpdateRecordAsync(string tableName, Dictionary<string, object> columns, string whereClause, Dictionary<string, object> whereParams)
        {
        Cursor.Current = Cursors.WaitCursor;

        // Формуємо SQL-запит для оновлення запису в базі даних
        var setClause = string.Join(", ", columns.Keys.Select(k => $"{k} = @{k}"));
        var query = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}";

        using SQLiteConnection conn = new(_connectionString);
        await conn.OpenAsync();

        // Використовуємо транзакцію для надійного виконання змін
        using var transaction = await conn.BeginTransactionAsync();
        try
            {
            using SQLiteCommand cmd = new(query, conn);

            // Додаємо параметри для запиту (дані, які будемо оновлювати)
            foreach(var column in columns)
                {
                cmd.Parameters.AddWithValue("@" + column.Key, column.Value ?? DBNull.Value);
                }

            // Додаємо параметри для умов (наприклад, де саме слід оновлювати)
            foreach(var param in whereParams)
                {
                cmd.Parameters.AddWithValue("@" + param.Key, param.Value ?? DBNull.Value);
                }

            // Виконуємо команду оновлення
            await cmd.ExecuteNonQueryAsync();
            // Підтверджуємо транзакцію, якщо все пройшло успішно
            await transaction.CommitAsync();
            return true;
            }
        catch(Exception ex)
            {
            // Відкочуємо транзакцію у разі виникнення помилки
            await transaction.RollbackAsync();
            MessageBox.Show($"Nie przewidziany warunek w czasie aktualizacji danych : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
            throw;
            }
        finally
            {
            Cursor.Current = Cursors.Default;
            }
        }

    public static async Task ReadRecordListBoxAsync(ListBox updateListBox, string query, string ColumnName)
        {
        updateListBox.Items.Clear();

        using SQLiteConnection conn = new(_connectionString);
        await conn.OpenAsync();

        using SQLiteCommand cmd = new(query, conn);
        using DbDataReader reader = await cmd.ExecuteReaderAsync();

        while(await reader.ReadAsync())
            {
            if(reader[ColumnName] != DBNull.Value && !string.IsNullOrEmpty(reader[ColumnName].ToString()))
                {
                updateListBox.Items.Add(reader[ColumnName].ToString());
                }
            }
        }
    public static async Task CarReadListBoxAsync(ListBox updateListBox, string query, string ColumnName, Dictionary<string, object> columns)
        {
        updateListBox.Items.Clear();

        using SQLiteConnection conn = new(_connectionStringCarDB);
        await conn.OpenAsync();

        using SQLiteCommand cmd = new(query, conn);
        foreach(var column in columns)
            {
            cmd.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);
            }
        using DbDataReader reader = await cmd.ExecuteReaderAsync();

        while(await reader.ReadAsync())
            {
            if(reader[ColumnName] != DBNull.Value && !string.IsNullOrEmpty(reader[ColumnName].ToString()))
                {
                updateListBox.Items.Add(reader[ColumnName].ToString());
                }
            }
        }
    // Універсальний метод для видалення запису(ів) з будь-якої таблиці
    public static async Task DeleteRecordAsync(string tableName, string whereClause, Dictionary<string, object> whereParams)
        {
        Cursor.Current = Cursors.WaitCursor;

        // Формуємо SQL-запит для видалення запису з бази даних
        var query = $"DELETE FROM {tableName} WHERE {whereClause}";

        using SQLiteConnection conn = new(_connectionString);
        await conn.OpenAsync();

        // Використовуємо транзакцію для надійного виконання змін
        using var transaction = await conn.BeginTransactionAsync();
        try
            {
            using SQLiteCommand cmd = new SQLiteCommand(query, conn);

            // Додаємо параметри для умов (наприклад, що саме слід видаляти)
            foreach(var param in whereParams)
                {
                cmd.Parameters.AddWithValue("@" + param.Key, param.Value ?? DBNull.Value);
                }

            // Виконуємо команду видалення
            await cmd.ExecuteNonQueryAsync();
            // Підтверджуємо транзакцію, якщо все пройшло успішно
            await transaction.CommitAsync();
            }
        catch(Exception ex)
            {
            // Відкочуємо транзакцію у разі виникнення помилки
            await transaction.RollbackAsync();
            MessageBox.Show("Wystąpił błąd przy usuwaniu rekordu: " + ex.Message);
            throw;
            }
        finally
            {
            Cursor.Current = Cursors.Default;
            }
        }

    #endregion
    #region Read data 
    public static async Task LoadData(string cmd, DataGridView view, string categoryError, string textError, Dictionary<string, object> parameters = null)
        {
        Cursor.Current = Cursors.WaitCursor;
        try
            {
            using SQLiteConnection conn = new(_connectionString);
            await conn.OpenAsync();

            using SQLiteCommand command = new(cmd, conn);

            // Якщо є параметри, додаємо їх до команди
            if(parameters != null)
                {
                foreach(var param in parameters)
                    {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

            using SQLiteDataAdapter adapter = new(command);
            DataTable dataTable = new();
            await Task.Run(() => adapter.Fill(dataTable));
            view.DataSource = dataTable;


            }
        catch(Exception ex)
            {
            MessageBox.Show($"{cmd}");
            Queue<string> dataError = new();
            await Settings.Error(ex, dataError, categoryError, textError);
            }
        Cursor.Current = Cursors.Default;
        }
    public static async Task ReadAddDataListBox(string sqlQuerry, string[] nameColumnsRead, ListBox listBox)
        {
        Cursor.Current = Cursors.WaitCursor;
        List<string> data = new(); // Створюємо новий список, щоб зберігати дані
        try
            {
            using SQLiteConnection conn = new(_connectionString);
            await conn.OpenAsync();
            using SQLiteCommand readEmployer = new(sqlQuerry, conn);
            using SQLiteDataReader reader = readEmployer.ExecuteReader();
            while(reader.Read())
                {
                StringBuilder rowData = new();

                for(int i = 0;i < nameColumnsRead.Length;i++)
                    {
                    rowData.Append(reader[nameColumnsRead[i]]);

                    if(i < nameColumnsRead.Length - 1)
                        rowData.Append(' ');
                    }
                data.Add(rowData.ToString());
                }
            if(data.Count == 0)
                {
                MessageBox.Show("Brak recordów, Proszę dodać dane", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox.Items.Clear();
                return;
                }

            // Встановлюємо нові дані у ListBoxEmployer за допомогою властивості Items
            listBox.Items.Clear();
            listBox.Items.AddRange(data.ToArray());
            }
        catch(Exception ex)
            {
            MessageBox.Show("Nie przewidziany warunek: " + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        data.Clear();
        Cursor.Current = Cursors.Default;
        }
    #endregion
    #region delete data in DB
    public static async Task DeleteDataTable(DataGridView table, DataGridViewCellEventArgs e, string nameButtonDel, string cellID, string nameTable)
        {
        Queue<string> dataError = new();
        Cursor.Current = Cursors.WaitCursor;
        string? idToDelete;
        try
            {
            if(e.ColumnIndex == table.Columns[$"{nameButtonDel}"].Index && table.Rows[e.RowIndex].Cells[$"{cellID}"].Value != DBNull.Value)
                {
                idToDelete = table.Rows[e.RowIndex].Cells[$"{cellID}"].Value.ToString();
                using SQLiteConnection conn = new(_connectionString);
                await conn.OpenAsync();

                using var transaction = conn.BeginTransaction();

                using SQLiteCommand delete = new($"DELETE FROM {nameTable} WHERE ID=@ID", conn);
                delete.Parameters.AddWithValue("ID", idToDelete);

                await delete.ExecuteNonQueryAsync();
                await transaction.CommitAsync();

                table.Rows.RemoveAt(e.RowIndex);
                }
            }
        catch(Exception ex)
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

            foreach(string table in nameTable)
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

            foreach(var table in tableData)
                {
                string columns = string.Join(", ", table.Columns); // Формування SQL-запиту для кожної таблиці
                string querry = $"SELECT {columns} FROM {table.TableName} WHERE VIN LIKE '%{vin}'";

                using SQLiteCommand cmd = new(querry, conn);
                using SQLiteDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                    {
                    for(byte i = 0;i < table.Columns.Length;i++)
                        {
                        object columnValue = reader[table.Columns[i]];
                        table.Data[i] = columnValue?.ToString() ?? string.Empty;
                        }
                    }
                }
            }
        catch(Exception ex)
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
            foreach(var table in tableData)
                {
                string columns = string.Join(", ", table.Columns);
                string values = "@" + string.Join(", @", table.Columns);

                string query = $"INSERT INTO {table.TableName} ({columns}) VALUES ({values})";

                using SQLiteCommand cmd = new(query, conn);
                for(byte i = 0;i < table.Columns.Length;i++)
                    {
                    cmd.Parameters.AddWithValue($"{table.Columns[i]}", table.Data[i]);
                    }
                cmd.ExecuteNonQuery();
                }
            transaction.Commit();

            DeleteData(vin, connectionString[0]).Wait();
            }
        catch(Exception ex)
            {
            transaction.Rollback();
            MessageBox.Show("Błąd pod czas archiwizacji bazy danych\n " + ex);
            throw;
            }
        }

    #endregion
    public async static Task CheckScheduleCar()
        {
        Cursor.Current = Cursors.WaitCursor;
        string today = DateTime.Today.ToString("D");

        MessageBox.Show(today);
        try
            {
            using SQLiteConnection conn = new(_connectionString);

            await conn.OpenAsync();

            using SQLiteCommand cmd = new("SELECT Imię, Nazwisko, Telefon, Marka, Model, Problem, DataPrzyjęcia FROM ZaplanowaneSamochody WHERE DataPrzyjęcia = @DataPrzyjęcia", conn);

            cmd.Parameters.AddWithValue("@DataPrzyjęcia", today);

            using DbDataReader reader = await cmd.ExecuteReaderAsync();
            if(reader.HasRows)//перевірка чи є стовпці в базі даних, якщо немає то код не буде засмічувати пам'ять коли не потрібно
                {
                while(await reader.ReadAsync())
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
        catch(Exception ex)
            {
            MessageBox.Show("Wystąpił błąd: " + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        Cursor.Current = Cursors.Default;
        }

    public class TableData {
        public string? TableName { get; set; }
        public string[] Columns { get; set; }
        public string[] Data { get; set; }
        }
    }
