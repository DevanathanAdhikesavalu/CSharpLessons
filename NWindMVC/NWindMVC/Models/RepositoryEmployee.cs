namespace NWindMVC.Models
{
    public class RepositoryEmployee
    {
        private NorthwindContext _context;
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }
        public  List<Employee> AllEmployees()
        {
            return _context.Employees.ToList();
        }
        public Order FindEmployeeById(int id)
        {
            var orderById = _context.Orders.Find(id);
            return orderById;
        }
        public List<Order> FindOrderByCustomerID(string  customerID)
        {
            List<Order> customerorders = (from o in _context.Orders where o.CustomerId == customerID select o).ToList();
            return customerorders;
        }
        public List<OrderDetail> FindOrderDetailById(int orderID)
        {
            List<OrderDetail> orderDetails = (from od in _context.OrderDetails where od.OrderId == orderID select od).ToList();
            return orderDetails;
        }
        public Product GetProductById(int productid)
        {
            Product product = (from p in _context.Products where p.ProductId == productid select p).SingleOrDefault();
            return product;
        }

    }
}
