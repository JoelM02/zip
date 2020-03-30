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
    public partial class frmIncorrectAnswer : Form
    {
        public frmIncorrectAnswer()
        {
            InitializeComponent();
        }

        private void frmIncorrectAnswer_Load(object sender, EventArgs e)
        {
            if (tokenMultiplier.risk1 == true)
            {

                frmTopicPicker.currentTokenAmount = frmTopicPicker.currentTokenAmount - 1;

            }

            if (tokenMultiplier.risk2 == true)
            {

                frmTopicPicker.currentTokenAmount = frmTopicPicker.currentTokenAmount - 2;

            }

            if (tokenMultiplier.risk3 == true)
            {

                frmTopicPicker.currentTokenAmount = frmTopicPicker.currentTokenAmount - 3;

            }
        }
    }
}
