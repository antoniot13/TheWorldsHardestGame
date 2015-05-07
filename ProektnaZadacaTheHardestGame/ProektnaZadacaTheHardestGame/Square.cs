using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProektnaZadacaTheHardestGame
{
    public class Square
    {

       
        public int X { get; set; }
        public int Y { get; set; }
        public enum Direction { Left, Right, Up, Down }
        public Direction direction { get; set; }
        public static readonly int SIDE = 15;
        public static readonly int VELOCITY = 5;
        public Brush brush { get; set; }
        public Pen pen { get; set; }
        public Level l1;
        public int Deaths { get; set; }
        public int BrojLevel { get; set; }
        bool flag { get; set; }
        public bool flagCrtanje { get; set; }
       
        Timer t;

        public Square(int brojlevel,int deaths)
        {
            
            BrojLevel = brojlevel;
           
            if (BrojLevel == 3)
            {

                X = 50;
                Y = 165;
            }
            else
            {
                X = 85;
                Y = 165;
            }

            flagCrtanje = false;
            
            brush = new SolidBrush(Color.Red);
            pen = new Pen(Color.Black,2);
            direction = Direction.Right;
            l1 = new Level(BrojLevel);
            Deaths = deaths;
            flag = false; 
           
        }
        public void Move()
        {
            if (BrojLevel == 2)
                MoveLevel2();
            else if (BrojLevel == 1)
                MoveLevel1();
            else if(BrojLevel==3)
                MoveLevel3();

           
            
        }
        public void IsHit(float x,float y)
        {
            flag = false;
           
            if (Math.Abs(X - x) < SIDE - 5 && Math.Abs(Y - y) < SIDE - 5)
            {
              
                if (BrojLevel == 3)
                {
                    if (!flagCrtanje)
                    {
                        
                            X = 50;
                            Y = 165;
                    }
                }
                else
                {
                    if (!flagCrtanje)
                    {
                       
                            X = 85;
                            Y = 165;
                        
                    }
                }

                flagCrtanje = true;
                flag = true;
            }
            if (Math.Abs(X + 10 - x) <= SIDE - 5 && Math.Abs(Y + 10 - y) <= SIDE - 5)
            {

               
                if (BrojLevel == 3)
                {
                    if (!flagCrtanje)
                    {
                     
                            X = 50;
                            Y = 165;
                       
                    }
                    
                }
                else
                {
                    if (!flagCrtanje)
                    {
                      
                            X = 85;
                            Y = 165;
                    }
                   
                }
                flagCrtanje = true;
                flag = true;
               
            }
         
            if (flag)
                Deaths++;     
            
        }
        public void MoveLevel3()
        {
            Rectangle g = l1.Golem1;
            Rectangle s = l1.Start1;
            Rectangle e = l1.End1;
            if (X + SIDE >= 440 && Y + SIDE >= 130 && Y + SIDE <= 200)
            {
                 BrojLevel++;
                 
                if (Y - SIDE / 4 + 1 <= e.Top && X + SIDE >= e.Right)
                {
                    if (direction == Direction.Down)
                        Y += VELOCITY;
                    if (direction == Direction.Left)
                        X -= VELOCITY;
                }
                else if (X + SIDE >= e.Right && Y + SIDE >= e.Bottom)
                {
                    if (direction == Direction.Up)
                        Y -= VELOCITY;
                    if (direction == Direction.Left)
                        X -= VELOCITY;
                }

                else if (Y - SIDE / 4 + 1 <= e.Top)
                {
                    if (Y >= 90 && Y <= 130 && X + SIDE == 440)
                    {
                        RLUP();
                    }
                    RLD();
                }
                else if (Y + SIDE >= e.Bottom)
                {
                    if (Y + SIDE == 200 && X + SIDE == 440)
                    {
                        RLUP();
                    }
                    RLU();
                }
                else
                {
                    RLUP();
                }
            }
            else if (X <= 80 && Y >= 130 && Y <= 200)
            {
                if (X - SIDE / 4 + 1 <= s.Left && Y - SIDE / 4 + 1 <= s.Top)
                {
                    if (direction == Direction.Right)
                        X += VELOCITY;
                    if (direction == Direction.Down)
                        Y += VELOCITY;
                }
                else if (X - SIDE / 4 + 1 <= s.Left && Y + SIDE >= s.Bottom)
                {
                    if (direction == Direction.Right)
                        X += VELOCITY;
                    if (direction == Direction.Up)
                        Y -= VELOCITY;
                }

                else if (X - SIDE / 4 + 1 <= s.Left)
                {
                    RUD();
                }
                else if (Y - SIDE / 4 + 1 <= s.Top)
                {
                    if (Y == 130 && X == 80)
                    {
                        RLUP();
                    }
                    RLD();
                }
                else if (Y + SIDE >= s.Bottom)
                {
                    if (Y + SIDE >= 200 && Y + SIDE <= 240 && X == 80)
                    {
                        RUD();
                    }
                    else
                        RLU();
                }
                else
                {
                    RLUP();
                }
            }
            else
                Borders(g);
            
        }
        public void MoveLevel1()
        {
            Rectangle g = l1.Golem1;
            Rectangle s = l1.Start1;
            Rectangle e = l1.End1;
            if (X + SIDE >= 410 && Y + SIDE >= 150 && Y + SIDE <= 190)
            {
                BrojLevel++;

                if (Y - SIDE / 4 + 1 <= e.Top && X + SIDE >= e.Right)
                {
                    if (direction == Direction.Down)
                        Y += VELOCITY;
                    if (direction == Direction.Left)
                        X -= VELOCITY;
                }
                else if (X + SIDE >= e.Right && Y + SIDE >= e.Bottom)
                {
                    if (direction == Direction.Up)
                        Y -= VELOCITY;
                    if (direction == Direction.Left)
                        X -= VELOCITY;
                }

                else if (Y - SIDE / 4 + 1 <= e.Top)
                {
                    if (Y  >= 90 && Y  <= 150 && X + SIDE == 410)
                    {
                        RLUP();
                    }
                    RLD();
                }
                else if (Y + SIDE >= e.Bottom)
                {
                    if (Y + SIDE == 190 && X + SIDE == 410)
                    {
                        RLUP();
                    }
                    RLU();
                }
                else
                {
                    RLUP();
                }
            }
            else if (X <= 110 && Y >= 150 && Y <= 190)
            {
                if (X - SIDE / 4 + 1 <= s.Left && Y - SIDE / 4 + 1 <= s.Top)
                {
                    if (direction == Direction.Right)
                        X += VELOCITY;
                    if (direction == Direction.Down)
                        Y += VELOCITY;
                }
                else if (X - SIDE / 4 + 1 <= s.Left && Y + SIDE >= s.Bottom)
                {
                    if (direction == Direction.Right)
                        X += VELOCITY;
                    if (direction == Direction.Up)
                        Y -= VELOCITY;
                }

                else if (X - SIDE / 4 + 1 <= s.Left)
                {
                    RUD();
                }
                else if (Y - SIDE / 4 + 1 <= s.Top)
                {
                    if (Y == 150 && X == 110)
                    {
                        RLUP();
                    }
                    RLD();
                }
                else if (Y + SIDE >= s.Bottom)
                {
                    if (Y+SIDE >= 190 && Y+SIDE <= 250 && X == 110)
                    {
                        RUD();
                    }
                    else 
                        RLU();
                }
                else
                {
                    RLUP();
                }
            }
            else
                Borders(g);
        }
        public void MoveLevel2()
        {
            
            Rectangle g = l1.Golem1;
            Rectangle s = l1.Start1;
            Rectangle e = l1.End1;

           
            if (X+SIDE >= 410 && Y+SIDE >= 90 && Y+SIDE <= 120)
            {
                BrojLevel++;
            

                if (Y - SIDE / 4 + 1 <= e.Top && X + SIDE >= e.Right)
                {
                    if (direction == Direction.Down)
                        Y += VELOCITY;
                    if (direction == Direction.Left)
                        X -= VELOCITY;
                }
                else if (X + SIDE >= e.Right && Y + SIDE >= e.Bottom)
                {
                    if (direction == Direction.Up)
                        Y -= VELOCITY;
                    if (direction == Direction.Left)
                        X -= VELOCITY;
                }

                else if (Y - SIDE / 4 + 1 <= e.Top)
                {
                    RLD();
                }
                else if (Y + SIDE >= e.Bottom)
                {
                    if (Y+SIDE == 120 && X +SIDE== 410)
                    {
                        RLUP();
                    }
                    RLU();
                }
                else
                {
                    RLUP();
                }
            }
            else if (X <= 110 && Y >= 160 && Y <= 190)
            {
                if (X - SIDE / 4 + 1 <= s.Left && Y - SIDE / 4 + 1 <= s.Top)
                {
                    if (direction == Direction.Right)
                        X += VELOCITY;
                    if (direction == Direction.Down)
                        Y += VELOCITY;
                }
                else if (X - SIDE / 4 + 1 <= s.Left && Y + SIDE >= s.Bottom)
                {
                    if (direction == Direction.Right)
                        X += VELOCITY;
                    if (direction == Direction.Up)
                        Y -= VELOCITY;
                }

                else if (X - SIDE / 4 + 1 <= s.Left)
                {
                    RUD();
                }
                else if (Y - SIDE / 4 + 1 <= s.Top)
                {
                    if (Y == 160 && X == 110)
                    {
                        RLUP();
                    }
                    RLD();
                }
                else if (Y + SIDE >= s.Bottom)
                {
                    RLU();
                }
                else
                {
                    RLUP();
                }
            }
            else
            {
                Borders(g);
            }
        }
        public void Borders(Rectangle g)
        {
             
            if (X - SIDE / 4 + 1 <= g.Left && Y - SIDE / 4 + 1 <= g.Top)
            {
                if (direction == Direction.Right)
                    X += VELOCITY;
                if (direction == Direction.Down)
                    Y += VELOCITY;
            }
            else if (X - SIDE / 4 + 1 <= g.Left && Y + SIDE >= g.Bottom)
            {
                if (direction == Direction.Right)
                    X += VELOCITY;
                if (direction == Direction.Up)
                    Y -= VELOCITY;
            }
            else if (Y - SIDE / 4 + 1 <= g.Top && X + SIDE >= g.Right)
            {
                if (direction == Direction.Down)
                    Y += VELOCITY;
                if (direction == Direction.Left)
                    X -= VELOCITY;
            }
            else if (X + SIDE >= g.Right && Y + SIDE >= g.Bottom)
            {
                if (direction == Direction.Up)
                    Y -= VELOCITY;
                if (direction == Direction.Left)
                    X -= VELOCITY;
            }
            else if (X - SIDE / 4 + 1 <= g.Left)
            {
                RUD();
            }
            else if (X + SIDE >= g.Right)
            {
                LUD();
            }
            else if (Y - SIDE / 4 + 1 <= g.Top)
            {
                RLD();
            }
            else if (Y + SIDE >= g.Bottom)
            {
                RLU();
            }
            else
            {
                RLUP();
            }

            
        }
        public void RLUP()
        {
            if (direction == Direction.Right)
                X += VELOCITY;
            if (direction == Direction.Left)
                X -= VELOCITY;
            if (direction == Direction.Up)
                Y -= VELOCITY;
            if (direction == Direction.Down)
                Y += VELOCITY;
        }
        public void RLU()
        {
            if (direction == Direction.Right)
                X += VELOCITY;
            if (direction == Direction.Left)
                X -= VELOCITY;
            if (direction == Direction.Up)
                Y -= VELOCITY;
        }
        public void RLD()
        {
            if (direction == Direction.Right)
                X += VELOCITY;
            if (direction == Direction.Left)
                X -= VELOCITY;
            if (direction == Direction.Down)
                Y += VELOCITY;
        }
        public void RUD()
        {
             if (direction == Direction.Right)
                 X += VELOCITY;     
            if (direction == Direction.Up)
                Y -= VELOCITY;
            if (direction == Direction.Down)
                Y += VELOCITY;
        }
        public void LUD()
        {
            if (direction == Direction.Left)
                X -= VELOCITY;
            if (direction == Direction.Up)
                Y -= VELOCITY;
            if (direction == Direction.Down)
                Y += VELOCITY;
        }
        public  void TimerCallback(Object o)
        {
            flagCrtanje = false;
            GC.Collect();
        }
        public void Draw(Graphics g)
        {
           
            Brush br = new SolidBrush(Color.FromArgb(255, 0, 255, 0));
            if (flagCrtanje)
            {

                g.FillRectangle(br, X, Y, SIDE, SIDE);
                g.DrawRectangle(pen, X, Y, SIDE, SIDE);
                t = new Timer(TimerCallback, null, 200, 500);
            }
            else
            {

                g.FillRectangle(brush, X, Y, SIDE, SIDE);
                g.DrawRectangle(pen, X, Y, SIDE, SIDE);

            }
           
           
            
        }
        
      

    } 
}
