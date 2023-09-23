using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayTwo
{
    internal class DemoA
    {
        //Global varable declaration
        int x = 123;
        static int y = 567;
        public static void FirstMethod()
        {
            //local varable declaration
            int x = 2000;
            int y = 5000;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(DemoA.y);
        }
        public void SecondMethod()
        {
            Console.WriteLine(x);

        }
    }
    internal class DemoB
    {

    }
}
