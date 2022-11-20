namespace Employee_Usercase
{
    internal class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 400;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HOURS = 200;

        public static int computeEmpWage()
        {
            int empHrs ;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= MAX_HOURS && totalWorkingDays <= NUM_OF_WORKING_DAYS)
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
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("total Wage :" + totalEmpWage);
            return totalEmpWage;
        }
          static void Main(String[] args)
          {
            compute empWage();
          }
    }      
}    
                                                                                                                                                                                                     






               
    
                
                
                
                
                   
                        
                    
    



