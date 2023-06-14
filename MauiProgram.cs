﻿using DuckPaperScissors.GameObjects;
using DuckPaperScissors.Pages;
using DuckPaperScissors.Scenes;
using Orbit.Engine;

namespace DuckPaperScissors;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseOrbitEngine()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("SpaceMono-Bold.ttf", "SpaceMonoBold");
            })
            .Services
                .AddTransient<MainPage>()
                .AddSingleton(HapticFeedback.Default)
                .AddSingleton(Vibration.Default)
                .AddSingleton<UserInputManager>()
                .AddSingleton<DuckDuelPage>()
                .AddSingleton<DucksOfSumoArenaPage>()
                .RegisterGameObjects()
                .RegisterScenes();

        return builder.Build();
    }
}
