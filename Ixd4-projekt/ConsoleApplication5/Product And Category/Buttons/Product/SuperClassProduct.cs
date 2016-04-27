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
    public partial class SuperClassProduct : Std_Button
    {
        public Product Product { get; set; }
        public SuperClassProduct()
        {
            //throw new WarningException("This Ctor may not be used");
        }
        public SuperClassProduct(Product Product)
        {
            this.Product = Product;
            this.MouseDown += OnMouseDown;
            this.MouseUp += OnMouseUp;
            this.label1.MouseDown += OnMouseDown;
            this.label1.MouseUp += OnMouseUp;
        }
        public event EventHandler<ProductEventArgs> MouseUpped;
        public event EventHandler<ProductEventArgs> MouseDowned;

        internal void OnMouseUp(object sender, MouseEventArgs e)
        {
            if(MouseUpped != null)
            {
                MouseUpped(this, new ProductEventArgs() { product = this.Product});
            }
        }
        internal void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (MouseDowned != null)
            {
                MouseDowned(this, new ProductEventArgs() { product = this.Product });
            }
        }
    }
}
