using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal static class SensorFactory
    {
        public static ISensor CreateSensor(string type)
        {
            switch (type)
            {
                case "thermal": return new BasicSensor("thermal");
                case "movement": return new BasicSensor("movement");
                case "pluse": return new PluseSensor();
                case "motion": return new MotionSensor();
                case "magnetic": return new MagneticSensor();
                case "signal": return new SignalSensor();
                case "light": return new LightSensor();
                default: throw new ArgumentException($"Unknown sensor type: {type}");
            }
        }

        public static List<ISensor> CreatePattern(string[] pattern, int repeats)
        {
            var sensors = new List<ISensor>();
            for (int i = 0; i < repeats; i++)
            {
                foreach (var type in pattern)
                {
                    sensors.Add(CreateSensor(type));
                }
            }
            return sensors;
        }
    }
}
