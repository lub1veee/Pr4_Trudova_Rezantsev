using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4_Trudova_Rezantsev
{
    internal class Formuler
    {
        public static string CalculateFormul1(double x, double y, double z)
        {
            if (x >= y || x == 0) return "Ошибка";
            return (Math.Abs(
                Math.Pow(x, (y / x)) - Math.Pow(y / x, 1 / 3)
                ) + (y - x) * (Math.Cos(y) - z / (y - x)) / (1 + Math.Pow(y - x, 2))).ToString();
        }

        public static string CalculateFormul2(Func<double, double> f, params double[] points)
        {
            return "";
        }

        public static double[] ParseString(params string[] points)
        {
            double[] res = new double[points.Length];
            for(int i = 0; i < points.Length; i++)
            {
                if (!double.TryParse(points[i], out double result)) return null;
                res[i] = result;
            }
            return res;
        } 
    }
}
