using System;

namespace classEmploeesAndCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.setCompanyName("K,I,D");
            emp.setNameOfEmployee("Tom");
            emp.setLastNameOfEmployee("Pion");
            emp.setAge(27);
            emp.setHowManyExperience(7);
            emp.setSalary(300);
            emp.setCurrency('$');
            Console.WriteLine(emp.getCompanyNames() + "  " + emp.getNameOfEmploee() + " " + emp.getLameOfEmploee() + "  " + emp.getSalary()+emp.getCurrency());
            emp.recruit(emp.getHowManyExperience());
            emp.promotion(emp.getHowManyExperience());
            
        }
    }
}
