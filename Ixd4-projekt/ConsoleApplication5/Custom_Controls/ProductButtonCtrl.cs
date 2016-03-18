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
        public EventHandler<ProductEventArgs> MouseDowned;

        private void TypeButtonCtrl_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDowned(_product);
        }

        protected virtual void OnMouseDowned(T product)
        {
            if(MouseDowned != null)
            {
                MouseDowned(this, new ProductEventArgs() { product = product });
            }
        }

        public EventHandler<ProductEventArgs> MouseUpped;

        private void TypeButtonCtrl_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUpped(_product);
        }

        protected virtual void OnMouseUpped(T product)
        {
            if (MouseUpped != null)
            {
                MouseUpped(this, new ProductEventArgs() { product = product });
            }
        }
    }
}
