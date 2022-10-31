namespace JCafe.Views;

using Android.OS;
using System.Diagnostics;
using Xamarin.Google.Crypto.Tink.Proto;

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
			// error message
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
            // error message
        }
       
	}
}