//using CommunityToolkit.Maui.Alerts;

namespace DuckPaperScissors;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnNewDuelClicked(object sender, EventArgs e)
    {
        var hasInternet = Connectivity.Current.NetworkAccess == NetworkAccess.Internet;

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        // 1
        //string text = "This is a Toast";
        //ToastDuration duration = ToastDuration.Short;

        //double fontSize = 14;

        //var toast = Toast.Make(text, duration, fontSize);

        //await toast.Show(cancellationTokenSource.Token);




        // 2
        //await Toast.Make("Howdy, I'm a Toast!",
        //ToastDuration.Long,
        //          16)
        //    .Show(cancellationTokenSource.Token);

        //OpenWindow
        await Shell.Current.GoToAsync("DuckDuelPage"/*, Dictionary<string, object>*/);
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);

        DisplayAlert("Quack", "Crushed it", "Get outta here");
    }
}

