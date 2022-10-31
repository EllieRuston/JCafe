namespace JCafe.Views;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}

	private async void btnEsp_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MenuEspresso());
	}

	private async void btnHot_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new MenuHot());
    }

	private async void btnCold_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new MenuCold());
    }

	private async void btnFood_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new MenuFood());
    }
}