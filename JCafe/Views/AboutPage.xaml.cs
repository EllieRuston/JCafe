namespace JCafe.Views;
using System.Diagnostics;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void FB_Clicked(object sender, EventArgs e)
	{
		try
		{
			Uri uri = new Uri("https://www.facebook.com/FamilyGuy/about");
			await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
		}
		catch (Exception ex)
		{
            await DisplayAlert("Error", ex.Message, "OK");
        }
	}

	private async void Instagram_Clicked(object sender, EventArgs e)
	{
        try
        {
            Uri uri = new Uri("https://www.instagram.com/itsdougthepug");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
			await DisplayAlert("Error", ex.Message, "OK");
        }
       
	}
}