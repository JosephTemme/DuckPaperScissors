using DuckPaperScissors.DuckGameObjects;
using Orbit.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaperScissors.GameObjects;

public class Pond : DuckGameObject
{
    Microsoft.Maui.Graphics.IImage image;

    public Pond()
    {
        image = LoadImage("the_pond.jpg");
    }

    public override void Render(ICanvas canvas, RectF dimensions)
    {
        base.Render(canvas, dimensions);

        var size = Math.Min(dimensions.Width, dimensions.Height) / 2;

        var halfWidth = size / 2;
        var halfHeight = size / 2;
        canvas.DrawImage(image, halfWidth, halfHeight, size, size);
    }
}
