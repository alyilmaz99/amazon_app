using System;
using System.Collections.Generic;
using System.Text;

namespace amazon_app.Models
{
   public class ShoppingCart
    {
        public int ID { get; set; }
        public decimal TotalPrice { get; set; }
        public int TotalNumber { get; set; }
        public int DiscountID { get; set; }
    }
}
