using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace _10_Interface_class
{
    internal class Array1 : IOutput, IMath, ICalc, IOutput2, ICalc2
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

        public int CountDistinct()
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnucal = true;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnucal = false;
                        break;
                    }
                }
                if(isUnucal)
                {
                    count++;
                }
            }

            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < valueToCompare)
                {
                    count++;
                }
            }
            return count;
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

        public void ShowEven()
        {
            Console.Write("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.Write("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine();

        }
    }
}
