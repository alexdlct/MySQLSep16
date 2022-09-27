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
        public string txDate { get; set; }
        public int tx_type_typeID { get; set; }
        public int typeID { get; set; }
        public string DataType { get; set; }
    }

 }

