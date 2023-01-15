using MateoVelasquez_Hamburguesa.Data;

namespace MateoVelasquez_Hamburguesa;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        string dbPath = FileAccessHelper.GetLocalFilePath("burger.db3");
        builder.Services.AddSingleton<MV_BurgerDatabase>(s => ActivatorUtilities.CreateInstance<MV_BurgerDatabase>(s, dbPath));

        return builder.Build();
	}
}
