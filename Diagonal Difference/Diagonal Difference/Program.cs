using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Diagonal_Difference
{
    public static class Program
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            var right = 0;
            var left = 0;
            var result = 0;
            var rowCount = arr.Count - 1;
            var listCount = arr[0].Count;

            for (var j = 0; j < listCount; j++)
            {
                right += arr[j][j];
                left += arr[rowCount - j][j];
            }
            result = Math.Abs(right - left);
            return result;
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<int>> arr = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
            int result = Program.diagonalDifference(arr);
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
