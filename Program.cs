using System;

namespace master
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int EMP_WAGE_PER_HOUR = 20;

            int EmpHours = 0;
            int EmpWage = 0;
            Random rand = new Random();

            int empCheck = rand.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                EmpHours = 8;
            }
            else
            {
                EmpHours = 0;
            }
            EmpWage = EmpHours * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Employee Wage is: " + EmpWage);
        }
    }
}
