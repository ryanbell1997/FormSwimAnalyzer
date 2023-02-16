using Application.Services.UIData;
using Client.Services.Uploader;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System.Reflection;
using Tewr.Blazor.FileReader;

namespace Client;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});
            
        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddSyncfusionBlazor();
        builder.Services.AddFileReaderService();
		builder.Services.AddSingleton<IUploaderService, UploaderService>();
		builder.Services.AddSingleton<IUIDataService, UIDataService>();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		var app = builder.Build();

        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("");

		return app;
    }
}
