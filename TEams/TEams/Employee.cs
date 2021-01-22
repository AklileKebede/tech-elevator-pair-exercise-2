using System;
using System.Collections.Generic;
using System.Text;

namespace TEams
{
    class Employee
    {
        public long EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; } = 60000.0;
        public Department Department { get; set; }
        public string HireDate { get; set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + this.FirstName;
            }
        }
        public Employee(long employeeId, string firstName, string lastName, string email, Department department, string hireDate)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Department = department;
            this.HireDate = hireDate;
        }
        public Employee() { }

        public double RaiseSalary()
        {
            // salary = salary + (raiseSalary * percent to raise)
            double raisePercent = 0;

            this.Salary = this.Salary + (this.Salary * raisePercent / 100);

            return this.Salary;
        }

    }
}
