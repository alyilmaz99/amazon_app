using System;
using System.Collections.Generic;
using System.Text;

namespace amazon_app.Models
{
   public class Product
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public string ProductImage { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool IsFavorite { get; set; } = false;
        public bool IsBasket { get; set; } = false;
    }
}
