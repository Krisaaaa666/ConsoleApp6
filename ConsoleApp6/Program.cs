﻿         using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "B80X2412B80X3412B80X3412B80X3482B80X3412B80X4412B80X4432B80X4512B80X4712B80X4765B80X3412B80X5310B80X5342B80X5467B80X4582B80X5672B80X6012B80X6754B80X6890B80X6999B80X7865B80X7943B80X7999B80X8136B80X8355B80X8888B80X6789B80X11234B80X18694B80X111111";
            string[] words = SplitText(input);
            PrintWords(words);
        }

        static string[] SplitText(string text)
        {
            string[] words = text.Split(new char[] { 'B' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        static void PrintWords(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine("B" + word);
            }
            Console.ReadKey();
        }
    }
}
    
