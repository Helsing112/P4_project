namespace ConsoleApplication5
{
    partial class TablesPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_OneTimePayment = new ConsoleApplication5.OneTimePaymentButton();
            this.Button_MoveContent = new ConsoleApplication5.TableManagementButtons();
            this.Button_MoveTable = new ConsoleApplication5.TableManagementButtons();
            this.Button_CombineTables = new ConsoleApplication5.TableManagementButtons();
            this.back_Button1 = new ConsoleApplication5.Back_Button();
            this.table_Panel_for_MainPage1 = new ConsoleApplication5.Table_Panel_for_MainPage();
            this.timerInfo1 = new ConsoleApplication5.TimerInfo();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button_OneTimePayment);
            this.panel1.Controls.Add(this.Button_MoveContent);
            this.panel1.Controls.Add(this.Button_MoveTable);
            this.panel1.Controls.Add(this.Button_CombineTables);
            this.panel1.Location = new System.Drawing.Point(9, 142);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 513);
            this.panel1.TabIndex = 8;
            // 
            // Button_OneTimePayment
            // 
            this.Button_OneTimePayment.BackColor = System.Drawing.Color.Transparent;
            this.Button_OneTimePayment.Image_set = null;
            this.Button_OneTimePayment.Location = new System.Drawing.Point(0, 49);
            this.Button_OneTimePayment.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Button_OneTimePayment.Name = "Button_OneTimePayment";
            this.Button_OneTimePayment.Size = new System.Drawing.Size(167, 88);
            this.Button_OneTimePayment.TabIndex = 7;
            this.Button_OneTimePayment.Textlabel = "QUICK BILL";
            // 
            // Button_MoveContent
            // 
            this.Button_MoveContent.BackColor = System.Drawing.Color.Transparent;
            this.Button_MoveContent.Image_set = null;
            this.Button_MoveContent.Location = new System.Drawing.Point(0, 412);
            this.Button_MoveContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_MoveContent.Name = "Button_MoveContent";
            this.Button_MoveContent.Size = new System.Drawing.Size(167, 88);
            this.Button_MoveContent.TabIndex = 4;
            this.Button_MoveContent.Textlabel = "MOVE CONTENT";
            this.Button_MoveContent.Button_Click += new System.EventHandler(this.Button_MoveContent_Button_Click_1);
            // 
            // Button_MoveTable
            // 
            this.Button_MoveTable.BackColor = System.Drawing.Color.Transparent;
            this.Button_MoveTable.Image_set = null;
            this.Button_MoveTable.Location = new System.Drawing.Point(0, 320);
            this.Button_MoveTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_MoveTable.Name = "Button_MoveTable";
            this.Button_MoveTable.Size = new System.Drawing.Size(167, 88);
            this.Button_MoveTable.TabIndex = 5;
            this.Button_MoveTable.Textlabel = "MOVE TABLE";
            // 
            // Button_CombineTables
            // 
            this.Button_CombineTables.BackColor = System.Drawing.Color.Transparent;
            this.Button_CombineTables.Image_set = null;
            this.Button_CombineTables.Location = new System.Drawing.Point(0, 228);
            this.Button_CombineTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_CombineTables.Name = "Button_CombineTables";
            this.Button_CombineTables.Size = new System.Drawing.Size(167, 88);
            this.Button_CombineTables.TabIndex = 6;
            this.Button_CombineTables.Textlabel = "COMBINE TABLES";
            // 
            // back_Button1
            // 
            this.back_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back_Button1.BackColor = System.Drawing.Color.Transparent;
            this.back_Button1.Image_set = null;
            this.back_Button1.Location = new System.Drawing.Point(1375, 775);
            this.back_Button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.back_Button1.Name = "back_Button1";
            this.back_Button1.Size = new System.Drawing.Size(154, 61);
            this.back_Button1.TabIndex = 2;
            this.back_Button1.Textlabel = "Back";
            // 
            // table_Panel_for_MainPage1
            // 
            this.table_Panel_for_MainPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_Panel_for_MainPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table_Panel_for_MainPage1.Location = new System.Drawing.Point(209, 57);
            this.table_Panel_for_MainPage1.Name = "table_Panel_for_MainPage1";
            this.table_Panel_for_MainPage1.Size = new System.Drawing.Size(1126, 779);
            this.table_Panel_for_MainPage1.TabIndex = 1;
            // 
            // timerInfo1
            // 
            this.timerInfo1.BackColor = System.Drawing.Color.White;
            this.timerInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerInfo1.employeename = null;
            this.timerInfo1.Location = new System.Drawing.Point(0, 0);
            this.timerInfo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timerInfo1.Name = "timerInfo1";
            this.timerInfo1.Size = new System.Drawing.Size(1546, 50);
            this.timerInfo1.TabIndex = 0;
            this.timerInfo1.tablename = null;
            // 
            // TablesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_Button1);
            this.Controls.Add(this.table_Panel_for_MainPage1);
            this.Controls.Add(this.timerInfo1);
            this.Name = "TablesPage";
            this.Size = new System.Drawing.Size(1546, 864);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public TimerInfo timerInfo1;
        public Table_Panel_for_MainPage table_Panel_for_MainPage1;
        public Back_Button back_Button1;
        public TableManagementButtons Button_MoveContent;
        public TableManagementButtons Button_MoveTable;
        public TableManagementButtons Button_CombineTables;
        public OneTimePaymentButton Button_OneTimePayment;
        private System.Windows.Forms.Panel panel1;
    }
}
