using Microsoft.Maui.Graphics.Win2D;
using Orbit.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaperScissors.DuckGameObjects;
public abstract class DuckGameObject : GameObject
{
    protected override Microsoft.Maui.Graphics.IImage LoadImage(string imageName)
    {
        var assembly = GetType().GetTypeInfo().Assembly;

        using (var stream = assembly.GetManifestResourceStream("DuckPaperScissors.Resources.EmbeddedResources." + imageName))
        {
#if WINDOWS
            return new W2DImageLoadingService().FromStream(stream);
#else
            return PlatformImage.FromStream(stream);
#endif
        }
    }
}
