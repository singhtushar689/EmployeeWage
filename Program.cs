namespace Employeeattendance
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
                    break;
                case FullTime:
                    empHours = 8;
                    break;
                    default:
                    empHours = 0;
                    break;

            }
            empWage = empHours * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage is :" + empWage);
            
           
        }
    }
}