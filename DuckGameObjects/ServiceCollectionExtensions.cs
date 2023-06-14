namespace DuckPaperScissors.GameObjects;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterGameObjects(this IServiceCollection services) =>
        services
            .AddTransient<Asteroid>()
            .AddTransient<AsteroidLauncher>()
            .AddTransient<AsteroidRemains>()
            .AddScoped<Battery>()
            .AddTransient<BatteryLevelIndicator>()
            .AddTransient<Gun>()
            .AddScoped<Planet>()
            .AddTransient<PlanetHealthIndicator>()
            .AddTransient<Shadow>()
            .AddTransient<Ship>()
            .AddTransient<Sun>()
            .AddScoped<Thruster>()
            .AddTransient<Duck>()
            .AddTransient<Pond>()
            .AddTransient<BB8Mount>();
}
