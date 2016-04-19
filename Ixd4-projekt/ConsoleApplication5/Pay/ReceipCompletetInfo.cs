
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class ReceiptCompleteInfo
    {
        public Table_Info Table { get; private set; }
        public Employee Employee { get; private set; }

        public ReceiptCompleteInfo(Table_Info CurrentTable, Employee CurrentEmployee)
        {
            this.Employee = CurrentEmployee;
            this.Table = CurrentTable;
        }
    }
}
