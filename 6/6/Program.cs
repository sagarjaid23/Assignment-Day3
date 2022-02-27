using System;

namespace _6
{
    internal class Program
    {
        public const int PARTTIME = 1;
        public const int FULLTIME = 2;
        public const int RATEPERHR = 20;
        public const int WORKING_DAYS = 20;
        public const int MAX_HOUR_IN_MONTH = 100;
        static void Main(string[] args)
        {
            int empHrs = 0, totalEmpHrs = 0, totalworkingDays = 0;
            while (totalEmpHrs <= MAX_HOUR_IN_MONTH && totalworkingDays < WORKING_DAYS)
            {
                totalworkingDays++;
                Random rnd = new Random();
                int Check = rnd.Next(0, 3);
                switch (Check)
                {
                    case PARTTIME:
                        empHrs = 4;
                        break;
                    case FULLTIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = empHrs;
                Console.WriteLine("Days:" + WORKING_DAYS + "Hrs:" + empHrs);
            }
            int totalEmpWage = empHrs * RATEPERHR;
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);
        }
    }
}
