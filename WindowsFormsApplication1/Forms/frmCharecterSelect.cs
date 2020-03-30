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



    public partial class frmTopicPicker : Form
    {

        public static int currentTokenAmount = 5;
        public static string topicSelected = "";

        
        


        public frmTopicPicker()
        {         
            InitializeComponent();
        }

        public void frmCharecterSelect_Load(object sender, EventArgs e)
        {
            //variables
            Timer timer;







            if (currentTokenAmount<=0)
            {
                //if current tokens are less than or equal to  zero the game is over
            }

            //hide all arrows to start, they will show based on what random number is picked

           








            //user starts with 5 tokens
            tokenAmount.Text = Convert.ToString(currentTokenAmount);

            bttnContinue.Hide();

            lblRandomTopic.Text = "...";
            //lblRandomTopic.Font = new Font("Microsoft Sans Serif", 40, FontStyle.Regular);
            //lblRandomTopic.ForeColor = Color.Blue;
        }




        




      

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             
              
              1. General Knowledge
              2. Science Tech and Maths
              3. Animals & Nature
              4. Books
              5. Sport
              6. Food
              7. Geography & Travel
              8. Music
             

                      
           */

            bool generalSelected = false;
            bool scienceSelected = false;
            bool animalSelected = false;
            bool bookSelected = false;
            bool sportSelected = false;
            bool foodSelected = false;
            bool geographySelected = false;
            bool musicSelected = false;


            
            Random rnd = new Random();
            int randomTopic = rnd.Next(1, 9);

            

           

            //topic is general knowledge
            if (randomTopic == 1)
            {
                //play the first arrow, then the second, then the third, then the fourth, and so on, then slowly make the arrow pick one of the topics

                //arrow must finish on the first topic

                //lblRandomTopic.Text = "General Knowledge";
                //lblRandomTopic.Font = new Font("Microsoft Sans Serif", 40, FontStyle.Regular);
                //lblRandomTopic.ForeColor = Color.Blue;


                lblRandomTopic.Text = "General Knowledge";
                lblRandomTopic.Font = new Font("Microsoft Sans Serif", 40, FontStyle.Regular);
                lblRandomTopic.ForeColor = Color.Blue;
                lblRandomTopic.Location = new Point(249, 313);

                topicSelected = "General Knowledge";

                generalSelected = true;

                lblAnimals.Hide();
                lblBooks.Hide();
                lblFood.Hide();
                lblGeneral.Hide();
                lblGeography.Hide();
                lblMusic.Hide();
                lblScience.Hide();
                lblSport.Hide();


                bttnContinue.Show();

            }
     
            //topic is sport
            if (randomTopic == 2)
            {
                lblRandomTopic.Text = "Sport";
                lblRandomTopic.Font = new Font("Microsoft Sans Serif", 40, FontStyle.Regular);
                lblRandomTopic.ForeColor = Color.Red;
                lblRandomTopic.Location = new Point(409, 314);
                





                topicSelected = "Sport";

                sportSelected = true;

                //hide all labels
                lblAnimals.Hide();
                lblBooks.Hide();
                lblFood.Hide();
                lblGeneral.Hide();
                lblGeography.Hide();
                lblMusic.Hide();
                lblScience.Hide();
                lblSport.Hide();


                bttnContinue.Show();

            }


            //topic is animals and nature
            if (randomTopic == 3)
            {
                lblRandomTopic.Text = "Animals and Nature";
                lblRandomTopic.Font = new Font("Microsoft Sans Serif", 40, FontStyle.Regular);

                
                Color animalsColour = Color.FromArgb(0, 192, 0);

                lblRandomTopic.ForeColor = animalsColour;

                
                
                lblRandomTopic.Location = new Point(242, 314);

                topicSelected = "Animals and Nature";

                animalSelected = true;

                //hide all labels
                lblAnimals.Hide();
                lblBooks.Hide();
                lblFood.Hide();
                lblGeneral.Hide();
                lblGeography.Hide();
                lblMusic.Hide();
                lblScience.Hide();
                lblSport.Hide();


                bttnContinue.Show();

            }

            //topic is geography
            if (randomTopic == 4)
            {
                lblRandomTopic.Text = "Geography and Travel";
                lblRandomTopic.Font = new Font("Microsoft Sans Serif", 36, FontStyle.Regular);


                Color geographyColour = Color.FromArgb(128, 128, 255);

                lblRandomTopic.ForeColor = geographyColour;


                //change this
                lblRandomTopic.Location = new Point(249, 314);

                topicSelected = "Geography and Travel";

                //change this
                geographySelected = true;

                //hide all labels
                lblAnimals.Hide();
                lblBooks.Hide();
                lblFood.Hide();
                lblGeneral.Hide();
                lblGeography.Hide();
                lblMusic.Hide();
                lblScience.Hide();
                lblSport.Hide();


                bttnContinue.Show();

            }






            //topic is science, tech and maths
            if (randomTopic == 5)
            {
                lblRandomTopic.Text = "Science, Tech and Maths";
                lblRandomTopic.Font = new Font("Microsoft Sans Serif", 32, FontStyle.Regular);



                lblRandomTopic.ForeColor = Color.Yellow;


                //change this
                lblRandomTopic.Location = new Point(231, 314);

                topicSelected = "Science, Tech and Maths";

                //change this
                scienceSelected = true;

                //hide all labels
                lblAnimals.Hide();
                lblBooks.Hide();
                lblFood.Hide();
                lblGeneral.Hide();
                lblGeography.Hide();
                lblMusic.Hide();
                lblScience.Hide();
                lblSport.Hide();


                bttnContinue.Show();

            }

            //topic is food
            if (randomTopic == 6)
            {
                lblRandomTopic.Text = "Food";
                lblRandomTopic.Font = new Font("Microsoft Sans Serif", 40, FontStyle.Regular);


                Color foodColour = Color.FromArgb(255, 128, 0);

                lblRandomTopic.ForeColor = foodColour;


                //change this
                lblRandomTopic.Location = new Point(421, 314);

                topicSelected = "Food";

                //change this
                foodSelected = true;

                //hide all labels
                lblAnimals.Hide();
                lblBooks.Hide();
                lblFood.Hide();
                lblGeneral.Hide();
                lblGeography.Hide();
                lblMusic.Hide();
                lblScience.Hide();
                lblSport.Hide();


                bttnContinue.Show();

            }

            //topic is books
            if (randomTopic == 7)
            {
                lblRandomTopic.Text = "Books";
                lblRandomTopic.Font = new Font("Microsoft Sans Serif", 40, FontStyle.Regular);




                lblRandomTopic.ForeColor = Color.Gray;


                //change this
                lblRandomTopic.Location = new Point(407, 314);

                topicSelected = "Food";

                //change this
                foodSelected = true;

                //hide all labels
                lblAnimals.Hide();
                lblBooks.Hide();
                lblFood.Hide();
                lblGeneral.Hide();
                lblGeography.Hide();
                lblMusic.Hide();
                lblScience.Hide();
                lblSport.Hide();


                bttnContinue.Show();

            }




            //topic is music
            if (randomTopic == 8)
            {
                lblRandomTopic.Text = "Music";
                lblRandomTopic.Font = new Font("Microsoft Sans Serif", 40, FontStyle.Regular);




                Color musicColour = Color.FromArgb(255, 128, 255);

                lblRandomTopic.ForeColor = musicColour;


                //change this
                lblRandomTopic.Location = new Point(407, 314);

                topicSelected = "Music";

                //change this
                musicSelected = true;

                //hide all labels
                lblAnimals.Hide();
                lblBooks.Hide();
                lblFood.Hide();
                lblGeneral.Hide();
                lblGeography.Hide();
                lblMusic.Hide();
                lblScience.Hide();
                lblSport.Hide();


                bttnContinue.Show();

            }





        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void bigAnimals_Click(object sender, EventArgs e)
        {

        }

        private void tokenAmount_Click(object sender, EventArgs e)
        {

        }

        private void currentTokens_Click(object sender, EventArgs e)
        {

        }

        private void bttnContinue_Click(object sender, EventArgs e)
        {
            //random topic picker -> token multiplier

            tokenMultiplier tm = new tokenMultiplier();
            this.Hide();
            tm.Show();
        }
    }
}

