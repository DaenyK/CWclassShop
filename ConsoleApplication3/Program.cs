using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            shopww shop = new shopww();
            shop.Address = "Кунаева 24";
            shop.Phone = "8 777 209 43 43";


            Catalog catalog = new Catalog() { Name = "Смартфоны" };

            product product = new product();
            product.Name = "Смартфон Samsung Galaxy s9";
            product.Manufacture = "Xiaomi";
            product.Price = 79800;
            product.TypeSecurity = TypeSecurity.Type1;

            catalog.Products.Add(product);
            shop.Catalogs.Add(catalog);

            shop.PrintCatalog();
        }
    }
}
