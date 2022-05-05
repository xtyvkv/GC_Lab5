using System;
using System.Linq;

namespace GC_Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

            // Find min value
            int minResult = nums.Min();
            Console.WriteLine("Minimum Value: {0}", minResult);

            // Find max value
            int maxResult = nums.Max();
            Console.WriteLine("Maximum Value: {0}", maxResult);

            // Find max below 10000
            var maxWithinRange = nums.Where(x => x < 10000).ToArray();
            var maxLessThan = maxWithinRange.Max();
            Console.WriteLine($"Maximum Value below 10000: {maxLessThan}");

            // BELOW IS NOT COMPLETE

            // Find values between 10 and 100
            var betweensies = nums.Where((x) => (x > 10) && (x < 100)).ToArray();
            var sortedBetweensies = betweensies.OrderBy((x) => x);
            var descendingSortedBetweensies = betweensies.OrderByDescending((x) => x).ToList();
            Console.WriteLine("Values between 10 and 100:");
            descendingSortedBetweensies.ForEach(x => Console.WriteLine(x));

            // Find values between 100000 and 999999
            var coolBetween = nums.Where((x) => (x > 100000) && (x < 999999)).ToArray();
            var sortedCoolBetween = coolBetween.OrderBy((x) => x);
            var descendingSortedCoolBetween = coolBetween.OrderByDescending((x) => x).ToList();
            Console.WriteLine("Values between 100000 and 999999:");
            descendingSortedCoolBetween.ForEach(x => Console.WriteLine(x));
            
        }
    }
}
