using System;
using System.Linq;

namespace GC_Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create array
            int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };
            
            // Print array
            Console.WriteLine("[{0}]", String.Join(", ", nums));
            Console.WriteLine();

            // Find min value
            int minResult = nums.Min();
            Console.WriteLine("Minimum value:\n> {0}", minResult);
            Console.WriteLine();

            // Find max value
            int maxResult = nums.Max();
            Console.WriteLine("Maximum value:\n> {0}", maxResult);
            Console.WriteLine();

            // Find max below 10000
            var maxWithinRange = nums.Where(x => x < 10000).ToArray();
            var maxLessThan = maxWithinRange.Max();
            Console.WriteLine($"Maximum value below 10000:\n> {maxLessThan}");
            Console.WriteLine();

            // Find values between 10 and 100
            var numRange1 = nums.Where((x) => (x > 10) && (x < 100)).ToArray();
            var sortedNumRange1 = numRange1.OrderBy((x) => x);
            var descendingSortedNumRange1 = numRange1.OrderByDescending((x) => x).ToList();
            Console.WriteLine("Values between 10 and 100:");
            descendingSortedNumRange1.ForEach(x => Console.WriteLine($"> {x}"));
            Console.WriteLine();

            // Find values between 100000 and 999999
            var numRange2 = nums.Where((x) => (x > 100000) && (x < 999999)).ToArray();
            var sortedNumRange2 = numRange2.OrderBy((x) => x);
            var descendingSortedNumRange2 = numRange2.OrderByDescending((x) => x).ToList();
            Console.WriteLine("Values between 100000 and 999999:");
            descendingSortedNumRange2.ForEach(x => Console.WriteLine($"> {x}"));
            Console.WriteLine();

            // Count even numbers in array
            var evenNums = nums.Count(x => x % 2 == 0);
            Console.WriteLine("Count of even values:\n> {0}", evenNums);
            
        }
    }
}
