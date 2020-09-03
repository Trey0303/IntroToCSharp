using System;
using System.Collections.Generic;

namespace BubbleSortExercise
{
    class Program
    {


        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 2, 3, 1, 4, 6, 1, 7, 100, 29, 3, 5, 17, 8, 9};
            //Print the unsorted array
            Console.WriteLine("Unsorted");
            printArray(array);

            

            for (int i = 0; i < array.Length - 1; ++i)
            {

                if (array[i] > array[i + 1])
                {

                    BubbleSort(array);
                }

            }
            //Check(array);
            Console.WriteLine("\nSorted");
            printArray(array);
            Console.ReadLine();


        }
        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0},\t", array[i]);
                if (i % 10 == 9)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        static void BubbleSort(int[] array)
        {

            if (array.Length <= 1)
            {
                Console.WriteLine("e");
                return;
            }
            int count = 0;
            bool sorted = false;
            while (!sorted)
            {
                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                        sorted = false;
                    }

                    if (array[i] < array[i + 1])
                    {
                        count++;
                    }

                    if (count > array.Length)
                    {
                        sorted = true;
                    }
                }

                 

            }

        }
        
    }
}
