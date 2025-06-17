using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigation_Game.Models
{
    internal static class SensorFactory
    {
        public static List<ISensor> CreatePattern(string[] pattern, int repeats)
        {
            var sensors = new List<ISensor>();
            for (int i = 0; i < repeats; i++)
            {
                foreach (var type in pattern)
                {
                    sensors.Add(new BasicSensor(type));
                }
            }
            return sensors;
        }
    }
}
