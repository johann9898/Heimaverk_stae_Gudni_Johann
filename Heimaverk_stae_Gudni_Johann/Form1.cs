using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using System.Threading;

namespace Heimaverk_stae_Gudni_Johann
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread panelThread = new Thread(new ThreadStart(Repainter));
            panelThread.Start();
        }
        List<Point> pointlist = new List<Point>();

        private void bt_submit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_line.Text))
            {
                return;
            }
            Expression num = new Expression(tb_line.Text);
            pointlist.Clear();
            for (int i = -50; i <= 50; i++)
            {
                num.Parameters["x"] = i;
                float number = Convert.ToSingle(num.Evaluate());

                //Failsafe
                int upperbound = 100000;
                if (number > upperbound)
                {
                    number = upperbound;
                }
                if (number < -upperbound)
                {
                    number = -upperbound;
                }
                if (number > upperbound)
                {
                    number = upperbound;
                }
                if (number < -upperbound)
                {
                    number = -upperbound;
                }

                Point point = new Point(i * 4, Convert.ToInt32((number) * -4));
                point.Offset(202, 202);

                pointlist.Add(point);

            }


        }
        private delegate void RefreshDelegate();
        public void Repainter()
        {
            while (true)
            {
                Thread.Sleep(10);
                Invoke(new RefreshDelegate(panel_grid.Refresh));
            }
        }

        private void panel_grid_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Times New Roman", 8.0f);
            Pen blackpen = new Pen(Color.Black, 1);
            Pen redpen = new Pen(Color.Red, 1);
            Pen lightpen = new Pen(Color.LightGray, 1);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            Graphics g = e.Graphics;
            //g.DrawLine(blackpen, 202, 0, 202, 500);
            //g.DrawLine(blackpen, 0, 202, 500, 202);
            for (int i = 0; i < 26; i++)
            {
                Point xpoint1 = new Point(i * 16, 0);
                Point xpoint2 = new Point(i * 16, 500);
                Point ypoint1 = new Point(0, i * 16);
                Point ypoint2 = new Point(500, i * 16);
                xpoint1.Offset(10, 0);
                xpoint2.Offset(10, 0);
                ypoint1.Offset(0, 10);
                ypoint2.Offset(0, 10);
                if (i == 12)
                {
                    g.DrawLine(blackpen, xpoint1, xpoint2);
                    g.DrawLine(blackpen, ypoint1, ypoint2);
                }
                else
                {
                    g.DrawLine(lightpen, xpoint1, xpoint2);
                    g.DrawLine(lightpen, ypoint1, ypoint2);
                }
                g.DrawString(Convert.ToString(48 - (i * 4)), font, blackBrush, 202, i * 16);
                g.DrawString(Convert.ToString((i * 4) - 48), font, blackBrush, i * 16, 202);

            }
            if (pointlist.Count > 0)
            {
                
                for (int i = 1; i < pointlist.Count; i++)
                {
                    g.DrawLine(redpen, pointlist[i-1], pointlist[i]);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }
        private Point offsetExample()
        {

            Point pointResult = new Point(10, 5);

            // Offset Point X value by 20 and Y value by 30.
            // point1 is now equal to (30,35)
            pointResult.Offset(20, 30);

            return pointResult;

        }
    }
}
public class BufferedPanel : Panel
{
    public BufferedPanel()
    {
        DoubleBuffered = true;
    }
}