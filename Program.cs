namespace Employeeattendance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Employees");
            int EmployeeIsPresent = 1; 
            Random random = new Random();   
          int EmployeeInput = random.Next(0,2);
            if (EmployeeInput == EmployeeIsPresent) 
            Console.WriteLine("Employee is Present");
            else
            Console.WriteLine("Employee is Absent");
        }
    }
}