using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Messages
    {
        public static void ConfirmedAddEmployeees() { Message_box.Message("Employee has been added", 1); }
        public static void ConfirmTableBeenSaved() { Message_box.Message("Table setting has been saved", 1); }
    }
}
