using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Events_Car
{
    internal class Game
    {
        public List<Car> Cars { get; private set; }
        public event Action<string> RaceFinished;
        private bool raceOver = false;
        public Game()
        {
            Cars = new List<Car>();
        }
        public void AddCar(Car car)
        {

            car.Finished += OnCarFinished;
            Cars.Add(car);
        }
        public void Start()
        {
            while (!raceOver)
            {
                foreach (Car car in Cars)
                {
                    car.Drive();
                    if (raceOver) break;
                }
                
                Console.WriteLine();
            }
        }

        private void OnCarFinished(string winner)
        {
            raceOver = true;
            Console.WriteLine($"{winner} finished first");
            RaceFinished?.Invoke( winner );
            
            
        }

    }
}
