using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class EmpController : Controller
    {
        // GET: EmpController
        public ActionResult Index()
        {
            List<Employee> list = EmpDbRepository.GetEmpList();
            //if (list != null)
            //{
                return View(list);
            //}
            //return View();
        }

        // GET: EmpController/Details/5
        public ActionResult Details(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            Employee employee = EmpDbRepository.GetEmpById(id);
            return View("EmployeeDetails",employee);
        }

        // GET: EmpController/Create
        public ActionResult Create()
        {
            Employee emp = new Employee();
            return View(emp);
        }

        // POST: EmpController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Employee pEmp)
        {
            try
            {
                if(ModelState.IsValid) 
                {
                    EmpDbRepository.AddNewEmp(pEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee ModEmp = EmpDbRepository.GetEmpById(id);
            return View(ModEmp);
        }

        // POST: EmpController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Employee ModEmp)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmpDbRepository.UpdateEmp(ModEmp);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee DelEmp = EmpDbRepository.GetEmpById(id);
            if(DelEmp != null)
            {
                return View(DelEmp);
            }
            return View(DelEmp);
        }

        // POST: EmpController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection,Employee dAuthor)
        {
            try
            {
                EmpDbRepository.DeleteEmp(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
