using HomeMaui.ViewModels;

namespace HomeMaui.Views;

public partial class GetYoutubeSong : ContentPage
{
	public GetYoutubeSong(YoutubeVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}