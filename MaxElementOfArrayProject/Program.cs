using System;
using MaxElementOfArrayClassLibrary;
using static System.Console;

namespace MaxElementOfArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var example1 = new int[] {1, 2, 3, 4, 5,};
            var example2 = new int[] {1, -10, 3, 4, -4};

            var max = new MaxElementOfArray();

            ShowConsoleResults(max, example1, example2);

            ReadKey();
        }

        private static void FormatedWriteLine(int[] array, int max)
        {
            WriteLine($"Array: {{ {string.Join(", ", array)} }} | Max: {max.ToString()}");
        }

        private static void ShowConsoleResults(MaxElementOfArray max, params int[][] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                FormatedWriteLine(arrays[i], max.Find(arrays[i]));
            }
        }
    }
}