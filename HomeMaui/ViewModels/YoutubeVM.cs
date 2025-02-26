using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HomeMaui.Services;
using HomeSpeaker.Shared;
using System.Collections.ObjectModel;

namespace HomeMaui.ViewModels;

public partial class YoutubeVM : ObservableObject {
    private readonly HomeSpeakerService service;

    [ObservableProperty]
    private string searchText;

    [ObservableProperty]
    private ObservableCollection<Video> songs;


    public YoutubeVM(HomeSpeakerService service) {
        this.service = service;
        SearchText = string.Empty;
        songs = new ObservableCollection<Video>();
    }

    [RelayCommand]
    public async Task SearchYoutube() {
        var response = await service.HomeSpeakerClient.SearchViedoAsync(
            new SearchVideoRequest() { SearchTerm = searchText }
            );
        var videos = response.Results;
        Songs.Clear();
        foreach (Video song in videos) {
            Songs.Add(song);
        }
    }
}
