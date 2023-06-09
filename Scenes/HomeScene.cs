using Orbit.Engine;
using Orbit.GameObjects;

namespace Orbit.Scenes;

public class HomeScene : GameScene
{
    public HomeScene(
        Duck duck,
        Sun sun,
        Pond pond)
    {
        Add(sun);
        Add(pond);
        Add(duck);
    }
}
