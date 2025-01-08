using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interface_class
{
    internal class Array1 : IOutput, IMath
    {
        private int[] arr;

        public Array1(int[] arr1)
        {
            arr = arr1;
        }

        public float Avg()
        {
            float avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }
            return avg/arr.Length;
        }

        public int Max()
        {
            int Max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max) 
                    Max = arr[i];
            }
            return Max;
        }

        public int Min()
        {
            int Min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                    Min = arr[i];
            }
            return Min;
        }

        public bool Search(int valueToSearch)
        {
            bool isNumber = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == valueToSearch)
                {
                    isNumber = true; break;
                }
            }
            return isNumber;
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
