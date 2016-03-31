using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
namespace ConsoleApplication5
{
    partial class Table_management_settings_form
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
            #region Instantiation of field variables (Controls)
            this.TableType_Panel = new System.Windows.Forms.Panel();
            this.ResturantPlan_panel = new System.Windows.Forms.Panel();
            this.Label_TextEntry = new System.Windows.Forms.Label();
            this.NameEntry_textbox = new System.Windows.Forms.TextBox();
            this.Label_headlineType = new System.Windows.Forms.Label();
            this.Panel_preview = new System.Windows.Forms.Panel();
            this.Label_ShapePanel = new System.Windows.Forms.Label();
            this.Panel_shape = new System.Windows.Forms.Panel();
            this.Label_size = new System.Windows.Forms.Label();
            this.Label_Preview = new System.Windows.Forms.Label();
            this.Button_plusWidth = new System.Windows.Forms.Button();
            this.Button_MinusWidth = new System.Windows.Forms.Button();
            this.Button_MinusHeight = new System.Windows.Forms.Button();
            this.Button_PlusHeight = new System.Windows.Forms.Button();
            this.Label_middleSize = new System.Windows.Forms.Label();
            this.Button_save = new System.Windows.Forms.Button();
            this.Button_back = new System.Windows.Forms.Button();
            this.Label_headlineResturantPlan = new System.Windows.Forms.Label();
            this.pictureBox_Plan = new System.Windows.Forms.PictureBox();
            this.Button_addNewPlan = new System.Windows.Forms.Button();
            this.Button_exit = new System.Windows.Forms.Button();
            this.Button_savePlan = new System.Windows.Forms.Button();
            this.Button_TablePreview = new ConsoleApplication5.Table_Control_Manager();
            this.TableType_Panel.SuspendLayout();
            this.ResturantPlan_panel.SuspendLayout();
            this.Panel_preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Plan)).BeginInit();
            this.SuspendLayout();
            #endregion

            #region TableType Panel
            // TableType_Panel
            // 
            this.TableType_Panel.Controls.Add(this.Button_back);
            this.TableType_Panel.Controls.Add(this.Button_save);
            this.TableType_Panel.Controls.Add(this.Label_middleSize);
            this.TableType_Panel.Controls.Add(this.Button_PlusHeight);
            this.TableType_Panel.Controls.Add(this.Button_MinusHeight);
            this.TableType_Panel.Controls.Add(this.Button_MinusWidth);
            this.TableType_Panel.Controls.Add(this.Button_plusWidth);
            this.TableType_Panel.Controls.Add(this.Label_Preview);
            this.TableType_Panel.Controls.Add(this.Label_size);
            this.TableType_Panel.Controls.Add(this.Panel_shape);
            this.TableType_Panel.Controls.Add(this.Label_ShapePanel);
            this.TableType_Panel.Controls.Add(this.Panel_preview);
            this.TableType_Panel.Controls.Add(this.NameEntry_textbox);
            this.TableType_Panel.Controls.Add(this.Label_headlineType);
            this.TableType_Panel.Controls.Add(this.Label_TextEntry);
            this.TableType_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TableType_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableType_Panel.Location = new System.Drawing.Point(0, 0);
            this.TableType_Panel.Name = "TableType_Panel";
            this.TableType_Panel.Size = new System.Drawing.Size(807, 642);
            this.TableType_Panel.TabIndex = 0;
            // 
            // Label_TextEntry
            // 
            this.Label_TextEntry.AutoSize = true;
            this.Label_TextEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TextEntry.Location = new System.Drawing.Point(71, 75);
            this.Label_TextEntry.Name = "Label_TextEntry";
            this.Label_TextEntry.Size = new System.Drawing.Size(206, 25);
            this.Label_TextEntry.TabIndex = 0;
            this.Label_TextEntry.Text = "Name of the table type";
            // 
            // NameEntry_textbox
            // 
            this.NameEntry_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameEntry_textbox.Location = new System.Drawing.Point(76, 103);
            this.NameEntry_textbox.MaxLength = 20;
            this.NameEntry_textbox.Name = "NameEntry_textbox";
            this.NameEntry_textbox.Size = new System.Drawing.Size(201, 26);
            this.NameEntry_textbox.TabIndex = 1;
            // 
            // Label_headlineType
            // 
            this.Label_headlineType.AutoSize = true;
            this.Label_headlineType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_headlineType.Location = new System.Drawing.Point(273, 20);
            this.Label_headlineType.Name = "Label_headlineType";
            this.Label_headlineType.Size = new System.Drawing.Size(221, 29);
            this.Label_headlineType.TabIndex = 2;
            this.Label_headlineType.Text = "Create Table Type";
            #region Preview panel
        
            // 
            // Panel_preview
            // 
            this.Panel_preview.Controls.Add(this.Button_TablePreview);
            this.Panel_preview.Location = new System.Drawing.Point(361, 103);
            this.Panel_preview.Name = "Panel_preview";
            this.Panel_preview.Size = new System.Drawing.Size(434, 420);
            this.Panel_preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_preview.TabIndex = 3;
            // 
            // Label_Preview
            // 
            this.Label_Preview.AutoSize = true;
            this.Label_Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Preview.Location = new System.Drawing.Point(536, 75);
            this.Label_Preview.Name = "Label_Preview";
            this.Label_Preview.Size = new System.Drawing.Size(81, 25);
            this.Label_Preview.TabIndex = 7;
            this.Label_Preview.Text = "Preview";
            // 
            // Button_TablePreview
            // 
            this.Button_TablePreview.Location = new System.Drawing.Point(163, 168);
            this.Button_TablePreview.Name = "Button_TablePreview";
            this.Button_TablePreview.Size = new System.Drawing.Size(113, 75);
            this.Button_TablePreview.TabIndex = 0;
            this.Button_TablePreview.Text = "404";
            this.Button_TablePreview.UseVisualStyleBackColor = true;
            #endregion

            #region Shape panel
            // 
            // Label_ShapePanel
            // 
            this.Label_ShapePanel.AutoSize = true;
            this.Label_ShapePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ShapePanel.Location = new System.Drawing.Point(71, 173);
            this.Label_ShapePanel.Name = "Label_ShapePanel";
            this.Label_ShapePanel.Size = new System.Drawing.Size(212, 25);
            this.Label_ShapePanel.TabIndex = 4;
            this.Label_ShapePanel.Text = "Shape of the table type";
            //Button_roundShape
            System.Windows.Forms.Button Button_elipsis = new System.Windows.Forms.Button();
            Button_elipsis.Location = new System.Drawing.Point(0, 0);
            Button_elipsis.Size = new System.Drawing.Size(30, Panel_shape.Size.Height);
            Button_elipsis.AutoSize = false;
            Button_elipsis.Region = Create_Region_round(Button_elipsis.Size, Button_elipsis.Location);
            //this.Label_ShapePanel.Controls.Add(Button_elipsis);

            // 
            // Panel_shape
            // 
            this.Panel_shape.Location = new System.Drawing.Point(35, 201);
            this.Panel_shape.Name = "Panel_shape";
            this.Panel_shape.Size = new System.Drawing.Size(295, 131);
            this.Panel_shape.TabIndex = 5;
            #endregion

            #region Size controls
            // 
            // Label_size
            // 
            this.Label_size.AutoSize = true;
            this.Label_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_size.Location = new System.Drawing.Point(71, 388);
            this.Label_size.Name = "Label_size";
            this.Label_size.Size = new System.Drawing.Size(215, 26);
            this.Label_size.TabIndex = 6;
            this.Label_size.Text = "Size of the table type";
            // 
            // Button_plusWidth
            // 
            this.Button_plusWidth.Location = new System.Drawing.Point(209, 457);
            this.Button_plusWidth.Name = "Button_plusWidth";
            this.Button_plusWidth.Size = new System.Drawing.Size(39, 26);
            this.Button_plusWidth.TabIndex = 8;
            this.Button_plusWidth.Text = "+";
            this.Button_plusWidth.UseVisualStyleBackColor = true;
            this.Button_plusWidth.Click += new System.EventHandler(this.Button_plusWidth_Click);
            // 
            // Button_MinusWidth
            // 
            this.Button_MinusWidth.Location = new System.Drawing.Point(103, 457);
            this.Button_MinusWidth.Name = "Button_MinusWidth";
            this.Button_MinusWidth.Size = new System.Drawing.Size(39, 26);
            this.Button_MinusWidth.TabIndex = 9;
            this.Button_MinusWidth.Text = "-";
            this.Button_MinusWidth.UseVisualStyleBackColor = true;
            this.Button_MinusWidth.Click += new System.EventHandler(this.Button_MinusWidth_Click);
            // 
            // Button_MinusHeight
            // 
            this.Button_MinusHeight.Location = new System.Drawing.Point(155, 486);
            this.Button_MinusHeight.Name = "Button_MinusHeight";
            this.Button_MinusHeight.Size = new System.Drawing.Size(39, 26);
            this.Button_MinusHeight.TabIndex = 10;
            this.Button_MinusHeight.Text = "-";
            this.Button_MinusHeight.UseVisualStyleBackColor = true;
            this.Button_MinusHeight.Click += new System.EventHandler(this.Button_MinusHeight_Click);
            // 
            // Button_PlusHeight
            // 
            this.Button_PlusHeight.Location = new System.Drawing.Point(155, 428);
            this.Button_PlusHeight.Name = "Button_PlusHeight";
            this.Button_PlusHeight.Size = new System.Drawing.Size(39, 26);
            this.Button_PlusHeight.TabIndex = 11;
            this.Button_PlusHeight.Text = "+";
            this.Button_PlusHeight.UseVisualStyleBackColor = true;
            this.Button_PlusHeight.Click += new System.EventHandler(this.Button_PlusHeight_Click);
            // 
            // Label_middleSize
            // 
            this.Label_middleSize.AutoSize = true;
            this.Label_middleSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_middleSize.Location = new System.Drawing.Point(148, 457);
            this.Label_middleSize.Name = "Label_middleSize";
            this.Label_middleSize.Size = new System.Drawing.Size(55, 26);
            this.Label_middleSize.TabIndex = 12;
            this.Label_middleSize.Text = "Size";
            #endregion
            // 
            // Button_save
            // 
            this.Button_save.Location = new System.Drawing.Point(614, 565);
            this.Button_save.Name = "Button_save";
            this.Button_save.Size = new System.Drawing.Size(84, 53);
            this.Button_save.TabIndex = 13;
            this.Button_save.Text = "Save Type";
            this.Button_save.UseVisualStyleBackColor = true;
            this.Button_save.Click += Button_save_Click;
            // 
            // Button_back
            // 
            this.Button_back.Location = new System.Drawing.Point(711, 565);
            this.Button_back.Name = "Button_back";
            this.Button_back.Size = new System.Drawing.Size(84, 53);
            this.Button_back.TabIndex = 14;
            this.Button_back.Text = "Back";
            this.Button_back.UseVisualStyleBackColor = true;
            #endregion

            #region Resturant Panel
            // 
            // ResturantPlan_panel
            // 
            this.ResturantPlan_panel.Controls.Add(this.Button_savePlan);
            this.ResturantPlan_panel.Controls.Add(this.Button_exit);
            this.ResturantPlan_panel.Controls.Add(this.Button_addNewPlan);
            this.ResturantPlan_panel.Controls.Add(this.pictureBox_Plan);
            this.ResturantPlan_panel.Controls.Add(this.Label_headlineResturantPlan);
            this.ResturantPlan_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResturantPlan_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ResturantPlan_panel.Location = new System.Drawing.Point(813, 0);
            this.ResturantPlan_panel.Name = "ResturantPlan_panel";
            this.ResturantPlan_panel.Size = new System.Drawing.Size(342, 642);
            this.ResturantPlan_panel.TabIndex = 1;
            // 
            // Label_headlineResturantPlan
            // 
            this.Label_headlineResturantPlan.AutoSize = true;
            this.Label_headlineResturantPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_headlineResturantPlan.Location = new System.Drawing.Point(84, 20);
            this.Label_headlineResturantPlan.Name = "Label_headlineResturantPlan";
            this.Label_headlineResturantPlan.Size = new System.Drawing.Size(180, 29);
            this.Label_headlineResturantPlan.TabIndex = 0;
            this.Label_headlineResturantPlan.Text = "Resturant Plan";
            // 
            // pictureBox1
            // 
            this.pictureBox_Plan.Location = new System.Drawing.Point(22, 124);
            this.pictureBox_Plan.Name = "pictureBox1";
            this.pictureBox_Plan.Size = new System.Drawing.Size(297, 208);
            this.pictureBox_Plan.TabIndex = 1;
            this.pictureBox_Plan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Plan.TabStop = false;
            try
            {
                this.pictureBox_Plan.Image = Image.FromFile(Properties.Settings.Default.Path_of_resturant_plan);
            }
            catch (System.Exception) //if the image cannot be found we continue without an image
            {
            }
            this.pictureBox_Plan.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // Button_addNewPlan
            // 
            this.Button_addNewPlan.Location = new System.Drawing.Point(102, 360);
            this.Button_addNewPlan.Name = "Button_addNewPlan";
            this.Button_addNewPlan.Size = new System.Drawing.Size(162, 45);
            this.Button_addNewPlan.TabIndex = 2;
            this.Button_addNewPlan.Text = "Add new plan";
            this.Button_addNewPlan.UseVisualStyleBackColor = true;
            this.Button_addNewPlan.Click += Button_addNewPlan_Click;
            // 
            // Button_exit
            // 
            this.Button_exit.Location = new System.Drawing.Point(246, 565);
            this.Button_exit.Name = "button2";
            this.Button_exit.Size = new System.Drawing.Size(84, 53);
            this.Button_exit.TabIndex = 3;
            this.Button_exit.Text = "Exit";
            this.Button_exit.UseVisualStyleBackColor = true;
            this.Button_exit.Click += Button_exit_Click;
            // 
            // Button_savePlan
            // 
            this.Button_savePlan.Location = new System.Drawing.Point(102, 428);
            this.Button_savePlan.Name = "Button_savePlan";
            this.Button_savePlan.Size = new System.Drawing.Size(162, 45);
            this.Button_savePlan.TabIndex = 4;
            this.Button_savePlan.Text = "Save";
            this.Button_savePlan.UseVisualStyleBackColor = true;
            this.Button_savePlan.Click += Button_savePlan_Click;

            #endregion
            // 
            // Table_management_settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 642);
            this.Controls.Add(this.ResturantPlan_panel);
            this.Controls.Add(this.TableType_Panel);
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Table_management_settings_form";
            this.Text = "Table_management_settings_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TableType_Panel.ResumeLayout(false);
            this.TableType_Panel.PerformLayout();
            this.ResturantPlan_panel.ResumeLayout(false);
            this.ResturantPlan_panel.PerformLayout();
            this.Panel_preview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Plan)).EndInit();
            this.ResumeLayout(false);


        }


        #endregion

        private System.Windows.Forms.OpenFileDialog File_dialog;
        private System.Windows.Forms.Panel TableType_Panel;
        private System.Windows.Forms.Panel ResturantPlan_panel;
        private System.Windows.Forms.Label Label_middleSize;
        private System.Windows.Forms.Button Button_PlusHeight;
        private System.Windows.Forms.Button Button_MinusHeight;
        private System.Windows.Forms.Button Button_MinusWidth;
        private System.Windows.Forms.Button Button_plusWidth;
        private System.Windows.Forms.Label Label_Preview;
        private System.Windows.Forms.Label Label_size;
        private System.Windows.Forms.Panel Panel_shape;
        private System.Windows.Forms.Label Label_ShapePanel;
        private System.Windows.Forms.Panel Panel_preview;
        private System.Windows.Forms.TextBox NameEntry_textbox;
        private System.Windows.Forms.Label Label_headlineType;
        private System.Windows.Forms.Label Label_TextEntry;
        private System.Windows.Forms.Button Button_back;
        private System.Windows.Forms.Button Button_save;
        private System.Windows.Forms.Button Button_exit;
        private System.Windows.Forms.Button Button_addNewPlan;
        private System.Windows.Forms.PictureBox pictureBox_Plan;
        private System.Windows.Forms.Label Label_headlineResturantPlan;
        private System.Windows.Forms.Button Button_savePlan;
        private Table_Control_Manager Button_TablePreview;
    }
}