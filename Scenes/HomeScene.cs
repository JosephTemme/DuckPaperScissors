using DuckPaperScissors.GameObjects;
using Orbit.Engine;

namespace DuckPaperScissors.Scenes;

public class HomeScene : GameScene
{
    public HomeScene(
        Ship ship,
        Sun sun,
        Planet planet)
    {
        Add(sun);
        Add(ship);
        Add(planet);
    }
}
