using StoreStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreStock.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<ProductModel> products = new List<ProductModel>();

            products.Add(new ProductModel("TEE01-BL", "T-Shirt Dragon", 100, 90, 8, 10, 100000));
            products.Add(new ProductModel("TEE02-BL", "T-Shirt Unicorn", 100, 80, 8, 10, 100000));
            products.Add(new ProductModel("TEE03-BL", "T-Shirt Phoenix", 100, 70, 8, 10, 100000));

            return View("Index", products);
        }
    }
}