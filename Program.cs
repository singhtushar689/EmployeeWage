namespace Employee_Usercase
{
    internal class Program
    {

        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 400;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HOURS = 200;

        static void Main(string[] args)

        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;

            while (empHrs <= MAX_HOURS && totalWorkingDays <= NUM_OF_WORKING_DAYS)
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

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Wage is :" + empWage);
                Console.WriteLine("Total Monthly Wage is :" + totalEmpWage);
            }
        }
    }
}    
                






               
    
                
                
                
                
                   
                        
                    
    



