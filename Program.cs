using Employeeattendance;

namespace Employee_Usercase
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("Amazon", 10, 20, 100);
            EmpWageBuilderObject Jio = new EmpWageBuilderObject("Tata", 15, 30, 50);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.ToString());
            Jio.computeEmpWage();
            Console.WriteLine(Jio.ToString());
        }
    }
}





               
    
                
                
                
                
                   
                        
                    
    



