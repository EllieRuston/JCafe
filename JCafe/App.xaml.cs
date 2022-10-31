using JCafe.Views;

namespace JCafe;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		
		MainPage = new AppShell();
	}
}
