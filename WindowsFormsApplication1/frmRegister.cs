using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class frmRegister : Form
    {
        bool errors = false;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            //greyed out for aesthetics
            txtbxNewUsername.Text = "Please enter a new username";
            txtbxNewUsername.Font = new Font("Arial", 11, FontStyle.Italic);
            txtbxNewUsername.ForeColor = Color.Gray;

            txtBxCreatePassword.Text = "Please enter a password";
            txtBxCreatePassword.Font = new Font("Arial", 11, FontStyle.Italic);
            txtBxCreatePassword.ForeColor = Color.Gray;

            txtBxConfirmPassword.Text = "Please confirm the password entered";
            txtBxConfirmPassword.Font = new Font("Arial", 11, FontStyle.Italic);
            txtBxConfirmPassword.ForeColor = Color.Gray;
        }

 


        private void bttnCancel_Click(object sender, EventArgs e)
        {
            frmLogin fl= new frmLogin();
            fl.Show();
            fl.Location = this.Location;
            this.Close();



        }

        private void ConfirmPSClick(object sender, EventArgs e)
        {
            if (txtBxConfirmPassword.Text=="Please confirm the password entered")
            {
                txtBxConfirmPassword.Text = "";
                txtBxConfirmPassword.Font = new Font("Ariel", 11, FontStyle.Regular);
                txtBxConfirmPassword.ForeColor = Color.Black;
            }

        }

        private void ConfrimPSLeave(object sender, EventArgs e)
        {
            if (txtBxConfirmPassword.Text == "")
            {
                txtBxConfirmPassword.Text = "Please confirm the password entered";
                txtBxConfirmPassword.Font = new Font("Arial", 11, FontStyle.Italic);
                txtBxConfirmPassword.ForeColor = Color.Gray;
            }
        }





        private void CreatePSClick(object sender, EventArgs e)
        {
            if (txtBxCreatePassword.Text == "Please enter a password")
            {
                txtBxCreatePassword.Text = "";
                txtBxCreatePassword.Font = new Font("Ariel", 11, FontStyle.Regular);
                txtBxCreatePassword.ForeColor = Color.Black;
            }

        }

        private void CreatePSLeave(object sender, EventArgs e)
        {
            if (txtBxCreatePassword.Text == "")
            {
                txtBxCreatePassword.Text = "Please enter a password";
                txtBxCreatePassword.Font = new Font("Arial", 11, FontStyle.Italic);
                txtBxCreatePassword.ForeColor = Color.Gray;
            }

        }




        private void NewUNLeave(object sender, EventArgs e)
        {

            if (txtbxNewUsername.Text=="")
            {
                txtbxNewUsername.Text = "Please enter a new username";
                txtbxNewUsername.Font = new Font("Arial", 11, FontStyle.Italic);
                txtbxNewUsername.ForeColor = Color.Gray;

            }

        }

        private void NewUSClick(object sender, EventArgs e)
        {
            if (txtbxNewUsername.Text == "Please enter a new username")
            {
                txtbxNewUsername.Text = "";
                txtbxNewUsername.Font = new Font("Ariel", 11, FontStyle.Regular);
                txtbxNewUsername.ForeColor = Color.Black;
            }


        }

        public void bttnCreateUser_Click(object sender, EventArgs e)
        {
            checkValueIsCorrect();

            if (errors == false)
            {
                File.AppendAllText("userLogin.txt", txtbxNewUsername.Text + '~' + txtBxCreatePassword.Text + Environment.NewLine);              
            }


            frmLogin fl = new frmLogin();
            fl.Show();
            fl.Location = this.Location;
            this.Close();
        }

        //check all value are appropriate
        private void checkValueIsCorrect()
        {
            string error = "";

            //username is blank
            if (txtbxNewUsername.Text.Length == 0)
            {
                error += "Please enter a username";
                errors =true;         
            }

            if (txtBxCreatePassword.Text.Length == 0)
            {
                error += "Please enter a password";
                errors = true;
            }

            if (txtBxConfirmPassword.Text.Length == 0)
            {
                error += "Please confirm your password";
                errors = true;
            }

            if (txtBxCreatePassword.Text != txtBxConfirmPassword.Text)
            {
                error += "Passwords do not match";
                errors = true;
            }

            if (errors == true)
            {
                MessageBox.Show(error);
            }




        }
    }
}
