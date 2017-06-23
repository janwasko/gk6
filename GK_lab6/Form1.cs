using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK_lab6
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Black, 1);
        private System.Drawing.Pen pen_red = new System.Drawing.Pen(Color.Red, 1);
        private System.Drawing.Pen pen_gray = new System.Drawing.Pen(Color.Gray, 1);
        private SolidBrush brush1 = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            P1x.Text = "-200";
            P1y.Text = "50";
            P2x.Text = "-150";
            P2y.Text = "-50";
            P3x.Text = "-100";
            P3y.Text = "50";
            P4x.Text = "-50";
            P4y.Text = "-50";
            P5x.Text = "0";
            P5y.Text = "50";
            P6x.Text = "50";
            P6y.Text = "-50";
            P7x.Text = "100";
            P7y.Text = "50";
            P8x.Text = "150";
            P8y.Text = "-50";
        }
        private void drawPoint(int x, int y)
        {
            g.DrawEllipse(pen_red, x - 1 + pictureBox1.Width / 2, -y - 1 + pictureBox1.Height / 2, 3, 3);
            g.FillEllipse(brush1, x - 1 + pictureBox1.Width / 2, -y - 1 + pictureBox1.Height / 2, 3, 3);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int P1_x, P1_y, P4_x, P4_y, R1_x, R1_y, R4_x, R4_y;
            double t, t2, t3;
            
            int.TryParse(P1x.Text, out P1_x);
            int.TryParse(P1y.Text, out P1_y);
            int.TryParse(P2x.Text, out P4_x);
            int.TryParse(P2y.Text, out P4_y);
            int.TryParse(P3x.Text, out R1_x);
            int.TryParse(P3y.Text, out R1_y);
            int.TryParse(P4x.Text, out R4_x);
            int.TryParse(P4y.Text, out R4_y);
            int n = 100;
            int prev_x, prev_y;
            double x = P1_x, y = P1_y;
            double delta = 1.0 / n;
            for (int i = 0; i < n; i++)
            {
                t = delta * i;
                t2 = t * t;
                t3 = t2 * t;
                prev_x = (int)x;
                prev_y = (int)y;
                x = (int)((2 * t3 - 3 * t2 + 1) * P1_x + (-2 * t3 + 3 * t2) * P4_x + (t3 - 2 * t2 + t) * R1_x + (t3 - t2) * R4_x);
                y = (int)((2 * t3 - 3 * t2 + 1) * P1_y + (-2 * t3 + 3 * t2) * P4_y + (t3 - 2 * t2 + t) * R1_y + (t3 - t2) * R4_y);

                g.DrawLine(pen1, prev_x + pictureBox1.Width / 2, prev_y + pictureBox1.Height / 2, (int)x + pictureBox1.Width / 2, (int)y + pictureBox1.Height / 2);
            }
            //drawPoint(P1_x, P1_y);
            //drawPoint(P4_x, P4_y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int P1_x, P1_y, P2_x, P2_y, R1_x, R1_y, R2_x, R2_y;
            double t, t2, t3;
            int.TryParse(P1x.Text, out P1_x);
            int.TryParse(P1y.Text, out P1_y);
            int.TryParse(P2x.Text, out P2_x);
            int.TryParse(P2y.Text, out P2_y);
            int.TryParse(P3x.Text, out R1_x);
            int.TryParse(P3y.Text, out R1_y);
            int.TryParse(P4x.Text, out R2_x);
            int.TryParse(P4y.Text, out R2_y);


            int n = 100;
            int prev_x, prev_y;
            double x = P1_x, y = P1_y;
            double delta = 1.0 / n;
            for (int i = 0; i < n; i++)
            {
                t = delta * i;
                t2 = t * t;
                t3 = t2 * t;
                prev_x = (int)x;
                prev_y = (int)y;
                x = (int)((1 - t) * (1 - t) * (1 - t) * P1_x + 3 * t * (1 - t) * (1 - t) * P2_x + 3 * t2 * (1 - t) * R1_x + (t3) * R2_x);
                y = (int)((1 - t) * (1 - t) * (1 - t) * P1_y + 3 * t * (1 - t) * (1 - t) * P2_y + 3 * t2 * (1 - t) * R1_y + (t3) * R2_y);

                g.DrawLine(pen1, prev_x + pictureBox1.Width / 2, prev_y + pictureBox1.Height / 2, (int)x + pictureBox1.Width / 2, (int)y + pictureBox1.Height / 2);
            }
            //drawPoint(P1_x, P1_y);
            //drawPoint(P2_x, P2_y);
            //drawPoint(R1_x, R1_y);
            //drawPoint(R2_x, R2_y);
        }
            

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int P1_x, P1_y, P2_x, P2_y, P3_x, P3_y, P4_x, P4_y, P5_x, P5_y, P6_x, P6_y, P7_x, P7_y, P8_x, P8_y;


            int.TryParse(P1x.Text, out P1_x);
            int.TryParse(P1y.Text, out P1_y);
            int.TryParse(P2x.Text, out P2_x);
            int.TryParse(P2y.Text, out P2_y);
            int.TryParse(P3x.Text, out P3_x);
            int.TryParse(P3y.Text, out P3_y);
            int.TryParse(P4x.Text, out P4_x);
            int.TryParse(P4y.Text, out P4_y);
            int.TryParse(P5x.Text, out P5_x);
            int.TryParse(P5y.Text, out P5_y);
            int.TryParse(P6x.Text, out P6_x);
            int.TryParse(P6y.Text, out P6_y);
            int.TryParse(P7x.Text, out P7_x);
            int.TryParse(P7y.Text, out P7_y);
            int.TryParse(P8x.Text, out P8_x);
            int.TryParse(P8y.Text, out P8_y);

            int[] pointsX = { P1_x, P2_x, P3_x, P4_x, P5_x, P6_x, P7_x, P8_x };
            int[] pointsY = { P1_y, P2_y, P3_y, P4_y, P5_y, P6_y, P7_y, P8_y };
            float n = 100;
            float x = 1, y = 1;
            float a = 1, b = 1;
            for (int i = 3; i < 8; i++)
            {

                for (float t = 0; t < 1.0; t += (1 / n))
                {

                    a = (pow(1 - t, 3) / 6 * pointsX[i - 3] + (3 * pow(t, 3) - 6 * pow(t, 2) + 4) / 6 * pointsX[i - 2] + (-3 * pow(t, 3) + 3 * pow(t, 2) + 3 * t + 1) / 6 * pointsX[i - 1] + pow(t, 3) / 6 * pointsX[i]);
                    b = (pow(1 - t, 3) / 6 * pointsY[i - 3] + (3 * pow(t, 3) - 6 * pow(t, 2) + 4) / 6 * pointsY[i - 2] + (-3 * pow(t, 3) + 3 * pow(t, 2) + 3 * t + 1) / 6 * pointsY[i - 1] + pow(t, 3) / 6 * pointsY[i]);
                    x = a;
                    y = b;
                    g.DrawLine(pen1, x + pictureBox1.Width / 2, -y + pictureBox1.Height / 2, (int)a + pictureBox1.Width / 2, (int)-b + pictureBox1.Height / 2);

                }

            }
            //g.DrawLine(pen1, 20, pictureBox1.Height / 2, pictureBox1.Width - 20, pictureBox1.Height / 2);
            //g.DrawLine(pen1, pictureBox1.Width / 2, 20, pictureBox1.Width / 2, pictureBox1.Height - 20);
            drawPoint(P1_x, P1_y);
            drawPoint(P2_x, P2_y);
            drawPoint(P3_x, P3_y);
            drawPoint(P4_x, P4_y);
            drawPoint(P5_x, P5_y);
            drawPoint(P6_x, P6_y);
            drawPoint(P7_x, P7_y);
            drawPoint(P8_x, P8_y);
        }
        private float pow(float x, int power)
        {
            float ret = 1;
            bool flip = false;
            if (power < 0)
            {
                power *= -1;
                flip = true;
            }
            for (int p = 0; p < power; ++p)
            {
                ret *= x;
            }
            return flip ? 1 / ret : ret;
        }
    }
}
