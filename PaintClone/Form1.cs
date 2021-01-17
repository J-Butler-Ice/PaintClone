using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintClone
{
    public partial class PaintClone : Form
    {
        Bitmap bmp = new Bitmap(1024, 768);
        Pen p = new Pen(Color.Black, 5);
        bool drawing = false;
        public PaintClone()
        {
            InitializeComponent();
        }

        private void CanvasBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
            }
            else
            {
                drawing = true;
            }
        }

        private void CanvasBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(drawing){
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 3, 1);
                canvasBox.Image = bmp;
            }
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void BlackButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG File|.png";
            saveFileDialog1.Title = "Save As";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.canvasBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.canvasBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case 3:
                        this.canvasBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
            }
        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            p.Color = Color.Azure;
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(1024, 768);
            canvasBox.Image = bmp;
        }
    }
}
