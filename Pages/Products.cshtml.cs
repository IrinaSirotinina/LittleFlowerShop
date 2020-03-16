using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowerShop.Data;
using FlowerShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FlowerShop
{
    public class ProductsModel : PageModel
    {
        private readonly FlowerShop.Data.FlowerShopContext _context;

        public ProductsModel(FlowerShop.Data.FlowerShopContext context)
        {
            _context = context;
        }
        public List<Product> Products { get; set; } = new List<Product>();
        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }

        internal static void Initialize(FlowerShopContext context)
        {
            throw new NotImplementedException();
        }
    }
}