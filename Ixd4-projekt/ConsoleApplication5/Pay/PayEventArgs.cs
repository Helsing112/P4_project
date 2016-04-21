using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class PayEventArgs : EventArgs
    {
        public List<ReceiptProduct> BoughtProducts { get; set; }
        public Table_Info ActiveTable { get; set; }
    }
}
