using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class shopww
    {
        public shopww()
        {
            //conmect db
        }
        public shopww(string address, string phone)
        {
            Address = address;
            Phone = phone;

        }
        public string Address { get; set; }
        public string Phone { get; set; }

        // public Catalog[] Catalogs { get; set; }
        public List<Catalog> Catalogs = new List<Catalog>();

        /// <summary>
        ///     метод для  распечатки информации о продукции
        /// </summary>
        public void PrintCatalog()
        {
            foreach (Catalog catalog in Catalogs)
            {
                Console.WriteLine(catalog.Name);
                foreach (product produuct in catalog.Products)
                    produuct.GetProductInfo();
            }
        }
    }
}
