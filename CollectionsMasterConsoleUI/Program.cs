using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50

            int[] myArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(myArray);


            //TODO: Print the first number of the array

                Console.WriteLine(myArray[0]);

            //TODO: Print the last number of the array

                Console.WriteLine(myArray[49]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(myArray);
            NumberPrinter(myArray);


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(myArray);
            NumberPrinter(myArray);


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var myIntList = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine(myIntList.Capacity);


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this
            Populater(myIntList);          


            //TODO: Print the new capacity
            NumberPrinter(myIntList);


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            string userInput = Console.ReadLine();
            if(userInput.All(char.IsLetter))
            {
                Console.WriteLine("Sorry please input a number.");
            }
        
            int.TryParse(userInput, out int userNumber);

            NumberChecker(myIntList, userNumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myIntList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(myIntList);
            NumberPrinter(myIntList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myIntList.Sort();
            NumberPrinter(myIntList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            myIntList.ToArray();


            //TODO: Clear the list
            myIntList.Clear();


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 3 == 0 && numbers[i] != 0) 
            {
                numbers[i] = 0;
            }
        }
        }

        private static void OddKiller(List<int> numberList)
        {
            numberList.RemoveAll(n => n % 2 != 0);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("Your number is in the list!");
            }
            else
            {
                Console.WriteLine("The list does not contain that number.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for(int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(0,51));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }

        }

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            Console.WriteLine(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
