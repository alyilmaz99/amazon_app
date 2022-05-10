using amazon_app.Models;
using amazon_app.Service;
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
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {

            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            ServiceProducts.GetInstance().Products.Where(product => product.Name == (asd.FirstOrDefault() as Product)?.Name).FirstOrDefault().IsBasket = false;
            await Navigation.PushAsync(new CartPage());
        }
        IReadOnlyList<object> asd;
        public void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            asd = e.CurrentSelection;
           

        }
    }
}