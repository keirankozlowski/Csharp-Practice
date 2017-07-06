using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestWord();
        }


        //Write a program that reads a text file and displays the number of words.
        static void WordCount()
        { 
            var path = @"C:\Users\kkozlowski\Downloads\exerciseFile.txt";            
            var text = File.ReadAllText(path);
            var textCount = new List<string>(text.Split());
            var wordCount = 0;

            foreach (var word in textCount)
            {
                wordCount++;
            }

            Console.WriteLine(wordCount);
        }


        //Write a program that reads a text file and displays the longest word in the file.
        static void LongestWord()
        {
            var path = @"C:\Users\kkozlowski\Downloads\exerciseFile.txt";
            var text = File.ReadAllText(path);
            var textCount = new List<string>(text.Split(' '));
            string longestWord;

            if (String.IsNullOrEmpty(text))
                Console.WriteLine("Empty file");

            foreach (var word in textCount)
            {
                var wordLength = 0;   
                if (word.Length > wordLength)
                    longestWord = word;
                    wordLength = word.Length;
                    for (int i = 0; i < 1; i++)
                    {
                        Console.WriteLine("Longest word: " + longestWord);
                    }
             }
        }
    }
}