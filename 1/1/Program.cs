using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int FULL_TIME = 1;
            Random rnd = new Random();
            int check = rnd.Next(0, 2);
            if (check == FULL_TIME)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
        }
    }
}
