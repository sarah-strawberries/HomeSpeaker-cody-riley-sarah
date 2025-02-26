using HomeMaui.ViewModels;

namespace HomeMaui.Views;

public partial class Activity : ContentPage
{
	public Activity(ActivityVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}