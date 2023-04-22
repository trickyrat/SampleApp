using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

using SampleApp.ViewModel;

namespace SampleApp.View;

public partial class ConstructMessage
{
}

public partial class LoginPage : ContentPage
{
    private double LoginProgress { get; set; }
    public static ProgressBar LoginProgressBar;
    private LoginViewModel vm = new LoginViewModel();
    public LoginPage()
    {
        WeakReferenceMessenger.Default.Register<ConstructMessage>(this, async (m, e) =>
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            var message = "Your account was created";
            var dismissalText = "Click Here to Close the SnackBar";
            TimeSpan duration = TimeSpan.FromSeconds(10);
            Action action = async () =>
            {
                await DisplayAlert(
                    "Snackbar Dismissed!",
                    "The user has dismissed the snackbar",
                    "OK");
            };
            var snackbarOptions = new SnackbarOptions
            {
                BackgroundColor = Colors.Red,
                TextColor = Colors.Yellow,
                ActionButtonTextColor = Colors.Black,
                CornerRadius = new CornerRadius(20),
                Font = Microsoft.Maui.Font.SystemFontOfSize(14),
                ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(14)
            };
            var snackbar = Snackbar.Make(
                message,
                action,
                dismissalText,
                duration,
                snackbarOptions);
            await snackbar.Show(cancellationTokenSource.Token);
            vm.ActivityIndicatorIsRunning = false;
        });
        LoginProgressBar = new ProgressBar();
        InitializeComponent();
        LoginStackLayout.Children.Add(LoginProgressBar);
        BindingContext = vm;
    }

    private void ManageActivityIndicator(object sender, ConstructMessage message) { }

    private async void OnSubmit(object sender, EventArgs e)
    {
        for (double i = 0.0; i < 1.0; i += 0.1)
        {
            await LoginProgressBar.ProgressTo(i, 500, Easing.Linear);
        }
        await DisplayAlert("Submit", $"You entered {vm.Name} and {vm.Password}", "OK");
    }

    //private async void OnCreate(object sender, EventArgs e)
    //{
    //    CreateAccount.Text = await DisplayPromptAsync(
    //        title: "New Account",
    //        message: "How old are you?",
    //        placeholder: "Please enter your age",
    //        keyboard: Keyboard.Numeric,
    //        accept: "Ok",
    //        cancel: "Cancel");
    //}

    //private async void OnCreate(object sender, EventArgs e)
    //{
    //    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
    //    var message = "Your account was created";
    //    ToastDuration duration = ToastDuration.Short;
    //    var fontSize = 14;
    //    var toast = Toast.Make(message, duration, fontSize);
    //    await toast.Show(cancellationTokenSource.Token);
    //}


    //private async void OnCreate(object sender, EventArgs e)
    //{
    //    CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
    //    var message = "Your account was created";
    //    var dismissalText = "Click Here to Close the SnackBar";
    //    TimeSpan duration = TimeSpan.FromSeconds(10);
    //    Action action = async () =>
    //    {
    //        await DisplayAlert(
    //            "Snackbar Dismissed!",
    //            "The user has dismissed the snackbar",
    //            "OK");
    //    };
    //    var snackbarOptions = new SnackbarOptions
    //    {
    //        BackgroundColor = Colors.Red,
    //        TextColor = Colors.Yellow,
    //        ActionButtonTextColor = Colors.Black,
    //        CornerRadius = new CornerRadius(20),
    //        Font = Microsoft.Maui.Font.SystemFontOfSize(14),
    //        ActionButtonFont = Microsoft.Maui.Font
    //        .SystemFontOfSize(14)
    //    };
    //    var snackbar = Snackbar.Make(
    //    message,
    //    action,
    //    dismissalText,
    //    duration,
    //    snackbarOptions);
    //    await snackbar.Show(cancellationTokenSource.Token);
    //    vm.ActivityIndicatorIsRunning = false;
    //}






    //private async void OnForgotPassword(object sender, EventArgs e)
    //{
    //    CreateAccount.Text = await DisplayActionSheet(
    //        "How can we solve this?",
    //        "Cancel",
    //        null,
    //        "Get new password",
    //        "Show me my hint",
    //        "Delete account");
    //}
}