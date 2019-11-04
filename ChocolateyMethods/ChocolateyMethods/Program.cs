using System;

namespace ChocolateyMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Redo: keeps track of whether user would like to try another method.
            char redo = 'y';

            while (redo == 'y')
            {
                Console.WriteLine("Possible Methods:");
                Console.WriteLine("Method 1: Reverse the word order in a phrase.");
                Console.WriteLine("Method 2: Find the second largest integer in an array.");
                Console.WriteLine("Method 3: Find if an integer is a prime number.");
                Console.WriteLine("What method would you like to try? (Ex. 1, 2, 3)");
                string input = Console.ReadLine();

                //Checks that the input is a correct method option.
                while (!input.Equals("1") && !input.Equals("2") && !input.Equals("3"))
                {
                    Console.WriteLine("Not a method option. Please enter 1, 2, or 3");
                    input = Console.ReadLine();
                }
                switch (input)
                {
                    case "1":
                        Console.WriteLine("What phrase would you like to reverse?");
                        string phrase = Console.ReadLine();
                        ReverseWordOrder(phrase);
                        break;
                    case "2":
                        Console.WriteLine("Please enter your list of numbers seperated by spaces:");
                        int[] array = CreateIntArr(Console.ReadLine());
                        FindSecondLargeInArray(array);
                        break;
                    case "3":
                        Console.WriteLine("Please enter the number you would like to check:");
                        int[] number = CreateIntArr(Console.ReadLine());
                        if (FindPrime(number[0])) Console.WriteLine("Prime");
                        else Console.WriteLine("Not Prime");
                        break;
                }

                //Asks user if they'd like to try another method. Repeats unit either y or n is entered.
                Console.WriteLine("Would you like to try another method? Y or N");
                string answer = Console.ReadLine();
                redo = char.ToLower(answer[0]);
                while (redo != 'y' && redo != 'n')
                {
                    Console.WriteLine("Please reenter: ");
                    answer = Console.ReadLine();
                    redo = char.ToLower(answer[0]);
                }

            }
        }
        /*Method function provided by Chocolatey, body creates a string of str's words backward.
         *str: String entered by user that needs to be reversed.
         *rev: String made by reversing the words in str. Printed out.
         */
        internal static void ReverseWordOrder(string str)
        {
            string[] words = str.Split(' ');
            Array.Reverse(words);
            Console.WriteLine("Reversed: " + string.Join(" ", words));
        }
        /*Method creates an integer array from a string, str.
         *str: String entered by user that contains integers seperated by spaces.
         *Returns arr: arr is an integer array from numbers in str.
         */
        private static int[] CreateIntArr(string str)
        {
            bool works = false;
            int[] arr = new int[0];
            while (!works)
            {
                try
                {
                    string[] arrstr = str.Split(' ');
                    arr = new int[arrstr.Length];
                    for (int i = 0; i < arrstr.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(arrstr[i]);
                    }
                    works = true;
                }
                catch
                {
                    Console.WriteLine("Please enter only integers seperated by spaces:");
                    str = Console.ReadLine();
                }
            }
            return arr;

        }
        /*Method finds the second largest integer in an array using only one loop.
         *arr: the array is created by the user entering the integers.
         */
        internal static void FindSecondLargeInArray(int[] arr)
        {
            int first = arr[0];
            int second = arr[0];
            foreach (int i in arr)
            {
                if (i > first)
                {
                    second = first;
                    first = i;
                }
                else if (i > second) { second = i; }
            }
            Console.WriteLine("Second Largest number is " + second);
        }
        /*Method finds if a number is prime.
         *number: the integer to be checked is entered by the user.
         *prime: this boolean returns true if number is prime and false if it's not.
         */
        internal static bool FindPrime(int number)
        {
            if (number == 1 || number == 0) return false;
            if (number == 2) return true;
            int limit = (int)Math.Ceiling(Math.Sqrt(number));
            for (int i = 2; i < limit; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
    
}
