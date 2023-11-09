using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VinavaFashionProject.Models;

namespace VinavaFashionProject.ViewModels;

public class ProductViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Product> products = new ObservableCollection<Product>();
    public event PropertyChangedEventHandler PropertyChanged;

    public ProductViewModel()
    {
        if (products != null)
        {
            products.Add(new Product { Name = "Purple Long Sleeves Raw Vest", Price = 1500, ImageUrl = "product1.jpg" });
            products.Add(new Product { Name = "Plum Midi Raw Dress", Price = 2580, ImageUrl = "product2.jpg" });
            products.Add(new Product { Name = "Purple Long Sleeves Raw Vest", Price = 3612, ImageUrl = "product3.jpg" });
            products.Add(new Product { Name = "Purple Long Sleeves Raw Vest", Price = 2111, ImageUrl = "product4.jpg" });
            products.Add(new Product { Name = "Purple Long Sleeves Raw Vest", Price = 2111, ImageUrl = "product4.jpg" });
            products.Add(new Product { Name = "Purple Long Sleeves Raw Vest", Price = 2111, ImageUrl = "product4.jpg" });
            products.Add(new Product { Name = "Purple Long Sleeves Raw Vest", Price = 2111, ImageUrl = "product4.jpg" });
            products.Add(new Product { Name = "Purple Long Sleeves Raw Vest", Price = 2111, ImageUrl = "product4.jpg" });
        }
    }

    public ObservableCollection<Product> Products { get { return products; } }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}