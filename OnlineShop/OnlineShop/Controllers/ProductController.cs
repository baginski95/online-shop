using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using OnlineShop.ViewModels;
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
            var productsListViewModel = new ProductsListViewModel();
            productsListViewModel.Products = _productRepoitory.AllProducts;

            productsListViewModel.CurrentCategory = "Premium products";
            return View(productsListViewModel);
        }
    }
}
