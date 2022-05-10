using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using amazon_app.Models;
using amazon_app.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace amazon_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        /*
        *Search Bar Test
       private readonly List<string> _searchTest = new List<string>
       {
           "as","d","f","g","ghjk","wes"
       };*/
        IList<Product> Ilist { get; set; }

        ProductViewModel test1 = new ProductViewModel();
        private void MainSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            //  var searchresult = test1.products.Where(c => c.Name.Contains(MainSearchBar.Text));
            //string keyword = MainSearchBar.Text;
          // List test1.products.Where(c=> c.Name.Contains(keyword));
        }
        public HomePage()
        {
           
            InitializeComponent();
            // MainListWiev.ItemsSource = test1.ToString();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = this;
            Ilist = new List<Product>();
            
        }

        public async void OnImageNameTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CategoryPage());
        }
    }
}