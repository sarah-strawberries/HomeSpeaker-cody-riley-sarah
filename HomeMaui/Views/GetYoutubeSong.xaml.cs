using HomeMaui.ViewModels;

namespace HomeMaui.Views;

public partial class GetYoutubeSong : ContentPage
{
	public GetYoutubeSong(YoutubeViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}