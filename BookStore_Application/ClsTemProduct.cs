using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Application
{
    public class ClsTempProduct
    {
        public string Name { get; set; }
        public double SelllingPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public double TotalDiscount { get; set; }

        public ClsTempProduct()
        {

        }

        public ClsTempProduct(string name, double sellingPrice, int quantity, double totalPrice, double TotalDiscount)
        {
            Name = name;
            SelllingPrice = sellingPrice;
            Quantity = quantity;
            TotalPrice = totalPrice;
            TotalDiscount = totalPrice;
        }
    }
}
