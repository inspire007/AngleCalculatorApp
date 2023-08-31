using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AngleCalc
{
    public partial class ImageViewer : Form
    {
        public string imagePath;
        private Point p1, p2, p3;
        List<Point> p1List = new List<Point>();
        List<Point> p2List = new List<Point>();
        List<Point> p3List = new List<Point>();

        public ImageViewer(string imagePath)
        {
            InitializeComponent();
            this.imagePath = imagePath;
        }

        private void ImageViewer_Load(object sender, EventArgs e)
        {
            try
            {
                Image image = Image.FromFile(this.imagePath);
                pictureBox1.Image = image;
            }
            catch
            {
                MessageBox.Show("Failed to load image");
                this.Close();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (p1.X == 0)
            {
                p1.X = e.X;
                p1.Y = e.Y;
                a1.Text = p1.ToString();
            }
            else if (p2.X == 0)
            {
                p2.X = e.X;
                p2.Y = e.Y;
                a2.Text = p2.ToString();
            }
            else
            {
                p3.X = e.X;
                p3.Y = e.Y;
                a3.Text = p3.ToString();

                // + ((Control)sender).Right
                p1List.Add(p1);
                p2List.Add(p2);
                p3List.Add(p3);

                CalcAngle();
                pictureBox1.Invalidate();
                p1.X = 0;
                p1.Y = 0;
                p2.X = 0;
                p2.Y = 0;
                p3.X = 0;
                p3.Y = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p1 = new Point {X = 0, Y = 0};
            p2 = new Point {X = 0, Y = 0};
            p3 = new Point {X = 0, Y = 0};
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            angle_ans.Text = "";
            Image image = Image.FromFile(this.imagePath);
            pictureBox1.Image = image;
        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            /*var a = new Point { X = 0, Y = 100 };
            var b = new Point { X = 0, Y = 200 };
            var c = new Point { X = 100, Y = 0 };*/

            Bitmap bit = (Bitmap)pictureBox1.Image;
            int heightB = bit.Height;
            int heightP = pictureBox1.Height;
            int widthB = bit.Width;
            int widthP = pictureBox1.Width;
            double xRatio = (double)widthB / (double)widthP;
            double yRatio = (double)heightB / (double)heightP;

            Graphics G = Graphics.FromImage(pictureBox1.Image);
            using (var p = new Pen(Color.Blue, 5))
            {
                for (int x = 0; x < p1List.Count; x++)
                {
                    var a = new Point { X = (int)(p1List[x].X * xRatio), Y = (int)(p1List[x].Y * yRatio) };
                    var b = new Point { X = (int)(p2List[x].X * xRatio), Y = (int)(p2List[x].Y * yRatio) };
                    var c = new Point { X = (int)(p3List[x].X * xRatio), Y = (int)(p3List[x].Y * yRatio) };

                    //G.DrawLine(p, p1List[x], p2List[x]);
                    //G.DrawLine(p, p2List[x], p3List[x]);

                    G.DrawLine(p, a, b);
                    G.DrawLine(p, b, c);
                }
                p1List.Clear();
                p2List.Clear();
                p3List.Clear();
                pictureBox1.Invalidate();
                G.Dispose();
            }           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            point.Text = e.X.ToString() + "," + e.Y.ToString();
        }

        private void CalcAngle()
        {
            double p0c = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            double p1c = Math.Sqrt(Math.Pow(p2.X - p3.X, 2) + Math.Pow(p2.Y - p3.Y, 2));
            double p0p1 = Math.Sqrt(Math.Pow(p1.X - p3.X, 2) + Math.Pow(p1.Y - p3.Y, 2));

            double ans = Math.Acos((p1c * p1c + p0c * p0c - p0p1 * p0p1) / (2 * p1c * p0c));
            ans = (ans * 180) / 3.1416;
            angle_ans.Text = ans.ToString();
        }
    }
}
