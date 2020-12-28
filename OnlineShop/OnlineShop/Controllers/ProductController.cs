using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepoitory;
        private readonly ICategoryRepository _categoryRepository;
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepoitory = productRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            return View(_productRepoitory.AllProducts);
        }
    }
}
