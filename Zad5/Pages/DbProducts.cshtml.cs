using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zad5.Models;
using Zad5.Services;

namespace Zad5.Pages
{
    public class DbProductsModel : PageModel
    {
        public DataBaseProductService ProductService;
        public IEnumerable<DbProduct> Products { get; private set; }
        public DbProductsModel(DataBaseProductService productService)
        {
            ProductService = productService;
        }
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
