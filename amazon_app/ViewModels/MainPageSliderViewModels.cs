using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using amazon_app.Models;

namespace amazon_app.ViewModels
{
    public class MainPageSliderViewModels
    {
        private ObservableCollection<MainPageSlider> photo;

        public MainPageSliderViewModels()
        {
            photo = new ObservableCollection<MainPageSlider>
            {
                new MainPageSlider{ImageSource ="slider1.jpeg"},
                new MainPageSlider{ImageSource ="slider2.jpeg"},
                new MainPageSlider{ImageSource ="slider3.jpeg"},
                new MainPageSlider{ImageSource ="slider4.jpeg"},
            };
        }
        public ObservableCollection<MainPageSlider> Photo 
        {
            get => photo;
            set => photo = value;
        }
    }
}
