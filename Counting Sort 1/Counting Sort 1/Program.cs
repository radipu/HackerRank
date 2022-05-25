using System;
using System.Linq;

namespace Counting_Sort_1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            int[] res = new int[100];
            foreach (int i in Console.ReadLine().Trim().Split(' ').Select(int.Parse))
            {
                res[i]++;
            }

            foreach (int r in res)
            {
                Console.Write("{0} ", r);
            }
        }
    }
}
