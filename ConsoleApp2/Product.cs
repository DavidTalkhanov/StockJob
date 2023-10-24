using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ProductWithoutPrice
    {
        public int id { get; set; }
        public string Name { get; set; }
        public ProductWithoutPrice(int id, string name)
        {
            this.id = id;
            this.Name = name;
        }
    }
    public class Product:ProductWithoutPrice
    {
        public int Price { get; set; }
        public Product(int id, string name, int price) : base(id, name)
        {
            this.Price = price;
        }
        public Product UpPrice(Product product, int price)
        {
            product.Price = price;
            return product;
        }
    }
}
