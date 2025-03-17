using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HomeSpeaker.Shared;
using HomeMaui.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace HomeMaui.ViewModels {
    public partial class QueueVM : ObservableObject {
        private readonly HomeSpeakerService _hs;

        [ObservableProperty]
        private int volumeLevel;

        [ObservableProperty]
        private string currentSong;

        public ObservableCollection<SongViewModel> Queue { get; } = new();

        public QueueVM(HomeSpeakerService hs) {
            _hs = hs;
            LoadQueueCommand = new AsyncRelayCommand(LoadQueue);
            SaveQueueCommand = new AsyncRelayCommand(SaveQueueAsPlaylist);
            RemoveFromQueueCommand = new AsyncRelayCommand<SongViewModel>(RemoveFromQueue);

            LoadQueue(); // Load queue on creation
        }

        public IAsyncRelayCommand LoadQueueCommand { get; }
        public IAsyncRelayCommand SaveQueueCommand { get; }
        public IAsyncRelayCommand<SongViewModel> RemoveFromQueueCommand { get; }

        private async Task LoadQueue() {
            Queue.Clear();
            var queueItems = await _hs.GetPlayQueueAsync();
            foreach (var item in queueItems) {
                Queue.Add(item);
            }

            var status = await _hs.GetStatusAsync();
            CurrentSong = status?.CurrentSong?.Name ?? "[ Not playing anything ]";

            VolumeLevel = await _hs.GetVolumeAsync();
        }

        private async Task SaveQueueAsPlaylist() {
            var newPlaylistName = $"From Queue {DateTime.Now:ddd d MMM hh:mm tt}";
            foreach (var song in Queue) {
                await _hs.AddToPlaylistAsync(newPlaylistName, song.Path);
            }
        }

        private async Task RemoveFromQueue(SongViewModel song) {
            if (song != null) {
                Queue.Remove(song);
                await _hs.UpdateQueueAsync(Queue.ToList());
            }
        }

        public async Task UpdateQueueOrder() {
            await _hs.UpdateQueueAsync(Queue.ToList());
        }

        public async Task SetVolume(int volume) {
            VolumeLevel = volume;
            await _hs.SetVolumeAsync(volume);
        }
    }
}
