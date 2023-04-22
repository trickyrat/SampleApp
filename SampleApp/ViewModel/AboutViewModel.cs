using CommunityToolkit.Mvvm.ComponentModel;

namespace SampleApp.ViewModel;

public partial class AboutViewModel : ObservableObject
{
    [ObservableProperty] private string apiVersion;
    public AboutViewModel()
    {
        apiVersion = "1.0";
    }
}
