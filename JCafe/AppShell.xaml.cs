namespace JCafe;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(MenuEspresso), typeof(MenuEspresso));
	}
}
