using CommunityToolkit.Mvvm.ComponentModel;

namespace SampleApp.Model;

public partial class Preference : ObservableObject
{
    [ObservableProperty] private string preferencePrompt;
    [ObservableProperty] private string preferenceValue;
}
