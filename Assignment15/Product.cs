using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Product
    {

        readonly string pcode;
        String pname;
        int qty_in_stock;
        int discount_allowed;
        static String brand;

        public Product()
        {
            Console.WriteLine("Enter product code : ");
            pcode = Console.ReadLine();

        }

        static Product()
        {
            brand = "Lewis";

        }

        Product(string pcode, int qty_in_Stock, int discount_allowed, String pname)
        {
            this.pcode = pcode;
            this.qty_in_stock = qty_in_Stock;
            this.discount_allowed = discount_allowed;
            this.pname = pname;
        }

        public void GetDetails()
        {
            Console.WriteLine("Enter Product quantity : ");
           qty_in_stock = int.Parse( Console.ReadLine());

            //Console.WriteLine("Enter product code : ");
            //pcode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter discount percentage : ");
            discount_allowed = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter product name : ");
            pname = Console.ReadLine();

        }

        public void DisplayDetails() { 
            Console.WriteLine(pcode + pname+ qty_in_stock + discount_allowed);
        }

    }
}
