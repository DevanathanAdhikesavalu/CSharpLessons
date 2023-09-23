using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayTwo
{
    internal class Box
    {
        public static int height;
        public  int width;
        public const string type = "wooden";
        public int GetHeight()
        {
            return height;
        }
    }
    internal class Testbox
    {
        public static void TestOne()
        {
            Box.height = 100;
            //Box.width = 200;

            Box firstBox = new Box();
            Box secondBox = new Box();

            firstBox.width = 12345;
            secondBox.width = 67890;

            Console.WriteLine($"First box ={firstBox.width},{firstBox.GetHeight()}");
            Console.WriteLine($"Second box  ={secondBox.width},{firstBox.GetHeight()}");
            Console.WriteLine(Box.type);
            Box.height = 5555;
            Console.WriteLine($"First box ={firstBox.width},{firstBox.GetHeight()}");
            Console.WriteLine($"Second box  ={secondBox.width},{firstBox.GetHeight()}");
        }
    }




public class Student
    {

        public int value { get; set; }

    }

    public class ReferenceType
    {
        public static int ChangeReferenceType(Student val2)
        {
            val2.value = 10;
            return val2.value;
        }

        public static void Main()
        {
            Student val = new Student();

            val.value = 20;

            Console.WriteLine(val.value);   

            val.value = ChangeReferenceType(val);

            Console.WriteLine(val.value);
        }
    }
}
