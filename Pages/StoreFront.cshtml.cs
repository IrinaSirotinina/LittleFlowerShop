using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowerShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FlowerShop
{
    public class StoreFrontModel : PageModel
    {
        public List<Product> Products;

        public void OnGet()
        {
            ProductModel productModel = new ProductModel();
            Products = productModel.findAll();
        }
    }
}