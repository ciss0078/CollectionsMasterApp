using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
   
    

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            int[] numbers50 = new int[50];


            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            ArrayPopulator50(numbers50);

            Console.WriteLine(numbers50[0]);
            Console.WriteLine(numbers50[numbers50.Length - 1]);

            //Print the first number of the array

            //Print the last number of the array            

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(numbers50);
           // Console.WriteLine(NumberPrinter<int>(int[] numbers50 +"-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            //Array.Reverse(numbers50);
            ReverseArray(numbers50);

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");
            NumberPrinter(numbers50);

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers50);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers50);
            NumberPrinter(numbers50);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            List<int> numbers = new List<int>();


            //Print the capacity of the list to the console
            Console.WriteLine(numbers.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(numbers);
            //Print the new capacity
            Console.WriteLine(numbers.Capacity);
            

            Console.WriteLine("---------------------");
            NumberPrinter(numbers);

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!



            int searchNum;
            bool userNumber;


            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                userNumber = int.TryParse(Console.ReadLine(), out searchNum);

            } while (userNumber == false);



            NumberChecker(numbers, searchNum);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            //NumberPrinter();
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(numbers);
            Console.WriteLine("------------------");
            NumberPrinter(numbers);
            //Sort the list then print results
            numbers.Sort();
            Console.WriteLine("Sorted Evens!!");
            NumberPrinter(numbers);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            int[] arrayNumbers = numbers.ToArray();
            Console.WriteLine("Printing Array");
            NumberPrinter(arrayNumbers);

            //Clear the list

            numbers.Clear();
            Console.WriteLine("Print List");
            Console.WriteLine($"{numbers.Count}");

            #endregion
        }
        
      
        public static int[] ArrayPopulator50(int[] arr)
        {
            Random rd = new Random();

            for (int i = 0; i < 50; i++)
            {
                int rand50 = rd.Next(0, 50);
                arr[i] = rand50;
            }
            return arr;
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int num = 0; num < numberList.Count; num++)
            {
                if(numberList[num] % 2 != 0)
                {
                    numberList.RemoveAt(num--);
                    
                }
            }
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {

                
                Console.WriteLine($"{searchNumber} is present");
            }
            else
            {
                Console.WriteLine($"{searchNumber} is not present");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 50 ;i++)
            {
                
                int randList50 = rng.Next(0, 50);
                numberList.Add(randList50);

            }
            
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            NumberPrinter(array);
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
