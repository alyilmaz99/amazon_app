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
    public partial class HomePage : ContentPage
    {
        /*
        *Search Bar Test
       private readonly List<string> _searchTest = new List<string>
       {
           "as","d","f","g","ghjk","wes"
       };*/
        private void MainSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            /*
            string keyword = MainSearchBar.Text;
            IEnumerable<String> searchResult = _searchTest.Where(name => name.ToLower().Contains(keyword.ToLower()));
            MainListView.ItemsSource = searchResult;
            */
        }
        public HomePage()
        {
            InitializeComponent();
            // MainListView.ItemsSource = _searchTest; SEARCHBAR

            BindingContext = this;
        }
    }
}