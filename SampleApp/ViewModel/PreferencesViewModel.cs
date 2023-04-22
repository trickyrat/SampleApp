using CommunityToolkit.Mvvm.ComponentModel;

using SampleApp.Model;
using SampleApp.Services;

namespace SampleApp.ViewModel;

public partial class PreferencesViewModel : ObservableObject
{
    [ObservableProperty] private List<Preference> preferences;
    private readonly PreferenceService _preferenceService;

    public PreferencesViewModel()
    {
        _preferenceService = new();
    }

    public async Task Init()
    {
        Preferences = await _preferenceService.GetPreferences();
    }
}
