using SampleApp.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Services;

public class PreferenceService
{
    public async Task<List<Preference>> GetPreferences()
    {
        return await GetPreferencesMock();
    }
    private async Task<List<Preference>> GetPreferencesMock()
    {
        List<Preference> preferences = new()
            {
                new Preference()
                {
                    PreferencePrompt = "Shirt Size",
                    PreferenceValue = ""
                },
                new Preference()
                {
                    PreferencePrompt = "Favorite Music Genre",
                    PreferenceValue = ""
                },
                new Preference()
                {
                    PreferencePrompt = "Favorite Color",
                    PreferenceValue = ""
                },
                new Preference()
                {
                    PreferencePrompt = "Favorite Food",
                    PreferenceValue = ""
                },
                new Preference()
                {
                    PreferencePrompt = "Favorite Movie",
                    PreferenceValue = ""
                },
            };
        return preferences;
    }
}
