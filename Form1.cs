/***************************************************** 
 * Code for game "Shape Avoidance"                   *
 * Code Writen By Michael Osborne                    *
 * VER "1.0"                                         *
 *                                                   *
*****************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape_Avoidance
{
    public partial class Form1 : Form
    { 
        //Initializing Global Variables
        Int32 RCXaxis = 700;
        Int32 RCYaxis = 100;
        Int32 GTXaxis = 700;
        Int32 GTYaxis = 100;
        Int32 GTD = 1;
        Int32 GTACTIVE = 0;
        Int32 BSXaxis = 700;
        Int32 BSYaxis = 100;
        Int32 BSACTIVE = 0;
        Int32 Score = 0;        
        Int32 Stagenumber = 0;

        public Form1()
        {
            //Make form
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            //moves pictures to their starting positions after loading the form
            CirclePicture.Location = new Point(RCXaxis, RCYaxis);
            TrianglePicture.Location = new Point(GTXaxis, GTYaxis);
            SquarePicture.Location = new Point(BSXaxis, BSYaxis);
        }
        //CorMechanicsTimer runs most of the game
        private void CoreMechanicsTimer_Tick(object sender, EventArgs e)
        {

//Getting Mouse location
            //gets mouse position in the form and puts it into X and Y co-ordinates
            Point p = this.PointToClient(Cursor.Position);
            int X = p.X;
            int Y = p.Y;

//Collision Detection            
            //Comparing Mouse position to Circle Position
             if (X >= RCXaxis - 15 && X <= RCXaxis + 15 && Y >= RCYaxis - 13 && Y <=RCYaxis + 13){
                 CoreMechanicsTimer.Stop();
                 StageTimer.Stop();
                 ScoreTimer.Stop();
                 Score = 0;
                 Restart.Visible = true;
            };
            //Comparing Mouse Position to Triangle Position
             if (X >= GTXaxis - 15 && X <= GTXaxis + 15 && Y >= GTYaxis - 13 && Y <= GTYaxis + 13)
             {
                 CoreMechanicsTimer.Stop();
                 StageTimer.Stop();
                 ScoreTimer.Stop();
                 Score = 0;
                 Restart.Visible = true;
             };
            //Comparing Mouse Position to Square Position
             if (X >= BSXaxis - 15 && X <= BSXaxis + 15 && Y >= BSYaxis - 13 && Y <= BSYaxis + 13)
             {
                 CoreMechanicsTimer.Stop();
                 StageTimer.Stop();
                 ScoreTimer.Stop();
                 Score = 0;
                 Restart.Visible = true;
             };
            //Comparing Mouse Position to Vortex Position
             if (X >= 655)
             {
                 CoreMechanicsTimer.Stop();
                 StageTimer.Stop();
                 ScoreTimer.Stop();
                 Score = 0;
                 Restart.Visible = true;
             };

//Restriction on game limits 
            //Have you exited the form?
             if (X > 703 | X < 0 | Y > 264 | Y < 0)
             {
                 Outofbounds.Visible = true;
                 Restart.Visible = true;
                 SquarePicture.Visible = false;
                 CirclePicture.Visible = false;
                 TrianglePicture.Visible = false;
                 VortexPicture.Visible = false;
                 CoreMechanicsTimer.Stop();
                 StageTimer.Stop();
                 ScoreTimer.Stop();
                 Score = 0;
                 
             }
//Red Circle Mechanics
            //move circle left 
            RCXaxis = RCXaxis - 5;
            CirclePicture.Location = new Point(RCXaxis, RCYaxis);
               
            //reset Circle to right side at a random location
            if (RCXaxis < 20){
                Random randomCircle = new Random();
                int RC = randomCircle.Next(0,200);
                RCYaxis = RC;
                RCXaxis = 700;
            }
        
 //Green Triangle Mechanics
            //does Green triangle exist in this level? (GACTIVE 1=yes/ 0 = no)
            if (GTACTIVE == 1) { 

                 GTXaxis = GTXaxis - 7;
                 int GTV = 0;

            Random randomTriY = new Random();
            
            //Green triangle is random but generally wants to go up
                 if (GTD == 1)
                  {            
                     GTV = randomTriY.Next(0,6);
                  }
            //Green Triangle generally wants to go down
                 if (GTD == 2)
                  {
                     GTV = randomTriY.Next(2, 8);
                  }
            //Green Triangle Has no Preferance
                 if (GTD == 3)
                  {
                     GTV = randomTriY.Next(0, 8);
                  }
            
            //Yaxis variation (GTV = 1-3 UP/ GTV= 4-6 Down)
                 switch(GTV){
                    //Up
                 case 1: case 2: case 3:
                    GTYaxis = GTYaxis - 5;
                    break;
                    //Down
                 case 4: case 5: case 6:
                    GTYaxis = GTYaxis + 5;
                    break;
                 }

            //sets Triangle's next location
                  TrianglePicture.Location = new Point(GTXaxis, GTYaxis);

            //Resets Triangle to right side at random location when it reaches the left side
                 if (GTXaxis < 20)
                  {
                   Random randomTrireset = new Random();
                   int GTY = randomTrireset.Next(0, 200);
                   GTYaxis = GTY;
                   GTXaxis = 700;

            //Determines direction of triangle
                   Random rdmTriDirection = new Random();
                   GTD = rdmTriDirection.Next(1, 4);
                  }
            }

//Blue Square Mechanics
            //The Blue Square is set to follow the mouse
            //does the blue square exist? (1 = yes/ 0 = no)
            if (BSACTIVE == 1)
            {
                //X and Y are the mouse coordinates
                if (BSXaxis > X)
                {
                    BSXaxis = BSXaxis - 3;
                }
                if (BSXaxis < X)
                {
                    BSXaxis = BSXaxis + 3;
                }
                if (BSYaxis > Y)
                {
                    BSYaxis = BSYaxis - 2;
                }
                if (BSYaxis < Y)
                {
                    BSYaxis = BSYaxis + 2;
                }
                //Update Location
                SquarePicture.Location = new Point(BSXaxis, BSYaxis);
            }

            //Code used to test game mechanics/functionality
            Tests();
        }
       
//A minor reset to the game 
        private void ResetGame()
        {
            //Reset Shapes
            RCXaxis = 700;
            RCYaxis = 100;
            GTXaxis = 700;
            GTYaxis = 100;
            BSXaxis = 700;
            BSYaxis = 100;


            CoreMechanicsTimer.Start();
            StageTimer.Start();
            ScoreTimer.Start();
            Restart.Visible = false;

        }
//complete game reset (back to title)
        private void Restart_Click(object sender, EventArgs e)
        {
            GTACTIVE = 0;
            BSACTIVE = 0;
            Score = 0;
            Stagenumber = 0;
            RCXaxis = 700;
            RCYaxis = 100;
            GTXaxis = 700;
            GTYaxis = 100;
            BSXaxis = 700;
            BSYaxis = 100;
            CirclePicture.Location = new Point(RCXaxis, RCYaxis);
            TrianglePicture.Location = new Point(GTXaxis, GTYaxis);
            SquarePicture.Location = new Point(BSXaxis, BSYaxis);

            SquarePicture.Visible = false;
            CirclePicture.Visible = false;
            TrianglePicture.Visible = false;
            VortexPicture.Visible = false;
            Restart.Visible = false;
            TitleBox.Visible = true;
            StartButton.Visible = true;
        }

//Move to next Level
        private void Level2_Click(object sender, EventArgs e)
        {
             
            Stagenumber++;
               //Adds Shapes for each stage
            switch(Stagenumber){
                    //Triangle
              case 1:
                 GTACTIVE = 1;
                 TrianglePicture.Visible = true;
                 Level2.Visible = false;
                 ResetGame();
                 break;
                    //Square
               case 2:
                 BSACTIVE = 1;         
                 SquarePicture.Visible = true;
                 Level2.Visible = false;
                 ResetGame();
                 break;
                    //Default
               default:            
                 SquarePicture.Visible = true;
                 Level2.Visible = false;
                 ResetGame();
                 break;
            }
        }

//Timer for stage (10 sec)
        private void StageTimer_Tick(object sender, EventArgs e)
        {
            //end of Stage
            if (Stagenumber <= 1)
            {
                CoreMechanicsTimer.Stop();
                Level2.Visible = true;
                StageTimer.Stop();
                ScoreTimer.Stop();
            }
        }

//Timer for score (1 per second)
        private void ScoreTimer_Tick(object sender, EventArgs e)
        {
            Score = Score + 1;
            string ScoreString = Score.ToString();
            Scorebox.Text = (ScoreString);
        }

//Starts game
        private void StartButton_Click(object sender, EventArgs e)
        {
            TitleBox.Visible = false;
            StartButton.Visible = false;
            SquarePicture.Visible = true;
            CirclePicture.Visible = true;
            TrianglePicture.Visible = true;
            VortexPicture.Visible = true;
            BackgroundPicture.Visible = true;
            Outofbounds.Visible = false;
            CoreMechanicsTimer.Start();
            ScoreTimer.Start();
            StageTimer.Start();
            
        }

//Test code for various mechanics
        private void Tests()
        {
            //Testing Triangle
            /*
            textBox1.Visible = true;
            string GTDS = GTD.ToString();
            textBox1.Text = (GTDS);
            */

            //Testing Circle
            /*textBox1.Visible = true;
              textBox2.Visible = true;
              textBox3.Visible = true;
              textBox4.Visible = true;
             
            //Testing Collision Detection
              if (X >= RCXaxis - 50)
              {
                  textBox1.Text = "True";
              }
              else textBox1.Text = "False";

              if (X <= RCXaxis + 50)
              {
                  textBox2.Text = "True";
              }
              else textBox2.Text = "False";

              if (Y >= RCYaxis - 40)
              {
                  textBox3.Text = "True";
              }
              else textBox3.Text = "False";

              if (Y <= RCYaxis + 40)
              {
                  textBox4.Text = "True";
              }
              else textBox4.Text = "False";
           
                  */         

        }
        
           
   }
}
