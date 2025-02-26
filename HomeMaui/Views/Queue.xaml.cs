using HomeMaui.ViewModels;

namespace HomeMaui.Views;

public partial class Queue : ContentPage
{
	public Queue(QueueVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}