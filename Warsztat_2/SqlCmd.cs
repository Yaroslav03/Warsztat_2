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
}