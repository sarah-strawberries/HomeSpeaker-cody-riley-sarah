using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HomeMaui.Services;
using HomeSpeaker.Shared;
using System.Collections.ObjectModel;

namespace HomeMaui.ViewModels;

public partial class YoutubeVM : ObservableObject {
    //[ObservableProperty]
    //private string searchText;

    //[ObservableProperty]
    //public ObservableCollection<Video> songs;

    //[RelayCommand]
    //public async Task SearchYoutube() {
    //    var foundSongs = await service.HomeSpeakerClient.SearchViedoAsync(
    //        new SearchVideoRequest() { SearchTerm = searchText }
    //        );
    //    songs.Clear();
    //    //foreach (var song in foundSongs) {
    //    //    songs.Add(song);
    //    //}
    //}
}
