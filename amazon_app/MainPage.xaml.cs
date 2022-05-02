using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using amazon_app.Views;
namespace amazon_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
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
        
        public MainPage()
        {
            InitializeComponent();
            // MainListView.ItemsSource = _searchTest; SEARCHBAR
            
            BindingContext = this;
        }
       
    }
}
