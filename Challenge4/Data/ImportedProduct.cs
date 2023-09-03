using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4.Data
{
    internal class ImportedProduct : Product
    {
        public string CustomsFee { get; set; } // Taxa de alfândega

        public void PriceTag()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Price: ");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Customs Fee: ");
            CustomsFee = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"{Name}, $: {Price} (Customs fee: $ {CustomsFee})";
        }
    }
}
