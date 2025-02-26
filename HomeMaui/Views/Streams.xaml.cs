using HomeMaui.ViewModels;

namespace HomeMaui.Views;

public partial class Streams : ContentPage
{
	public Streams(StreamsVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}