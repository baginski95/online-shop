using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepoitory;
        public HomeController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepoitory = productRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductsOfTheWeek = _productRepoitory.ProductsOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
