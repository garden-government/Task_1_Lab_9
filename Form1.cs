using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_Lab_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /////////////////////////////////////////LIB
        public static double kordMiddle(double oldKor, double pointKor)
        {
            return (pointKor - oldKor) / 2 + oldKor;
        }

        public static double polarKord(double radiosPolar, double cornerPolar, char nameAxes)
        {
            if (nameAxes == 'x')
            {
                return radiosPolar * Math.Cos(cornerPolar);
            }
            else if (nameAxes == 'y')
            {
                return radiosPolar * Math.Sin(cornerPolar);
            }
            else
                return 0;
        }
        /////////////////////////////////////////LIB

        ///////////////////////////////////////// 10.000 точек простых чисел
        private void SimpleNumberFirst_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            for (int number = 0; number < 10000; number++)
            {
                bool isSimple = true;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isSimple = false;
                    }
                }
                if (isSimple)
                {
                    this.chart1.Series[0].Points.AddXY(polarKord(number, number, 'x'), polarKord(number, number, 'y'));
                }
            }
        }


        ///////////////////////////////////////// 150.000 точек простых чисел
        private void SimpleNumberSecond_Click(object sender, EventArgs e)
        {
            this.chart1.Series[0].Points.Clear();
            List<int> points = new List<int>();
            points.Add(2);
            for (int number = 2; number < 150000; number++)
            {
                bool isSimple = true;
                foreach (int point in points)
                {
                    if (number % point == 0)
                    {
                        isSimple = false;
                    }
                }
                if (isSimple)
                {
                    points.Add(number);
                    this.chart1.Series[0].Points.AddXY(polarKord(number, number, 'x'), polarKord(number, number, 'y'));
                }
            }
        }

        ///////////////////////////////////////// Фрактакл
        private void Fractal_Click(object sender, EventArgs e)
        {
            double x1 = 100, x2 = -100, x3 = 0, y1 = 0, y2 = 0, y3 = 250;
            this.chart1.Series[0].Points.Clear();
            double mainX = 0, mainY = 0;
            Random rand = new Random();
            for (int i = 0; i < 30000; i++)
            {
                int nextPoint = rand.Next(1, 4) % 3;
                if (nextPoint == 1)
                {
                    mainX = kordMiddle(mainX, x1);
                    mainY = kordMiddle(mainY, y1);
                    this.chart1.Series[0].Points.AddXY(mainX, mainY);
                }
                else if (nextPoint == 2)
                {
                    mainX = kordMiddle(mainX, x2);
                    mainY = kordMiddle(mainY, y2);
                    this.chart1.Series[0].Points.AddXY(mainX, mainY);
                }
                else
                {
                    mainX = kordMiddle(mainX, x3);
                    mainY = kordMiddle(mainY, y3);
                    this.chart1.Series[0].Points.AddXY(mainX, mainY);
                }
            }
        }
    }
}
