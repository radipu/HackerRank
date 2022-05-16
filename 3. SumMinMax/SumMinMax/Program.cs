using System;
using System.Collections.Generic;
using System.Linq;

namespace SumMinMax
{    
    public class Solution
    {
        public class Result
        {
            public static void minMaxSum(int[] arr)
            {
                Array.Sort(arr);
                long min = arr.Take(4).Sum(item => (long)item);
                long max = arr.Skip(1).Sum(item => (long)item);
                Console.WriteLine($"{min} {max}");
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrtemp => Convert.ToInt32(arrtemp));
            Result.minMaxSum(arr);
        }
    }
}
