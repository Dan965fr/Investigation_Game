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
            private int _turnNumber;
            private readonly List<string> _sensorTypes = new List<string> { "thermal", "movement", "pluse" , "motion", "magnetic", "signal", "light"};
            private Player _player = new Player();


        public void StartInvestigation()
            {
                _agent = new FootSoldier();
                _turnNumber = 0;

                Console.WriteLine("===== Welcome to the Iranian Agent Investigation System =====");

                while (true)
                {
                    Console.WriteLine($"\nAgent Rank: {_agent.Rank}");
                    Console.WriteLine($"Turn {_turnNumber + 1}: Choose a sensor to attach:");
                    for (int i = 0; i < _sensorTypes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {_sensorTypes[i]}");
                    }

                    Console.Write("Your choice: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int index) || index < 1 || index > _sensorTypes.Count)
                    {
                        Console.WriteLine(" Invalid choice. Please select a valid sensor number.");
                        continue;
                    }

                    ISensor selectedSensor = SensorFactory.CreateSensor(_sensorTypes[index - 1]);
                    _agent.AttachSensor(selectedSensor);

                    _turnNumber++;

                    int correct = _agent.ActivateSensors();
                    _player.AddScore(correct);
                    Console.WriteLine($" Correct sensors: {correct}/{_agent.SecretCount()}");
                    Console.WriteLine(_player);
                if (_agent is ICounterAttackable counterAgent)
                    {
                        counterAgent.CounterAttack(_turnNumber);
                    }


                    if (_agent.IsExposed())
                    {
                        Console.WriteLine($"\n Agent of rank {_agent.Rank} exposed!");

                        if (_agent.Rank == AgentRank.FootSoldier)
                        {
                            _agent = new SquadLeader();
                            Console.WriteLine(" Upgraded to SquadLeader.");
                        }
                        else if (_agent.Rank == AgentRank.SquadLeader)
                        {
                            _agent = new SeniorCommander();
                            Console.WriteLine(" Upgraded to SeniorCommander .");
                        }
                        else if (_agent.Rank == AgentRank.SeniorCommander)
                        {
                            _agent = new OrganizationLeader();
                            Console.WriteLine("Upgraded to OrganizationLeader. ");
                        } 
                        else
                        {
                            Console.WriteLine(" Final agent exposed. Mission complete!");
                            break;
                        }

                        _turnNumber = 0;
                    }
                }
            }
      }

    
}
