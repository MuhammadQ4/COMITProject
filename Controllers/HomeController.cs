using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        
        List<string> categoryId = new List<string>(); 
        [HttpGet]
        public IActionResult Index()
        {
            pivotSub _pivotSub = new pivotSub();
            ViewData["prods"] = _pivotSub.getProductsFromDB();
            return View(); 
        }
        public IActionResult searchByName(string searchTxt)
        {
            pivotSub _pivotSub = new pivotSub();
            ViewData["prods"] = _pivotSub.searchProductByName(searchTxt);
            return View("searchByName");
        }
      
        public IActionResult Living()
        {
            pivotSub _pivotSub = new pivotSub();
            ViewData["prods"] = _pivotSub.searchByLiving();
            ViewData["options"] = this.optionsList_controller();
            ViewData["categoryId"] = 1;
            ViewData["categoryName"] = "Living";
            return View();
        }

        public IActionResult Dining()
        {
            pivotSub _pivotSub = new pivotSub();
            ViewData["prods"] = _pivotSub.searchByDining();
            ViewData["options"] = this.optionsList_controller();
            ViewData["categoryId"] = 2;
            ViewData["categoryName"] = "Dining";
            return View("Living");
        }

        public IActionResult Bedroom()
        {
            pivotSub _pivotSub = new pivotSub();
            ViewData["prods"] = _pivotSub.searchByBedroom();
            ViewData["options"] = this.optionsList_controller();
            ViewData["categoryId"] = 3;
            ViewData["categoryName"] = "Bedroom";
            return View("Living");
        }

        public IActionResult Decor()
        {
            pivotSub _pivotSub = new pivotSub();
            ViewData["prods"] = _pivotSub.searchByDecor();
            ViewData["options"] = this.optionsList_controller();
            ViewData["categoryId"] = 4;
            ViewData["categoryName"] = "Decor";
            return View("Living");
        }

        public IActionResult Filter(int catID, int subcatID)
        {
            pivotSub _pivotSub = new pivotSub();
            ViewData["options"] = this.optionsList_controller();
            ViewData["prods"] = _pivotSub.searchBySubcat(catID, subcatID);
            ViewData["categoryId"] = catID;
            ViewData["subCategoryId"] = subcatID;
            return View("Living");
        }

        public List<subCategory> optionsList_controller()
        {
            pivotSub _pivotSub = new pivotSub();
            return _pivotSub.options();
        }

        //  public subCategory option_controller(int ID)
        // {
        //     pivotSub _pivotSub = new pivotSub();
        //     return _pivotSub.option(ID);
        // }

        public IActionResult sortProds(int catID, int subcatID)
        {
            pivotSub _pivotSub = new pivotSub();
            ViewData["prods"] = _pivotSub.sortFromHighToLow(catID, subcatID);
            ViewData["options"] = this.optionsList_controller();
            ViewData["categoryId"] = catID;
            ViewData["subCategoryId"] = subcatID;
            return View("Living");
        }

        // [HttpPost]
        // public IActionResult Register(User _user )
        // {
        //     UsersPad _newUserPad = new UsersPad();
        //     _newUserPad.RegisterUser(_user);
        //     ViewData["success"] = "Registration is successful!";
        //     return Redirect("/Home/Register");
        // }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
