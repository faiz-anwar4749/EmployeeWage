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
            int WorkingDays = 20;
            int EmpHours, EmpWage = 0;
            Random rand = new Random();
            for (int i = 0; i < WorkingDays; i++)
            {
                int check = rand.Next(0, 3);
                switch (check)
                {
                    case 2:
                        EmpHours = 8;
                        break;
                    case 1:
                        EmpHours = 4;
                        break;
                    default:
                        EmpHours = 0;
                        break;
                }
                EmpWage += EmpHours * EMP_WAGE_PER_HOUR;
            }
            Console.WriteLine("Employee Wage: " + EmpWage);
        }
    }
}
