namespace Employee_Usercase
{
    internal class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;  

        public static int computeEmpWage(string company , int empRatePerHour , int numOfWorkingDays , int maxHoursPerMonth)
        {
            int empHrs ;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= maxHoursPerMonth&& totalWorkingDays <= numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + "Emp Hours :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("total Wage :" + totalEmpWage);
            return totalEmpWage;
        }
          static void Main(String[] args)
          {
            computeEmpWage("Amazon", 20 , 20 ,300 );
            computeEmpWage("Nike", 100, 25, 500 );
          }
    }      
}    
                                                                                                                                                                                                     






               
    
                
                
                
                
                   
                        
                    
    



