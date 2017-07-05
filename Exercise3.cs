using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplaySmallest();
        }

        static void Facebook()
        {
            var names = new List<string>();

            while(true)
            {
                Console.WriteLine("Input some names, then press enter when you're done.");
                var input = Console.ReadLine();


                 if (String.IsNullOrWhiteSpace(input))
                 {
                     break;
                 }
                 else
                 {
                     names.Add(input);
                 }
            }

            if (names.Count > 2)
            {
                 Console.WriteLine("{0}, {1}, and {2} others like your status.", names[0], names[1], names.Count - 2);
            }
            if (names.Count == 2)
            {
                 Console.WriteLine("{0} and {1} like your status.", names[0], names[1]);
            }
            if (names.Count == 1)
            {
                 Console.WriteLine("{0} likes your status.", names[0]);
            }
            else
            {
                 Console.WriteLine();
            }
        }

        static void ReverseName()
        {
            Console.WriteLine("Enter your name.");
            var input = Console.ReadLine();

            var array = new char[input.Length];

            for(var i = input.Length; i > 0; i--)
            {
                array[input.Length - i] = input[i - 1];
            }

            var reversed = new String(array);
            Console.WriteLine(reversed);

        }

        static void SortNums()
        {
            Console.WriteLine("Input 5 numbers (no duplicates)");
            var nums = new List<int>();

            while (nums.Count < 5)
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (nums.Contains(num))
                {
                    Console.WriteLine("This is a duplicate, enter a different number.");
                    continue;
                }
                nums.Add(num);
            }

            nums.Sort();

            foreach(var num in nums)
            {
                Console.WriteLine(num);
            }
        }

        static void DisplayUniqueNums()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter nums or type 'Quit' to exit.");
                var num = Console.ReadLine();

                if (num.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    numbers.Add(Convert.ToInt32(num));
                }
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }


            foreach (var number in uniques)
            {
                Console.WriteLine(number);
            }
        }

        static void DisplaySmallest()
        {
            string[] elements;
            while (true)
            {
                Console.WriteLine("Input a list of comma-separated numbers, for example '4,5,6,4,3,2,6'.");
                var input = Console.ReadLine();

                elements = input.Split(',');

                var numbers = new List<int>();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    if (elements.Length > 5)
                    {
                        foreach (var number in elements)
                        {
                            numbers.Add(Convert.ToInt32(number));
                        }
                    }

                    var smallestNums = new List<int>();
                    while (smallestNums.Count < 3)
                    {
                        var min = numbers[0];
                        foreach (var number in numbers)
                        {
                            if (number < min)
                                min = number;
                        }

                        smallestNums.Add(min);
                        numbers.Remove(min);
                        smallestNums.Sort();

                        Console.WriteLine("Three smallest: {0}, {1}, {2}." + smallestNums[0], smallestNums[1], smallestNums[2]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid list.");
                }
            }
        }
    }
}
