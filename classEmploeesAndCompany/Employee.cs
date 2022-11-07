using System;
using System.Collections.Generic;
using System.Text;

namespace classEmploeesAndCompany
{
    class Employee : Company
    {
        private String EmployeesName;
        private String lastNameOfEmployee;
        private int age;
       

        public void setNameOfEmployee(String EmployeesName)
        {
            this.EmployeesName=EmployeesName;
        }
        public String getNameOfEmploee()
        {
            return EmployeesName;
        }
        public void setLastNameOfEmployee(String lastNameOfEmployee)
        {
            this.lastNameOfEmployee =lastNameOfEmployee;
        }
        public String getLameOfEmploee()
        {
            return lastNameOfEmployee;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
       


    }
}
