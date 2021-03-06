﻿using System;
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
        public static void TableTypeSaveNoNameDenied() { Message_box.Message("Your table needs to have a name or number", -1); }
        public static void TableTypeSaveConfirmation() { Message_box.Message("Your table type has been saved", 1); }
        public static void ConfirmRestPlanSaved() { Message_box.Message("The resturant plan has been saved", 1); }
        #endregion
        public static void DenyProductOrCatNoName(string ProductOrCat) { Message_box.Message($"The {ProductOrCat} needs to have a name", -1); }
        public static void DenyProductNoPrice() { Message_box.Message("The product needs to have a price", -1); }

        public static void IdAlreadyExists() { Message_box.Message("The ID is already assigned to another employee", -1);}
        public static void CategoryCreated() { Message_box.Message("Category Created", 1); }

        public static void CategoryCreated(Product inputProduct) { Message_box.Message(inputProduct.Name + " Added" + "\n" + "Price: " + inputProduct.Price, 1); }
        public static void WrongPassword() { Message_box.Message("Wrong Password", -1); }

        public static void ConfirmedAddProduct() { Message_box.Message("Product has been added", 1);  }
        public static void ConfirmedAddCategory() { Message_box.Message("Category has been added", 1);  }

        public static void EmployeeConfirmedLogin() { Message_box.Message("Employee signed in", 1);}
        

        public static void PrinterError() { Message_box.Message(("The printer was not found"));}

        internal static void DenyProductPriceFormat() { Message_box.Message("Product Price is wrong format", -1); }

        public static void CommentAdded() { Message_box.Message("Added a comment for the kitchen", 1); }

        public static void EmployeeAlreadySignedIn() { Message_box.Message("A employee with that ID is already signed in", -1); }

        public  static  void TableHasNoReceiptError() { Message_box.Message("The table you have chosen is not occupied", -1);}

        public static void MoveToTableIsAlreadyOccupedError() { Message_box.Message("The Table that you want to move to is already occupied", -1);}

        public static void ConfirmMovedTable(Table_Info tableInfo)
        {
            Message_box.Message($"The guests has been moved to table {tableInfo.Table_name}", 1);
        }
        public static void AllProductsHasBeenPaid() { Message_box.Message("The bill has been paid", 1);}

        public static void ConfirmSendToKitchen()
        {
            Message_box.Message($"The order has been send to the kitchen", 1);
        }
    }

}
