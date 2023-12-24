using EShopper.WebUl.Models;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Entity;
using ShopAppBll.Abstract;
using System.Diagnostics;

namespace EShopper.WebUl.Controllers
{
    public class HomeController : Controller
    {

        //Injection
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            Product p = new Product();
            _productService.Create(p);

            return View();
        }

    }

}
