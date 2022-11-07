using System;
using System.Collections.Generic;
using System.Text;

namespace classEmploeesAndCompany
{
    class Company
    {
        private String companyNames;
        private int howManyExperience;
        private int salary;
        private char currency;
        public int rise1 = 2;
        public void setCompanyName(String companyNames)
        {
            this.companyNames = companyNames;
        }
        public String getCompanyNames()
        {
            return companyNames;
        }
        public void setHowManyExperience(int howManyExperience)
        {
            this.howManyExperience = howManyExperience;
        }
        public int getHowManyExperience()
        {
            return howManyExperience;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public int getSalary()
        {
            return salary;
        }
        public void setCurrency(char currency)
        {
            this.currency=currency;
        }
        public char getCurrency()
        {
            return currency;
        }

        public void recruit(int howManyExperience)
        {
            if (howManyExperience < 1)
            {
                Console.WriteLine("Sorry for you refusal");
            }
            else
            {
                Console.WriteLine("We decide you accepted");
            }
        }
        public void promotion(int howManyEperience)
        {
            if (howManyExperience >= 3)
            {
                salary=salary*2;
                Console.WriteLine(salary);

               
            }
            else
            {
                Console.WriteLine("Sorry you don't get a rise");
            }
        }

    }
}
