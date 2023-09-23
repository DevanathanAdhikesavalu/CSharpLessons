using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DaySeven
{
    internal class LamdaDemo
    {
        public static void DemoA()
        {
            Func<int, int> foo = x => x / 2;
            int i = 100;
            int result = foo(i);
            Console.WriteLine(result);
        }
        public static void DemoB() 
        {
            Func<int> foo = () => 100;
            int result = foo();
            Console.WriteLine(result);
        }
        public static void DemoC() 
        {
            Func<double,double,double> callme = (x,y) =>(x+y)/2;
            int v1 = 101;
            int v2 = 10;
            double result = callme(v1,v2);
            Console.WriteLine(result);
        }
        public static void DemoD()
        {
            Func<int,double> foo = x =>(double)x/2;
            int v1 = 101;
            double result = foo(v1);
            Console.WriteLine(result);
        }
        public static void DemoE()
        {
            Func<double, int> foo = x => (int)x / 2;
            int v1 = 101;
            int result = foo(v1);
            Console.WriteLine(result);
        }

        static void Echo(Func<string> foo)
        {
            string str = foo();
            Console.WriteLine(str);
        }
        public static void TestEcho()
        {
            Echo(() => "hello");
            Echo(() => "World");
        }
        public static double DoTrans(Func<int,int,double> foo)
        {
            return foo(50, 5);
        }
        public static void TestDoTrans()
        {
            Func<int,int,double> Multiply = (x,y) => x*y;
            double d = DoTrans(Multiply);
            Console.WriteLine(d);

            Func<int,int,double> Add = (x,y) => x+y;
            d = DoTrans(Add);
            Console.WriteLine(d);

            Func<int, int, double> Divide = (x, y) =>
            {
                if (y == 0)
                    y = 1;
                return x / y;
            };
            double d1 = DoTrans(Divide);
            Console.WriteLine(d1);
        }
    }
}
