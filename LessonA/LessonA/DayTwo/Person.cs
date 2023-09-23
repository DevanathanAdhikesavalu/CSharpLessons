using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayTwo
{
    internal class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; }= string.Empty;

        public string Title { get; set; }=string.Empty;
       
        public string City { get; set; } = string.Empty;

        public string Region { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        public int Amount { get; set; }

        public int GST { get; set; }

        public long Phone { get; set; }

        public int TotalAmount{ get; set; }

        public override string ToString()
        {
            return $"ID:{this.Id},Name:{Title} {FirstName} {LastName},\n" +
                $" GST:{this.GST}, City:{City},State:{Region},\n" +
                $"Phone:{Phone}, Amount:{this.Amount},Zip:{PostalCode},TotalAmount:{TotalAmount}";
        }

    }
    internal class BillInvoice
    {
        public static void Invoice() 
        {
            Person InvoiceDetails = new Person();
            InvoiceDetails.Id = 1;
            InvoiceDetails.FirstName = "Devanathan";
            InvoiceDetails.LastName = "A";
            InvoiceDetails.Amount = 1000;
            InvoiceDetails.GST = 180;
            InvoiceDetails.TotalAmount = InvoiceDetails.Amount + InvoiceDetails.GST;
            InvoiceDetails.City = "Chennai";
            InvoiceDetails.Phone = 9003655060L;
            InvoiceDetails.PostalCode = "12345";
            InvoiceDetails.Title = "Mr.";
            String value = InvoiceDetails.ToString();
            Console.WriteLine(value);
        }

    }
}
