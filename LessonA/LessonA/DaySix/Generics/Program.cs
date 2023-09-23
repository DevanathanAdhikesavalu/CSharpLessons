using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DaySix.Generics
{
    using System;
    using System.Collections.Generic;



    public class Customer<TOrder, TInvoice, TBill, TProduct>
    {
        public string Name { get; set; }
        public List<TOrder> Orders { get; set; }
        public List<TInvoice> Invoices { get; set; }
        public List<TBill> Bills { get; set; }
        public List<TProduct> Products { get; set; }



        public Customer(string name)
        {
            Name = name;
            Orders = new List<TOrder>();
            Invoices = new List<TInvoice>();
            Bills = new List<TBill>();
            Products = new List<TProduct>();
        }



        public void AddOrder(TOrder order)
        {
            Orders.Add(order);
        }



        public void AddInvoice(TInvoice invoice)
        {
            Invoices.Add(invoice);
        }



        public void AddBill(TBill bill)
        {
            Bills.Add(bill);
        }



        public void AddProduct(TProduct product)
        {
            Products.Add(product);
        }
    }



    public class Order
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        // Add other order details here
    }



    public class Invoice
    {
        public int InvoiceNumber { get; set; }
        public decimal Amount { get; set; }
        // Add other invoice details here
    }



    public class Bill
    {
        public int BillNumber { get; set; }
        public decimal Amount { get; set; }
        // Add other bill details here
    }



    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        // Add other product details here
    }



    class Program
    {
        static void Main()
        {
            Customer<Order, Invoice, Bill, Product> customer = new Customer<Order, Invoice, Bill, Product>("John Doe");



            Order order = new Order { OrderNumber = 1, OrderDate = DateTime.Now };
            Invoice invoice = new Invoice { InvoiceNumber = 101, Amount = 100.50M };
            Bill bill = new Bill { BillNumber = 201, Amount = 50.75M };
            Product product = new Product { ProductName = "Widget", Price = 19.99M };



            customer.AddOrder(order);
            customer.AddInvoice(invoice);
            customer.AddBill(bill);
            customer.AddProduct(product);



            // Access customer details and associated data using the single customer object
            Console.WriteLine($"Customer Name: {customer.Name}");
            Console.WriteLine($"Orders: {customer.Orders.Count}");
            Console.WriteLine($"Invoices: {customer.Invoices.Count}");
            Console.WriteLine($"Bills: {customer.Bills.Count}");
            Console.WriteLine($"Products: {customer.Products.Count}");
        }
    }
}
