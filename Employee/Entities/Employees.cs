using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace Employee.Entities
{
    class Employees
    {
        List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee p)
        {
            employees.Add(p);
        }

        public int getEmployee()
        {
            return employees.Count;
        }
        
        public void GetEmployeeBySalary(double salary)
        {
            var n1 = employees.Where(p => p.Salary > salary).OrderBy(p => p.Email);
            foreach (Employee e in n1)
            {
                Console.WriteLine(e.Email);
            }
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (Employee p in employees)
            {
                str.Append("Name: ");
                str.Append(p.Name + " ");
                str.Append("E-mail: ");
                str.Append(p.Email);
                str.Append("Salary: ");
                str.AppendLine(p.Salary + " ");
            }
            return str.ToString();
        }
    }
}
