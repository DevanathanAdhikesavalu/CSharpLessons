using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NWindMVC.Models;

namespace NWindMVC.Controllers
{
    public class CustomerController : Controller
    {
        private RepositoryCustomer _repositoryCustomers;
        public CustomerController(RepositoryCustomer repository)
        {
            _repositoryCustomers = repository;
        }
        // GET: CustomerContoller
        public ActionResult Index()
        {
            List<String> CustomersIds = _repositoryCustomers.GetAllCustomerId();
            CustomerIdsViewModel idsViewModel = new CustomerIdsViewModel(CustomersIds);
            return View(idsViewModel);
        }

        // GET: CustomerContoller/Details/5

        public ActionResult Details(string id)
        {
            Customer customer = _repositoryCustomers.FindCustomerById(id);
            List<Order> details = _repositoryCustomers.GetCustomerOrders(id);
            //#region
            ViewData["OrderDetail"] = details;
          
                return View(customer);
            

         
        }

        // GET: CustomerContoller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerContoller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerContoller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerContoller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerContoller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerContoller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
