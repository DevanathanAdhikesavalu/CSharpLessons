using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.Day1
{
    internal class Calculator
    {
        public static int Add(int p1, int p2)
        {
            return p1+p2;
        }
        public static int Subtract(int p1, int p2)
        {
            return p1 - p2;
        }
        public static int Multiply(int p1, int p2)
        {
            return p1 * p2;
        }
        public static int Divide(int p1, int p2)
        {
            return p1 / p2;
        }

        public static void TestCalculator()
        {
            Console.WriteLine("Enter the value for first parameter");
            String x = Console.ReadLine();
            Console.WriteLine("Enter the value for second parameter");
            String y = Console.ReadLine();

            int firstValue = int.Parse(x);
            int secondValue = int.Parse(y);

            int addresult = Calculator.Add(firstValue, secondValue);
            Console.WriteLine(addresult);
            int subtractresult = Calculator.Subtract(firstValue, secondValue);
            Console.WriteLine(subtractresult);
            int multiplyresult = Calculator.Multiply(firstValue, secondValue);
            Console.WriteLine(multiplyresult);
            int divideresult = Calculator.Divide(firstValue, secondValue);
            Console.WriteLine(divideresult);
        }
    }
}
