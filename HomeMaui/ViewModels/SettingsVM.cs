using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HomeMaui.Services;

namespace HomeMaui.ViewModels;

public partial class SettingsVM : ObservableObject {
    private readonly HomeSpeakerService service;

    [ObservableProperty]
    private List<Tuple<string, string>> links = new();

    [ObservableProperty]
    private bool isEditable = false;

    [ObservableProperty]
    private string name;
    [ObservableProperty]
    private string url;

    public SettingsVM(HomeSpeakerService service) {
        links.Add(new Tuple<string, string>("Localhost", "http://localhost:5000")); // Don't worry about it
        this.service = service;
    }

    [RelayCommand]
    public void AllowEdit() {
        IsEditable = true;
    }

    [RelayCommand]
    public void Save() {
        IsEditable = false;
        service.UpdateClient(Url);
    }


}
