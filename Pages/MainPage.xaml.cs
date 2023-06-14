using Orbit.Engine;

namespace DuckPaperScissors;

public partial class MainPage : ContentPage
{
    private readonly IGameSceneManager gameSceneManager;
    private readonly UserInputManager userInputManager;
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    public MainPage(IGameSceneManager gameSceneManager,
                    UserInputManager userInputManager)
    {
        InitializeComponent();

        this.gameSceneManager = gameSceneManager;
        this.userInputManager = userInputManager;
    }

    private async void OnNewTangoClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("DuckDuelPage"/*, Dictionary<string, object>*/);
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

        var navParams = new Dictionary<string, object>
        {
            { "gameSceneManager", gameSceneManager },
            { "userInputManager", userInputManager}
        };
        await Shell.Current.GoToAsync("DucksOfSumoArenaPage", navParams);
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

