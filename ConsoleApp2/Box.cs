using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Box
    {
        public List<Product> products = new List<Product>();
        public int id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Box(int id, int weidth, int height)
        {
            Width = weidth;
            Height = height;
            this.id = id;
        }
        public void AddInBox(Product product)
        {
            products.Add(product);
        }
        public void GetProducts(Product product)
        {
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }
        public void IsProducts(Product product)
        {
            int k = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if (product.Name == products[i].Name)
                {
                    Console.WriteLine("YES");
                }
            }
            if (k == 0)
                Console.WriteLine("NO");
        }
        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].id == product.id)
                {
                    products.Remove(products[i]);
                }
            }
        }
    }
}
