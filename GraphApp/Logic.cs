using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApp
{
    class Logic
    {


        public Logic()
        {
            Pixels = new bool[190, 130];
        }





        public bool[,] Pixels { get; set; }


        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            DrawPointsInLine(x1, y1, x2, y2);
            if (y1 > 0 && y2 > 0)
            {
                DrawPointsInLine(x1, y1 - 1, x2, y2 - 1);
            }
            if (y1 + 1 < Pixels.GetLength(1) && y2 + 1 < Pixels.GetLength(1))
            {
                DrawPointsInLine(x1, y1 + 1, x2, y2 + 1);
            }


            DrawPointsInLine(x1, y1, x2, y2);
            if (x1 > 0 && x2 > 0)
            {
                DrawPointsInLine(x1 - 1, y1, x2 - 1, y2);
            }
            if (x1 + 1 < Pixels.GetLength(0) && x2 + 1 < Pixels.GetLength(0))
            {
                DrawPointsInLine(x1 + 1, y1, x2 + 1, y2);
            }
        }

        private void DrawPointsInLine(int x1, int y1, int x2, int y2)
        {
            if (x1 > x2)
            {
                int temp = x2;
                x2 = x1;
                x1 = temp;
                temp = y2;
                y2 = y1;
                y1 = temp;
            }
            int tempY;
            for (int i = x1; i < x2; i++)
            {
                tempY = y1 + (i - x1) * (y2 - y1) / (x2 - x1);
                Pixels[i, tempY] = true;
            }
        }




    }
}
