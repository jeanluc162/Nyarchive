using Nyarchive.App.RestApi;

namespace Nyarchive.App;

public partial class AddServerPage : ContentPage
{
	private readonly NyarchiveClient _nyarchiveClient;

	public AddServerPage(NyarchiveClient nyarchiveClient)
	{
		InitializeComponent();
		_nyarchiveClient = nyarchiveClient;
	}
}