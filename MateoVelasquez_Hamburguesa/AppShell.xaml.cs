namespace MateoVelasquez_Hamburguesa;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(Views.MV_BurgerItemPage), typeof(Views.MV_BurgerItemPage));
        Routing.RegisterRoute(nameof(Views.MV_BurgerListPage), typeof(Views.MV_BurgerListPage));

    }
}
