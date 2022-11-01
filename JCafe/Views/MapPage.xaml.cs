namespace JCafe.Views;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.ApplicationModel;
public partial class MapPage : ContentPage
{
	public MapPage()
	{
		InitializeComponent();
	}


	public async Task DriveToCafe()
	{
		var location = new Location(-36.8676623421464, 174.77576187116424);
		var options = new MapLaunchOptions { Name = "Jules Cafe" };


		try
		{
			await Map.Default.OpenAsync(location, options);
		}
		catch(Exception ex)
		{
			// no map application 
		}

	}
	
	private async void MapButton_Clicked(object sender, EventArgs e)
	{
		await Task.Run(DriveToCafe);
	}
}