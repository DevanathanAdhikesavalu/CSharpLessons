using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayThree
{
    internal abstract class Book
    {
        public Book() {
            Console.WriteLine("Book Constructor");
        }
        public abstract void OpenBook();
    }
    internal class Ebook : Book
    {
        public Ebook()
        {
            Console.WriteLine("Ebook constructor");
        }
        public override void OpenBook()
        {
            Console.WriteLine("Ebook open");
        }
    }
    class BookTester
    {
        public static void TestOne()
        {
            Ebook book = new Ebook();
            book.OpenBook();
        }
    }
}
