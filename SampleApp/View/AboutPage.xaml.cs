using SampleApp.ViewModel;

namespace SampleApp.View;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		BindingContext = new AboutViewModel();
		InitializeComponent();
	}
}