using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class BaseApiController : Controller
    {
        // GET: BaseApi
        public ActionResult Index()
        {
            return View();
        }

        // GET: BaseApi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BaseApi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BaseApi/Create
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

        // GET: BaseApi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BaseApi/Edit/5
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

        // GET: BaseApi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BaseApi/Delete/5
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
