using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ConsoleApplication5
{
    
    public partial class Table_management_settings_form : Form
    {
        public Table_management_settings_form()
        {
            InitializeComponent();
        }
        #region code for Resturant layout panel
        string path_plan_image;
        private void Button_addNewPlan_Click(object sender, EventArgs e)
        {
            File_dialog = new OpenFileDialog();
            File_dialog.Title = "Select picture";
            File_dialog.Filter = "Png Image|*.png|Jpeg Image|*.jpg|Gif Image|*.gif";
            File_dialog.InitialDirectory = Properties.Settings.Default.Path_of_Table_list_file;

            if (File_dialog.ShowDialog() == DialogResult.OK)
            {
                path_plan_image = File_dialog.FileName;
                pictureBox_Plan.Image = Image.FromFile(path_plan_image);
            }
        }
        private void Button_savePlan_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.Path_of_resturant_plan = path_plan_image;
            Properties.Settings.Default.Save();
            Messages.ConfirmRestPlanSaved();
        }
        #endregion

        #region Code for Table type panel
        private void Button_exit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void Button_save_Click(object sender, System.EventArgs e)
        {
            if(NameEntry_textbox.Text == null || NameEntry_textbox.Text == "")
            {
                Messages.TableTypeSaveNoNameDenied();
            }
            else
            {
                Button_TablePreview.Name = NameEntry_textbox.Text;
                XmlTableFileWriter.Save_Button_Type(Button_TablePreview);
            }
        }

        #region eventhandlers for size alterations
        private const int Size_alteration_amount = 10;
        private void Button_plusWidth_Click(object sender, EventArgs e)
        {
            this.Button_TablePreview.Width += Size_alteration_amount;
            this.Button_TablePreview.Location = new Point(Button_TablePreview.Location.X - Size_alteration_amount/2, Button_TablePreview.Location.Y);
        }
        private void Button_MinusWidth_Click(object sender, EventArgs e)
        {
            if (Button_TablePreview.Width > Size_alteration_amount*2)
            {
                this.Button_TablePreview.Width -= Size_alteration_amount;
                this.Button_TablePreview.Location = new Point(Button_TablePreview.Location.X + Size_alteration_amount / 2, Button_TablePreview.Location.Y);
            } 
        }
        private void Button_PlusHeight_Click(object sender, EventArgs e)
        {
            this.Button_TablePreview.Height += Size_alteration_amount;
            this.Button_TablePreview.Location = new Point(Button_TablePreview.Location.X, Button_TablePreview.Location.Y - Size_alteration_amount / 2);
        }
        private void Button_MinusHeight_Click(object sender, EventArgs e)
        {
            if(this.Button_TablePreview.Height >= Size_alteration_amount*2)
            {
                this.Button_TablePreview.Height -= Size_alteration_amount;
                this.Button_TablePreview.Location = new Point(Button_TablePreview.Location.X, Button_TablePreview.Location.Y + Size_alteration_amount / 2);
            }
        }
        #endregion

        private Region Create_Region_round(Rectangle input_rectangle) //creates a region of a elipsis
        {
            GraphicsPath graphics = new GraphicsPath(FillMode.Alternate);
            graphics.AddEllipse(input_rectangle.X,input_rectangle.Y,input_rectangle.Width,input_rectangle.Height);

            return new Region(graphics);
        }
        private Region Create_Region_round(Size input_size, Point Location) //creates a region of a elipsis
        {
            return Create_Region_round(new Rectangle(Location, input_size));
        }
        #endregion
    }
}
