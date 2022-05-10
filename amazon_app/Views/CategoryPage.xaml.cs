using amazon_app.Models;
using amazon_app.Service;
using amazon_app.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace amazon_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        public CategoryPage()
        {
            InitializeComponent();
            
        }
        public async void ProductImage_Clicked(object sender, EventArgs args)
        {         
                await Navigation.PushAsync(new ProductDetailPage());

        }

        private void CategoryBinding_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ProductViewModel. (e.CurrentSelection.FirstOrDefault() as Product)?.Name;

            ServiceProducts.GetInstance().Products.Where(product => product.Name == (e.CurrentSelection.FirstOrDefault() as Product)?.Name).FirstOrDefault().IsBasket = true;

            

            Console.WriteLine(ServiceProducts.GetInstance().Products);

        }
    }
}