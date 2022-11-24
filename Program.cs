using Employeeattendance;

namespace Employee_Usercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Amazon", 10, 20, 100);
            empWageBuilder.addCompanyEmpWage("Tata", 15, 30, 50);
            empWageBuilder.computeEmpWage();
        }
    }
}





               
    
                
                
                
                
                   
                        
                    
    



