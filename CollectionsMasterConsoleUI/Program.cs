﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

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
            ////TODO: Create an integer Array of size 50
            int[] myArray = new int[50];


            ////TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(myArray);

            ////TODO: Print the first number of the array
            Console.WriteLine($"The first number of the array is: {myArray[0]}");

            ////TODO: Print the last number of the array
            Console.WriteLine($" The last number of the array is: {myArray[49]}");
            Console.WriteLine();

            Console.WriteLine("All numbers original");
            ////UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");
            Console.WriteLine();

            ////TODO: Reverse the contents of the array and then print the array out to the console.
            ////Try for 2 different ways
            ///*  1) First way, using a custom method => Hint: Array._____(); 
            //    2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            //*/
            Console.WriteLine("All numbers reversed");
            Array.Reverse(myArray);
            NumberPrinter(myArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(myArray);
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine();
            Console.WriteLine("Multiples of three = 0");
            ThreeKiller(myArray);
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");
            Console.WriteLine();

            ////TODO: Sort the array in order now
            ///*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers");
            Array.Sort(myArray);
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");
            Console.WriteLine();
            /*   Set Up   */
            //TODO: Create an integer List
            var myList = new List<int>();


            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"The capacity of the list is: {myList.Count}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this
            Populater(myList);

            //TODO: Print the new capacity
            Console.WriteLine($"The new capacity of the list is: {myList.Count}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine();
            Console.WriteLine("What number will you search for in the number list?");

            string input = Console.ReadLine();
            int inputInt = 0;

            if (int.TryParse(input, out inputInt))
            {
                NumberChecker(myList, inputInt);
            }
            else
            {
                Console.WriteLine("You did not enter a number.");
            }

            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("All numbers");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine();
            Console.WriteLine("Evens numbers only");
            OddKiller(myList);
            NumberPrinter(myList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            myList.Sort();
            Console.WriteLine();
            Console.WriteLine("Sorted even numbers");
            NumberPrinter(myList);
            Console.WriteLine();
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            /* **************************************** */
            Console.WriteLine($"My list length: {myList.Count}");
            int[] arrayConvertedFromList = new int[myList.Count];
            for (int j = 0; j < myList.Count; j++)
            {
                int value;
                value = myList[j];
                arrayConvertedFromList[j] = value;
            }
            NumberPrinter(arrayConvertedFromList);

            //TODO: Clear the list
            myList.Clear();


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = numbers[i];
                if (temp % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                int temp = numberList[i];
                if (temp % 2 != 0)
                {
                    numberList[i] = 0;
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            foreach (int num in numberList)
            {
                if (num == searchNumber)
                {
                    Console.WriteLine($"You guessed {num}, which is in the list!");
                    break; //Stops iterating through the list once the number is found
                }
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numberList.Add(rng.Next(1, 51));
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers[i] = rng.Next(1, 51);
            }
        }

        private static void ReverseArray(int[] array)
        {
            int temp;

            for (int i = 0; i < 50; i++)
            {
                temp = array[i];           //Copy first value in the array to temp (temp = 2)
                array[i] = array[array.Length - 1 - i];  //Copy last value in the array to the first index array[0] = 25
                array[array.Length - 1] = temp;          //Copy temp to the last index in the array[49] = 2
            }
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
