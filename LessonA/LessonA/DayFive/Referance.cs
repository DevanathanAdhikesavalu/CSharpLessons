using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayFive
{
    internal class Referance
    {
        public static void Dotask(int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }

        public static void DoTaskA(ref int x)
        {
            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
        }
    }
    internal class Testing
    {
        internal static void TestRef()
        {
            int v1 = 1000;
            Console.WriteLine($"v1:{v1}");
            Referance.Dotask(v1);
            Console.WriteLine($"v1:{v1}");
            Referance.DoTaskA(ref v1);
            Console.WriteLine($"v1:{v1}");
        }
    }
}
