using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;
using Warsztat_2;
using Warsztat_2._0;
internal class SqlCmd
{
    private static readonly string _connectionString = "Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;";
    private static readonly string _connectionStringCarDB = "Data Source=DBCar.db;Version=3;New=False;Compress=True;";
    private static readonly string _connectionStringArchive = "Data Source=Archive.db;Version=3;New=False;Compress=True;";
    #region CRUD SQL
    public static async Task<bool> AddRecordAsync(string DB, string tableName, Dictionary<string, object> columns)
    {
        Cursor.Current = Cursors.WaitCursor;

        var columnNames = string.Join(", ", columns.Keys);
        var parameterNames = string.Join(", ", columns.Keys.Select(k => "@" + k));

        using SQLiteConnection conn = new($"Data Source={DB}.db;Version=3;New=False;Compress=True;");
        await conn.OpenAsync();

        var query = $"INSERT INTO {tableName} ({columnNames}) VALUES ({parameterNames})";

        using var transaction = await conn.BeginTransactionAsync();
        try
        {
            using SQLiteCommand cmd = new(query, conn);
            foreach (var column in columns)
            {
                cmd.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);
            }
            await cmd.ExecuteNonQueryAsync();
            await transaction.CommitAsync();
            return true;  // Запис успішний
        }
        catch (Exception ex)
        {
            // Перевіряємо, чи це помилка UNIQUE для поля Samochód.UniqueKey
            if (ex.Message.Contains("UNIQUE constraint failed: Samochód.UniqueKey"))
            {
                // Показуємо користувачеві більш "людське" пояснення
                MessageBox.Show(
                    "Nie można przypisać kolejnego samochodu do wybranego klienta (posiada on już jeden). Jeśli to jest ten sam klient, ale ma jeszcze inny samochód, proszę dodać go do systemu ponownie. Zasada: 1 klient = 1 samochód.",
                    "Błąd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                // Якщо помилка інша, то показуємо її, як і було раніше
                MessageBox.Show(
                    $"Nie przewidziany warunek w czasie zapisu danych: {ex.Message}",
                    "Błąd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            transaction.Rollback();
            return false;
            throw;
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
    }
    public static async Task SaveAllData(Dictionary<string, object> klientData,
                                        Dictionary<string, object> carData,
                                        Dictionary<string, object> historyData)
    {
        Cursor.Current = Cursors.WaitCursor;

        using SQLiteConnection conn = new(_connectionString);
        await conn.OpenAsync();
        using DbTransaction transaction = await conn.BeginTransactionAsync();

        try
        {
            string klientColumns = string.Join(", ", klientData.Keys);
            string klientValues = string.Join(", ", klientData.Keys.Select(k => $"@{k}"));

            string carColumns = string.Join(", ", carData.Keys);
            string carValues = string.Join(", ", carData.Keys.Select(k => $"@{k}"));

            string historyColumns = string.Join(", ", historyData.Keys);
            string historyValues = string.Join(", ", historyData.Keys.Select(k => $"@{k}"));

            string query = $@"
            INSERT INTO Klienty ({klientColumns}) VALUES ({klientValues});
            INSERT INTO Samochód ({carColumns}) VALUES ({carValues});
            INSERT INTO HistoriaNapraw ({historyColumns}) VALUES ({historyValues});
        ";

            using SQLiteCommand cmd = new(query, conn, (SQLiteTransaction)transaction);

            foreach (var column in klientData)
                cmd.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);

            foreach (var column in carData)
                cmd.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);

            foreach (var column in historyData)
                cmd.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);

            await cmd.ExecuteNonQueryAsync();
            await transaction.CommitAsync();

            MessageBox.Show("Dane zapisano pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            MessageBox.Show($"Błąd zapisu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
    }
    public static async Task UpdateAllData(Guid uniqueKey,
                                       Dictionary<string, object> сlientData,
                                       Dictionary<string, object> carData,
                                       Dictionary<string, object> historyData)
        {
        Cursor.Current = Cursors.WaitCursor;

        using SQLiteConnection conn = new(_connectionString);
        await conn.OpenAsync();
        using DbTransaction transaction = await conn.BeginTransactionAsync();

        try
            {
            // Функція для створення SQL-запиту UPDATE
            static string GenerateUpdateQuery(string tableName, Dictionary<string, object> data)
                {
                string setClause = string.Join(", ", data.Keys.Select(k => $"{k} = @{k}"));
                return $"UPDATE {tableName} SET {setClause} WHERE UniqueKey = @UniqueKey;";
                }

            // Оновлення даних клієнта
            if(сlientData.Count > 0)
                {
                string klientQuery = GenerateUpdateQuery("Klienty", сlientData);
                using SQLiteCommand klientCmd = new(klientQuery, conn, (SQLiteTransaction)transaction);
                klientCmd.Parameters.AddWithValue("@UniqueKey", uniqueKey);
                foreach(var column in сlientData)
                    klientCmd.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);
                await klientCmd.ExecuteNonQueryAsync();
                }

            // Оновлення даних автомобіля
            if(carData.Count > 0)
                {
                string carQuery = GenerateUpdateQuery("Samochód", carData);
                using SQLiteCommand carCmd = new(carQuery, conn, (SQLiteTransaction)transaction);
                carCmd.Parameters.AddWithValue("@UniqueKey", uniqueKey);
                foreach(var column in carData)
                    carCmd.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);
                await carCmd.ExecuteNonQueryAsync();
                }

            // Оновлення історії ремонту
            if(historyData.Count > 0)
                {
                string historyQuery = GenerateUpdateQuery("HistoriaNapraw", historyData);
                using SQLiteCommand historyCmd = new(historyQuery, conn, (SQLiteTransaction)transaction);
                historyCmd.Parameters.AddWithValue("@UniqueKey", uniqueKey);
                foreach(var column in historyData)
                    historyCmd.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);
                await historyCmd.ExecuteNonQueryAsync();
                }

            await transaction.CommitAsync();
            MessageBox.Show("Dane zaktualizowano pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        catch(Exception ex)
            {
            await transaction.RollbackAsync();
            MessageBox.Show($"Błąd aktualizacji: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        finally
            {
            Cursor.Current = Cursors.Default;
            }
        }
    public static async Task<List<Dictionary<string, object>>> LoadListAsync(string pathName, string tableName, string selectData, string keyColumnName, object keyValue)
    {
        Cursor.Current = Cursors.WaitCursor;
        var dataList = new List<Dictionary<string, object>>(); // Список для кількох рядків
        string query;
        try
        {
            using SQLiteConnection conn = new($"Data Source={pathName}.db;Version=3;New=False;Compress=True;");
            await conn.OpenAsync();

            query = $"SELECT {selectData} FROM {tableName} WHERE {keyColumnName} = @KeyValue";

            using SQLiteCommand cmd = new(query, conn);

            if (!string.IsNullOrEmpty(keyColumnName) && keyValue != null)
            {
                cmd.Parameters.AddWithValue("@KeyValue", keyValue);
            }

            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync()) // Читаємо кілька рядків
            {
                var data = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string columnName = reader.GetName(i);
                    object value = reader.GetValue(i);
                    data[columnName] = value;
                }
                dataList.Add(data); // Додаємо словник до списку
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Nie przewidziany warunek, proszę zrobić zdjęcie błędu i wysłać na adres yaroslavturbo13@gmail.com: \n" + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
        return dataList; // Повертаємо список словників
    }
    public static async Task<Dictionary<string, object>> LoadDataAsync(string fileNameDB, string tableName, Button button = null, string keyColumnName = null, object keyValue = null)
    {
        Cursor.Current = Cursors.WaitCursor;
        var data = new Dictionary<string, object>();
        string query;
        try
        {
            using SQLiteConnection conn = new($"Data Source={fileNameDB}.db;Version=3;New=False;Compress=True;");
            await conn.OpenAsync();

            if (!string.IsNullOrEmpty(keyColumnName) && keyValue != null)
            {
                query = $"SELECT * FROM {tableName} WHERE {keyColumnName} = @KeyValue";
            }
            else
            {
                query = $"SELECT * FROM {tableName}";
            }

            using SQLiteCommand cmd = new(query, conn);

            if (!string.IsNullOrEmpty(keyColumnName) && keyValue != null)
            {
                cmd.Parameters.AddWithValue("@KeyValue", keyValue);
            }

            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            if (!reader.HasRows)
            {
                if (button != null)
                {
                    button.Text = "Zapisz";
                }
                return data;
            }

            if (await reader.ReadAsync())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string columnName = reader.GetName(i);
                    object value = reader.GetValue(i);
                    data[columnName] = value;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Nie przewidziany warunek, proszę zrobić zdjęcie błędu i wysłać na adres yaroslavturbo13@gmail.com: \n" + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
        if (button != null)
        {
            button.Text = "Odśwież";
        }
        return data;
    }
    public static async Task<uint> CountDataAsync(string tableName)
    {
        Cursor.Current = Cursors.WaitCursor;
        uint count = 0; // Значення за замовчуванням
        try
        {
            using SQLiteConnection conn = new($"Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;");
            await conn.OpenAsync();

            // Використання параметра для уникнення SQL-ін'єкцій
            string query = $"SELECT COUNT(*) FROM \"{tableName}\"";

            using SQLiteCommand cmd = new(query, conn);

            object result = await cmd.ExecuteScalarAsync(); // Використовуємо ExecuteScalar для підрахунку
            if (result != null && uint.TryParse(result.ToString(), out uint parsedCount))
            {
                count = parsedCount; // Зберігаємо значення
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Nie przewidziany warunek, proszę zrobić zdjęcie błędu i wysłać na adres yaroslavturbo13@gmail.com: \n" + $"table name -> {tableName}" + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
        return count; // Повертаємо навіть якщо було виключення
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

            if (await reader.ReadAsync()) // Перевірка, чи є дані
            {
                marzha = Convert.ToDecimal(reader["Marża"]); // Отримання значення
            }
        }
        catch (Exception ex)
        {
            // Обробка виключення
            MessageBox.Show("Wystąpił błąd podczas pobierania wartości 'Marża': " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return marzha;
    }
    public static async Task<Guid> GetUniqueKey(string id, string table, string anotherConnection = null)
    {
        Guid uniqueKey = new();
        string connection;
        if (anotherConnection == null)
        {
            connection = _connectionString;
        }
        else
        {
            connection = anotherConnection;
        }
        try
        {
            using SQLiteConnection conn = new(connection);
            await conn.OpenAsync();

            using SQLiteCommand cmd = new($"SELECT UniqueKey FROM {table} WHERE ID=@ID", conn);

            cmd.Parameters.AddWithValue("@ID", id);
            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync()) // Перевірка, чи є дані
            {
                //string uniqueKeyString = reader["UniqueKey"].ToString();
                //MessageBox.Show($"{uniqueKeyString}");

                byte[] uniqueKeyBytes = (byte[])reader["UniqueKey"];
                uniqueKey = new Guid(uniqueKeyBytes);
            }
        }
        catch (Exception ex)
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
            foreach (var column in columns)
            {
                cmd.Parameters.AddWithValue("@" + column.Key, column.Value ?? DBNull.Value);
            }

            // Додаємо параметри для умов (наприклад, де саме слід оновлювати)
            foreach (var param in whereParams)
            {
                cmd.Parameters.AddWithValue("@" + param.Key, param.Value ?? DBNull.Value);
            }

            // Виконуємо команду оновлення
            await cmd.ExecuteNonQueryAsync();
            // Підтверджуємо транзакцію, якщо все пройшло успішно
            await transaction.CommitAsync();
            return true;
        }
        catch (Exception ex)
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

        while (await reader.ReadAsync())
        {
            if (reader[ColumnName] != DBNull.Value && !string.IsNullOrEmpty(reader[ColumnName].ToString()))
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
        foreach (var column in columns)
        {
            cmd.Parameters.AddWithValue($"@{column.Key}", column.Value ?? DBNull.Value);
        }
        using DbDataReader reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            if (reader[ColumnName] != DBNull.Value && !string.IsNullOrEmpty(reader[ColumnName].ToString()))
            {
                updateListBox.Items.Add(reader[ColumnName].ToString());
            }
        }
    }
    // Універсальний метод для видалення запису(ів) з будь-якої таблиці
    public static async Task<bool> DeleteRecordAsync(string fileName, string tableName, string whereClause, Dictionary<string, object> whereParams)
    {
        Cursor.Current = Cursors.WaitCursor;
        string connection = $"Data Source={fileName}.db;Version=3;New=False;Compress=True;";

        // Формуємо SQL-запит для видалення запису з бази даних
        var query = $"DELETE FROM {tableName} WHERE {whereClause}";

        using SQLiteConnection conn = new(connection);
        await conn.OpenAsync();

        // Використовуємо транзакцію для надійного виконання змін
        using var transaction = await conn.BeginTransactionAsync();
        try
        {
            using SQLiteCommand cmd = new(query, conn);

            // Додаємо параметри для умов (наприклад, що саме слід видаляти)
            foreach (var param in whereParams)
            {
                cmd.Parameters.AddWithValue("@" + param.Key, param.Value ?? DBNull.Value);
            }

            // Виконуємо команду видалення
            await cmd.ExecuteNonQueryAsync();
            // Підтверджуємо транзакцію, якщо все пройшло успішно
            await transaction.CommitAsync();
            return true;
        }
        catch (Exception ex)
        {
            // Відкочуємо транзакцію у разі виникнення помилки
            await transaction.RollbackAsync();
            MessageBox.Show("Wystąpił błąd przy usuwaniu rekordu: " + ex.Message);
            return false;
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
    }
    #endregion
    #region Read data 
    public static async Task LoadData(string cmd, DataGridView view, string categoryError, string textError, Dictionary<string, object> parameters = null, string anotherConnection = null)
    {
        Cursor.Current = Cursors.WaitCursor;
        string connection;
        if (anotherConnection == null)
        {
            connection = _connectionString;
        }
        else
        {
            connection = anotherConnection;
        }
        try
        {
            using SQLiteConnection conn = new(connection);
            await conn.OpenAsync();

            using SQLiteCommand command = new(cmd, conn);

            // Якщо є параметри, додаємо їх до команди
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            using SQLiteDataAdapter adapter = new(command);
            DataTable dataTable = new();
            await Task.Run(() => adapter.Fill(dataTable));
            view.DataSource = dataTable;


        }
        catch (Exception ex)
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
    public static async Task LoadBrands(ListBox listBox)
    {
        Cursor.Current = Cursors.WaitCursor;
        try
        {
            string query = "SELECT BrandName FROM Brands ORDER BY BrandName";

            using SQLiteConnection conn = new(_connectionStringCarDB);
            await conn.OpenAsync();

            using SQLiteCommand cmd = new(query, conn);
            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync()) // Читаємо кілька рядків
            {
                listBox.Items.Add(reader["BrandName"].ToString());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Nie przewidziany warunek: " + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }        
    }
    public static async Task LoadModels(ListBox listBox,string brandName)
    {
        Cursor.Current = Cursors.WaitCursor;
        try
        {
            listBox.Items.Clear();
            string query = "SELECT ModelName FROM Models WHERE BrandID = (SELECT BrandID FROM Brands WHERE BrandName = @brandName) ORDER BY ModelName";
            using SQLiteConnection conn = new(_connectionStringCarDB);
            await conn.OpenAsync();

            using SQLiteCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@brandName", brandName);

            using DbDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync()) // Читаємо кілька рядків
            {
                listBox.Items.Add(reader["ModelName"].ToString());
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show("Nie przewidziany warunek: " + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
    }
    public static async Task LoadEnginesAndYears(ListBox listbox0, ListBox listbox1, string modelName)
    {
        Cursor.Current = Cursors.WaitCursor;
        try
        {
            listbox0.Items.Clear();
            listbox1.Items.Clear();
            string query = @"SELECT DISTINCT EngineName, StartYear, EndYear FROM Generations g
                     JOIN Models m ON g.ModelID = m.ModelID
                     JOIN Engines e ON e.GenerationID = g.GenerationID
                     WHERE m.ModelName = @modelName ORDER BY StartYear";

            using SQLiteConnection conn = new(_connectionStringCarDB);
            await conn.OpenAsync();

            using SQLiteCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@modelName", modelName);
            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync()) // Читаємо кілька рядків
            {
                listbox0.Items.Add(reader["EngineName"].ToString());
                int startYear = Convert.ToInt32(reader["StartYear"]);
                int endYear = reader["EndYear"] != DBNull.Value ? Convert.ToInt32(reader["EndYear"]) : DateTime.Now.Year;

                for (int year = startYear; year <= endYear; year++)
                {
                    if (!listbox1.Items.Contains(year.ToString()))
                        listbox1.Items.Add(year.ToString());
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Nie przewidziany warunek: " + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
    }
    public static async Task LoadYears(ListBox yearListBox, string engineName, string modelName)
    {
        Cursor.Current = Cursors.WaitCursor;
        try
        {
            yearListBox.Items.Clear();
            string query = @"
            SELECT DISTINCT g.StartYear, g.EndYear 
            FROM Generations g
            JOIN Models m ON g.ModelID = m.ModelID
            JOIN Engines e ON e.GenerationID = g.GenerationID
            WHERE m.ModelName = @ModelName AND e.EngineName = @EngineName
            ORDER BY g.StartYear;";

            using SQLiteConnection conn = new(_connectionStringCarDB);
            await conn.OpenAsync();

            using SQLiteCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@ModelName", modelName);
            cmd.Parameters.AddWithValue("@EngineName", engineName);
            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync()) // Читаємо результати запиту
            {
                int startYear = Convert.ToInt32(reader["StartYear"]);
                int endYear = reader["EndYear"] != DBNull.Value ? Convert.ToInt32(reader["EndYear"]) : DateTime.Now.Year;

                for (int year = startYear; year <= endYear; year++)
                {
                    if (!yearListBox.Items.Contains(year.ToString()))
                        yearListBox.Items.Add(year.ToString());
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Nie przewidziany warunek: " + ex.Message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
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
            if (e.ColumnIndex == table.Columns[$"{nameButtonDel}"].Index && table.Rows[e.RowIndex].Cells[$"{cellID}"].Value != DBNull.Value)
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
    #region Send Data To Archive
    public static async Task<bool> SendToArchive(Guid uniqueKey)
    {
        Cursor.Current = Cursors.WaitCursor;
        var key = new Dictionary<string, object>
            {
                {"UniqueKey", uniqueKey}
            };
        string[] tables =
        {
        "Klienty",
        "Samochód",
        "NaprawaSamochodu",
        "HistoriaNapraw",
        "HistoriaUsług",
        "ZarządzanieZleceniem"
    };

        // Тепер зберігаємо дані (список рядків) для кожної таблиці
        var dataForTables = new Dictionary<string, List<Dictionary<string, object>>>();

        // Завантажуємо всі відповідні рядки з Архіву
        foreach (string table in tables)
        {
            dataForTables[table] = await LoadListAsync(
                pathName: "WarsztatDB",
                tableName: table,
                selectData: "*", // або перелік стовпців
                keyColumnName: "UniqueKey",
                keyValue: uniqueKey
            );
        }
        foreach (var row in dataForTables["ZarządzanieZleceniem"])
        {
            row["DataZamknięciaZlecenia"] = DateTime.Today.ToString("D");
        }


        try
        {
            bool allSucceeded = true;
            foreach (var table in tables)
            {
                var rows = dataForTables[table];

                // 1. Додаємо всі рядки
                foreach (var rowData in rows)
                {
                    bool isSucceed = await AddRecordAsync("Archive", table, rowData);
                    if (!isSucceed)
                    {
                        MessageBox.Show(
                            $"Błąd zapisu danych у таблиці {table} (UniqueKey: {uniqueKey})",
                            "Błąd",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        allSucceeded = false;
                        // Якщо не вдалося додати хоч один рядок — повертайте false
                        return false;
                    }
                }
                // 2. Якщо всі рядки успішно додані — видаляємо їх з архіву
                if (allSucceeded)
                {
                    foreach (string tableName in tables)
                    {
                        await DeleteRecordAsync("WarsztatDB", tableName, "UniqueKey=@UniqueKey", key);
                    }
                }
            }
            return true; // Усі операції пройшли успішно
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Nie przewidziany warunek w czasie zapisu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
    }
    public static async Task<bool> SendToArchiveOneTable(string ID)
    {
        Cursor.Current = Cursors.WaitCursor;
        var key = new Dictionary<string, object>
            {
            {"ID", ID}
            };
        var data = await LoadDataAsync("WarsztatDB", "Pracownicy", null, "ID", key);
        try
        {
            // Тепер можна перевірити, чи у всіх таблиць є записи
            bool allHaveData = data.Count > 0;
            if (allHaveData)
            {// Використовуємо отримані дані з відповідної таблиці
                bool isSucceed = await AddRecordAsync("Archive", "Pracownicy", data);
                if (isSucceed)
                {
                    await DeleteRecordAsync("WarsztatDB", "Pracownicy", "ID=@ID", key);

                    return true;  // Запис успішний
                }
            }
            return false;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Nie przewidziany warunek w czasie zapisu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
    }
    public static async Task<bool> RecoverData(Guid uniqueKey)
    {
        Cursor.Current = Cursors.WaitCursor;
        var key = new Dictionary<string, object>
            {
                {"UniqueKey", uniqueKey}
            };
        string[] tables =
        {
        "Klienty",
        "Samochód",
        "NaprawaSamochodu",
        "HistoriaNapraw",
        "HistoriaUsług",
        "ZarządzanieZleceniem"
    };

        // Тепер зберігаємо дані (список рядків) для кожної таблиці
        var dataForTables = new Dictionary<string, List<Dictionary<string, object>>>();

        // Завантажуємо всі відповідні рядки з Архіву
        foreach (string table in tables)
        {
            dataForTables[table] = await LoadListAsync(
                pathName: "Archive",
                tableName: table,
                selectData: "*", // або перелік стовпців
                keyColumnName: "UniqueKey",
                keyValue: uniqueKey
            );
        }

        try
        {
            foreach (var table in tables)
            {
                var rows = dataForTables[table];

                // 1. Додаємо всі рядки
                foreach (var rowData in rows)
                {
                    bool isSucceed = await AddRecordAsync("WarsztatDB", table, rowData);
                    if (!isSucceed)
                    {
                        MessageBox.Show(
                            $"Błąd zapisu danych у таблиці {table} (UniqueKey: {uniqueKey})",
                            "Błąd",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        // Якщо не вдалося додати хоч один рядок — повертайте false
                        return false;
                    }
                }

                // 2. Якщо всі рядки успішно додані — видаляємо їх з архіву
                await DeleteRecordAsync("Archive", table, "UniqueKey=@UniqueKey", key);
            }
            return true; // Усі операції пройшли успішно
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Nie przewidziany warunek w czasie zapisu danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
        }
    #endregion
    public static async Task<decimal> GetTotalEarningsForCurrentMonthAsync()
    {
        decimal totalEarnings = 0m;
        try
        {
            using SQLiteConnection conn = new("Data Source=Archive.db;Version=3;New=False;Compress=True;");
            await conn.OpenAsync();

            // Витягуємо всі записи (можна додати початкову приблизну фільтрацію, якщо потрібно)
            string query = "SELECT KosztPracyRęcznej, DataOczekiwaniaOdbioru FROM ZarządzanieZleceniem";

            using SQLiteCommand cmd = new(query, conn);
            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            // Отримуємо поточний рік та місяць
            int currentYear = DateTime.Today.Year;
            int currentMonth = DateTime.Today.Month;

            while (await reader.ReadAsync())
            {
                if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                {
                    decimal value = Convert.ToDecimal(reader["KosztPracyRęcznej"]);
                    string dateString = reader["DataOczekiwaniaOdbioru"].ToString();

                    var culture = new System.Globalization.CultureInfo("pl-PL");

                    if (DateTime.TryParse(dateString, culture,
                        System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    {
                        // Перевіряємо чи дата належить поточному місяцю та року
                        if (parsedDate.Year == currentYear && parsedDate.Month == currentMonth)
                        {
                            totalEarnings += value;
                        }
                    }
                    else
                    {
                        // Якщо дата не розпарсилась, можна або проігнорувати, або зробити логування помилки
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Nie przewidziany warunek, proszę zrobić zdjęcie błędu i wysłać na adres yaroslavturbo13@gmail.com: \n" + ex.Message,
                "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
        return totalEarnings;
    }
    public static async Task<decimal> GetTotalEarningsOnPartsForCurrentMonthAsync()
    {
        decimal totalEarnings = 0m;
        try
        {
            using SQLiteConnection conn = new("Data Source=Archive.db;Version=3;New=False;Compress=True;");
            await conn.OpenAsync();

            // Витягуємо всі записи (можна додати початкову приблизну фільтрацію, якщо потрібно)
            string query = "SELECT DochódZCzęści, DataZamknięciaZlecenia FROM ZarządzanieZleceniem";

            using SQLiteCommand cmd = new(query, conn);
            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            // Отримуємо поточний рік та місяць
            int currentYear = DateTime.Today.Year;
            int currentMonth = DateTime.Today.Month;

            while (await reader.ReadAsync())
            {
                if (!reader.IsDBNull(0) && !reader.IsDBNull(1))
                {
                    decimal value = Convert.ToDecimal(reader["DochódZCzęści"]);
                    string dateString = reader["DataZamknięciaZlecenia"].ToString();

                    var culture = new System.Globalization.CultureInfo("pl-PL");

                    if (DateTime.TryParse(dateString, culture,
                        System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    {
                        // Перевіряємо чи дата належить поточному місяцю та року
                        if (parsedDate.Year == currentYear && parsedDate.Month == currentMonth)
                        {
                            totalEarnings += value;
                        }
                    }
                    else
                    {
                        // Якщо дата не розпарсилась, можна або проігнорувати, або зробити логування помилки
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Nie przewidziany warunek, proszę zrobić zdjęcie błędu i wysłać na adres yaroslavturbo13@gmail.com: \n" + ex.Message,
                "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
        return totalEarnings;
    }
    public static async Task<decimal> GetTotalEarningsOnServicesForCurrentMonthAsync()
        {
        decimal totalEarnings = 0m;
        try
            {
            using SQLiteConnection conn = new("Data Source=Archive.db;Version=3;New=False;Compress=True;");
            await conn.OpenAsync();

            // Витягуємо всі записи (можна додати початкову приблизну фільтрацію, якщо потрібно)
            string query = "SELECT KosztUsługi, DataZamknięciaZlecenia FROM ZarządzanieZleceniem";

            using SQLiteCommand cmd = new(query, conn);
            using DbDataReader reader = await cmd.ExecuteReaderAsync();

            // Отримуємо поточний рік та місяць
            int currentYear = DateTime.Today.Year;
            int currentMonth = DateTime.Today.Month;

            while(await reader.ReadAsync())
                {
                if(!reader.IsDBNull(0) && !reader.IsDBNull(1))
                    {
                    decimal value = Convert.ToDecimal(reader["KosztUsługi"]);
                    string dateString = reader["DataZamknięciaZlecenia"].ToString();

                    var culture = new System.Globalization.CultureInfo("pl-PL");

                    if(DateTime.TryParse(dateString, culture,
                        System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                        {
                        // Перевіряємо чи дата належить поточному місяцю та року
                        if(parsedDate.Year == currentYear && parsedDate.Month == currentMonth)
                            {
                            totalEarnings += value;
                            }
                        }
                    else
                        {
                        // Якщо дата не розпарсилась, можна або проігнорувати, або зробити логування помилки
                        }
                    }
                }
            }
        catch(Exception ex)
            {
            MessageBox.Show("Nie przewidziany warunek, proszę zrobić zdjęcie błędu i wysłać na adres yaroslavturbo13@gmail.com: \n" + ex.Message,
                "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        finally
            {
            Cursor.Current = Cursors.Default;
            }
        return totalEarnings;
        }
    public static async Task<decimal> GetTotalDependecisForCurrentMonthAsync()
    {
        decimal totalEarnings = 0m;
        string[] dataWithFilter = { "StałeWydatkiFirmy", "WydatkiFirmy  WHERE date(substr(DataPotrącenia, 7, 4) || '-' || substr(DataPotrącenia, 4, 2) || '-' ||substr(DataPotrącenia, 1, 2))" +
                                                                          ">= date('now', 'start of month') AND date(substr(DataPotrącenia, 7, 4) || '-' || substr(DataPotrącenia, 4, 2) || '-' ||substr(DataPotrącenia, 1, 2)) < " +
                                                                          "date('now', 'start of month', '+1 month')" };
        try
        {
            using SQLiteConnection conn = new("Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;");
            await conn.OpenAsync();
            foreach (string data in dataWithFilter)
            {
                string query = $"SELECT CenaWydatku, DataPotrącenia FROM {data}";

                using SQLiteCommand cmd = new(query, conn);
                using DbDataReader reader = await cmd.ExecuteReaderAsync();


                while (await reader.ReadAsync())
                {
                    if (!reader.IsDBNull(0))
                    {
                        decimal value = Convert.ToDecimal(reader["CenaWydatku"]);

                        totalEarnings += value;
                    }
                }
            }

        }
        catch (Exception ex)
        {
            // Обробка виключення
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
        return totalEarnings;
    }
    public static async Task<decimal> GetTotalDependecisOfEmployerForCurrentMonthAsync()
    {
        decimal totalDependecis = 0m;

        try
        {
            using SQLiteConnection conn = new("Data Source=WarsztatDB.db;Version=3;New=False;Compress=True;");
            await conn.OpenAsync();

            string query = $"SELECT Zarobek FROM Pracownicy";

            using SQLiteCommand cmd = new(query, conn);
            using DbDataReader reader = await cmd.ExecuteReaderAsync();


            while (await reader.ReadAsync())
            {
                if (!reader.IsDBNull(0))
                {
                    decimal value = Convert.ToDecimal(reader["Zarobek"]);

                    totalDependecis += value;
                }
            }
        }
        catch (Exception ex)
        {
            // Обробка виключення
        }
        finally
        {
            Cursor.Current = Cursors.Default;
        }
        return totalDependecis;
    }
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
            if (reader.HasRows)//перевірка чи є стовпці в базі даних, якщо немає то код не буде засмічувати пам'ять коли не потрібно
            {
                while (await reader.ReadAsync())
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
}

