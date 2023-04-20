using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SampleApp.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private string fullName;
    [ObservableProperty] private string favoriteFlower = "flower.jpg";
    [ObservableProperty] private bool flowerIsVisible = true;

    [RelayCommand]
    private void ToggleFlowerVisibility()
    {
        FlowerIsVisible = !FlowerIsVisible;
    }
}
