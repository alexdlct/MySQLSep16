﻿using MySQLSep16.Models;
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

        public void CreateTransaction(BankModel bT)
        {
            string sql = "INSERT INTO tx_history (`Amt`, `txDate`, `tx_type_typeID`) VALUES (@Amt, @txDate, @tx_type_typeID)";
            _db.SaveData(sql, bT);

        }

        public List<BankModel> ReadAllTransactions()
        {
            string sql = "SELECT * from tx_history";
            List<BankModel> bankTransactions = _db.LoadData<BankModel, dynamic>(sql, new { });
            return bankTransactions;
        }

        public BankModel ReadTransactionbyID(int id)
        {
            string sql = "SELECT * FROM tx_history WHERE txID = @txID";
            List<BankModel> transaction = _db.LoadData<BankModel, dynamic>(sql, new { txID = id });
            return transaction.FirstOrDefault(u => u.txID == id);
        }

        public List<BankModel> ReadAllTransactsWithType()
        {
            string sql = "SELECT tx_history.txID, tx_history.AMT, tx_history.txDate, tx_type.Type FROM tx_history INNER JOIN tx_type ON tx_history.tx_type_typeID=tx_type.typeID";

            List<BankModel> bankTransaction = _db.LoadData<BankModel, dynamic>(sql, new { });
            return bankTransaction;
        }


    }
}
