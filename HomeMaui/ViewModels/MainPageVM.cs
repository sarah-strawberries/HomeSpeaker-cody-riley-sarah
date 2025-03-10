using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HomeMaui.ViewModels;

public partial class MainPageVM : ObservableObject {
    [RelayCommand]
    private async Task MovePage(string page) {
        await Shell.Current.GoToAsync($"//{page}");
    }
}
