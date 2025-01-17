using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Events_Car
{
    internal interface Car
    {
        string Name { get; }
        string Color { get; }

        int Speed {  get; }
        int Distancecovered { get; }

        void StartRace();

        void UpdateProgress();
        void Print();


        void ride();
    }
}
