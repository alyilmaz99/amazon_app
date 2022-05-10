using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using amazon_app.Models;
using System.Linq;
using System.Collections;
using amazon_app.Service;

namespace amazon_app.ViewModels
{
    
    public class ProductViewModel : INotifyPropertyChanged
    {

        public ProductViewModel()
        {
            products = ServiceProducts.GetInstance().Products;
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public ObservableCollection<Product> products
        {
            get { return ServiceProducts.GetInstance().Products; }
            set
            {
                ServiceProducts.GetInstance().Products = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("products"));
            }
        }
    }
}
