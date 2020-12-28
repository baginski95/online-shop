using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
           new List<Category>
           {
                new Category{CategoryId=1, CategoryName="Premium products", Description="Only for lords"},
                new Category{CategoryId=2, CategoryName="Regular products", Description="For regular ppl"},
                new Category{CategoryId=3, CategoryName="Good price Products", Description="100% satisfaction"}
           };
    }
}
