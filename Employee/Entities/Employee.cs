using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Entities
{
    class Employee
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            this.Name = name;
            Email = email;
            Salary = salary;
        }

        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   Name == employee.Name &&
                   Email == employee.Email &&
                   Salary == employee.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Email, Salary);
        }
    }
}
