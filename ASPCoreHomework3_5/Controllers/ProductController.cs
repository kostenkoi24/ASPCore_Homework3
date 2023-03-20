using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCoreHomework3_5.Models;

namespace ASPCoreHomework3_5.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            ProductModel productModel = new ProductModel();

            productModel.Id = "1";
            productModel.Name = "Notebook";
            productModel.Price = "999";

            ViewBag.Text = $"{productModel.Id} {productModel.Name} {productModel.Price}"  ;

            return View("Index");
        }

        public IActionResult Index1()
        {

            ProductModel productModel = new ProductModel();

            productModel.Id = "1";
            productModel.Name = "Notebook";
            productModel.Price = "999";

            
            return View(productModel);
        }

    }
}
