using VinavaFashionProject.ViewModels;

namespace VinavaFashionProject
{
    public partial class App : Application
    {
        public static ProductViewModel ProductViewModel { get; set; } = new ProductViewModel();
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}