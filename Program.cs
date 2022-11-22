using Employeeattendance;

namespace Employee_Usercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("Amazon", 20, 20, 100);
            EmpWageBuilderObject jio = new EmpWageBuilderObject("Tata", 15, 20, 50);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            jio.computeEmpWage();
            Console.WriteLine(jio.toString());
        }
    }
}





               
    
                
                
                
                
                   
                        
                    
    



