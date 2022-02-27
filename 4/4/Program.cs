using System;

namespace _4
{
    internal class Program
    {
        public const int FULLTIME = 1;
        public const int PARTTIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        static void Main(string[] args)
        {

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int Check = random.Next(0, 3);
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
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage is:" + empWage);
        }
    }
}
