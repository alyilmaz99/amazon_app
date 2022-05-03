using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace amazon_app.Models
{
    public class MainPageProducts
    {
        public float price {
            get => price;
            set => price =value;
        }

        public string name
        {
            get => name;
            set => name = value;

        }
        public ImageSource imageSource
        {
            get => imageSource;
            set => imageSource = value;
        }

    }
}
