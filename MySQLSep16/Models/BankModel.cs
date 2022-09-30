using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLSep16.Models
{
    internal class BankModel
    {
        public int txID { get; set; }
        public decimal Amt { get; set; }
        public DateTime txDate { get; set; }
        public int tx_type_typeID { get; set; }
        //Change to Type in conjunction with creating join and new SQL
        //public string Type { get; set; }
        //Add ToString()
        public override string ToString()
        {
            string output = $"Transaction Detail\nDate: {txDate}\nType:{tx_type_typeID}\nAmount:{Amt}";
            return output;
        }

    }

 }

