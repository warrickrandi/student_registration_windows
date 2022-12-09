using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.DataAccess.Client;

namespace Student_Registration_Windows
{
    public partial class View : Form
    {
        OracleConnection con = new OracleConnection();
        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            this.Text = "View Students";
            GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();

            //Create new object for main Form
            Main main = new Main();

            //Show the main Form
            main.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();

            //Create new object for Add Student Form
            AddStudent addStudent = new AddStudent();

            //Show the add student Form
            addStudent.Show();
        }

        private void GetData()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbString"].ToString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            try
            {
                cmd.CommandText = "SELECT * FROM AIS.STUDENT_REGISTRATIONS";
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);

                SetData(dataTable);
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void SetData(DataTable dataTable)
        {
            gridViewStudents.DataSource = dataTable;
            gridViewStudents.AutoGenerateColumns = false;
        }
    }
}
