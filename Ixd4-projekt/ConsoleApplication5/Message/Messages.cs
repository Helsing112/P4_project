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

        #region Table management messages--------------------------------------------------------------------
        public static void ConfirmTableBeenSaved() { Message_box.Message("Table setting has been saved", 1); }
        public static void TableTypeSaveNoNameDenied() { Message_box.Message("Your table type needs to have a name", -1); }
        public static void TableTypeSaveConfirmation() { Message_box.Message("Your table type has been saved", 1); }
        public static void ConfirmRestPlanSaved() { Message_box.Message("The resturant plan has been saved", 1); }
        #endregion

        public static void CategoryCreated() { Message_box.Message("Category Created", 1); }

        public static void CategoryCreated(Product inputProduct) { Message_box.Message(inputProduct.Name + " Added" + "\n" + "Price: " + inputProduct.Price, 1); }
        public static void WrongPassword() { Message_box.Message("Wrong Password", -1); }


        public static void ConfirmedAddProduct() { Message_box.Message("Product has been added", 1);  }
        public static void ConfirmedAddCategory() { Message_box.Message("Category has been added", 1);  }
    }

}
