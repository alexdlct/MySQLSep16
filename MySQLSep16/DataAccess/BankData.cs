using MySQLSep16.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLSep16.DataAccess
{
    internal class BankData
    {
        private readonly ISqlDataAccess _db = new SqlDataAccess();
        public List<BankModel> GetAllTransactions()
        {
            string sql = "SELECT * from tx_history";
            List<BankModel> txs = _db.LoadData<BankModel, dynamic>(sql, new { });
            return txs;
        }


    }
}
