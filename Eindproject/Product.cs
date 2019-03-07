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
        public string Oorsprong { get; set; }
        public DateTime datum { get; set; }

        public List<Product> products = new List<Product>();

    }
}
