using HomeMaui.Services;
using HomeMaui.ViewModels;
using HomeMaui.Views;
using Microsoft.Extensions.Logging;

namespace HomeMaui {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<HomeSpeakerService>();

            builder.Services.AddSingleton<GetYoutubeSong>();
            builder.Services.AddSingleton<YoutubeVM>();

            builder.Services.AddSingleton<Activity>();
            builder.Services.AddSingleton<ActivityVM>();

            builder.Services.AddSingleton<Folders>();
            builder.Services.AddSingleton<FoldersVM>();

            builder.Services.AddSingleton<Playlists>();
            builder.Services.AddSingleton<PlaylistsVM>();

            builder.Services.AddSingleton<Queue>();
            builder.Services.AddSingleton<QueueVM>();

            builder.Services.AddSingleton<Streams>();
            builder.Services.AddSingleton<StreamsVM>();

            builder.Services.AddSingleton<SongPage>();
            builder.Services.AddSingleton<SongViewModel>();

            return builder.Build();
        }
    }
}
