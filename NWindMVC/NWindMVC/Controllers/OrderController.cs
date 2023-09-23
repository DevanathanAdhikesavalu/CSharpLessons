using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NWindMVC.Models;

namespace NWindMVC.Controllers
{
    public class OrderController : Controller
    {
        private RepositoryOrders _repositoryOrders;
        public OrderController(RepositoryOrders repository)
        {
            _repositoryOrders = repository;   
        }
        // GET: OrderController
        public IActionResult Index()
        {
            //List<int> OrdersIds = _repositoryOrders.GetAllOrderId();
            //                                   //ViewBag.OrderIds = new SelectList(OrdersIds);
            //return View(OrdersIds);
            List<int> OrdersIds = _repositoryOrders.GetAllOrderId();
            OrderIdsViewModel idsViewModel = new OrderIdsViewModel(OrdersIds);
            return View(idsViewModel);
        }


        // GET: OrderController/Details/5
        //[HttpGet]
        public ActionResult Details(int? ID)
        {
            if (ID.HasValue)
            {
                Console.WriteLine($"Selected Order ID: {ID.Value}");
                Order order = _repositoryOrders.FindOrderById(ID.Value);
                List<OrderDetail> details = _repositoryOrders.FindOrderDetailByOrderId(ID.Value);
                //#region
                ViewData["OrderDetail"] = details;
                if (order != null)
                {
                    return View(order);
                }
            }

            return RedirectToAction("Index");
        }

        //GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
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

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
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
