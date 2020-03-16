using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}
