using CommunityToolkit.Maui.Maps;
using Microsoft.Extensions.Logging;

namespace MauiToolkitWindowsMapsSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiMaps()
            .UseMauiCommunityToolkitMaps("AvrW9DU83Bgpl6-CR_dARV2mQjBofnK_CJjHjDC_lCZc8CDzHNyQpijU19UhoIj1")
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
