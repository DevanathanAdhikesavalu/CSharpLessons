using FirstMVCApp.Models;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DoLogin(String txtUser,String txtpwd)
        {
            ViewData["userValue"] = $"{txtUser},{txtpwd}";
            return View();
        }
       

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddNewBook()
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult SaveNewBook(Book pBook)
        {
            String fname = @"c:\temp\book.csv";
            string strBook = $"{pBook.BookID},{pBook.Title},{pBook.AuthorName},{pBook.Cost}";
            using(StreamWriter sw = new StreamWriter(fname, true))
            {
                sw.WriteLine(strBook );
            }
            return View(pBook);
        }
        public IActionResult ListAllBook()
        {
            string fname = @"c:\temp\book.csv";
            List<Book> list = new List<Book>();

            using(StreamReader sr = new StreamReader(fname))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while(!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    book = StringToBook(data, new Book());
                    list.Add(book);
                }
            }
            return View(list);
        }
        private Book StringToBook(String[] data,Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;
        }

        public IActionResult RegisterNewAuthor()
        {
            Author author = new Author();
            return View(author);
        }
        public IActionResult SaveNewAuthor(Author pAuthor)
        {
            String fname = @"c:\temp\author.csv";
            string strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.AuthorDOB},{pAuthor.NoOfBooksPublished},{pAuthor.RoyaltyCompany}";
            using (StreamWriter sw = new StreamWriter(fname, true))
            {
                sw.WriteLine(strAuthor);
            }
            return View(pAuthor);
        }
        public IActionResult ListAllAuthors()
        {
            string fname = @"c:\temp\author.csv";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fname))
            {
                string strAuthor = $"{sr.ReadLine()}";
                String[] data = strAuthor.Split(',');
                Author author = StringToAuthor(data,new Author());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strAuthor = $"{sr.ReadLine()}";
                    data = strAuthor.Split(',');
                    author = StringToAuthor(data,new Author());
                    list.Add(author);
                }
            }
            return View(list);
        }
        //public IActionResult EditAuthor(Author author ,Author AuthorID, Author AuthorName, Author AuthorDOB, Author NoOfBooksPublished, Author RoyaltyCompany)
        //{
        //    return View();
        //}
        //public IActionResult DeleteAuthor(Author authorToDel)
        //{
        //    string fname = @"c:\temp\author.csv";
        //    string contentToDelete = $"{authorToDel.AuthorID},{authorToDel.AuthorName},{authorToDel.AuthorDOB},{authorToDel.NoOfBooksPublished},{authorToDel.RoyaltyCompany}";

        //    var lines = System.IO.File.ReadAllLines(fname);

        //    // Create a new list to store the modified content
        //    var updatedLines = new List<string>();

        //    // Iterate through the lines and skip the ones that contain the content to delete
        //    foreach (var line in lines)
        //    {
        //        if (!line.Contains(contentToDelete))
        //        {
        //            updatedLines.Add(line);
        //        }
        //    }
        //    System.IO.File.WriteAllLines(fname, updatedLines);


        //    return View();

        //}
        public IActionResult FindAuthor(string txtUser)
        {
            string fname = @"c:\temp\author.csv";
            List<Author> list = new List<Author>();
            List<Author> authorList = new List<Author>();
            using (StreamReader sr = new StreamReader(fname))
            {
                string strAuthor = $"{sr.ReadLine()}";
                String[] data = strAuthor.Split(',');
                Author author = StringToAuthor(data,new Author());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strAuthor = $"{sr.ReadLine()}";
                    data = strAuthor.Split(',');
                    author = StringToAuthor(data,new Author());
                    list.Add(author);
                }
                foreach (var item in list)
                {
                    if (item.AuthorID == int.Parse(txtUser))
                        authorList.Add(item);
                }
            }
            return View(authorList);
        }
        private Author StringToAuthor(String[] data,Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.AuthorDOB = DateTime.Parse(data[2]);
            author.NoOfBooksPublished = int.Parse(data[3]);
            author.RoyaltyCompany = data[4];
            return author;
        }
    }
}

//Create Author Controller - CreateAuthor, ListAuthors, ModifyAuthor, FindAuthor, DeleteAuthor

//Create Views w.r.t to the controller