namespace Orbit;

public partial class DuckDuelPage : ContentPage
{
    private System.Drawing.Color backgroundColor = System.Drawing.Color.Black;
    private int breadClickCounter = 0;
    private int basketClickCounter = 2;

    public DuckDuelPage()
    {
        InitializeComponent();

    }

    private void OnBreadClicked(object sender, EventArgs e)
    {
        vertStack.BackgroundColor = Colors.Blue;
        breadClickCounter++;

        BasketButton.RotateTo(90 * breadClickCounter);
    }

    private void OnBasketClicked(object sender, EventArgs e)
    {
        vertStack.BackgroundColor = Colors.Red;
        basketClickCounter++;

        BreadButton.RotateTo(90 * basketClickCounter);
    }

    private async void OnExitButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");

    }
}