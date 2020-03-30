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


    public partial class frmQuestion : Form
    {

        static bool bttnAPress = false;
        static bool bttnBPress = false;
        static bool bttnCPress = false;

        static bool continueButtonPress = false;

        int generalKnowledgeCount = 1;



        public frmQuestion()
        {
            InitializeComponent();

            


            lblCategory.Text = frmTopicPicker.topicSelected;

            if (tokenMultiplier.risk1==true)
            {
                lblRiskAmount.Text = "1";
            
            }

            if (tokenMultiplier.risk2 == true)
            {
                lblRiskAmount.Text = "2";

            }

            if (tokenMultiplier.risk3 == true)
            {
                lblRiskAmount.Text = "3";

            }

        }

        public class generalQuestions
        {


            public string generalQuestion { get; set; }
            public string generalCorrectAnswer1 { get; set; }

            public string generalIncorrectAnswer2 { get; set; }

            public string generalIncorrectAnswer3 { get; set; }



        }

        
        

        private void frmQuestion_Load(object sender, EventArgs e)
        {


            bttnAPress = false;
            bttnBPress = false;
            bttnCPress = false;

            List<generalQuestions> listQuestions = new List<generalQuestions>();
            

            tokenAmount.Text = Convert.ToString(frmTopicPicker.currentTokenAmount);

            continueButton.Hide();

            //general knowledge
            if (frmTopicPicker.topicSelected.ToUpper() == "GENERAL KNOWLEDGE")
            {
                //general knowledge

                using (StreamReader sr = new StreamReader("generalKnowledge.txt", true))
                {
                    string line;

                    

                    

                    while (!sr.EndOfStream)
                    {
                        string[] lineParts;

                        line = sr.ReadLine();

                        lineParts = line.Split('~');





                        //generalQuestions que = new generalQuestions();

                        //que.generalQuestion = lineParts[0];
                        //que.generalCorrectAnswer1 = lineParts[1];
                        //que.generalIncorrectAnswer2 = lineParts[2];
                        //que.generalIncorrectAnswer3 = lineParts[3];



                        //listQuestions.Add(que);
                        Random rdm = new Random();
                        int iRdm = rdm.Next(1, 6);

                        


                        Random randomCombo = new Random();

                        int rc = randomCombo.Next(1,2);

                        if (rc == 1 )
                        {
                            //correct answer in first button

                            lblQuestion.Text = lineParts[0];

                            bttnA.Text = lineParts[1];
                            bttnB.Text = lineParts[2];
                            bttnC.Text = lineParts[3];


                            if (bttnAPress == true || bttnBPress==true || bttnCPress==true) 
                            {
                                continueButton.Show();

                                if (bttnAPress==true && continueButtonPress==true)
                                {
                                    //correct answer


                                    frmCorrectAnswer ca = new frmCorrectAnswer();
                                    ca.Show();
                                    ca.Location = this.Location;
                                    this.Close();

                                }

                                if (bttnBPress == true)
                                {
                                    //incorrect answer

                                    frmIncorrectAnswer cr = new frmIncorrectAnswer();
                                    cr.Show();
                                    cr.Location = this.Location;
                                    this.Close();
                                }

                                if (bttnCPress == true)
                                {
                                    //incorrect answer

                                    frmIncorrectAnswer cr = new frmIncorrectAnswer();
                                    cr.Show();
                                    cr.Location = this.Location;
                                    this.Close();
                                }


                            }


                        }

                        if (rc == 2)
                        {
                            //correct answer in second button

                        }

                        if (rc == 3)
                        {
                            //correct answer in third button

                        }

                        generalKnowledgeCount++;
                    }
                }




            }


           


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void bttnA_Click(object sender, EventArgs e)
        {
            bttnAPress = true;
            bttnBPress = false;
            bttnCPress = false;

            return;
        }

        public void bttnB_Click(object sender, EventArgs e)
        {
            bttnBPress = true;
            bttnAPress = false;
            bttnCPress = false;

            return;

        }

        public void bttnC_Click(object sender, EventArgs e)
        {
            bttnCPress = true;
            bttnBPress = false;
            bttnAPress = false;

            return;
        }

        public void continueButton_Click(object sender, EventArgs e)
        {
            continueButtonPress = true;

            return;
        }
    }
}
