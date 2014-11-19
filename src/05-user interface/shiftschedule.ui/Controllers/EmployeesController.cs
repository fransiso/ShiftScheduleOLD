using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ShiftSchedule.Domain.Entities;
using ShiftSchedule.Infrastructure.Data.Repositories;
using ShiftSchedule.UI.ViewModels;

namespace ShiftSchedule.UI.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeRepository _employeesRepository = new EmployeeRepository();
        //
        // GET: /Employees/
        public ActionResult Index()
        {
            var employeeViewModel = Mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(_employeesRepository.GetAll());
            return View(employeeViewModel);
        }

        //
        // GET: /Employees/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employees/Create
        [HttpPost]
        public ActionResult Create(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                var employeedomain = Mapper.Map<EmployeeViewModel, Employee>(employee);
                _employeesRepository.Add(employeedomain);

                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //
        // GET: /Employees/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
