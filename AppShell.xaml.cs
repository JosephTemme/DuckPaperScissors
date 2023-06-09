using Orbit.Pages;

namespace Orbit;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("DuckDuelPage", typeof(DuckDuelPage));

        Routing.RegisterRoute("DucksOfSumoArenaPage", typeof(DucksOfSumoArenaPage));
    }
}
