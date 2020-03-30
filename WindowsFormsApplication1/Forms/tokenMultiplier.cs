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
    public partial class tokenMultiplier : Form
    {

       public static bool risk1 = false;
       public static bool risk2 = false;
       public static bool risk3 = false;


        public tokenMultiplier()
        {
            InitializeComponent();

            //flip arrow
            Image img = arrowPointDown.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            arrowPointDown.Image = img;
            

            tokenAmount.Text = Convert.ToString(frmTopicPicker.currentTokenAmount);

            continueButton.Hide();

            string topicSelected = "";

            
            if (risk1==true || risk2==true || risk3==true)
            {
                continueButton.Show();
            }





            lblTopicSelected.Text = frmTopicPicker.topicSelected;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select the amount of tokens you would like to bet.", "\n If you bet 1 token and get the question right, you will recieve your token back plus one token extra. Bet two token you will receive your tokens back plus 2 extra, and so on. However get the question wrong and you LOSE your tokens.");

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //risk 1

            risk1 = true;
            
        }

        private void tokenAmount_Click(object sender, EventArgs e)
        {
            int currentTokenAmountTokenMultiplier;
           

        }

        private void arrowPointDown_Click(object sender, EventArgs e)
        {

        }

        private void buttonRisk2_Click(object sender, EventArgs e)
        {

            

            int currentTokensInt = Convert.ToInt32(frmTopicPicker.currentTokenAmount);

            if (currentTokensInt < 2)
            {
                MessageBox.Show("Cannot risk 2 tokens, you do not have enough.");
                risk2 = false;
            }

            else
            {
                risk2 = true;

                continueButton.Show();

            }


        }

        private void buttonRisk3_Click(object sender, EventArgs e)
        {
            int currentTokensInt;

            currentTokensInt = Convert.ToInt32(frmTopicPicker.currentTokenAmount);

            if (currentTokensInt < 3)
            {
                MessageBox.Show("Cannot risk 3 tokens, you do not have enough.");
                risk3 = false;
            }

            else
            {
                risk3 = true;
            }

            continueButton.Show();
        }

        private void lblTopicSelected_Click(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            //login to register
            /// create new user then go back to login screen
            //frmRegister fr = new frmRegister();
            //fr.Show();
            //fr.Location = this.Location;
            //this.Close();

            frmQuestion fq = new frmQuestion();
            fq.Show();
            fq.Location = this.Location;
            this.Close();

            risk1 = false;
            risk2 = false;
            risk3 = false;

        }

        private void tokenMultiplier_Load(object sender, EventArgs e)
        {

        }
    }
}
