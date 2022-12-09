using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Configuration;

namespace Student_Registration_Windows
{
    public partial class AddStudent : Form
    {
        OracleConnection con = new OracleConnection();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            //Change the Form Window name
            this.Text = "Student Registration";
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            //Hide the current form
            this.Hide();

            //Create new object for main Form
            Main main = new Main();

            //Show the main Form
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear textboxs
            Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        //Add btn Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                RegisterStudent();
            }
        }

        //StudentID Validation
        private void txtStduentID_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtStudentID, epStudentID, e, "Please enter the Student ID");
        }


        //FirstName Validation
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtFirstName, epFirstName, e, "Please enter the First Name");
        }


        //LastName Validation
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtLastName, epLastName, e, "Please enter the Last Name");
        }

        //Address Validation
        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtAddress, epAddress, e, "Please enter the Address");
        }


        //Nic Validation
        private void txtNIC_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtNIC, epNIC, e, "Please enter the NIC");
        }


        //Email Validation
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtEmail, epEmail, e, "Please enter the Email");
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                emailValidation(txtEmail, epEmail, e);
            }
        }


        //nationality validation
        private void txtNationality_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtNationality, epNationality, e, "Please enter the Nationality");
        }


        //Required Feilds Validae Function
        private void requiredValidator(TextBox textbox,ErrorProvider errorProvider,CancelEventArgs e,string msg)
        {
            if (string.IsNullOrEmpty(textbox.Text))
            {
                e.Cancel = true;
                textbox.Focus();
                errorProvider.SetError(textbox, msg);
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textbox, null);
            }
        }

        //email validation
        private void emailValidation(TextBox textbox, ErrorProvider errorProvider, CancelEventArgs e)
        {
            if (!isValidEmail(textbox.Text))
            {
                e.Cancel = true;
                textbox.Focus();
                errorProvider.SetError(textbox, "Please enter a valid email");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textbox, null);
            }
        }


        //check email is valid or not
        bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //clear textboxes 
        private void Clear()
        {
            txtStudentID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtNationality.Text = "";
            txtNIC.Text = "";
            txtContactNo.Text = "";
        }

        private void txtContactNo_Validating(object sender, CancelEventArgs e)
        {
            requiredValidator(txtContactNo, epContactNo, e, "Please enter the Contact NO");
            if (!string.IsNullOrEmpty(txtContactNo.Text))
            {
                contactValidation(txtContactNo.Text, epContactNo,e);
            }
        }

        private void  contactValidation(string contactNo, ErrorProvider errorProvider,CancelEventArgs e)
        {
            if(contactNo.Length < 10 && contactNo.Length > 10)
            {
                e.Cancel = true;
                txtContactNo.Focus();
                errorProvider.SetError(txtContactNo, "Please enter a valid Contact No");
            }
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtStduentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void RegisterStudent()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["dbString"].ToString();
            OracleCommand cmd = new OracleCommand();
            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO AIS.STUDENT_REGISTRATIONS(STUDENTID,FIRST_NAME,LAST_NAME,ADDRESS,GENDER,NIC,EMAIL,NATIONALITY,CONTACT_NO)" +
                "VALUES(:STUDENTID,:FIRSTNAME,:LASTNAME,:ADDRESS,:GENDER,:NIC,:EMAIL,:NATIONALITY,:CONTACTNO)";

            //set parameters
            cmd.Parameters.Add(new OracleParameter("STUDENTID", txtStudentID.Text));
            cmd.Parameters.Add(new OracleParameter("FIRSTNAME", txtFirstName.Text));
            cmd.Parameters.Add(new OracleParameter("LASTNAME", txtLastName.Text));
            cmd.Parameters.Add(new OracleParameter("ADDRESS", txtAddress.Text));
            cmd.Parameters.Add(new OracleParameter("GENDER", GetGender()));
            cmd.Parameters.Add(new OracleParameter("NIC", txtNIC.Text));
            cmd.Parameters.Add(new OracleParameter("EMAIL", txtEmail.Text));
            cmd.Parameters.Add(new OracleParameter("NATIONALITY", txtNationality.Text));
            cmd.Parameters.Add(new OracleParameter("CONTACTNO", txtContactNo.Text));

            try
            {
                //Execute the Command
                con.Open();
                cmd.ExecuteNonQuery();


                //Clear Fields
                Clear();


                MessageBox.Show("Student Has been Registered SuccessFully");
                
            }
            catch
            {
                throw;
            }
            finally
            {
                //Close the Connection

                con.Close();
            }
        }


        public string GetGender()
        {
            string gender = "";

            //check with is selected
            if (rdoMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            return gender;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
