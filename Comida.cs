using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Comida
    {
        private int x, y, width, height;
        private SolidBrush pincel;
        public Rectangle comidarec;

        public Comida(Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;
        }
        public void dibujodecomida(Graphics paper)
        {
            comidarec.X = x;
            comidarec.Y = y;

            paper.FillRectangle(pincel, comidarec);
        }
    }
}
