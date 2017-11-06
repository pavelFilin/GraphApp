using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace GraphApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            log = new Logic();
            Constants.PixelSize = pictureBox1.Width / log.Pixels.GetLength(0);
            pictureBox1.Paint += DrawPixels;
        }

        private Logic log;
        
        private void DrawPixels(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < log.Pixels.GetLength(0); i++)
            {
                for(int j = 0; j < log.Pixels.GetLength(1); j++)
                {
                    if (log.Pixels[i, j])
                    {
                        e.Graphics.FillRectangle(Brushes.Black, i * Constants.PixelSize, j * Constants.PixelSize, Constants.PixelSize, Constants.PixelSize);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(Brushes.White, i * Constants.PixelSize, j * Constants.PixelSize, Constants.PixelSize, Constants.PixelSize);
                    }
                   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Bitmap bmpSave = (Bitmap)pictureBox1.Image;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmpSave.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
