using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphApp
{
    class BitmapManager
    {
        public Bitmap Pucture { get; set; }

        public int Width { get; private set; }

        public int Height { get; private set; }

        public BitmapManager(int width, int height)
        {
            Height = height;
            Width = width;
            Pucture = new Bitmap(width, height);
        }

        public Color[,] GetColors()
        {
            Color[,] colors = new Color[Height, Width];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    colors[i, j] = Pucture.GetPixel(Width, Height);
                }
            }
            return colors;
        }

        public void SetColors(Color[,] colors)
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Pucture.SetPixel(Width, Height, colors[i,j]);
                }
            }
        }

       
    }
}
