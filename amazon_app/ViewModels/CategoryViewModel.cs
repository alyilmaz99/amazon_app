using amazon_app.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace amazon_app.ViewModels
{
    
    public class CategoryViewModel : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Category> Categories;

        public ObservableCollection<Category> categories
        {
            get { return Categories; }
            set { Categories = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("categories"));
                    }
            
        }


        public CategoryViewModel()
        {
            categories = new ObservableCollection<Category>();
            addData();
        }

        private void addData()
        {
            categories.Add(new Category
            {
                ID = 0,
                Name = "PC",
                ImageSource = "PC",
            });
            categories.Add(new Category
            {
                ID = 0,
                Name = "Mother's Day",
                ImageSource = "MothersDay",
            }); 
            categories.Add(new Category
            {
                ID = 0,
                Name = "Sport",
                ImageSource = "Sport",
            });
            categories.Add(new Category
            {
                ID = 0,
                Name = "Man",
                ImageSource = "Man",
            });
            categories.Add(new Category
            {
                ID = 0,
                Name = "Women",
                ImageSource = "Women",
            });
        }
    }
}
