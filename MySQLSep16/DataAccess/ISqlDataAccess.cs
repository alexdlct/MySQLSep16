namespace MySQLSep16.DataAccess
{
    internal interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string sql, U paramaters);
        void SaveData<T>(string sql, T parameters);
    }
}