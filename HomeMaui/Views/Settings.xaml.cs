using HomeMaui.ViewModels;

namespace HomeMaui.Views;

public partial class Settings : ContentPage
{
	public Settings(SettingsVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}