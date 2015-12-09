using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Accessibility.Controllers
{
    public class AccessibilityController : Controller
    {
        // GET: Accessibility
        public ActionResult Index()
        {
            return View();
        }

        // GET: Accessibility/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Accessibility/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessibility/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Accessibility/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Accessibility/Edit/5
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

        // GET: Accessibility/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Accessibility/Delete/5
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
