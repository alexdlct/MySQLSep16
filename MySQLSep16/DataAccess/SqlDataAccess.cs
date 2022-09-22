using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLSep16.DataAccess
{
    internal class SqlDataAccess : ISqlDataAccess
    {
        private string connectionString = "server=localhost;port=3306;uid=appDev;pwd=AppDev22;database=db_garage;";

        //T = Type, U = parameters
        public List<T> LoadData<T, U>(string sql, U paramaters)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                //var catches all kinds of data types
                var data = connection.Query<T>(sql, paramaters);
                return data.ToList();
            }
        }
        //Save is equal to changing/adding/deleting
        public void SaveData<T>(string sql, T parameters)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.Execute(sql, parameters);
            }
        }

    }
}
