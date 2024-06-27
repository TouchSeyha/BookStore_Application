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
        public decimal SellingPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        //public decimal TotalDiscount { get; set; }

        public ClsTempProduct()
        {

        }

        public ClsTempProduct(string name, decimal sellingPrice, int quantity, decimal totalPrice)
        {
            Name = name;
            SellingPrice = sellingPrice;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }
    }
}
