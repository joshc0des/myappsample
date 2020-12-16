using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a few numbers separated by hyphens: ");
            var rawText = Console.ReadLine();

            string[] numberStrings = rawText.Split('-');
            int[] numberInts = Array.ConvertAll(numberStrings, int.Parse);

            for (var i = 0; i < numberInts.Length; i++)
            {
                if (i == numberInts.Length - 1)
                {
                    Console.WriteLine("Consecutive");
                }
                else if (numberInts[i+1] >= numberInts[i])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Not Consecutive");
                    break;
                }
            }
        }
    }
}
