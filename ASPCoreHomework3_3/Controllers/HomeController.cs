using ASPCoreHomework3_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreHomework3_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            //FileStream fileStream = System.IO.File.OpenRead("App_Data/DataFile.txt");
            //var path = "App_Data/DataFile.txt";
            //string[] lines = System.IO.File.ReadAllLines(path);
            //return lines;

            FileStream fileStream = System.IO.File.OpenRead("App_Data/DataFile.txt");
            return File(fileStream, "application/txt");
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
