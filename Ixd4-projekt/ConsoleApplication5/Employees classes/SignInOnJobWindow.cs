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
    public partial class SignInOnJobWindow : Standard_Window_Layout
    {
        public SignInOnJobWindow(string path)
        {


            InitializeComponent();
            Initializejobpeople(path);

          
        }
        //public string[] Listofemp { get; set; }

   
        private void Initializejobpeople(string path)
        {
            
            EmployeesReader EmployeeControl = new EmployeesReader(500, 200, path);
            EmployeeControl.Location = new Point(0, 0);
            EmployeesReader.PasswordCorrect += new EventHandler<EmployeeEventArgs>(Close_window);
            Controls.Add(EmployeeControl);

            // List<EmployeeButton> ListOfEmployees = EmployeeControl.EmployeeHolder.Controls.OfType<EmployeeButton>().ToList();

            //List<string> list = new List<string>();
            //foreach (var item in ListOfEmployees)
            //{
            //    list.Add(item.employee.EmployeeName);
            //}
            //Listofemp = list.ToArray();
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Close_window(object sender, EmployeeEventArgs e)
        {
            this.Hide();
        }

        private void OnJobWindow_Load(object sender, EventArgs e)
        {

        }

        private void SignInOnJobWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //var autoComplete = new AutoCompleteStringCollection();
            //autoComplete.AddRange(Listofemp);
            //textBox1.AutoCompleteCustomSource = autoComplete;
            //textBox1.AutoCompleteCustomSource = Listofemp.ToAutoCompleteStringCollection();
        }
    }
    public static class EnumerableExtensionsEx
    {
        public static AutoCompleteStringCollection ToAutoCompleteStringCollection(
            this IEnumerable<string> enumerable)
        {
            if (enumerable == null) throw new ArgumentNullException("enumerable");
            var autoComplete = new AutoCompleteStringCollection();
            foreach (var item in enumerable) autoComplete.Add(item);
            return autoComplete;
        }
    }
}
