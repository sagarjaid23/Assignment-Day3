﻿using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FULLTIME = 1;
            int EMP_RATE_PER_HR = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int Check = random.Next(0, 2);
            if (Check == FULLTIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage is:" + empWage);
        }
    }
    
}
