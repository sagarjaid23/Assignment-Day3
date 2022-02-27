using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FULLTIME = 1;
            int PARTTIME = 2;
            int EMP_RATE_PER_HR = 20;
            int NUM_WORKING_DAYS = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int Check = random.Next(0, 3);
            if (Check == FULLTIME)
            {
                empHrs = 8;
            }
            else if (Check == PARTTIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR * NUM_WORKING_DAYS;
            Console.WriteLine("Employee Monthly Wage is:" + empWage);
        }
    }
}
