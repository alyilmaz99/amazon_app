using System;
using System.Collections.Generic;
using System.Text;

namespace amazon_app.Models
{
    public class BasketItem
    {
        public int Number { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string BrandName { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
    }
}
