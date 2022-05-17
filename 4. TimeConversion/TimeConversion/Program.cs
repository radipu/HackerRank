using System;
using System.IO;

namespace TimeConversion
{
    public class Program
    {
        static string timeConversion(string s)
        {
            bool conversion = DateTime.TryParse(s, out DateTime time);
            if (conversion)
            {
                return time.ToString("HH:mm:ss");
            }

            return "time conversion is done";
        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            string s = Console.ReadLine();
            string result = Program.timeConversion(s);
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }
    }
}
