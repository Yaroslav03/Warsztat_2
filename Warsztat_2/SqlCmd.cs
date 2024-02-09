using System.Data.SQLite;
internal class SqlCmd
    {
    
    public static async Task DeleteDataTable(DataGridView table, DataGridViewCellEventArgs e, string path, string nameButtonDel, string cellID, string nameTable)
    {
        Cursor.Current = Cursors.WaitCursor;

        if (e.ColumnIndex == table.Columns[$"{nameButtonDel}"].Index && table.Rows[e.RowIndex].Cells[$"{cellID}"].Value != DBNull.Value)
        {
            long idToDelete = (long)table.Rows[e.RowIndex].Cells[$"{cellID}"].Value;
            using SQLiteConnection conn = new(path);
            await conn.OpenAsync();

            using var transaction = conn.BeginTransaction();

            using SQLiteCommand delete = new($"DELETE FROM {nameTable} WHERE ID=@ID", conn);
            delete.Parameters.AddWithValue("ID", idToDelete);

            await delete.ExecuteNonQueryAsync();
            await transaction.CommitAsync();

            table.Rows.RemoveAt(e.RowIndex);

            idToDelete = 0;
        }
        Cursor.Current = Cursors.Default;
    }
    }