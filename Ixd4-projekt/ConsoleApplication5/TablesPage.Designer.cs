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
            this.Button_CombineTables = new ConsoleApplication5.TableManagementButtons();
            this.Button_MoveTable = new ConsoleApplication5.TableManagementButtons();
            this.Button_MoveContent = new ConsoleApplication5.TableManagementButtons();
            this.Button_OneTimePayment = new ConsoleApplication5.TableManagementButtons();
            this.back_Button1 = new ConsoleApplication5.Back_Button();
            this.table_Panel_for_MainPage1 = new ConsoleApplication5.Table_Panel_for_MainPage();
            this.timerInfo1 = new ConsoleApplication5.TimerInfo();
            this.SuspendLayout();
            // 
            // Button_CombineTables
            // 
            this.Button_CombineTables.BackColor = System.Drawing.Color.Transparent;
            this.Button_CombineTables.Image_set = null;
            this.Button_CombineTables.Location = new System.Drawing.Point(26, 579);
            this.Button_CombineTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_CombineTables.Name = "Button_CombineTables";
            this.Button_CombineTables.Size = new System.Drawing.Size(128, 128);
            this.Button_CombineTables.TabIndex = 6;
            this.Button_CombineTables.Textlabel = "COMBINE TABLES";
            // 
            // Button_MoveTable
            // 
            this.Button_MoveTable.BackColor = System.Drawing.Color.Transparent;
            this.Button_MoveTable.Image_set = null;
            this.Button_MoveTable.Location = new System.Drawing.Point(26, 741);
            this.Button_MoveTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_MoveTable.Name = "Button_MoveTable";
            this.Button_MoveTable.Size = new System.Drawing.Size(128, 128);
            this.Button_MoveTable.TabIndex = 5;
            this.Button_MoveTable.Textlabel = "MOVE TABLE";
            // 
            // Button_MoveContent
            // 
            this.Button_MoveContent.BackColor = System.Drawing.Color.Transparent;
            this.Button_MoveContent.Image_set = null;
            this.Button_MoveContent.Location = new System.Drawing.Point(26, 897);
            this.Button_MoveContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_MoveContent.Name = "Button_MoveContent";
            this.Button_MoveContent.Size = new System.Drawing.Size(128, 128);
            this.Button_MoveContent.TabIndex = 4;
            this.Button_MoveContent.Textlabel = "MOVE CONTENT";
            // 
            // Button_OneTimePayment
            // 
            this.Button_OneTimePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OneTimePayment.BackColor = System.Drawing.Color.Transparent;
            this.Button_OneTimePayment.Image_set = null;
            this.Button_OneTimePayment.Location = new System.Drawing.Point(1764, 758);
            this.Button_OneTimePayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_OneTimePayment.Name = "Button_OneTimePayment";
            this.Button_OneTimePayment.Size = new System.Drawing.Size(128, 128);
            this.Button_OneTimePayment.TabIndex = 3;
            this.Button_OneTimePayment.Textlabel = "SINGLE PAYMENT";
            // 
            // back_Button1
            // 
            this.back_Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.back_Button1.BackColor = System.Drawing.Color.Transparent;
            this.back_Button1.Image_set = null;
            this.back_Button1.Location = new System.Drawing.Point(1764, 912);
            this.back_Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_Button1.Name = "back_Button1";
            this.back_Button1.Size = new System.Drawing.Size(128, 128);
            this.back_Button1.TabIndex = 2;
            this.back_Button1.Textlabel = "Back";
            // 
            // table_Panel_for_MainPage1
            // 
            this.table_Panel_for_MainPage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_Panel_for_MainPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.table_Panel_for_MainPage1.Location = new System.Drawing.Point(210, 84);
            this.table_Panel_for_MainPage1.Name = "table_Panel_for_MainPage1";
            this.table_Panel_for_MainPage1.Size = new System.Drawing.Size(1509, 970);
            this.table_Panel_for_MainPage1.TabIndex = 1;
            // 
            // timerInfo1
            // 
            this.timerInfo1.BackColor = System.Drawing.Color.Transparent;
            this.timerInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.timerInfo1.employeename = null;
            this.timerInfo1.Location = new System.Drawing.Point(0, 0);
            this.timerInfo1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timerInfo1.Name = "timerInfo1";
            this.timerInfo1.Size = new System.Drawing.Size(1920, 50);
            this.timerInfo1.TabIndex = 0;
            this.timerInfo1.tablename = null;
            // 
            // TablesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Button_CombineTables);
            this.Controls.Add(this.Button_MoveTable);
            this.Controls.Add(this.Button_MoveContent);
            this.Controls.Add(this.Button_OneTimePayment);
            this.Controls.Add(this.back_Button1);
            this.Controls.Add(this.table_Panel_for_MainPage1);
            this.Controls.Add(this.timerInfo1);
            this.Name = "TablesPage";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);

        }

        #endregion

        public TimerInfo timerInfo1;
        public Table_Panel_for_MainPage table_Panel_for_MainPage1;
        public Back_Button back_Button1;
        public TableManagementButtons Button_OneTimePayment;
        public TableManagementButtons Button_MoveContent;
        public TableManagementButtons Button_MoveTable;
        public TableManagementButtons Button_CombineTables;
    }
}
