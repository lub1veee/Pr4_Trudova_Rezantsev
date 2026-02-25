using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pr4_Trudova_Rezantsev
{
    internal class Formuler
    {
        public static double CalculateFormul1(double x, double y, double z)
        {
            if (x >= y || x == 0)
            {
                MessageBox.Show("Параметр x должен быть больше параметра Y и не равняться нулю", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            return Math.Abs(
            Math.Pow(x, (y / x)) - Math.Pow(y / x, 1 / 3)
            ) + (y - x) * (Math.Cos(y) - z / (y - x)) / (1 + Math.Pow(y - x, 2));
        }

        public static double CalculateFormul2(Func<double, double> f, params double[] points)
        {
            if (points.Length != 2) MessageBox.Show("А как..");

            double x = points[0];
            double fx = f(x);
            double p = points[1];
            if (x > Math.Abs(p))
            {
                return 2 * Math.Pow(fx, 3) + 3 * Math.Pow(p, 2);
            }
            else if (3 < x && x < Math.Abs(p))
            {
                return Math.Abs(fx - p);
            }
            else if (x == Math.Abs(p))
            {
                return Math.Pow(fx - p, 2);
            }
            else return 0;
        }

        public static double[] ParseString(params string[] points)
        {
            double[] res = new double[points.Length];
            for(int i = 0; i < points.Length; i++)
            {
                if (string.IsNullOrEmpty(points[i]))
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                    return null;
                }
                if (!double.TryParse(points[i], out double result)) return null;
                res[i] = result;
            }
            return res;
        } 
    }
}
