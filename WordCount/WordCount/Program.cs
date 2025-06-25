using System;

namespace WordCountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = args?.Length > 0 ? args[0] : "./WordCount.Texts/poe-fall-of-the-house-of-usher.txt";
            Console.WriteLine(Utilities.WordCount(filePath));
        }
    }
}


