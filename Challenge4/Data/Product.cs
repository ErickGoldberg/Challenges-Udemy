using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4.Data
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public void PriceTag()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Price: ");
            Price = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{Name}, $: {Price}";
        }
    }
}
