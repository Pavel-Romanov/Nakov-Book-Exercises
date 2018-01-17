using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =
            {
                3, 2, 3, 4, 2, 2, 4, 1, 2, 3, 4, 5
            };
            int start = 0;
            int bestStart = 0;
            int lenght = 1;
            int bestLenght = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                start = array[i];
                if (array[i] == array[i + 1] - 1)
                {
                    lenght++;
                }
                if (array[i] != array[i + 1] - 1)
                {
                    lenght = 1;
                }
                if (lenght > bestLenght)
                {
                    bestLenght = lenght;
                    bestStart = start;
                }
            }
            for (int i = bestStart-(bestLenght-2); i <= bestStart + 1; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
