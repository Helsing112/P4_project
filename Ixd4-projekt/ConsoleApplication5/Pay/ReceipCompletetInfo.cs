
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class ReceiptCompleteInfo
    {
        public List<ReceiptProduct> ProductList { get;private set; }
        public Table_Info Table { get; private set; }
        public Employee Employee { get; private set; }

        public ReceiptCompleteInfo(List<ReceiptProduct> List, Table_Info CurrentTable, Employee CurrentEmployee)
        {
            this.ProductList = List;
            this.Employee = CurrentEmployee;
            this.Table = CurrentTable;
        }
    }
}
