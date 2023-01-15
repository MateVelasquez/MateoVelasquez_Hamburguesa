using MateoVelasquez_Hamburguesa.Data;

namespace MateoVelasquez_Hamburguesa;

public partial class App : Application

{
    public static MV_BurgerDatabase BurgerRepo { get; private set; }

    public App(MV_BurgerDatabase repo)
	{

		InitializeComponent();

		MainPage = new AppShell();

		BurgerRepo = repo;
	}



}
