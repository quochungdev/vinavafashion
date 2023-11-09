using Microsoft.Maui.Controls;
using VinavaFashionProject.Models;
using VinavaFashionProject.ViewModels;

namespace VinavaFashionProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private ProductViewModel productViewModel = App.ProductViewModel;
        public HomePage()
        {
            InitializeComponent();
            //BindingContext = new HomePageViewModels();
            BindingContext = productViewModel;

            var items = new List<CollectionItem>
            {
                new CollectionItem {Image = (FileImageSource)FileImageSource.FromFile("carousel1.jpg")},
                new CollectionItem {Image = (FileImageSource)FileImageSource.FromFile("carousel2.jpg")},
                new CollectionItem {Image = (FileImageSource)FileImageSource.FromFile("carousel3.jpg")},
            };
            carouselView.ItemsSource = items;
        }
    }
}