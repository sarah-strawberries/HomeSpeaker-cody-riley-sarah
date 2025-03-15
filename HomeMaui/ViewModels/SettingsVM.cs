using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HomeMaui.Services;
using System.Collections.ObjectModel;

namespace HomeMaui.ViewModels;

public partial class SettingsVM : ObservableObject {
    private readonly HomeSpeakerService service;
    private readonly PersistenceService pers;

    [ObservableProperty]
    private ObservableCollection<Tuple<string, string>> links = new();

    [ObservableProperty]
    private bool isEditable = false;

    [ObservableProperty]
    private string name;
    [ObservableProperty]
    private string url;

    public SettingsVM(HomeSpeakerService service, PersistenceService pers) {
        this.service = service;
        this.pers = pers;
        links = new ObservableCollection<Tuple<string, string>>(pers.GetLinks());
    }

    [RelayCommand]
    public void AllowEdit() {
        IsEditable = true;
    }

    [RelayCommand]
    public void Save() {
        if (Url != string.Empty) {
            IsEditable = false;
            Links.Add(new Tuple<string, string>(Name, Url)); // Needed to be an ObservableCollection
            pers.AddLink(Name, Url);
            Name = string.Empty;
            Url = string.Empty;
        } else {
            Url = "Please enter a valid URL.";
        }
    }

    [RelayCommand]
    public void UpdateClient(string url) {
        service.UpdateClient(url);
    }

    [RelayCommand]
    public void RemoveLink(Tuple<string, string> link) {
        Links.Remove(link);
        pers.RemoveLink(link);
    }
}
