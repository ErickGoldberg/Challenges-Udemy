using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4.Data
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; } // Data de fabricação

        public void PriceTag()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Price: ");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Manufacture Date (DD/MM/YYYY): ");
            ManufactureDate = Convert.ToDateTime(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"{Name} (used) $ {Price} (Manufacture date: {ManufactureDate})";
        }
    }
}
