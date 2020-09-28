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
            EmpWage = EmpHours * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Employee Wages: " + EmpWage);
        }
    }
}
