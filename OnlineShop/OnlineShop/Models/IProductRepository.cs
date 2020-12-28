﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> AllProducts { get; }
        IEnumerable<Product> ProductsOfTheWeek { get; }
        Product GetProductById(int productId);
    }
}
