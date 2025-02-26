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
            builder.Services.AddSingleton<YoutubeViewModel>();

            return builder.Build();
        }
    }
}
