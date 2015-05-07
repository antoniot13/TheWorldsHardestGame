using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektnaZadacaTheHardestGame
{
    public class Ball
    {
        // Pozicija na topceto
        public float X { get; set; }
        public float Y { get; set; }
        // Radius na topceto
        public float Radius { get; set; }
        // Brzina na dvizennje
        public float Velocity { get; set; }
        // Agol na dvizenje
        public float Angle { get; set; }
        // Granici na dvizenje 
        public Rectangle Bounds;
        

        private float velocityX;
        private float velocityY;
        // Kontruktor so 5 argumenti za setiranje na soodvetnite vrednosti dadeni kako argumenti
        public Ball(float x, float y, float radius, float velocity, float angle)
        {
            
            X = x;
            Y = y;
            Radius = radius;
            Velocity = velocity;
            Angle = angle;
            velocityX = (float)Math.Cos(Angle) * Velocity;
            velocityY = (float)Math.Sin(Angle) * Velocity;
        }
        //Metoda so koja se ovozmozuva dvizenje na topceto vo granicite dadeni so objektot Bounds
        public void Move()
        {
            float nextX = X + velocityX;
            float nextY = Y + velocityY;
            // Ogranicuvanje od levo i od desno
            if (nextX - Radius <= Bounds.Left || (nextX + Radius >= Bounds.Right))
            {
                velocityX = -velocityX;
            }
            // Ogranicuvanje od gore i od dole
            if (nextY - Radius <= Bounds.Top || (nextY + Radius >= Bounds.Bottom))
            {
                velocityY = -velocityY;
            }
            // Pomestuvanje na topceto
            X += velocityX;
            Y += velocityY;
        }
        // Iscrtuvanje na topceto vrz osnova na pozicijata i radiusot
        public void Draw(Brush brush, Graphics g)
        {
            Pen pen=new Pen(Color.Black,3);
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
    }
}
