using SampleApp.ViewModel;

namespace SampleApp.View;

public partial class MainPage : ContentPage
{
	private MainViewModel vm = new MainViewModel();

	public MainPage()
	{
        BindingContext = vm;
        InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		vm.FullName = "Trickyrat";
        vm.FavoriteFlower = "flower.jpg";
    }
}

