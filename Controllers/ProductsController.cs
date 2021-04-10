using StoreStock.Data;
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
            ProductDAO productDAO = new ProductDAO();

            products = productDAO.FetchAll();

            return View("Index", products);
        }

        public ActionResult Details(int id)
        {

            ProductDAO productDAO = new ProductDAO();

            ProductModel product = productDAO.FetchOne(id);

            return View("Details", product);
        }
        public ActionResult Create()
        {
            return View("ProductForm");
        }
        public ActionResult Edit(int id)
        {
            ProductDAO productDAO = new ProductDAO();

            ProductModel product = productDAO.FetchOne(id);
            return View("ProductForm", product);
        }

        public ActionResult ProcessCreate(ProductModel productModel)
        {

            ProductDAO productDAO = new ProductDAO();

            productDAO.Create(productModel);
       

            return View("Details", productModel);
        }
        public ActionResult Delete(int id)
        {
            ProductDAO productDAO = new ProductDAO();
            productDAO.Delete(id);

            List<ProductModel> product = productDAO.FetchAll();
            return View("Index", product);
        }
    }
}