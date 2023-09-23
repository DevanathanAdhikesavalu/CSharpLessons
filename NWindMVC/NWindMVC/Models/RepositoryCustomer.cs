using Microsoft.EntityFrameworkCore;

namespace NWindMVC.Models
{
    public class RepositoryCustomer
    {
        private NorthwindContext _context;
        public RepositoryCustomer(NorthwindContext context)
        {
            _context = context;
        }
        public List<string> GetAllCustomerId()
        {
            List<string> custIds = new List<string>();
            foreach (var customer in _context.Customers)
            {
                custIds.Add(customer.CustomerId);
            }
            return custIds;
        }
        public Customer FindCustomerById(String id)
        {
            Customer customer = _context.Customers.Find(id);
            return customer;
        }
        public List<Order> GetCustomerOrders(String id)
        {
            List<Customer> ordersWithOrderDetails = _context.Customers.Include(d => d.Orders).ToList();
            Customer customer = ordersWithOrderDetails.FirstOrDefault(x => x.CustomerId == id);
            return customer.Orders.ToList();
        }
    }
}

/*
  Create repository For Customer
	GetAllCustomerID -> List<int>
	FindCustomerByID -> Customer
	GetCustomerOrders -> List<Order>
Create Customer Controller
	Show all Customer Name in DropdownList
	Show the selected Customer in a Detail View with 
				all Orders of the Customer as Partial View
 */
