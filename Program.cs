﻿namespace Employeeattendance
{
    internal class Program
    {
        
        const int Emp_Rate_Per_Hour = 500;
        static void Main(string[] args)
        {
            const  int PartTime = 1;
            const int FullTime = 2; 
            int empHours = 0;
            int empWage = 0;
            Random random = new Random(); 
            int Empcheck = random.Next(0,3);
            switch (Empcheck)
            {
                case PartTime:
                    empHours = 4;
                    Console.WriteLine("Employee is Part-Time");
                    break;
                    case FullTime:
                    empHours = 8;
                    Console.WriteLine("Employee is Full-Time");
                    break;
                    default:
                    empHours = 0;
                    Console.WriteLine("Employee is Absent");    
                    break;

            }
            empWage = empHours * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage is :" + empWage);
            
           
        }
    }
}