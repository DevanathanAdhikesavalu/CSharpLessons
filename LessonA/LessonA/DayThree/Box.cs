using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayThree
{
    internal class Box
    {
        public int Height;
        public int Length;
        public int Width;



        public Box(int x)
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }
        public override string ToString()
        {
            return $"height:{Height},Length:{Length},Width:{Width}";
        }
    }
    internal class WoodenBox : Box {
        public int Area;
        public WoodenBox():base(1)
        {
            Console.WriteLine("Wooden box constructor is created");
        }
        public WoodenBox(int x):base(x)
        {
            Console.WriteLine("Wooden box constructor is created");

        }
        public WoodenBox(int x, int y):base(x)
        {
            Console.WriteLine("Wooden box constructor is created");
        }
        public void Move()
        {
            Console.WriteLine("Wooden Box Shifted");
        }
        public override string ToString()
        {
            return "Deva is OP";
        }
    }
    internal class BoxTester
    {
        public static void TestOne()
        {
            Box box = new Box(100);
            box.Height = 10;
            box.Width = 5;
            box.Length = 20;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);

        }
        public static void TestTwo()
        {
            WoodenBox box = new WoodenBox();    
            box.Height = 10;
            box.Width = 5;
            box.Length = 20;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
            box.Area = 10;
            box.Move();
        }
        public static void TestThree()
        {
            Box box = new WoodenBox();
            box.Height = 10;
            box.Width = 5;
            box.Length = 20;
            box.Open();
            box.Close();
            String output = box.ToString();
            Console.WriteLine(output);
            //box.Area = 10;
            //box.Move();
        }
    }
}
