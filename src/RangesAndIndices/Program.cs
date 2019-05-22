using System;
using System.Collections.Generic;

namespace RangesAndIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Index x = 3;       // number 3 from beginning
            Index y = ^4;      // number 4 from end
            Console.WriteLine($"index results: {a[x]}, {a[y]}");

            var slice = a[x..y];
            Console.WriteLine($"range slice results: {string.Join(",", slice)}");

            var rangeAll = a[..];
            Console.WriteLine($"range all results: {string.Join(",", rangeAll)}");

            var last = ^1; // simpler compared to using arr.Length - 1 to access the last item
            var rangeToLast = a[..last];
            Console.WriteLine($"range first to last results: {string.Join(",", rangeToLast)}");

            Console.ReadKey();
        }
    }
}
