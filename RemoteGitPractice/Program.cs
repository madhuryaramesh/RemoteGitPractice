using System;

namespace RemoteGitPractice
{
    class Program
    {
        public const int isFulltime = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome UC1");
            //int empHrs = 0;
            //int empWage = 0;
            Console.WriteLine("UC1");
            Console.WriteLine("-------------------------------");
            Random rand = new Random();
            int empCheck = rand.Next(0, 2);
            if (empCheck == isFulltime)
            {
                Console.WriteLine("Employee is Present");
            }

            else
            {
                Console.WriteLine("Employee is Present");
            }

            Console.WriteLine("-------------------------------");
        }
    }
}
