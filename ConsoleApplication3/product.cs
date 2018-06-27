using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public enum TypeSecurity { Type1, Type2, Type3 }
    public class product
    {
        public product() : this(0) { }
       
     
        public product(double Price):this(Price, "") { }
      
        public product(double Price, string Name): this(Price, Name, "") { }
        public product(double Price, string Name, string man)
        {
            this.Price = Price;
            this.Name = Name;
            this.Manufacture = man;
 
      }




        private double Price_;
        public double Price
        {
            get { return Price_; }
            set
            {
                if (value < 0)
                    Price_ = 0;
                else
                {
                    Price_ = value;
                    PriceInShop = PriceInShop - (PriceInShop * 0.03);
                }
            }
        }

        public double PriceInShop { get; private set; }
        public string Name { get; set; }
        public string Manufacture { get; set; }
        public string Color { get; set; }
        public TypeSecurity TypeSecurity { get; set; }
        /// <summary>
        /// возвращает информацию о продукте
        /// </summary>
        public void GetProductInfo()
        {
            Console.WriteLine("{0}\t{1}", Name, Price);
        }
    }
}
