using HomeMaui.ViewModels;


namespace HomeMaui.Views;

public partial class Playlists : ContentPage
{
	public Playlists(PlaylistsVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}