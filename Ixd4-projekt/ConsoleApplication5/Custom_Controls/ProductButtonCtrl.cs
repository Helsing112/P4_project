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
    public partial class ProductButtonCtrl <T> : UserControl where T : Product
    {
        private T _product;
        public ProductButtonCtrl(T product)
        {
            _product = product;
            InitializeComponent(product);
            
        }
        public EventHandler<ProductEventArgs> MouseClicked;

        private void TypeButtonCtrl_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClicked(_product);
        }

        protected virtual void OnMouseClicked(T product)
        {
            if(MouseClicked != null)
            {
                MouseClicked(this, new ProductEventArgs() { product = product });
            }
        }

        private void MAD_Click(object sender, EventArgs e)
        {
            OnMouseClicked(_product);
        }
    }
}
