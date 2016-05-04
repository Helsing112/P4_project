using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ConsoleApplication5
{
    public partial class TEST : UserControl
    {
        public CategoryNew OtherCategory { get; set; }
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

            InitializeOtherProducts();

            Flow_DrinksCats.CategoryClicked += Flow_DrinksCats_CategoryClicked;
            Flow_FoodCats.CategoryClicked += Flow_FoodCats_CategoryClicked;
        }

        private void InitializeOtherProducts()
        {
            XmlProductReader reader = new XmlProductReader();
            OtherCategory = reader.Read_product<CategoryNew>(Properties.Resources.LocationOfProductLib+Properties.Resources.OtherLibFile);
        }

        private void InitializeProductNavi()
        {
            ProductNavigator = new SuperClassProductViewer();
            ProductNavigator.Size = new Size(Flow_DrinksCats.Width + Flow_FoodCats.Width, Flow_FoodCats.Height);
            ProductNavigator.Location = Label_HeadLineFood.Location;
            ProductNavigator.BackColor = Flow_FoodCats.BackColor;

            ProductNavigator.back_Button1.Button_Click += BackButton1OnButtonClick;
        }

        private void BackButton1OnButtonClick(object sender, EventArgs eventArgs)
        {
            resetProductViewers();
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
            ProductNavigator.Parent = null;
            Controls.Add(Flow_DrinksCats);
            Controls.Add(Flow_FoodCats);
            Controls.Add(Label_HeadlineDrinks);
            Controls.Add(Label_HeadLineFood);
            Controls.Add(Button_OtherLibrary);
        }
        private void drawProductNavi(CategoryNew inputCat)
        {
            Flow_FoodCats.Parent = null;
            Flow_DrinksCats.Parent = null;
            Label_HeadlineDrinks.Parent = Label_HeadLineFood.Parent = Button_OtherLibrary.Parent = null;


            ProductNavigator.InitializeFlowOfProductsFromCat(inputCat);

            Controls.Add(ProductNavigator);
        }

        public SuperClassProductViewer ProductNavigator;

        private void Button_OtherLibrary_Button_Click(object sender, EventArgs e)
        {
            drawProductNavi(OtherCategory);
        }
    }
}
