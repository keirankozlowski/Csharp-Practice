using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter whichever method you'd like to see here
        }

        static void Consecutive()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen.");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }
            numbers.Sort();

            var isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                    isConsecutive = false;
                break;
            }
            if (isConsecutive == true)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");
        }

        static void Duplicates()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen.");
            var input = Console.ReadLine();
            var numbers = new List<int>();

            if (String.IsNullOrEmpty(input))
                return;
            else
                foreach (var number in input.Split('-'))
                {
                    numbers.Add(Convert.ToInt32(number));
                }

            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }
            if (includesDuplicates)
                Console.WriteLine("Duplicate");
        }

        static void ValidTime()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (ex: 19:00)");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
                Console.WriteLine("Invalid Time");

            var time = new List<int>();
            foreach (var number in input.Split(':'))
            {
                time.Add(Convert.ToInt32(number));
            }

            if ((time[0] >= 00 && time[0] <= 23) && ((time[1] >= 00 && time[1] <= 59)))
                Console.WriteLine("Valid Time");
            else
                Console.WriteLine("Invalid Time");
        }

        static void PascalCase()
        {
            Console.WriteLine("Enter a few words separated by a space.");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid, try again");
                return;
            }

            var output = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                output += wordWithPascalCase;
            }
            Console.WriteLine(output);
        }

        static void VowelCounter()
        {
            Console.WriteLine("Enter an English word");
            var input = Console.ReadLine().ToLower();
            var vowels = new List<char>(new char[]{'a','e','i','o','u'});
            var counter = 0;
            
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                    counter++;
            }

            Console.WriteLine(counter);
        }
    }
}