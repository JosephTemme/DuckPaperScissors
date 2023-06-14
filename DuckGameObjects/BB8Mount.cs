using DuckPaperScissors.DuckGameObjects;
using Orbit.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaperScissors.GameObjects;

/// <summary>
/// Mounts to the underside of the Duck to allow for 
/// proper Sumo movement!
/// </summary>
public class BB8Mount : DuckGameObject
{
    private readonly Battery battery;
    private readonly UserInputManager userInputManager;
    private const float batteryDrain = 0.5f;

    public BB8Mount(
        Battery battery,

        UserInputManager userInputManager)
    {
        this.battery = battery;
        this.userInputManager = userInputManager;
    }

    public Duck Duck { get; set; }

    public float Thrust { get; private set; }

    public bool IsThrusting => Thrust != -0.25f;

    public override void Update(double millisecondsSinceLastUpdate)
    {
        //if (this.battery.ConsumeBatteryAmount(thruster.GetBatteryDrain(userInputManager.TouchMode)))
        //{
        Thrust = Thruster.GetThrust(userInputManager.TouchMode);
        //}
        //else
        //{
        //    Thrust = -0.25f;
        //}

        base.Update(millisecondsSinceLastUpdate);
    }

    private static float GetBatteryDrain(TouchMode touchMode) => touchMode switch
    {
        TouchMode.SlowDown => batteryDrain,
        TouchMode.SpeedUp => batteryDrain,
        _ => 0
    };

    public static float GetThrust(TouchMode touchMode) => touchMode switch
    {
        TouchMode.None => -0.25f,
        //TouchMode.SlowDown => -0.1f,
        //TouchMode.SpeedUp => -1.2f,
        TouchMode.Up => 1f,
        TouchMode.Down => 1f,
        TouchMode.Right => 1f,
        TouchMode.Left => 1f,
        _ => 0f
    };
}
