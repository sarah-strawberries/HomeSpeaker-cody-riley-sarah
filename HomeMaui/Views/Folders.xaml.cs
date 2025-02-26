using HomeMaui.ViewModels;

namespace HomeMaui.Views;

public partial class Folders : ContentPage
{
	public Folders(FoldersVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}