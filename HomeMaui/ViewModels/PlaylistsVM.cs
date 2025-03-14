using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HomeSpeaker.Shared;
using HomeMaui.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HomeMaui.ViewModels {
    public partial class PlaylistsVM : ObservableObject {
        private readonly HomeSpeakerService _hs;

        [ObservableProperty]
        private bool isLoading;

        public ObservableCollection<Playlist> Playlists { get; } = new();

        public PlaylistsVM(HomeSpeakerService hs) {
            _hs = hs;
            LoadPlaylistsCommand = new AsyncRelayCommand(LoadPlaylists);
            LoadPlaylists(); 
        }

        public IAsyncRelayCommand LoadPlaylistsCommand { get; }

        private async Task LoadPlaylists() {
            if (IsLoading) return;
            IsLoading = true;

            try {
                var playlists = await _hs.GetPlaylistsAsync();
                Playlists.Clear();
                foreach (var playlist in playlists) {
                    Playlists.Add(playlist);
                }
            } finally {
                IsLoading = false;
            }
        }
    }
}
