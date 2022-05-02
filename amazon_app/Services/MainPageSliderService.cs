using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using amazon_app.Models;

namespace amazon_app.Services
{
    public class MainPageSliderService
    {
        private ObservableCollection<MainPageSlider> photo;

        public MainPageSliderService()
        {
            photo = new ObservableCollection<MainPageSlider>
            {
                new MainPageSlider{ImageSource ="slider1.jpeg"},
                new MainPageSlider{ImageSource ="slider2.jpeg"},
                new MainPageSlider{ImageSource ="slider3.jpeg"},
                new MainPageSlider{ImageSource ="slider4.jpeg"},
                new MainPageSlider{ImageSource ="slider5.jpeg"},
            };
        }
        public ObservableCollection<MainPageSlider> Photo 
        {
            get => photo;
            set => photo = value;
        }
    }
}
