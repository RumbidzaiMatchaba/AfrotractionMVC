using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FiveRosesTea.Models;

namespace FiveRosesTea.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult ProductView()
        {
            return View();
        }
        public ActionResult createProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult createProduct(Product product)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}