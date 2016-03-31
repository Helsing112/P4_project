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
    public partial class TableAdd : Form
    {
        public TableAdd()
        {
            InitializeComponent();
            this.CreateAmountOfTableButtons.Click += CreateAmountOfTableButtons_Click;

        }
        private Control activeControl;
        private Point previousLocation;

        private void AmountOfTableInput_TextChanged(object sender, EventArgs e)
        {

        }
        public void CreateAmountOfTableButtons_Click(object sender, EventArgs e)
        {
            int lel;
            List<Button> Bordliste = new List<Button>();

            lel = Int32.Parse(AmountOfTableInput.Text);
            for (int i = 0; i < lel; i++)
            {
                Bordliste.Add(new Button());
            }

            int z = 0;

            foreach (var Button in Bordliste)
            {

                Button.Location = new Point(Properties.Settings.Default.Location.X, Properties.Settings.Default.Location.Y + z*24);
                Button.Name = "Bord";
                Button.Size = new System.Drawing.Size(75, 23);
                Button.TabIndex = 0;
                Button.Text = "Bord " + z.ToString();
                Button.UseVisualStyleBackColor = true;
                Button.Click += new System.EventHandler(NewTable_Click);
                Controls.Add(Button);
                Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewTable_MouseDown);
                Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewTable_MouseMove);
                Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewTable_MouseUp);
                z++;

 
            }
      
}
        private void NewTable_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState != CheckState.Checked)
            {
                MessageBox.Show("lålålålååå wolololo");
            }
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateAmountOfTableButtons = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AmountOfTableInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateAmountOfTableButtons
            // 
            this.CreateAmountOfTableButtons.Location = new System.Drawing.Point(363, 180);
            this.CreateAmountOfTableButtons.Name = "CreateAmountOfTableButtons";
            this.CreateAmountOfTableButtons.Size = new System.Drawing.Size(100, 38);
            this.CreateAmountOfTableButtons.TabIndex = 0;
            this.CreateAmountOfTableButtons.Text = "Create Tables";
            this.CreateAmountOfTableButtons.UseVisualStyleBackColor = true;
         
        

            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(445, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AmountOfTableInput
            // 
            this.AmountOfTableInput.Location = new System.Drawing.Point(363, 154);
            this.AmountOfTableInput.Name = "AmountOfTableInput";
            this.AmountOfTableInput.Size = new System.Drawing.Size(100, 20);
            this.AmountOfTableInput.TabIndex = 2;
            this.AmountOfTableInput.TextChanged += new System.EventHandler(this.AmountOfTableInput_TextChanged);
            // 
            // TableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 394);
            this.Controls.Add(this.AmountOfTableInput);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CreateAmountOfTableButtons);
            this.Name = "TableAdd";
            this.Text = "TableAdd";
            this.Load += new System.EventHandler(this.TableAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var textbox = new TextBox();

        //    textbox.MouseDown += new MouseEventHandler(NewTable_MouseDown);
        //    textbox.MouseMove += new MouseEventHandler(NewTable_MouseMove);
        //    textbox.MouseUp += new MouseEventHandler(NewTable_MouseUp);


        //    this.Controls.Add(textbox);

        //}


        void NewTable_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {

                activeControl = sender as Control;
                previousLocation = e.Location;
                Cursor = Cursors.Hand;
                //Properties.Settings.Default.Location = Table.Location;
                //Properties.Settings.Default.Save();
            }
        }

        void NewTable_MouseMove(object sender, MouseEventArgs e)
        {
            //if (checkbox1.checkstate == checkstate.checked)
            //{

            if (activeControl == null || activeControl != sender)
                return;

            var location = activeControl.Location;
            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
            activeControl.Location = location;
            //Properties.Settings.Default.Location = Bord.Location;
            //Properties.Settings.Default.Save();

        }

        void NewTable_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {

                activeControl = null;
                Cursor = Cursors.Default;

                Properties.Settings.Default.Save();
            }
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {

            }
        }
   
        private void TableAdd_Load(object sender, EventArgs e)
          {

        }

       
    }
}







