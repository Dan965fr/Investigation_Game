using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Investigation_Game.Models;

namespace Investigation_Game.Menue
{
    internal class InvestigationManager
    {
        private IranianAgent _agent;
        private List<Sensor> _sensorOptions;

        public InvestigationManager()
        {
            _sensorOptions = new List<Sensor>() {

                new Sensor("thermal"),
                new Sensor("movement")
            };
            _agent = new IranianAgent(new List<Sensor>
            {
                new Sensor("thermal"),
                new Sensor("thermal")

            });
            


        }
        public void StartInvestigation()
        {
            Console.WriteLine("=====Welcome To Investigation=====");
            while (!_agent.IsExposed())
            {
                Console.WriteLine("\nchose sensor to pair:(1.thermal,2.movement)");
                string choice = Console.ReadLine();

                Sensor chosenSensor = null;
                if (choice == "1") chosenSensor = _sensorOptions[0];
                else if (choice == "2") chosenSensor = _sensorOptions[1];
                else
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }
                _agent.AttachSensor(chosenSensor);
                int correctCount = _agent.ActivateSensors();
                Console.WriteLine($"For now: {correctCount}/{_agent.SecretCount()} right sensor");




            }
            Console.WriteLine("The agent expose");

        }

    }
}
