using HomeMaui.ViewModels;

namespace HomeMaui.Views;

public partial class GetYouTubeSong : ContentPage
{
	public GetYouTubeSong(YouTubeVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}