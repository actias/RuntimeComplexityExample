using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RuntimeComplexityExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello there. This little app will compar two functions speed to count the pairs of numbers that add up to a given number");

            while (true)
            {
                Console.WriteLine("How big would you like the array (0 to n)?");

                var input = Console.ReadLine();

                int arraySize;
                int numberToFind;

                if (!int.TryParse(input, out arraySize))
                    Console.WriteLine("No...just...no...");

                Console.WriteLine("Cool, now what number would you like to look for?");

                input = Console.ReadLine();

                if (!int.TryParse(input, out numberToFind))
                    Console.WriteLine("No...just...no...");

                Console.WriteLine("Alright! Let's do this thing! Hit Enter to get this party started.");
                Console.ReadLine();

                var array = Enumerable.Range(0, arraySize).ToArray();

                Console.WriteLine("Testing CountPairs (the original function)...");

                var sw = Stopwatch.StartNew();

                var pairs = PairCounter.CountPairs(array, numberToFind);

                sw.Stop();

                Console.WriteLine("Number of Pairs: {0}", pairs);
                Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);

                Console.WriteLine("Testing CountPairs1 (the new function)...");

                sw = Stopwatch.StartNew();

                pairs = PairCounter.CountPairsNew(array, numberToFind);

                sw.Stop();

                Console.WriteLine("Number of Pairs: {0}", pairs);
                Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);


                Console.WriteLine("Fun times right? Test again?");

                if (Console.ReadLine().ToLower().StartsWith("y")) continue;

                break;
            }
        }
    }
}
