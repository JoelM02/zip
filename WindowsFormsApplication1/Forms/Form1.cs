using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmLoadingScreen : Form
    {
        public frmLoadingScreen()
        {
            InitializeComponent();
        }

        //timer for loading screen
        private void timer1_Tick(object sender, EventArgs e)
        {
            tmrLoadingScreen.Stop(); //this will stop the timer from ticking more than once

            //creating an instance of the frmLogin called 'login'
            WelcomeMenu WM = new WelcomeMenu();

            //displays the control to the user
            WM.Show();

            this.Hide();
                     
        }

        private void frmLoadingScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
