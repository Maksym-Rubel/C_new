using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interface_class
{
    internal class Array1 : IOutput
    {
        private int[] arr;

        public Array1(int[] arr1)
        {
            arr = arr1;
        }

        public void Show()
        {
            Console.WriteLine("Array: " + string.Join(", ",arr));
        }
        public void Show(string info)
        {
            Console.WriteLine($"-------{info}------");
            Console.WriteLine($"Array: " + string.Join(", ", arr));
        }
    }
}
