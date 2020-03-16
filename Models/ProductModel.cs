using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop.Models
{
    public class ProductModel
    {
        private List<Product> Products;

        public ProductModel()
        {
            Products = new List<Product>() {
                new Product
                {
                    Id = "01",
                    Name = "Small Rose Bouquet",
                    Price = 35,
                    Description = "Small bouquet of a rose and assorted flowers",
                    InStock = true,
                    Photo = "bouque2.jpg"
                },
                 new Product
                {
                    Id = "02",
                    Name = "Tulips",
                    Price = 25,
                    Description = "Beautiful spring bouquet of tulips",
                    InStock = true,
                    Photo = "tulips.jpg"
                },
                new Product
                {
                    Id = "03",
                    Name = "Assorted",
                    Price = 80,
                    Description = "Large bouqet of assorted flowers",
                    InStock = true,
                    Photo = "flower2.jpg"
                },
                new Product
                {
                    Id = "04",
                    Name = "Be My Valentine",
                    Price = 100,
                    Description = "Bouquet of fifty red roses",
                    InStock = true,
                    Photo = "fiftyroses.jpg"
                },
                new Product
                {
                    Id = "05",
                    Name = "Peonies",
                    Price = 60,
                    Description = "Bouquet of large fragrant peonies",
                    InStock = true,
                    Photo = "peonies.jpg"
                },
                new Product
                {
                    Id = "06",
                    Name = "Classic Romance",
                    Price = 70,
                    Description = "Classical bouquet of assorted flowers",
                    InStock = true,
                    Photo = "roses1.jpg"
                },
                new Product
                {
                    Id = "07",
                    Name = "Red Bouqet",
                    Price = 80,
                    Description = "Bouquet of red roses and other red flowers",
                    InStock = true,
                    Photo = "roses4.jpg"
                },
                new Product
                {
                    Id = "08",
                    Name = "Wedding Bouqet",
                    Price = 60,
                    Description = "A lovely bouqet for the bride on her special day",
                    InStock = true,
                    Photo = "weddingBouque.jpg"
                },
                 new Product
                {
                    Id = "09",
                    Name = "Pink Valentine",
                    Price = 100,
                    Description = "Large bouquet of fifty pink roses",
                    InStock = true,
                    Photo = "fiftypinkroses.png"
                },
                  new Product
                {
                    Id = "10",
                    Name = "Spring Assorted",
                    Price = 65,
                    Description = "Large bouquet of assorted flowers",
                    InStock = true,
                    Photo = "bouque3.jpg"
                }

            };
        }

        public List<Product> findAll()
        {
            return Products;
        }

        public Product find(string id)
        {
            return Products.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
