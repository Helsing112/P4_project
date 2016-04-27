using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication5
{
    public partial class Table_management_AddTableForm : Form
    {
        private Table_Control_Manager activePreview;
        public Table_management_AddTableForm()
        {
            InitializeComponent();
            ReadTypeFile_AddToPanel();
        }

        /// <summary>
        /// Creates a dialog box of Table_management_Addtableform that returns a 
        /// Table_control_Manager
        /// Returns a table_control_manager = null if Exit is pressed.
        /// </summary>
        public static Table_Control_Manager Show_addForm()
        {
            Table_management_AddTableForm temp_form = new Table_management_AddTableForm();
            temp_form.StartPosition = FormStartPosition.CenterScreen;
            temp_form.ShowDialog();
            Table_Control_Manager tmp_control = null;
            try
            {
                tmp_control = temp_form.activePreview.CloneForAddConfirm();

            }
            catch (NullReferenceException)
            {

            }

            return tmp_control;

        }
        private void ReadTypeFile_AddToPanel()
        {
            List<Table_Control_Manager> TableType_list =  XmlTableFileReader.Read_TableType_files();
            foreach (Table_Control_Manager item in TableType_list)
            {
                TableType_Show_Control temp_control = new TableType_Show_Control(item);
                temp_control.TableTypeClicked += OnTableTypeClicked;
                Flow_TableType.Controls.Add(temp_control);
            }
        }
        private void TextBox_NumberInput_TextChanged(object sender, System.EventArgs e)
        {
            if(activePreview != null)
            {
                activePreview.Text = textBox_NumberInput.Text;
            }
        }

        private void OnTableTypeClicked(object sender, EventArgs e)
        {
            
            Table_Control_Manager temp_controls = (Table_Control_Manager)sender;
            activePreview = temp_controls.CloneForAddConfirm();
            activePreview.Text = textBox_NumberInput.Text;
            panel_preview.Controls.Clear();
            panel_preview.Controls.Add(activePreview);
            button_flip.Enabled = true;
        }

        private void button_flip_Click(object sender, EventArgs e) //swaps the height and the lenght
        {
            int temp_lenght;
            temp_lenght = activePreview.Width;
            activePreview.Width = activePreview.Height;
            activePreview.Height = temp_lenght;
        }
        public EventHandler ButtonConfirmClick;
        private void button_add_confirm_Click(object sender, EventArgs e)
        {
            if(textBox_NumberInput.Text != "")
            {
                this.Close();
            }
            else
            {
                Messages.TableTypeSaveNoNameDenied();
            }
        }        

        private void button_quit_Click(object sender, EventArgs e)
        {
            activePreview = null;
            this.Close();
        }
    }
}
