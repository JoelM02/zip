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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblS_Click(object sender, EventArgs e)
        {

        }

        private void frmHelp_Load(object sender, EventArgs e)
        {

        }

        private void pBoxP1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Player one controls." + Environment.NewLine + "W- Move tank forward" + Environment.NewLine + "S- Move tank backwards" + Environment.NewLine + "A- Rotate tank left" + Environment.NewLine + "D- Rotate tank right" + Environment.NewLine + "L.Shift- Shoot Tank Bullet");
        }

        private void pBoxP2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Player two controls." + Environment.NewLine + "↑- Move tank forward" + Environment.NewLine + "↓- Move tank backwards" + Environment.NewLine + "←- Rotate tank left" + Environment.NewLine + "→- Rotate tank right" + Environment.NewLine + "R.Shift- Shoot Tank Bullet");
        }

        private void bttnContinueToGame_Click(object sender, EventArgs e)
        {
            

        }
    }
}
