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
    public partial class TablesOnFrontpage : UserControl
    {
        public TablesOnFrontpage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TablesOnFrontpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TablesOnFrontpage";
            this.Size = new System.Drawing.Size(223, 197);
            this.ResumeLayout(false);
            this.BorderStyle = BorderStyle.Fixed3D;

        }

    //   public void MaybeIDontKnow()
    //    {
    //        int lel;
    //        List<Button> Bordliste = new List<Button>();

    //        lel = Int32.Parse(AmountOfTableInput.Text);
    //        for (int i = 0; i < lel; i++)
    //        {
    //            Bordliste.Add(new Button());
    //        }

    //        int z = 0;

    //        foreach (var Button in Bordliste)
    //        {

    //            Button.Location = new Point(Properties.Settings.Default.Location.X, Properties.Settings.Default.Location.Y + z * 24);
    //            Button.Name = "Bord";
    //            Button.Size = new System.Drawing.Size(75, 23);
    //            Button.TabIndex = 0;
    //            Button.Text = "Bord " + z.ToString();
    //            Button.UseVisualStyleBackColor = true;
    //            Button.Click += new System.EventHandler(NewTable_Click);
    //            Controls.Add(Button);
    //            Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewTable_MouseDown);
    //            Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewTable_MouseMove);
    //            Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewTable_MouseUp);
    //            z++;


    //        }
    //    }

    }
}
