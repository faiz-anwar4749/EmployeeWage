using System;

namespace master
{
    class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 2;
            Random rand = new Random();

            int EmployeeCheck = rand.Next(1, 3);
            if (EmployeeCheck == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
