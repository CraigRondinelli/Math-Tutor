using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//**************************************//
//*         Craig Rondinelli            // 
//*             CIS 202                 //
//*        Math Tutor Program           //
//**************************************//

namespace Math_Tutor
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();

            //Sets all labels that track user progress to 0.
            lblAttempt.Text = "0";
            lblCorrect.Text = "0";
            lblWrong.Text = "0";
            lblPercent.Text = "0%";
            lblAnswer.Text = "";

            //Names the form.
            this.Text = "Rondinelli - Math";

            //Plays music and loops.
            System.Media.SoundPlayer music = new System.Media.SoundPlayer(@"01-main-theme-overworld.wav");
            music.PlayLooping();
            music.Play();
        }

        //Declares variables at class level used throughout program.
        int x, y;
        int a = 0, b=0, c = 0, ticks = 0;
        double avg = 0;
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            //Timer that resets and counts up when a new problem is generated.
            ticks = 0;
            lblTimer.Text = "00 : 00";
            timerProblem.Start();

            //Resets the Mario pictures to their original settings.
            picMarioJump.Visible = false;
            picMarioStand.Visible = true;
            picCoin.Visible = false;
            timerStandVisible.Stop();
            picDead.Top = 256;
            timerDead.Stop();
            picDead.Visible = false;

            //Clears the answer textbox and label.
            txtAnswer.Clear();
            lblAnswer.Text = "";

            //Selects the difficulty of the problems. From 1-12, or 1-24.
            if (radEasy.Checked == true) 
            {
                Random num = new Random();
                x = num.Next(0, 13);
                y = num.Next(0, 13);
            }
            else if (radHard.Checked == true)
            {
                Random num = new Random();
                x = num.Next(0, 25);
                y = num.Next(0, 25);
            }

            //Generates a different type of problem depending on which radio button is selected.
            if (radAdd.Checked == true)
                lblProblem.Text = x + "   +   " + y + "   =   ";
            else if (radSub.Checked == true)
                lblProblem.Text = x + "   -   " + y + "   =   ";
            else if (radMult.Checked == true)
                lblProblem.Text = x + "   *   " + y + "   =   ";

            //Adds 1 to the variable tracking attempted problems and outputs it into a label.
            lblAttempt.Text = (++a).ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e) 
        {
            //Stops timer for problem.
            timerProblem.Stop();

            //Try/Catch to make sure only numbers are entered.
            try
            {
                //Parses number entered in textbox, determines which radio button is selected, and outputs correct or incorrect. Also starts Mario jumping or Mario dying, depending on right or wrong answer. Uses if/else statements.
                int answer = int.Parse(txtAnswer.Text);

                if (radAdd.Checked == true)

                {
                    if (answer == x + y)
                    {
                        lblAnswer.Text = ("Correct!");

                        picMarioStand.Visible = false;
                        picMarioJump.Visible = true;
                        
                        timerJump.Start();

                        picCoin.Visible = true;
                        timerCoin.Start();

                        lblCorrect.Text = (++b).ToString();
                    }

                    else
                    {
                        MessageBox.Show("Incorrect, the right answer is  " + x + " + " + y + " = " + ( x + y) + ".");

                        timerBullet.Start();
                        picBullet.Visible = true;
                        picBullet.Left = 987;

                        timerDead.Start();

                        timerStandVisible.Start();
                        picDead.Visible = true;

                        lblWrong.Text = (++c).ToString();
                    }
                }

                else if (radSub.Checked == true)
                {
                    if (answer == x - y)
                    {
                        lblAnswer.Text = ("Correct!");

                        picMarioStand.Visible = false;
                        picMarioJump.Visible = true;

                        timerJump.Start();

                        picCoin.Visible = true;
                        timerCoin.Start();

                        lblCorrect.Text = (++b).ToString();
                    }

                    else
                    {
                        MessageBox.Show("Incorrect, the right answer is  " + x + " - " + y + " = " + (x - y) + ".");

                        timerBullet.Start();
                        picBullet.Visible = true;
                        picBullet.Left = 987;

                        timerDead.Start();

                        timerStandVisible.Start();
                        picDead.Visible = true;

                        lblWrong.Text = (++c).ToString();
                    }
                }

                else if (radMult.Checked == true)
                {
                    if (answer == x * y)
                    {
                        lblAnswer.Text = ("Correct!");

                        picMarioStand.Visible = false;
                        picMarioJump.Visible = true;

                        timerJump.Start();

                        picCoin.Visible = true;
                        timerCoin.Start();

                        lblCorrect.Text = (++b).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect, the right answer is  " + x + " * " + y + " = " + (x * y) + ".");

                        timerBullet.Start();
                        picBullet.Visible = true;
                        picBullet.Left = 987;

                        timerDead.Start();

                        timerStandVisible.Start();
                        picDead.Visible = true;
                       
                        lblWrong.Text = (++c).ToString();
                    }
                }
            }
                catch (Exception)
                {
                MessageBox.Show("Only numbers can go here! Try again!");
                }

            //Calcuates and outputs the percentage of problems user got correct.
            double avg = (double)b / (b + c);
            lblPercent.Text = avg.ToString("p");

            //Resets timer.
            ticks = 0;
            lblTimer.Text = "00 : 00";
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            //Allows user to check answer only when text is entered into the textbox.
            btnCheck.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all textboxes and resets Mario pictures to original settings.
            picMarioJump.Visible = false;
            picMarioStand.Visible = true;
            picCoin.Visible = false;
            timerStandVisible.Stop();
            picDead.Top = 256;
            timerDead.Stop();
            picDead.Visible = false;
            lblAnswer.Text = "";
            txtAnswer.Clear();
        }
            

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Resets everything.
            a = 0;
            b = 0;
            c = 0;
            avg = 0;
            txtAnswer.Clear();
            btnCheck.Enabled = false;
            radAdd.Checked = true;
            radEasy.Checked = true;
            lblAttempt.Text = "0";
            lblCorrect.Text = "0";
            lblWrong.Text = "0";
            lblPercent.Text = "0%";
            lblProblem.Text = "";
            lblAnswer.Text = "";
            picMarioJump.Visible = false;
            picMarioStand.Visible = true;
            picDead.Top = 256;
            timerDead.Stop();
            picDead.Visible = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits program, with confirmation.
            var confirmResult = MessageBox.Show("Are you sure you want to quit?", " ", MessageBoxButtons.YesNo);
             if (confirmResult == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer for problems, that counts upwards.
            ticks++;
            int min = (ticks / 60);
            int sec = (ticks % 60);
            lblTimer.Text = min.ToString("00") + " : " + sec.ToString("00");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Controls Mario jumping.
            timerJump.Interval = 25;

            picMarioJump.Top -= 10;
            if (picMarioJump.Top <= 210)
                picMarioJump.Top += 10;
        }

        private void timerCoin_Tick(object sender, EventArgs e)
        {
            //Controls coin movement.
            timerCoin.Interval = 100;

            picCoin.Top -= 10;
            if (picCoin.Top <= 111)
                picCoin.Top += 10;
        }

        private void timerBullet_Tick(object sender, EventArgs e)
        {
            //Controls bullet bill movement.
            timerBullet.Interval = 10;

            picBullet.Left -= 50;
        }

        private void picTitle_Click(object sender, EventArgs e)
        {
            //Displays textbox when picture is clicked on.
            MessageBox.Show("Created by Craig Rondinelli for CIS 202 in 2015!");
        }

        private void timerDead_Tick(object sender, EventArgs e)
        {
            //Controls mario dying.
            timerDead.Interval = 50;

            picDead.Top += 50;
        }

        private void timerStandVisible_Tick(object sender, EventArgs e)
        {
            //Controls Mario standing.
            timerStandVisible.Interval = 25;
            picMarioStand.Visible = false;
        }
    }
}
