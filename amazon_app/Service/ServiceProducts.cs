using amazon_app.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace amazon_app.Service
{
    class ServiceProducts 
    {

        private ServiceProducts() {
            Products = new ObservableCollection<Product>();
            addData();
        }

        private static ServiceProducts _instance;

        public static ServiceProducts GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ServiceProducts();
            }
            return _instance;
        }


        

        public ObservableCollection<Product> Products;

        //public ObservableCollection<Product> products
        //{
        //    get { return Products; }
        //    set
        //    {
        //        Products = value;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("products"));
        //    }
        //}

        public void addData()
        {
            Products.Add(new Product
            {
                ID = 0,
                Name = "Acer Nitro 5 AN515 - 55 - 53E5 Gaming Laptop",
                IsBasket = false,
                IsFavorite = false,
                Description = "Acer Nitro 5 AN515-55-53E5 Gaming Laptop | Intel Core i5-10300H | NVIDIA GeForce RTX 3050 Laptop GPU | 15.6\" FHD 144Hz IPS Display | 8GB DDR4 | 256GB NVMe SSD | Intel Wi - Fi 6 | Backlit Keyboard",
                Price = 943,
                ProductImage = "acer.jpg",
            });
            Products.Add(new Product
            {
                ID = 0,
                Name = "Lenovo Flex 5 Laptop",
                IsBasket = false,
                IsFavorite = false,
                Description = "Lenovo Flex 5 Laptop, 14.0\" FHD Touch Display, AMD Ryzen 5 5500U,16GB RAM,256GB Storage,AMD Radeon Graphics,Windows 11 Home",
                Price = 671,
                ProductImage = "lenovo.jpg",
            });
            Products.Add(new Product
            {
                ID = 0,
                Name = "MSI Pulse GL66 Gaming Laptop",
                IsBasket = false,
                IsFavorite = false,
                Description = "MSI Pulse GL66 Gaming Laptop: 15.6\" 144Hz FHD 1080p Display,Intel Core i7 - 11800H,NVIDIA GeForce RTX 3070,16GB,512GB SSD,Win10,Black(11UGK - 001)",
                Price = 1645,
                ProductImage = "msi.jpg",
            });
            Products.Add(new Product
            {
                ID = 0,
                Name = "ASUS ROG Strix Scar 15 (2022) Gaming Laptop",
                IsBasket = false,
                IsFavorite = false,
                Description = "ASUS ROG Strix Scar 15 (2022) Gaming Laptop, 15.6” 300Hz IPS FHD Display, NVIDIA GeForce RTX 3070 Ti,Intel Core i9 12900H, 16GB DDR5, 1TB SSD, Per-Key RGB Keyboard, Windows 11 Home, G533ZW-AS94",
                Price = 2618,
                ProductImage = "asus.jpg",
            });
            Products.Add(new Product
            {
                ID = 0,
                Name = "Razer Blade 14 Gaming Laptop",
                IsBasket = false,
                IsFavorite = false,
                Description = "Razer Blade 14 Gaming Laptop: AMD Ryzen 9 5900HX 8 Core, NVIDIA GeForce RTX 3080, 14\" QHD 165Hz,16GB RAM,1TB SSD - CNC Aluminum - Chroma RGB - THX Spatial Audio - Vapor Chamber Cooling",
                Price = 2684,
                ProductImage = "razer.jpg",
            });

        }

    }
}
