using Nyarchive.App.RestApi;

namespace Nyarchive.App.Views;

public partial class ServerSettingsPage : ContentPage
{
	public ServerSettingsPage(ViewModels.ServerSettings serverSettings)
	{
		BindingContext = serverSettings;
		InitializeComponent();
	}
}