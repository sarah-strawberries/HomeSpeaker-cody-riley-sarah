using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HomeMaui.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using HomeSpeaker.Shared;

namespace HomeMaui.ViewModels {
    public class PlaylistsVM {
        //probably am doing this wrong but I need a HomeSpeakerService
        public HomeSpeakerService _hs;
        public PlaylistsVM(HomeSpeakerService hs) {
            _hs = hs;
        }
        //doesn't work and don't know why

        //[ObservableProperty]
        //private ObservableCollection<Song> _songs = [];

        //[ObservableProperty]
        //private ObservableCollection<Playlist> _playlists = [];


        //public partial class Playlists : ObservableObject {

        //}

        //public partial class Songs : ObservableObject {
        //    Song song;
        //}
    }



}
