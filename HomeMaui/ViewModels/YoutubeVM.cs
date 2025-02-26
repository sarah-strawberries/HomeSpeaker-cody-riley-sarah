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

    //[ObservableProperty]
    //public ObservableCollection<Video> songs;


    public YoutubeVM(HomeSpeakerService service) {
        this.service = service;
        SearchText = string.Empty;
        //songs = new ObservableCollection<Video>();
    }

    [RelayCommand]
    public async Task SearchYoutube() {
        //var foundSongs = await service.HomeSpeakerClient.SearchViedoAsync(
        //    new SearchVideoRequest() { SearchTerm = searchText }
        //    );
        SearchText = "Inside method";
        //songs.Clear();
        //foreach (var song in foundSongs) {
        //    songs.Add(song);
        //}
    }
}
