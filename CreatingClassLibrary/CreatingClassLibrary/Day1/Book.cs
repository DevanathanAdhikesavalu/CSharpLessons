using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClassLibrary.Day1
{
    public class Book
    {
        public String Title { get; set; } = String.Empty;
        public String Author=String.Empty;
        public string Genere = String.Empty;
        public DateTime DateOfPublish;
        public int BookPrice;
        public int TotalPages = 300;
        public void OpenBook()
        {
            Console.WriteLine("Book is Open");
        }
        public int GetCurrentPage()
        {
            Random r= new Random();
            return r.Next(TotalPages);
        }
        public void BookMarkPage(int pageNo)
        {
            Console.WriteLine($"Page No:{pageNo} Bookmarked");
        }
    }
}
