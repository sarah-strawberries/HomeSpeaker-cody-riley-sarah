using HomeMaui.ViewModels;

namespace HomeMaui.Views;

public partial class SongPage : ContentPage
{
	public SongPage(SongViewModel vm)
	{
		InitializeComponent();
		BindingContext =vm;
	}
}