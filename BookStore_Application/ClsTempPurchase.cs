using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Application
{
    public class ClsTempPurchase
    {
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal Discount {  get; set; }
        public decimal FinalPrice { get; set; }

        public ClsTempPurchase()
        {

        }

        public ClsTempPurchase(string name, decimal sellingPrice, int quantity, decimal totalPrice, decimal discountPercentage,decimal discount, decimal finalPrice)
        {
            Name = name;
            PurchasePrice = sellingPrice;
            Quantity = quantity;
            TotalPrice = totalPrice;
            DiscountPercentage = discountPercentage;
            Discount = discount;
            FinalPrice = finalPrice;
        }
    }
}
