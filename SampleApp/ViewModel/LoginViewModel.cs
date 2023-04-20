using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

using SampleApp.View;

namespace SampleApp.ViewModel;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty] private string name;
    [ObservableProperty] private string password;
    [ObservableProperty] private bool activityIndicatorIsRunning = true;

    [RelayCommand]
    private async void Submit()
    {
        for (double i = 0.0; i < 1.0; i += 0.1)
        {
            await LoginPage.LoginProgressBar.ProgressTo(i, 500, Easing.Linear);
        }
        //await DisplayAlert("Submit", $"You entered {vm.Name} and {vm.Password}", "OK");
        await Application.Current.MainPage.DisplayAlert("Submit", $"You entered {Name} and {Password}", "OK");
    }

    [RelayCommand]
    private void Create()
    {
        WeakReferenceMessenger.Default.Send(new ConstructMessage());

    }

    //[RelayCommand]
    //private async void ForgotPassword()
    //{
    //    LoginPage.CreateAccount.Text = await Application.Current.MainPage.DisplayActionSheet(
    //        "How can we solve this?",
    //        "Cancel",
    //        null,
    //        "Get new password",
    //        "Show me my hint",
    //        "Delete account");
    //}
}
