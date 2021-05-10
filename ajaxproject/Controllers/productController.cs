using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ajaxproject.Controllers
{
    public class productController : Controller
    {
        // GET: productController
        public ActionResult Index()
        {
            return View();
        }

        // GET: productController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: productController/Create
        public ActionResult Postdata()
        {
            return View();
        }

        // POST: productController/Create
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

        // GET: productController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: productController/Edit/5
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

        // GET: productController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: productController/Delete/5
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
