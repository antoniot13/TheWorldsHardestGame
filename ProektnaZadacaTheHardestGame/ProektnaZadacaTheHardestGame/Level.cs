using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektnaZadacaTheHardestGame
{
   
    public class Level
    {
        //  Objeti od klasata Rectangle
        public Rectangle Golem1 { get; set; }
        public Rectangle Start1 { get; set; }
        public Rectangle End1 { get; set; }
        // Instanci od klasata Ball 
        public Ball BallOne { get; set; }
        public Ball BallTwo { get; set; }
        public Ball BallThree { get; set; }
        public Ball BallFour { get; set; }
        public Ball BallFive { get; set; }
        public Ball BallSix { get; set; }
        public Ball BallSeven { get; set; }
        public Ball BallEight { get; set; }
        public Ball BallNine { get; set; }
        public Ball BallTen { get; set; }
        public Ball BallEleven { get; set; }
        public Ball BallTwelve { get; set; }
        public Ball BallThirthteen { get; set; }
        public Ball BallFourteen { get; set; }
        public Ball BallFifteen { get; set; }
        public Ball BallSixteen { get; set; }
        // static read only promenliva za golemina na topceto
        public static readonly int SIZEBALL = 5;
        // static read only promenlivi za brzinata na topcinjata zavisno od levelot
        public static readonly int VELOCITYLEVEL1 = 14;
        public static readonly int VELOCITYLEVEL2 = 20;
        public static readonly int VELOCITYLEVEL3 = 13;
        // static read only promenlivi za agolot na dvizenje na topcinjata
        public static readonly float ANGLE90 = (float)(Math.PI / 2);
        public static readonly float ANGLE45 = (float)(Math.PI / 4);
        public static readonly float ANGLE180 = (float)(Math.PI); 
        // Informacinja za brojot na tekovniot level
        public int BrojLevel { get; set; }
        // brush i pen objekti za iscrtuvanje na topcinjata i pravoagolnicite
        Brush b;
        Pen p;
        Brush brushTopce ;
        Brush bela;
       

         // Konstruktor 
        public Level(int brojlevel)
        {
            // Inicijaliziranje na brush i pen objektite
            b = new SolidBrush(Color.LightGreen);
            p = new Pen(Color.Black, 2);
            brushTopce = new SolidBrush(Color.Blue);
            bela = new SolidBrush(Color.White);
            // Setiranje na levelot
            BrojLevel = brojlevel;
            // Inicijalizacija na objektite vo zavisnost od levelot
            if (BrojLevel == 2)
            {
                Golem1 = new Rectangle(110, 90, 300, 100);
                Start1 = new Rectangle(80, 160, 30, 30);
                End1 = new Rectangle(410, 90, 30, 30);
                BallOne = new Ball(120, 100, SIZEBALL, VELOCITYLEVEL2, ANGLE180);
                BallOne.Bounds = Golem1;
                BallTwo = new Ball(400, 125, SIZEBALL, VELOCITYLEVEL2, ANGLE180);
                BallTwo.Bounds = Golem1;
                BallThree = new Ball(120, 150, SIZEBALL, VELOCITYLEVEL2, ANGLE180);
                BallThree.Bounds = Golem1;
                BallFour = new Ball(400, 175, SIZEBALL, VELOCITYLEVEL2, ANGLE180);
                BallFour.Bounds = Golem1;
            }
            else if (BrojLevel == 1)
            {
                Golem1 = new Rectangle(110, 90, 300, 160);
                Start1 = new Rectangle(60, 150, 50, 40);
                End1 = new Rectangle(410, 150, 50, 40);
                BallOne = new Ball(120, 95, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallOne.Bounds = Golem1;
                BallTwo = new Ball(145, 245, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallTwo.Bounds = Golem1;
                BallThree = new Ball(170, 95, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallThree.Bounds = Golem1;
                BallFour = new Ball(195, 245, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallFour.Bounds = Golem1;
                BallFive = new Ball(220, 95, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallFive.Bounds = Golem1;
                BallSix = new Ball(245, 245, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallSix.Bounds = Golem1;
                BallSeven = new Ball(270, 95, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallSeven.Bounds = Golem1;
                BallEight = new Ball(295, 245, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallEight.Bounds = Golem1;
                BallNine = new Ball(320, 95, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallNine.Bounds = Golem1;
                BallTen = new Ball(345, 245, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallTen.Bounds = Golem1;
                BallEleven = new Ball(370, 95, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallEleven.Bounds = Golem1;
                BallTwelve = new Ball(395, 245, SIZEBALL, VELOCITYLEVEL1, ANGLE90);
                BallTwelve.Bounds = Golem1;
            }
            else if (BrojLevel == 3)
            {
                Golem1 = new Rectangle(80, 90, 360, 150);
                Start1 = new Rectangle(40, 130, 40, 70);
                End1 = new Rectangle(440, 130, 40, 70);
                BallOne = new Ball(95, 95, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallOne.Bounds = Golem1;
                BallTwo = new Ball(125, 235, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallTwo.Bounds = Golem1;
                BallThree = new Ball(155, 95, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallThree.Bounds = Golem1;
                BallFour = new Ball(185, 235, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallFour.Bounds = Golem1;
                BallFive = new Ball(215, 95, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallFive.Bounds = Golem1;
                BallSix = new Ball(245, 235, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallSix.Bounds = Golem1;
                BallSeven = new Ball(275, 95, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallSeven.Bounds = Golem1;
                BallEight = new Ball(305, 235, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallEight.Bounds = Golem1;
                BallNine = new Ball(335, 95, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallNine.Bounds = Golem1;
                BallTen = new Ball(365, 235, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallTen.Bounds = Golem1;
                BallEleven = new Ball(395, 95, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallEleven.Bounds = Golem1;
                BallTwelve = new Ball(425, 235, SIZEBALL, VELOCITYLEVEL3, ANGLE90);
                BallTwelve.Bounds = Golem1;
                BallThirthteen = new Ball(85, 100, SIZEBALL, VELOCITYLEVEL3, ANGLE45);
                BallThirthteen.Bounds = Golem1;
                BallFourteen = new Ball(85, 230, SIZEBALL, VELOCITYLEVEL3, ANGLE45);
                BallFourteen.Bounds = Golem1;
                BallFifteen = new Ball(430, 100, SIZEBALL, VELOCITYLEVEL3, ANGLE45);
                BallFifteen.Bounds = Golem1;
                BallSixteen = new Ball(430, 230, SIZEBALL, VELOCITYLEVEL3, ANGLE45);
                BallSixteen.Bounds = Golem1;

            } 
        }
       // Metod za ctranje 
        public void Draw(Graphics g)
        {
            //Crtanjve vo zavisnot od levelot 
            if (BrojLevel == 2)
            {
                g.DrawImage(Properties.Resources.slikaKockiLevel1, 110, 90);
                g.DrawRectangle(p, Golem1);

                g.FillRectangle(b, End1);
                g.FillRectangle(b, Start1);
                g.DrawRectangle(p, 80, 160, 30, 30);
                g.DrawRectangle(p, 410, 90, 30, 30);
                BallOne.Draw(brushTopce, g);
                BallTwo.Draw(brushTopce, g);
                BallThree.Draw(brushTopce, g);
                BallFour.Draw(brushTopce, g);
                g.DrawLine(new Pen(Color.LightGreen, 2), new Point(110, 161), new Point(110, 189));
                g.DrawLine(new Pen(Color.LightGreen, 2), new Point(410, 91), new Point(410, 119));
            }
            else if (BrojLevel == 1)
            {  
                g.DrawImage(Properties.Resources.slikaKocki, 110, 90);
                DrawRectAndBalls(g);
                g.DrawRectangle(p, 60, 150, 50, 40);
                g.DrawRectangle(p, 410, 150, 50, 40);
                g.DrawLine(new Pen(Color.LightGreen, 2), new Point(110, 151), new Point(110, 189));
                g.DrawLine(new Pen(Color.LightGreen, 2), new Point(410, 151), new Point(410, 189));
               
            }
            else if (BrojLevel == 3)
            {
                g.DrawImage(Properties.Resources.slikaKockiLevel3, 80, 90);
               
                DrawRectAndBalls(g);
                BallThirthteen.Draw(brushTopce,g);
                BallFourteen.Draw(brushTopce,g);
                BallFifteen.Draw(brushTopce, g);
                BallSixteen.Draw(brushTopce, g);
                g.DrawRectangle(p, 40, 130, 40, 70);
                g.DrawRectangle(p, 440, 130, 40, 70);
                g.DrawLine(new Pen(Color.LightGreen, 2), new Point(80, 131), new Point(80, 199));
                g.DrawLine(new Pen(Color.LightGreen, 2), new Point(440, 131), new Point(440, 199));
               
            }     
        }
        // Pomosna funkcinja koja gi isrctuva figurite koi se isti za site leveli
        public void DrawRectAndBalls(Graphics g)
        {
            g.DrawRectangle(p, Golem1);
            g.FillRectangle(b, Start1);
            g.FillRectangle(b, End1);
            BallOne.Draw(brushTopce, g);
            BallTwo.Draw(brushTopce, g);
            BallThree.Draw(brushTopce, g);
            BallFour.Draw(brushTopce, g);
            BallFive.Draw(brushTopce, g);
            BallSix.Draw(brushTopce, g);
            BallSeven.Draw(brushTopce, g);
            BallEight.Draw(brushTopce, g);
            BallNine.Draw(brushTopce, g);
            BallTen.Draw(brushTopce, g);
            BallEleven.Draw(brushTopce, g);
            BallTwelve.Draw(brushTopce, g);
        }
        
    }
}
