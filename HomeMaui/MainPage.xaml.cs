using HomeMaui.ViewModels;
namespace HomeMaui; 
public partial class MainPage : ContentPage {
    public MainPage(MainPageVM vm) {
        InitializeComponent();
        BindingContext = vm;
    }
}
