namespace DuckPaperScissors;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnNewDuelClicked(object sender, EventArgs e)
    {
        //OpenWindow
        
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

