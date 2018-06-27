using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Catalog
    {
        public string Name { get; set; }
        //public product [] Products { get; set; }

        public List<product> Products = new List<product>();

    }
}
