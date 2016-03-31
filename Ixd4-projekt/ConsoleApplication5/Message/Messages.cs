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
        public static void CategoryCreated() { Message_box.Message("Category Created", 1); }

        public static void CategoryCreated(Product inputProduct) { Message_box.Message(inputProduct.Name + " Added" + "\n" + "Price: " + inputProduct.Price, 1); }
        public static void WrongPassword() { Message_box.Message("Wrong Password", -1); }


    }

}
