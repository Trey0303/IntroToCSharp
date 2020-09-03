using System;

namespace ExerciseArrays
{
    class Program
    {
        //Create a program that asks for 4 numbers from the user and store them in an array. Print out the numbers in reverse order.
        //will ask for user input to have an array of 4 numbers and will display those 4 numbers in reverse
        static void Main(string[] args)
        {
            //creates an array called data
            int[] data = new int[4];
            //asks player to input 4 numbers
            Console.WriteLine("type in 4 numbers: ");

            //player input
            //for loop will continue until i is one less than the length of data array. in this case 5 {0,1,2,3,4,}
            //                                                                                          1,2,3,4,X
            for (int i = 0; i < data.Length; i++)
            {
                //player will input number here
                string numberInput = Console.ReadLine();
                //player input will be added to data array
                data[i] = Convert.ToInt32(numberInput);
                
            }
            //just to put space between player input and reversed player input
            Console.WriteLine(" ");
            
            //sorts array to have it reversed
            Array.Reverse(data);

            //prints out reversed data array
            for (int i = 0; i < data.Length; i++)
            {
               Console.WriteLine(data[i] + " ");
            }
            Console.WriteLine(" ");
            ///////////////////
            /////Write a for loop to initialize the following array (int data[10]) with the values 10, 9, 8… (Etc)
            Console.WriteLine("///////// ");
            int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + ", ");
            }
            Console.WriteLine(" ");
            ///////////////////
            ///Write a program that lets the user enter 5 values into an array. The program should then
            ///display the largest and smallest values stored in the array.
            
            //creates an array
            int[] fiveValues = new int[5];
            //asks player to type 5 numbers
            Console.WriteLine("type in 5 numbers: ");
            for (int i = 0; i < fiveValues.Length; i++)
            {
                //gives player ability to input number here
                string userInput = Console.ReadLine();
                //player input will be added to array
                fiveValues[i] = Convert.ToInt32(userInput);

            }
            //sets lowest number to be first value of array because its the smallest number it knows so far
            int lowestNum = fiveValues[0];
            for (int i = 0; i < fiveValues.Length; i++)
            {
                //chesks to see if value is smallest than current smallest number
                if (lowestNum > fiveValues[i])
                {
                    //has value become new smallest number
                    lowestNum = fiveValues[i];
                }
                
            }
            //prints smallest number
            Console.WriteLine("Smallest number in array is: " + lowestNum);

            //sets biggest number to be first value of array because its the biggest number it knows so far
            int biggestNum = fiveValues[0];
            for (int i = 0; i < fiveValues.Length; i++)
            {
                //chesks to see if value is bigger than current biggest number
                if (biggestNum < fiveValues[i])
                {
                    //has value become new biggest number
                    biggestNum = fiveValues[i];
                }

            }
            //prints largest number
            Console.WriteLine("Largest number in array is: " + biggestNum);
        }
    }
}
