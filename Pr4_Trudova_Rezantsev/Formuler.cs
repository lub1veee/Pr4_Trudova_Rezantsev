using System;

namespace Pr4_Trudova_Rezantsev
{
    /// <summary>
    /// Вспомогательный класс для вычисления математических формул из практической работы 4.
    /// </summary>
    public class Formuler
    {
        /// <summary>
        /// Вычисляет значение формулы 1
        /// </summary>
        /// <param name="x">
        /// Параметр x. Должен быть строго меньше y и не равен нулю.
        /// </param>
        /// <param name="y">Параметр y.</param>
        /// <param name="z">Параметр z.</param>
        /// <returns>Результат вычисления формулы.</returns>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если x >= y или x == 0.
        /// </exception>
        /// <exception cref="DivideByZeroException">
        /// Выбрасывается, если y равно x (деление на ноль в знаменателе).
        /// </exception>
        public static double CalculateFormul1(double x, double y, double z)
        {
            if (x == 0)
                throw new ArgumentException(
                    "Параметр x не должен равняться нулю.", nameof(x));

            if (x >= y)
                throw new ArgumentException(
                    "Параметр x должен быть строго меньше параметра y.", nameof(x));

            double diff = y - x;

            double base1 = Math.Pow(x, y / x);      
            double base2 = Math.Pow(y / x, 1.0 / 3.0); 
            double absPart = Math.Abs(base1 - base2);

            double numerator = Math.Cos(y) - z / diff;
            double denominator = 1 + Math.Pow(diff, 2);

            return absPart + diff * numerator / denominator;
        }

        /// <summary>
        /// Вычисляет значение кусочной формулы 2
        /// Для остальных значений x возвращает 0.
        /// </summary>
        /// <param name="f">Функция f(x), передаваемая как делегат.</param>
        /// <param name="points">
        /// Массив из двух элементов: points[0] = x, points[1] = p.
        /// </param>
        /// <returns>Результат вычисления согласно условию.</returns>
        /// <exception cref="ArgumentException">
        /// Выбрасывается, если массив <paramref name="points"/> не содержит ровно двух элементов.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Выбрасывается, если <paramref name="f"/> или <paramref name="points"/> равны null.
        /// </exception>
        public static double CalculateFormul2(Func<double, double> f, params double[] points)
        {
            if (f is null)
                throw new ArgumentNullException(nameof(f), "Функция f не может быть null.");

            if (points is null)
                throw new ArgumentNullException(nameof(points), "Массив points не может быть null.");

            if (points.Length != 2)
                throw new ArgumentException(
                    "Массив points должен содержать ровно 2 элемента (x и p).", nameof(points));

            double x = points[0];
            double p = points[1];
            double fx = f(x);
            double absP = Math.Abs(p);

            if (x > absP)
                return 2 * Math.Pow(fx, 3) + 3 * Math.Pow(p, 2);

            if (x == absP)
                return Math.Pow(fx - p, 2);

            if (x > 3 && x < absP)
                return Math.Abs(fx - p);

            return 0;
        }

        /// <summary>
        /// Вычисляет значение формулы 3
        /// </summary>
        /// <param name="x">Аргумент функции. Должен быть ≥ 0 (из-за √x).</param>
        /// <param name="b">Коэффициент b (по умолчанию 1).</param>
        /// <returns>Значение функции в точке x.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если x &lt; 0.</exception>
        public static double CalculateFormul3(double x, double b = 1)
        {
            if (x < 0)
                throw new ArgumentException("Параметр x должен быть ≥ 0.", nameof(x));

            return 0.0025 * b * Math.Pow(x, 3) + Math.Sqrt(x) + Math.Exp(0.82);
        }

        /// <summary>
        /// Разбирает массив строк в массив вещественных чисел <see cref="double"/>.
        /// </summary>
        /// <param name="points">Строковые представления чисел.</param>
        /// <returns>
        /// Массив <see cref="double"/> при успешном разборе;
        /// <c>null</c> если хотя бы одна строка пустая или не является числом.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Выбрасывается, если <paramref name="points"/> равен null.
        /// </exception>
        public static double[] ParseString(params string[] points)
        {
            if (points is null)
                throw new ArgumentNullException(nameof(points));

            double[] result = new double[points.Length];

            for (int i = 0; i < points.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(points[i]))
                    return null;

                if (!double.TryParse(points[i], out double value))
                    return null;

                result[i] = value;
            }

            return result;
        }
    }
}