using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {

        

        class Player
        {
            public string userNameEntered { get; set; }
            public string passwordEntered { get; set; }
        }


        //new list
        static List<Player> listPlayers = new List<Player>();
        bool error = false;


        private void LoginClick(object sender, EventArgs e)
        {

            //make sure values are valid
            checkValues();

            for (int i = 0; i < listPlayers.Count(); i++)
            {
                if (txtBxUsername.Text == listPlayers[i].userNameEntered.ToString() && txtBxPassword.Text == listPlayers[i].passwordEntered.ToString())
                {

                    MessageBox.Show("Login accepted");

                    MainMenu mm = new MainMenu();
                    this.Hide();
                    mm.Show();

                }
            }
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {
            //load as cool loader thing
            txtBxUsername.Text = "Please enter username";
            txtBxUsername.Font = new Font("Arial", 11, FontStyle.Italic);
            txtBxUsername.ForeColor = Color.Gray;

            txtBxPassword.Text = "Please enter password";
            txtBxPassword.Font = new Font("Arial", 11, FontStyle.Italic);
            txtBxPassword.ForeColor = Color.Gray;


            //hide mouse click icon
           


            //if (listPlayers.Count == 0)
            //{
                using (StreamReader sr = new StreamReader("userLogin.txt", true))
                {
                    string line;

                    while (!sr.EndOfStream)
                    {
                        string[] lineParts;

                        line = sr.ReadLine();

                        lineParts = line.Split('~');

                        Player pla = new Player();
                        pla.userNameEntered = lineParts[0];
                        pla.passwordEntered = lineParts[1];

                        listPlayers.Add(pla);
                    }
                //}
            }

        }


        private void checkValues()
        {
            string errors = "";

            if (txtBxUsername.Text.Length == 0)
            {
                errors += "Please enter a username";
                error = true;
            }

            if (txtBxPassword.Text.Length == 0)
            {
                errors += "\nPlease enter a password";
                error = true;
            }

           

            

            if (error == true)
            {
                MessageBox.Show(errors, "Error");
            }
        }






        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxUsername_TextChanged(object sender, EventArgs e)
        {

        }

       





        private void UsernameClick(object sender, EventArgs e)
        {
            
            if (txtBxUsername.Text == "Please enter username")
            {
                txtBxUsername.Text = "";
                txtBxUsername.Font = new Font("Arial", 11, FontStyle.Regular);
                txtBxUsername.ForeColor = Color.Black;
            }

        }
           
        

        private void UsernameLeave(object sender, EventArgs e)
        {
            if (txtBxUsername.Text == "")
            {
                txtBxUsername.Text = "Please enter username";
                txtBxUsername.Font = new Font("Arial", 11, FontStyle.Italic);
                txtBxUsername.ForeColor = Color.Gray;
            }
        }

        private void PasswordClick(object sender, EventArgs e)
        {
            //not blank
            if (txtBxPassword.Text == "Please enter password")
            {
                txtBxPassword.Text = "";
                txtBxPassword.Font = new Font("Arial", 11, FontStyle.Regular);
                txtBxPassword.ForeColor = Color.Black;
            }

            else
            {
            }
        }

        private void PasswordLeave(object sender, EventArgs e)
        {
            if (txtBxPassword.Text == "")
            {
                txtBxPassword.Text = "Please enter password";
                txtBxPassword.Font = new Font("Arial", 11, FontStyle.Italic);
                txtBxPassword.ForeColor = Color.Gray;
            }
        }

        

        private void RegisterClick(object sender, EventArgs e)
        {
            //create new user then go back to login screen
            frmRegister fr = new frmRegister();
            fr.Show();
            fr.Location = this.Location;
            this.Close();

            
        }

        public Timer timer;

        private void MouseClick(object sender, EventArgs e)
        {          

            //timer.Interval = (1000);
            //timer.Tick += Timer_Tick;

            //timer.Enabled = true;
            //timer.Start();








        }

        private void timerTick(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void locationChangeBoom(object sender, EventArgs e)
        {

        }

        private void pctrBxBoom_Click(object sender, EventArgs e)
        {

        }





        //closing form

    }
}
