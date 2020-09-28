using System;

namespace master
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_WAGE_PER_HOUR = 20;
            int EmpHours, EmpWage;
            Random rand = new Random();
            int check = rand.Next(0, 3);
            if (check == IS_FULL_TIME)
            {
                EmpHours = 8;
            }
            else if (check == IS_PART_TIME)
            {
                EmpHours = 4;
            }
            else
                EmpHours = 0;
            EmpWage = EmpHours * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Employee Wages: " + EmpWage);
        }
    }
}
