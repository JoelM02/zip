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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {        
            frmTopicPicker cs = new frmTopicPicker();
            cs.Show();
            cs.Location = this.Location;
            this.Hide();
        }

        private void lnkLblHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
