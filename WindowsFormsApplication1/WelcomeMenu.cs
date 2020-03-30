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
    public partial class WelcomeMenu : Form
    {
        public WelcomeMenu()
        {
            InitializeComponent();
        }

        private void lbllnkPlay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            fl.Location = this.Location;
            this.Hide();
        }

        private void lbllnkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
