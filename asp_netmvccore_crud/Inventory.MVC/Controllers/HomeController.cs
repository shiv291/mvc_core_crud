using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Inventory.MVC.Models;
using Inventory.BusinessLib;
using System.IO;

namespace Inventory.MVC.Controllers
{
    public class HomeController : Controller
    {
        IProductOperation operation;
        public HomeController(IProductOperation _operation)
        {
            operation = _operation;
        }
        public IActionResult Index()
        {
            //  var result = operation.GetProducts();
            //  return View(result);
            return View();
        }

        public IActionResult Create()
        {
            var list = new List<KeyValueModel>();
                list.Add(new KeyValueModel() { Key = "Green", Value = "Green" });
            list.Add(new KeyValueModel() { Key = "Red", Value = "Red" });
            list.Add(new KeyValueModel() { Key = "Yellow", Value = "Yellow" });
            list.Add(new KeyValueModel() { Key = "Orange", Value = "Orange" });
            ViewBag.ColorList = list;

            var categoryList = new List<KeyValueModel>();
            categoryList.Add(new KeyValueModel() { Key = "1", Value = "Electronic" });
            categoryList.Add(new KeyValueModel() { Key = "2", Value = "Mobile" });
            ViewBag.CategoryList = list;

            Dictionary<string, string> Companies = new Dictionary<string, string>();
            Companies.Add("FlipKart", "FlipKart");
            Companies.Add("Amazon", "Amazon");
            Companies.Add("Ebay", "Ebay");
            Companies.Add("Relience", "Relience");
            ViewBag.Companies = Companies;



            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
            var list = new List<KeyValueModel>();
            list.Add(new KeyValueModel() { Key = "Green", Value = "Green" });
            list.Add(new KeyValueModel() { Key = "Red", Value = "Red" });
            list.Add(new KeyValueModel() { Key = "Yellow", Value = "Yellow" });
            list.Add(new KeyValueModel() { Key = "Orange", Value = "Orange" });
            ViewBag.ColorList = list;

            var categoryList = new List<KeyValueModel>();
            categoryList.Add(new KeyValueModel() { Key = "1", Value = "Electronic" });
            categoryList.Add(new KeyValueModel() { Key = "2", Value = "Mobile" });
            ViewBag.CategoryList = list;

            Dictionary<string, string> Companies = new Dictionary<string, string>();
            Companies.Add("FlipKart", "FlipKart");
            Companies.Add("Amazon", "Amazon");
            Companies.Add("Ebay", "Ebay");
            Companies.Add("Relience", "Relience");
            ViewBag.Companies = Companies;

            if (!ModelState.IsValid)
            {

                string path = string.Empty;
                if (model.ProductImage.Length > 0)
                {
                    path = Path.Combine(
                                Directory.GetCurrentDirectory(), "wwwroot",
                                model.ProductImage.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.ProductImage.CopyToAsync(stream);
                    }
                }

                string companies = string.Join(",", model.Companies);



                return View();
            }
                return View();
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
