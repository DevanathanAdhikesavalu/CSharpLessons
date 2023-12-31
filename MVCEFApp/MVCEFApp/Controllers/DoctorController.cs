﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEFApp.Models;

namespace MVCEFApp.Controllers
{
    public class DoctorController : Controller
    {
        // GET: DoctorController
        public ActionResult Index()
        {
            List<Doctor> Doctors = RepositoryDoctor.GetDoctors();
            if(Doctors!= null && Doctors.Count >0)
                return View(Doctors);
            else
                return RedirectToAction("Create");
        }

        // GET: DoctorController/Details/5
        public ActionResult Details(int id)
        {
            Doctor doctor = RepositoryDoctor.GetDoctorById(id);
            return View(doctor);
        }

        // GET: DoctorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Doctor pDoctor)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    RepositoryDoctor.AddNewDoctor(pDoctor);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception err)
            {
                return View();
            }
        }

        // GET: DoctorController/Edit/5
        public ActionResult Edit(int id)
        {
            Doctor doctor = RepositoryDoctor.GetDoctorById(id);
            return View(doctor);
        }

        // POST: DoctorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Doctor doctor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryDoctor.ModifyDoctor(doctor);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorController/Delete/5
        public ActionResult Delete(int id)
        {
            Doctor doctor = RepositoryDoctor.GetDoctorById(id);
            return View(doctor);
        }

        // POST: DoctorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if(ModelState.IsValid)
                    RepositoryDoctor.RemoveDoctor(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
