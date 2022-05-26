using System;

namespace New_Year_Chaos
{
    public static class Program
    {
        public static void minimumBribes(int[] q)
        {
            int ans = 0;
            for (var i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] - (i+1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }

                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i])
                        ans++;
                }
            }
            Console.WriteLine(ans);
        }
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                minimumBribes(q);
            }
        }
    }
}
