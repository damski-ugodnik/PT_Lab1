using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public static class MyCalc
    {
        /// <summary>
        /// Метод сложения двух чисел
        /// </summary>
        /// <param name="x">первое слагаемое</param>
        /// <param name="y">второе слагаемое</param>
        /// <returns></returns>
        public static double Add(double x, double y) { return x + y; }

        /// <summary>
        /// Метод вычитания двух чисел
        /// </summary>
        /// <param name="x">первое слагаемое</param>
        /// <param name="y">второе слагаемое</param>
        /// <returns></returns>
        public static double Sub(double x, double y) { return x - y; }

        /// <summary>
        /// Метод умножения двух чисел
        /// </summary>
        /// <param name="x">первое слагаемое</param>
        /// <param name="y">второе слагаемое</param>
        /// <returns></returns>
        public static double Mul(double x, double y) { return x * y; }

        /// <summary>
        /// Метод деления двух чисел
        /// </summary>
        /// <param name="x">первое слагаемое</param>
        /// <param name="y">второе слагаемое</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">исключение деления на 0</exception>
        public static double Div(double x, double y)
        {
            if (y == 0)
                throw new ArgumentException("Error: division by Zero");
            return x / y;
        }

        /// <summary>
        /// Метод извлечения квадратного корня из числа
        /// </summary>
        /// <param name="x">подкоренное выражение</param>
        /// <returns></returns>
        public static double Sqrt(double x) { return Math.Sqrt(x); }

        /// <summary>
        /// Метод получения синуса угла
        /// </summary>
        /// <param name="x">аргумент тригонометрической функции</param>
        /// <returns></returns>
        public static double Sin(double x) { return Math.Sin(x); }
    }
}
