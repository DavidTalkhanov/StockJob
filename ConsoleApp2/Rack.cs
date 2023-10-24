using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Rack
    {
        public List<Box> products = new List<Box>();
        public int Number { get; set; }
        public string Color { get; set; }
        public Rack(List<Box> products, int number, string color)
        {
            this.products = products;
            Number = number;
            Color = color;
        }
    }
}
