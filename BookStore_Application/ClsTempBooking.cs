using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Application
{
    public class ClsTempBooking
    {
        public string Name { get; set; }
        public decimal SellingPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalPrice { get; set; }

        public ClsTempBooking()
        {

        }

        public ClsTempBooking(string name, decimal sellingPrice, int quantity, decimal totalPrice,
                            decimal discountPercentage, decimal discount, decimal finalPrice)
        {
            Name = name;
            SellingPrice = sellingPrice;
            Quantity = quantity;
            TotalPrice = totalPrice;
            DiscountPercentage = discountPercentage;
            Discount = discount;
            FinalPrice = finalPrice;
        }
    }
}
