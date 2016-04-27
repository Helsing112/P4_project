using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public partial class TEST : UserControl
    {
        public TEST()
        {
            InitializeComponent();
            initializeProductViewers();
        }

        private void initializeProductViewers()
        {
            ProductView_Drinks.initializeFlowOfProducts(Properties.Resources.LocationOfProductLib + Properties.Resources.DrinkLibFile);
            ProductView_Foods.initializeFlowOfProducts(Properties.Resources.LocationOfProductLib + Properties.Resources.FoodLibFile);
        }

        private void superClassProduct1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
