using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace WindowsFormsApp1
{
    class Snake
    {
        private Rectangle[] snakeRec;
        private SolidBrush pincel;
        private int x, y, width, height;

        public Rectangle[] SnakeRec
        {
            get
            {
                return snakeRec;
            }

        }
        public Snake()
        {
            snakeRec = new Rectangle[3];
            pincel = new SolidBrush(Color.DarkBlue);

            x = 20;
            y = 0;
            width = 10;
            height = 10;
            for (int i = 0; i < snakeRec.Length; i++) ;
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }

        }
        public void dibujasnake(Graphics papel)
        {
            foreach (Rectangle rec in snakeRec)
            {

                papel.FillRectangle(pincel, rec);

            }
        }
        public void dibujasnake()
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {

                snakeRec[i] = snakeRec[i - 1];

            }
        }
        public void movimientoabajo()
        {
            dibujasnake();
            snakeRec[0].Y += 10;
        }
        public void movimientoarriba()
        {
            dibujasnake();
            snakeRec[0].Y -= 10;
        }
        public void movimientoizquierda()
        {
            dibujasnake();
            snakeRec[0].X -= 10;
        }
        public void movimientoderecha()
        {
            dibujasnake();
            snakeRec[0].X += 10;
        }
        public void crecimientodesnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
        }
       
    }
}
     

    

 
