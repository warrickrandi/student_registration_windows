using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Registration_Windows
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "Main"; //Change the Form Window name
        }

        private void btnViewStdudent_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();

            //Create new object for View Form
            View view = new View();

            //Show the view Form
            view.Show();
        }

        private void btnAddStduent_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();

            //Create new object for Add Student Form
            AddStudent addStudent = new AddStudent();

            //Show the add student Form
            addStudent.Show();
        }
    }
}
