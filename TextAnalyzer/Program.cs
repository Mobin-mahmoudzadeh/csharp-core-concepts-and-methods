using System;

namespace TextAnalyzer
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== Text Analyzer ===");
            Console.Write("Please enter text to analyze: ");
            
            string text = Console.ReadLine(); 
            
            Console.WriteLine("\n------------------- Result -------------------");
            Console.WriteLine("The length of the string (without spaces) is: " + text.Replace(" ", "").Length);
            Console.WriteLine("Upper Case: " + text.ToUpper());
            Console.WriteLine("Lower Case: " + text.ToLower());
            
            bool hasCSharp = text.Contains("C#");
            Console.WriteLine("Does it contain 'C#'? " + hasCSharp);
            Console.WriteLine("----------------------------------------------");
        }
    }
}