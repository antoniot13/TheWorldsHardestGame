using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektnaZadacaTheHardestGame
{
    public partial class Form1 : Form
    {
        public Bitmap slika;
        public Square kvadrat;
        public Level level;
        public int brojLevel { get; set; }
        public Timer timer;
        public int Deaths { get; set; }
        Form formaStart;
        public bool flagVtor { get; set; }
        public bool flagTret { get; set; }
        public Form endForm;
        public SoundPlayer sound;
        public bool flagS;
        public Form1()
        {
           InitializeComponent();
           sound = new SoundPlayer(Properties.Resources.song);
           sound.PlayLooping();
           flagS = true;
            this.DoubleBuffered = true;
            flagVtor = false;
            flagTret = false;
            brojLevel = 1;
            Deaths = 0;
            kvadrat = new Square(brojLevel,Deaths);
            level = new Level(brojLevel);
            
          
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Start();
           
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            
            Graphics g = e.Graphics;
            g.Clear(Color.AliceBlue);
            level.Draw(g);
             


            kvadrat.Draw(g);
            String s="Deaths: "+kvadrat.Deaths;
            FontFamily fontFamily = new FontFamily("Britannic Bold");
             Font font = new Font(
               fontFamily,
               20,
               FontStyle.Italic,
               GraphicsUnit.Pixel);
             g.DrawString(s, font, new SolidBrush(Color.Black), 400, 10);
             g.DrawString("Menu", font, new SolidBrush(Color.Black), 25, 10);

            
        }
     
       
          
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
             if (e.KeyCode== Keys.A)
            {
                kvadrat.direction = Square.Direction.Left;
            }
             else if (e.KeyCode == Keys.D)
            {
                kvadrat.direction = Square.Direction.Right;
               
            }
             else if (e.KeyCode == Keys.W)
            {
                kvadrat.direction = Square.Direction.Up;
               

            }
             else if (e.KeyCode == Keys.S)
            {
                kvadrat.direction = Square.Direction.Down;
            }
             


              kvadrat.Move();
              Deaths = kvadrat.Deaths;
              if (kvadrat.BrojLevel == 2 && !flagVtor)
              {
                  flagVtor = true;
                  brojLevel = kvadrat.BrojLevel;
                  level = new Level(brojLevel);
                  kvadrat = new Square(brojLevel,Deaths);  
              }
              if (kvadrat.BrojLevel == 3 && !flagTret)
              {
                  flagTret = true;
                  brojLevel = kvadrat.BrojLevel;
                  level = new Level(brojLevel);
                  kvadrat = new Square(brojLevel, Deaths);  
              }
              if (kvadrat.BrojLevel == 4)
              {
                  endForm = new EndFormcs(Deaths);
                  this.Hide();
                  endForm.Show();
              }

            Invalidate();
        }
        
        public void timer_Tick(object sender, EventArgs e)
        {

            if (brojLevel == 2)
            {
               level.BallOne.Move();
                level.BallTwo.Move();
                level.BallThree.Move();
                level.BallFour.Move();
                kvadrat.IsHit(level.BallOne.X, level.BallOne.Y);
                kvadrat.IsHit(level.BallTwo.X, level.BallTwo.Y);
                kvadrat.IsHit(level.BallThree.X, level.BallThree.Y);
                kvadrat.IsHit(level.BallFour.X, level.BallFour.Y);
            }
            else if(brojLevel==1)
            {
                MoveAndHit();
            }
            else if (brojLevel == 3)
            {
                MoveAndHit();
                level.BallThirthteen.Move();
                level.BallFourteen.Move();
                level.BallFifteen.Move();
                level.BallSixteen.Move();
                kvadrat.IsHit(level.BallThirthteen.X, level.BallThirthteen.Y);
                kvadrat.IsHit(level.BallFourteen.X, level.BallFourteen.Y);
                kvadrat.IsHit(level.BallFifteen.X, level.BallFifteen.Y);
                kvadrat.IsHit(level.BallSixteen.X, level.BallSixteen.Y);
                
            }
            Invalidate();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a')
            {
                kvadrat.direction = Square.Direction.Left;
            }
            else if (e.KeyChar == 'd')
            {
                kvadrat.direction = Square.Direction.Right;
               
            }
            else if (e.KeyChar == 'w')
            {
                kvadrat.direction = Square.Direction.Up;
               

            }
            else if (e.KeyChar == 's')
            {
                kvadrat.direction = Square.Direction.Down;
            }


            kvadrat.Move();
            Deaths = kvadrat.Deaths;
            if (kvadrat.BrojLevel == 2 && !flagVtor)
            {
                brojLevel = kvadrat.BrojLevel;
                level = new Level(brojLevel);
                kvadrat = new Square(brojLevel, Deaths);
                flagVtor = true;
            }
            else if (kvadrat.BrojLevel == 3 && !flagTret)
            {
                flagTret = true;
                brojLevel = kvadrat.BrojLevel;
                level = new Level(brojLevel);
                kvadrat = new Square(brojLevel, Deaths);
            }

            Invalidate();
        }


        

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            formaStart = new StartForm();
            formaStart.Show();
            this.Hide();
        }

        private void rectangleShape1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void rectangleShape1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void MoveAndHit()
        {
            level.BallOne.Move();
            level.BallTwo.Move();
            level.BallThree.Move();
            level.BallFour.Move();
            level.BallFive.Move();
            level.BallSix.Move();
            level.BallSeven.Move();
            level.BallEight.Move();
            level.BallNine.Move();
            level.BallTen.Move();
            level.BallEleven.Move();
            level.BallTwelve.Move();
            kvadrat.IsHit(level.BallOne.X, level.BallOne.Y);
            kvadrat.IsHit(level.BallTwo.X, level.BallTwo.Y);
            kvadrat.IsHit(level.BallThree.X, level.BallThree.Y);
            kvadrat.IsHit(level.BallFour.X, level.BallFour.Y);
            kvadrat.IsHit(level.BallFive.X, level.BallFive.Y);
            kvadrat.IsHit(level.BallSix.X, level.BallSix.Y);
            kvadrat.IsHit(level.BallSeven.X, level.BallSeven.Y);
            kvadrat.IsHit(level.BallEight.X, level.BallEight.Y);
            kvadrat.IsHit(level.BallNine.X, level.BallNine.Y);
            kvadrat.IsHit(level.BallTen.X, level.BallTen.Y);
            kvadrat.IsHit(level.BallEleven.X, level.BallEleven.Y);
            kvadrat.IsHit(level.BallTwelve.X, level.BallTwelve.Y);
        }

        private void volume_Click(object sender, EventArgs e)
        {
            flagS = !flagS;

            if (flagS)
            {
                volume.Image = Properties.Resources.volume1;
                sound.PlayLooping();

            }
            else
            {
                volume.Image = Properties.Resources.mute1;
                sound.Stop();
            }
        }
       
    }
    
}
