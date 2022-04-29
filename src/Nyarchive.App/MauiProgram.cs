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
            builder.Services.AddHttpClient<RestApi.NyarchiveClient>(httpClient =>
            {
                httpClient.Timeout = Timeout.InfiniteTimeSpan;
            }).SetHandlerLifetime(Timeout.InfiniteTimeSpan);

            builder.Services.AddLogging(loggingBuilder =>
                loggingBuilder.AddDebug()
            );

            return builder.Build();
        }
    }
}