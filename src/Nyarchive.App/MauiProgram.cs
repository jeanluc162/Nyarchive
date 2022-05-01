using Microsoft.Extensions.Logging;

namespace Nyarchive.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddLogging(loggingBuilder =>
                loggingBuilder.AddDebug()
            );

            builder.Services.AddSingleton<IPreferences>(Preferences.Default);
            builder.Services.AddSingleton<Navigation.INavigationService, Navigation.NavigationService>();
            builder.Services.AddHttpClient<RestApi.NyarchiveClient>(httpClient =>
            {
                httpClient.Timeout = Timeout.InfiniteTimeSpan;
            }).SetHandlerLifetime(Timeout.InfiniteTimeSpan);

            builder.Services.AddTransient<Views.ServerSettingsPage>();
            builder.Services.AddTransient<ViewModels.ServerSettings>();

            builder.Services.AddTransient<AppShell>();

            return builder.Build();
        }
    }
}