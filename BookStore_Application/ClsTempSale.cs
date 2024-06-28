using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Application
{
    public class ClsTempSale
    {
        public string Name { get; set; }
        public decimal SellingPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal Discount { get; set; }

       /* public decimal AmountPaid { get; set; }

        public decimal AmountRemain { get; set; }*/
        public decimal FinalPrice { get; set; }

        public ClsTempSale()
        {

        }

        public ClsTempSale(string name, decimal sellingPrice, int quantity, decimal totalPrice, 
                            decimal discountPercentage,decimal discount, decimal finalPrice)
        {
            Name = name;
            SellingPrice = sellingPrice;
            Quantity = quantity;
            TotalPrice = totalPrice;
            DiscountPercentage = discountPercentage;
            Discount = discount;
           /* AmountPaid = amountPaid;
            AmountRemain = amountRemain;*/
            FinalPrice = finalPrice;
        }
    }
}
