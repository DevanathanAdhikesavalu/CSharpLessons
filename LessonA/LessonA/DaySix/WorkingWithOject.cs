using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DaySix
{
    internal class WorkingWithOject
    {
        public static void TestOne()
        {
            Object objectOne = new Object();
            Console.WriteLine($"ToString: {objectOne.ToString()}");
            Console.WriteLine($"HashCode: {objectOne.GetHashCode()}");
            Type typeOne = objectOne.GetType();
            Console.WriteLine($"Type: {typeOne.FullName}");



            String stringData = "WorldCup 2023";
            Console.WriteLine($"ToString: {stringData.ToString()}");
            Console.WriteLine($"HashCode: {stringData.GetHashCode()}");
            Type typeTwo = stringData.GetType();
            Console.WriteLine($"Type: {typeTwo.FullName}");
        }
        public static void TestTwo()
        {
            Emp empOne = new Emp();
            empOne.ID = 1001;empOne.Name = "Deva";
            Emp empTwo = empOne;//new Emp();
            empTwo.ID = 1001;empTwo.Name = "Vicky";
            Emp empThree = empOne;//new Emp();
            empThree.ID = 1001;empThree.Name = "Vicky";

            bool flag = (empOne.Equals(empTwo));
            Console.WriteLine(flag);
            flag = (empOne.Equals(empThree));
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());    
            Console.WriteLine(empThree.GetHashCode());
        }
    }
}
