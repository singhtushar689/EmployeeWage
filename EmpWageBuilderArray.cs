using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeeattendance
{
    internal class EmpWageBuilderArray
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] CompanyEmpWagesArray;

        public EmpWageBuilderArray()
        {
            this.CompanyEmpWagesArray = new CompanyEmpWage[5];

        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWagesArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                CompanyEmpWagesArray[i].setTotalEmpWage(this.computeEmpWage(this.CompanyEmpWagesArray[i]));
                Console.WriteLine(this.CompanyEmpWagesArray[i].toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage CompanyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= CompanyEmpWage.maxHoursPerMonth && totalWorkingDays < CompanyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs : " + empHrs);

            }
            return totalEmpHrs * CompanyEmpWage.empRatePerHour;

        }
    }
}

