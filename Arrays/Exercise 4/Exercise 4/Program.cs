using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =
            {
                2, 1, 1, 2, 3, 2, 2, 2, 2, 1
            };
            int start = 0;
            int bestStart = 0;
            int lenght = 1;
            int bestLenght = 0;

            for (int i = 0; i < array.Length - 1 ; i++)
            {
                start = array[i];
                if(array[i] == array[i + 1])
                {
                    lenght++;
                }
                if (array[i] != array[i + 1])
                {
                    lenght = 1;
                }
                if (lenght > bestLenght)
                {
                    bestLenght = lenght;
                    bestStart = start;
                }
            }
            for (int i = 0; i < bestLenght; i++)
            {
                Console.Write(bestStart + " ");
            }
            Console.WriteLine();
        }
    }
}
