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
            Flow_FoodCats.initializeFlowOfProducts(Properties.Resources.LocationOfProductLib + Properties.Resources.DrinkLibFile);
            Flow_DrinksCats.initializeFlowOfProducts(Properties.Resources.LocationOfProductLib + Properties.Resources.FoodLibFile);

            InitializeProductNavi();

            Flow_DrinksCats.CategoryClicked += Flow_DrinksCats_CategoryClicked;
            Flow_FoodCats.CategoryClicked += Flow_FoodCats_CategoryClicked;
        }

        private void InitializeProductNavi()
        {
            ProductNavigator = new SuperClassProductViewer();
            ProductNavigator.Size = new Size(Flow_DrinksCats.Width + Flow_FoodCats.Width, Flow_FoodCats.Height);
            ProductNavigator.Location = Flow_FoodCats.Location;

            Label_HeadlineProductNavigator = new Standard_Label();
            this.Label_HeadlineProductNavigator.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_HeadlineProductNavigator.ForeColor = System.Drawing.Color.Black;
            this.Label_HeadlineProductNavigator.Location = new System.Drawing.Point(ProductNavigator.Location.X, ProductNavigator.Location.Y - Label_HeadLineFood.Height);
            this.Label_HeadlineProductNavigator.Name = "Label_HeadlineProductNavigator";
            this.Label_HeadlineProductNavigator.Size = new System.Drawing.Size(ProductNavigator.Width, Label_HeadLineFood.Height);
            this.Label_HeadlineProductNavigator.Text = "asdasdasd";
            this.Label_HeadlineProductNavigator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void Flow_FoodCats_CategoryClicked(object sender, EventArgs e)
        {
            SuperClassCategory temp = (SuperClassCategory)sender;
            drawProductNavi(temp.Category);
        }

        private void Flow_DrinksCats_CategoryClicked(object sender, EventArgs e)
        {
            SuperClassCategory temp = (SuperClassCategory)sender;
            drawProductNavi(temp.Category);
        }
        public void resetProductViewers()
        {
            Label_HeadlineProductNavigator.Parent = ProductNavigator.Parent = null;
            Controls.Add(Flow_DrinksCats);
            Controls.Add(Flow_FoodCats);
            Controls.Add(Label_HeadlineDrinks);
            Controls.Add(Label_HeadLineFood);
        }
        private void drawProductNavi(CategoryNew inputCat)
        {
            Flow_FoodCats.Parent = null;
            Flow_DrinksCats.Parent = null;
            Label_HeadlineDrinks.Parent = Label_HeadLineFood.Parent = null;


            ProductNavigator.InitializeFlowOfProductsFromCat(inputCat);
            Label_HeadlineProductNavigator.Text = inputCat.Name;

            Controls.Add(ProductNavigator);
            Controls.Add(Label_HeadlineProductNavigator);
        }

        public SuperClassProductViewer ProductNavigator;
        public Standard_Label Label_HeadlineProductNavigator;


    }
}
