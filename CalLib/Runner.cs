using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalLib
{
    class Runner
    {
        public static void Main()
        {
            Console.WriteLine("Only Negitive Numbers Accepted!");
            Console.WriteLine("Enter the Choice: 1 -> Addition, 2 -> Division, 3 -> Multiply, 4 -> Subtract");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            double ans;
            try
            {
                switch (choice)
                {
                    case 1:
                        ans = Calculator.Add(num1, num2);
                        Console.WriteLine("ans is " + ans);
                        break;
                    case 2:
                        ans = Calculator.Div(num1, num2);
                        Console.WriteLine("ans is " + ans);
                        break;
                    case 3:
                        ans = Calculator.Mul(num1, num2);
                        Console.WriteLine("ans is " + ans);
                        break;
                    case 4:
                        ans = Calculator.Sub(num1, num2);
                        Console.WriteLine("ans is " + ans);
                        break;
                }
            }


            catch (PositiveNumberExeption _)
            {
                Console.WriteLine("Can't Have Positive Numbers in this Application.");
            }
            catch (DivideByZeroException _)
            {
                Console.WriteLine("Denominator Can't be Zero while Division.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
