using System;

namespace Problems
{
   public class Program
    {
         string Prefix(string input)
        {
            if (input.Equals(null))
            {
                return null;
            }
            int length = input.Length;
            string[] arrayOfWords = input.Split(' ');
            int numOfWords = arrayOfWords.Length;
            string output = $"{length},{numOfWords}: {input}";
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
