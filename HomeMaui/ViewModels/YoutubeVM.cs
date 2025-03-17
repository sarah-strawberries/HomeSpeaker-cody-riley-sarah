using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grpc.Core;
using HomeMaui.Services;
using HomeSpeaker.Shared;
using System.Collections.ObjectModel;

namespace HomeMaui.ViewModels;

public partial class YouTubeVM : ObservableObject {
    private readonly HomeSpeakerService service;

    [ObservableProperty]
    private string searchText;

    [ObservableProperty]
    private ObservableCollection<Video> songs;

    [ObservableProperty]
    private double progressValue = 0.0;


    public YouTubeVM(HomeSpeakerService service) {
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

    [RelayCommand]
    public async Task CacheVideo(Video SearchResult) {
        var cacheCallReply = service.HomeSpeakerClient.CacheVideo(new CacheVideoRequest { Video = SearchResult });
        await foreach (var reply in cacheCallReply.ResponseStream.ReadAllAsync()) {
            ProgressValue = reply.PercentComplete;
        }
        ProgressValue = 1;
    }
}
