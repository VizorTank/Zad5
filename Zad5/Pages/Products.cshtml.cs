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
    public class ProductsModel : PageModel
    {
        public JsonFileProductService ProductService;
        public IEnumerable<Product> Products { get; private set; }

        public ProductsModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
