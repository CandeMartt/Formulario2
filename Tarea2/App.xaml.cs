namespace Tarea2;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var navPage = new NavigationPage(new MainPage());
		navPage.BarBackground = Colors.DarkViolet;
        MainPage = navPage;
	}
}
