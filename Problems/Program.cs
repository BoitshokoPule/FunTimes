using System;

namespace Problems
{
   public class Program
    {
        public string Prefix(string input)
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
            Program testing = new Program();
            Console.WriteLine(testing.Prefix("well"));
        }
    }
}
