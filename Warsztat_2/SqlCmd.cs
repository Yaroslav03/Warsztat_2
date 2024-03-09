using System.Data;
using System.Data.SQLite;
using Warsztat_2._0;
internal class SqlCmd
{

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
            dataError.Enqueue($"idToDelete:{table.Rows[e.RowIndex].Cells[$"{cellID}"].Value.ToString()}");

            await Settings.Error(ex, dataError, $"{table}", "problem with deleting records");
        }
        Cursor.Current = Cursors.Default;
    }
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

    public static bool DataExistsRead(SQLiteDataReader reader)
    {
        return reader.Read();
    }
    public static async Task<bool> TableExistHistory(string path, string tableName)
    {
        using SQLiteConnection conn = new(path);
        await conn.OpenAsync();
        using SQLiteCommand search = new($"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}'", conn);

        string? result = (string?)await search.ExecuteScalarAsync();
        return result != null && result.ToString() == tableName;
    }
    public static async Task<bool> TableExist(string path, string tableName)
    {
        using SQLiteConnection conn = new(path);
        await conn.OpenAsync();
        using SQLiteCommand search = new($"SELECT name FROM sqlite_master WHERE type='table' AND name='{tableName}'", conn);

        string? result = (string?)await search.ExecuteScalarAsync();
        return result != null && result.ToString() == tableName;
    }
}