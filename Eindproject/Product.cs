using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindproject
{
    public class Product
    {
        public string Omschrijving { get; set; }
        public int Stock { get; set; }

        public Product (string omschrijving, int stock)
        {
            Omschrijving = omschrijving;
            Stock = Stock;
        }

        public List<Product> products = new List<Product>();

    }
}
