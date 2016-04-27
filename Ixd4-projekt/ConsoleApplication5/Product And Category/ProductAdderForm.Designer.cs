namespace ConsoleApplication5
{
    partial class ProductAdderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_ChooseLogo = new ConsoleApplication5.Pay_Button();
            this.Button_ChooseWithImage = new ConsoleApplication5.Pay_Button();
            this.Button_ChooseNoImage = new ConsoleApplication5.Pay_Button();
            this.Label_ChooseStyle = new ConsoleApplication5.Standard_Label();
            this.Button_other = new ConsoleApplication5.Pay_Button();
            this.Button_Drinks = new ConsoleApplication5.Pay_Button();
            this.Button_food = new ConsoleApplication5.Pay_Button();
            this.Label_Headline = new ConsoleApplication5.Standard_Label();
            this.superClassProductViewer1 = new ConsoleApplication5.SuperClassProductViewer();
            this.Button_AddPicture = new ConsoleApplication5.Add_Button();
            this.Button_AddProduct = new ConsoleApplication5.Save_Create_Button();
            this.pictureBox_ChooseImage = new System.Windows.Forms.PictureBox();
            this.Label_ChooseImage = new ConsoleApplication5.Standard_Label();
            this.Button_AddCategory = new ConsoleApplication5.Add_Button();
            this.TextBox_PriceInput = new System.Windows.Forms.TextBox();
            this.label_choosePrice = new System.Windows.Forms.Label();
            this.TextBox_nameInput = new System.Windows.Forms.TextBox();
            this.Label_ChooseName = new System.Windows.Forms.Label();
            this.Button_Quit = new ConsoleApplication5.Quit_Close_Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChooseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_ChooseLogo
            // 
            this.Button_ChooseLogo.BackColor = System.Drawing.Color.Transparent;
            this.Button_ChooseLogo.Image_set = null;
            this.Button_ChooseLogo.Location = new System.Drawing.Point(275, 216);
            this.Button_ChooseLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_ChooseLogo.Name = "Button_ChooseLogo";
            this.Button_ChooseLogo.Size = new System.Drawing.Size(128, 50);
            this.Button_ChooseLogo.TabIndex = 8;
            this.Button_ChooseLogo.Textlabel = "Logo";
            // 
            // Button_ChooseWithImage
            // 
            this.Button_ChooseWithImage.BackColor = System.Drawing.Color.Transparent;
            this.Button_ChooseWithImage.Image_set = null;
            this.Button_ChooseWithImage.Location = new System.Drawing.Point(141, 216);
            this.Button_ChooseWithImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_ChooseWithImage.Name = "Button_ChooseWithImage";
            this.Button_ChooseWithImage.Size = new System.Drawing.Size(128, 50);
            this.Button_ChooseWithImage.TabIndex = 7;
            this.Button_ChooseWithImage.Textlabel = "Image";
            // 
            // Button_ChooseNoImage
            // 
            this.Button_ChooseNoImage.BackColor = System.Drawing.Color.Transparent;
            this.Button_ChooseNoImage.Image_set = null;
            this.Button_ChooseNoImage.Location = new System.Drawing.Point(7, 216);
            this.Button_ChooseNoImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_ChooseNoImage.Name = "Button_ChooseNoImage";
            this.Button_ChooseNoImage.Size = new System.Drawing.Size(128, 50);
            this.Button_ChooseNoImage.TabIndex = 6;
            this.Button_ChooseNoImage.Textlabel = "No Image";
            // 
            // Label_ChooseStyle
            // 
            this.Label_ChooseStyle.AutoSize = true;
            this.Label_ChooseStyle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_ChooseStyle.ForeColor = System.Drawing.Color.White;
            this.Label_ChooseStyle.Location = new System.Drawing.Point(118, 158);
            this.Label_ChooseStyle.Name = "Label_ChooseStyle";
            this.Label_ChooseStyle.Size = new System.Drawing.Size(165, 35);
            this.Label_ChooseStyle.TabIndex = 5;
            this.Label_ChooseStyle.Text = "Choose Style";
            // 
            // Button_other
            // 
            this.Button_other.BackColor = System.Drawing.Color.Transparent;
            this.Button_other.Image_set = null;
            this.Button_other.Location = new System.Drawing.Point(275, 89);
            this.Button_other.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_other.Name = "Button_other";
            this.Button_other.Size = new System.Drawing.Size(128, 50);
            this.Button_other.TabIndex = 4;
            this.Button_other.Textlabel = "Other";
            // 
            // Button_Drinks
            // 
            this.Button_Drinks.BackColor = System.Drawing.Color.Transparent;
            this.Button_Drinks.Image_set = null;
            this.Button_Drinks.Location = new System.Drawing.Point(141, 89);
            this.Button_Drinks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Drinks.Name = "Button_Drinks";
            this.Button_Drinks.Size = new System.Drawing.Size(128, 50);
            this.Button_Drinks.TabIndex = 3;
            this.Button_Drinks.Textlabel = "Drinks";
            // 
            // Button_food
            // 
            this.Button_food.BackColor = System.Drawing.Color.Transparent;
            this.Button_food.Image_set = null;
            this.Button_food.Location = new System.Drawing.Point(7, 89);
            this.Button_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_food.Name = "Button_food";
            this.Button_food.Size = new System.Drawing.Size(128, 50);
            this.Button_food.TabIndex = 2;
            this.Button_food.Textlabel = "Food";
            // 
            // Label_Headline
            // 
            this.Label_Headline.AutoSize = true;
            this.Label_Headline.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_Headline.ForeColor = System.Drawing.Color.White;
            this.Label_Headline.Location = new System.Drawing.Point(42, 25);
            this.Label_Headline.Name = "Label_Headline";
            this.Label_Headline.Size = new System.Drawing.Size(325, 35);
            this.Label_Headline.TabIndex = 1;
            this.Label_Headline.Text = "Add a product or category";
            // 
            // superClassProductViewer1
            // 
            this.superClassProductViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.superClassProductViewer1.Location = new System.Drawing.Point(422, 4);
            this.superClassProductViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.superClassProductViewer1.Name = "superClassProductViewer1";
            this.superClassProductViewer1.Size = new System.Drawing.Size(753, 758);
            this.superClassProductViewer1.TabIndex = 0;
            // 
            // Button_AddPicture
            // 
            this.Button_AddPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_AddPicture.BackColor = System.Drawing.Color.Transparent;
            this.Button_AddPicture.Image_set = null;
            this.Button_AddPicture.Location = new System.Drawing.Point(10, 599);
            this.Button_AddPicture.Margin = new System.Windows.Forms.Padding(4);
            this.Button_AddPicture.Name = "Button_AddPicture";
            this.Button_AddPicture.Size = new System.Drawing.Size(172, 74);
            this.Button_AddPicture.TabIndex = 24;
            this.Button_AddPicture.Textlabel = "Add image";
            // 
            // Button_AddProduct
            // 
            this.Button_AddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_AddProduct.BackColor = System.Drawing.Color.Transparent;
            this.Button_AddProduct.Image_set = null;
            this.Button_AddProduct.Location = new System.Drawing.Point(10, 771);
            this.Button_AddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.Button_AddProduct.Name = "Button_AddProduct";
            this.Button_AddProduct.Size = new System.Drawing.Size(173, 74);
            this.Button_AddProduct.TabIndex = 25;
            this.Button_AddProduct.Textlabel = "Add Product";
            // 
            // pictureBox_ChooseImage
            // 
            this.pictureBox_ChooseImage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox_ChooseImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_ChooseImage.ErrorImage = global::ConsoleApplication5.Properties.Resources.placeholder;
            this.pictureBox_ChooseImage.Image = global::ConsoleApplication5.Properties.Resources.placeholder;
            this.pictureBox_ChooseImage.ImageLocation = "@\"C:\\Users\\kranzekage\\Source\\Repos\\P4_project\\PictureLibrary\"";
            this.pictureBox_ChooseImage.InitialImage = null;
            this.pictureBox_ChooseImage.Location = new System.Drawing.Point(188, 559);
            this.pictureBox_ChooseImage.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_ChooseImage.Name = "pictureBox_ChooseImage";
            this.pictureBox_ChooseImage.Size = new System.Drawing.Size(215, 156);
            this.pictureBox_ChooseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ChooseImage.TabIndex = 23;
            this.pictureBox_ChooseImage.TabStop = false;
            // 
            // Label_ChooseImage
            // 
            this.Label_ChooseImage.AutoSize = true;
            this.Label_ChooseImage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Label_ChooseImage.ForeColor = System.Drawing.Color.White;
            this.Label_ChooseImage.Location = new System.Drawing.Point(97, 292);
            this.Label_ChooseImage.Name = "Label_ChooseImage";
            this.Label_ChooseImage.Size = new System.Drawing.Size(0, 35);
            this.Label_ChooseImage.TabIndex = 26;
            // 
            // Button_AddCategory
            // 
            this.Button_AddCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_AddCategory.BackColor = System.Drawing.Color.Transparent;
            this.Button_AddCategory.Image_set = null;
            this.Button_AddCategory.Location = new System.Drawing.Point(220, 771);
            this.Button_AddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.Button_AddCategory.Name = "Button_AddCategory";
            this.Button_AddCategory.Size = new System.Drawing.Size(172, 74);
            this.Button_AddCategory.TabIndex = 27;
            this.Button_AddCategory.Textlabel = "Add Category";
            // 
            // TextBox_PriceInput
            // 
            this.TextBox_PriceInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox_PriceInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_PriceInput.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_PriceInput.Location = new System.Drawing.Point(162, 442);
            this.TextBox_PriceInput.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_PriceInput.Name = "TextBox_PriceInput";
            this.TextBox_PriceInput.Size = new System.Drawing.Size(177, 34);
            this.TextBox_PriceInput.TabIndex = 30;
            // 
            // label_choosePrice
            // 
            this.label_choosePrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_choosePrice.AutoSize = true;
            this.label_choosePrice.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label_choosePrice.ForeColor = System.Drawing.Color.White;
            this.label_choosePrice.Location = new System.Drawing.Point(55, 433);
            this.label_choosePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_choosePrice.Name = "label_choosePrice";
            this.label_choosePrice.Size = new System.Drawing.Size(99, 46);
            this.label_choosePrice.TabIndex = 31;
            this.label_choosePrice.Text = "Price";
            this.label_choosePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox_nameInput
            // 
            this.TextBox_nameInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextBox_nameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_nameInput.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_nameInput.Location = new System.Drawing.Point(124, 374);
            this.TextBox_nameInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TextBox_nameInput.Name = "TextBox_nameInput";
            this.TextBox_nameInput.Size = new System.Drawing.Size(279, 34);
            this.TextBox_nameInput.TabIndex = 28;
            // 
            // Label_ChooseName
            // 
            this.Label_ChooseName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label_ChooseName.AutoSize = true;
            this.Label_ChooseName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.Label_ChooseName.ForeColor = System.Drawing.Color.White;
            this.Label_ChooseName.Location = new System.Drawing.Point(8, 365);
            this.Label_ChooseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_ChooseName.Name = "Label_ChooseName";
            this.Label_ChooseName.Size = new System.Drawing.Size(114, 46);
            this.Label_ChooseName.TabIndex = 29;
            this.Label_ChooseName.Text = "Name";
            this.Label_ChooseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Quit
            // 
            this.Button_Quit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Quit.Image_set = null;
            this.Button_Quit.Location = new System.Drawing.Point(979, 771);
            this.Button_Quit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Quit.Name = "Button_Quit";
            this.Button_Quit.Size = new System.Drawing.Size(166, 74);
            this.Button_Quit.TabIndex = 32;
            this.Button_Quit.Textlabel = "Quit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductAdderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 854);
            this.Controls.Add(this.Button_Quit);
            this.Controls.Add(this.TextBox_PriceInput);
            this.Controls.Add(this.label_choosePrice);
            this.Controls.Add(this.TextBox_nameInput);
            this.Controls.Add(this.Label_ChooseName);
            this.Controls.Add(this.Button_AddCategory);
            this.Controls.Add(this.Label_ChooseImage);
            this.Controls.Add(this.Button_AddPicture);
            this.Controls.Add(this.Button_AddProduct);
            this.Controls.Add(this.pictureBox_ChooseImage);
            this.Controls.Add(this.Button_ChooseLogo);
            this.Controls.Add(this.Button_ChooseWithImage);
            this.Controls.Add(this.Button_ChooseNoImage);
            this.Controls.Add(this.Label_ChooseStyle);
            this.Controls.Add(this.Button_other);
            this.Controls.Add(this.Button_Drinks);
            this.Controls.Add(this.Button_food);
            this.Controls.Add(this.Label_Headline);
            this.Controls.Add(this.superClassProductViewer1);
            this.Name = "ProductAdderForm";
            this.Text = "ProductAdderForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ChooseImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperClassProductViewer superClassProductViewer1;
        private Standard_Label Label_Headline;
        private Pay_Button Button_food;
        private Pay_Button Button_Drinks;
        private Pay_Button Button_other;
        private Standard_Label Label_ChooseStyle;
        private Pay_Button Button_ChooseNoImage;
        private Pay_Button Button_ChooseWithImage;
        private Pay_Button Button_ChooseLogo;
        private Add_Button Button_AddPicture;
        private Save_Create_Button Button_AddProduct;
        private System.Windows.Forms.PictureBox pictureBox_ChooseImage;
        private Standard_Label Label_ChooseImage;
        private Add_Button Button_AddCategory;
        private System.Windows.Forms.TextBox TextBox_PriceInput;
        private System.Windows.Forms.Label label_choosePrice;
        private System.Windows.Forms.TextBox TextBox_nameInput;
        private System.Windows.Forms.Label Label_ChooseName;
        private Quit_Close_Button Button_Quit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}