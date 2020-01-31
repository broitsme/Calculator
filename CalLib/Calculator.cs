using System;
namespace CalLib
{

    static public class Calculator
    {

        /// <summary>
        /// calculates sum of two numbers
        /// </summary>
        /// <param name="num1">first value</param>
        /// <param name="num2">second value</param>
        /// <returns>sum of two inputs as double</returns>
        public static double Add(double num1, double num2)
        {
            if(num1 > 0 || num2 > 0)
            {
                throw new PositiveNumberExeption();
            }
            return num1 + num2;
        }
        /// <summary>
        /// calculates product of two numbers
        /// </summary>
        /// <param name="num1">first value</param>
        /// <param name="num2">second value</param>
        /// <returns>multiplies of two inputs as double</returns>
        public static double Mul(double num1, double num2)
        {
            if (num1 > 0 || num2 > 0)
            {
                throw new PositiveNumberExeption();
            }

            return num1 * num2;
        }
        /// <summary>
        /// divides two numbers
        /// </summary>
        /// <param name="num1">first value</param>
        /// <param name="num2">second value</param>
        /// <returns>subtracts fisrst and second input respectively as double</returns>
        public static double Sub(double num1, double num2)
        {
            if (num1 > 0 || num2 > 0)
            {
                throw new PositiveNumberExeption();
            }
            return num1 - num2;
        }
        /// <summary>
        /// divides two numbers
        /// </summary>
        /// <param name="num1">first value</param>
        /// <param name="num2">second value</param>
        /// <returns>divides fisrst and second input</returns>
        public static double Div(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            if (num1 > 0 || num2 > 0)
            {
                throw new PositiveNumberExeption();
            }
               return num1 / num2;
        }
    }
}
