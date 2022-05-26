using System;
using System.IO;

namespace Recursive_Digit_Sum
{
    public static class Program
    {
        public static int superDigit (string n, int k)
        {
            Console.WriteLine ($"{k} => {n}");
            if (n.Length == 1)
            {
                return int.Parse (n);
            }

            var sum = 0L;
            for (var index = 0; index < n.Length; index++)
            {
                sum += int.Parse(n.Substring (index, 1));
            }

            return superDigit((sum * k).ToString(), 1);
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            string[] nk = Console.ReadLine().Split(' ');
            string n = nk[0];
            int k = Convert.ToInt32(nk[1]);
            int result = superDigit(n, k);
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
