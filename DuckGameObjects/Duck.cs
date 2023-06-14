using DuckPaperScissors.DuckGameObjects;
using DuckPaperScissors.Pages;
using Microsoft.Maui.Graphics.Win2D;
using Orbit.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaperScissors.GameObjects
{
    public class Duck : DuckGameObject
    {
        readonly Microsoft.Maui.Graphics.IImage slowDownImage;
        readonly Microsoft.Maui.Graphics.IImage speedUpImage;
        readonly Microsoft.Maui.Graphics.IImage image;
        private readonly IGameSceneManager gameSceneManager;
        //private readonly Thruster thruster;
        private readonly UserInputManager userInputManager;
        public float angle = 0f;

        // TODO: Different types of collision here:
        // 1. Collide with Asteroid - damages ship
        // 2. Move into shadow - stop regenerating power

        public override bool IsCollisionDetectionEnabled => true;

        public Duck(
            IGameSceneManager gameSceneManager,
            //Thruster thruster,
            //Gun gun,
            Battery battery,
            BB8Mount bb8Mount,
            UserInputManager userInputManager)
        {
            image = LoadImage("saturn_duck.jpg");
            //speedUpImage = LoadImage("ship_forward.png");
            //slowDownImage = LoadImage("ship_reverse.png");

            this.gameSceneManager = gameSceneManager;
            //this.thruster = thruster;
            this.userInputManager = userInputManager;
            //Add(gun);
            //Add(thruster);
            Add(battery);

            bb8Mount.Duck = this;
            bb8Mount.Add(bb8Mount);

            //gun.Duck = this;

            //var collision = gameSceneManager.FindCollision(this);

            //if (collision is Planet planet)
            //{
            //    planet.OnHit(25);
            //    CurrentScene.Remove(this);

            //    var remains = this.serviceProvider.GetRequiredService<AsteroidRemains>();
            //    remains.SetBounds(this.Bounds);
            //    CurrentScene.Add(remains);
            //}

            //if (collision is Ship ship)
            //{
            //    CurrentScene.Remove(this);

            //    // TODO: Damage the ship;
            //}

            //// TODO: Allow collision with other asteroids.
            //if (collision is Asteroid otherAsteroid)
            //{
            //    // TODO: Split in to smaller asteroids?
            //    CurrentScene.Remove(otherAsteroid);
            //    CurrentScene.Remove(this);
            //}

            // TODO: remove when off screen.
        }

        public override void Render(ICanvas canvas, RectF dimensions)
        {
            base.Render(canvas, dimensions);

            var size = Math.Min(dimensions.Width, dimensions.Height) / 20;

            Bounds = new RectF(
                dimensions.Center.X - size,
                dimensions.Center.Y - size,
                size * 2,
                size * 2);

            //var orbitRadius = Bounds.Width * 3;

            //canvas.Translate(dimensions.Center.X, dimensions.Center.Y);
            //canvas.Rotate(angle);
            var image = /*this.thruster.IsThrusting ? GetImage(userInputManager.TouchMode) :*/ GetImage(TouchMode.None);
            canvas.DrawImage(image, Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height);

            //Bounds = WHAT???? Needs to include rotation and translation details ;(

            if (DucksOfSumoArenaPage.ShowBounds)
            {
                canvas.StrokeColor = Colors.Yellow;
                canvas.StrokeSize = 4;
                canvas.DrawEllipse(Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height);
            }
        }

        public override void Update(double millisecondsSinceLastUpdate)
        {
            base.Update(millisecondsSinceLastUpdate);

            //angle += this.thruster.Thrust;
        }

        private Microsoft.Maui.Graphics.IImage GetImage(TouchMode touchMode) => touchMode switch
        {
            //TouchMode.SlowDown => slowDownImage,
            //TouchMode.SpeedUp => speedUpImage,
            _ => image
        };
    }
}
