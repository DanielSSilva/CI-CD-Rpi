using System;

namespace CI_CD_tests_PI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"CPU architecture = {System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")}");
        }
    }
}
