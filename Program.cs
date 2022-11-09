namespace Employeeattendance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int PartTime = 1;
            const int FullTime = 2;
            const int Rate_Per_Hour = 200;
            int empHours = 0;
            int empWage = 0;
            Random random = new Random();   
            int EmpCheck = random.Next(0,3);
            if (EmpCheck == PartTime)
            {
                empHours = 4;
            }
            else if (EmpCheck == FullTime)
            {
                empHours = 8;
            }
            else 
            {
                empHours = 0;
            }
            empWage = empHours * Rate_Per_Hour;
            Console.WriteLine("Emp Wage is :" + empWage);
        }
    }
}