using DuckPaperScissors.GameObjects;
using Orbit.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaperScissors.Scenes
{
    public class SumoScene : GameScene
    {
        public SumoScene(
            Duck duck,
            Sun sun,
            Pond pond)
        {
            Add(sun);
            Add(pond);
            Add(duck);
        }
    }
}
