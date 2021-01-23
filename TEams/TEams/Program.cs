using System;
using System.Collections.Generic;

namespace TEams
{
    class Program
    {
        //Create a memeber variable in the Program class called departments to hold a List<Department>.
        //Declare it static so it can be accessed in the static methods in Program.cs.

        public static List<Department> departments= new List<Department> ();

        public static List<Employee> employees = new List<Employee>();
        static void Main(string[] args)
        {
            // create some departments

            CreateDepartments();
            
            // print each department by name
            PrintDepartments();

            // create employees
            CreateEmployees();
            

            // give Angie a 10% raise, she is doing a great job!


            // print all employees
            PrintEmployees();

            // create the TEams project
            CreateTeamsProject();

            // create the Marketing Landing Page Project
            CreateLandingPageProject();

            // print each project name and the total number of employees on the project
            PrintProjectsReport();
        }

        /**
         * Create departments and add them to the collection of departments
         */
        private static void CreateDepartments()
        {
            // 001 Marketing
            //002 Sales
            // 003 Engineering

            Department departmentMarketing = new Department(001, "Marketing");
            Department departmentSales = new Department(002, "Sales");
            Department departmentEngineering = new Department(003, "Enginnering");
            
            departments.Add(departmentMarketing);
            departments.Add(departmentSales);
            departments.Add(departmentEngineering);


        }

        /**
         * Print out each department in the collection.
         */
        private static void PrintDepartments()
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");
            foreach (Department departmentPrint in departments)
            {
                Console.WriteLine(departmentPrint.Name);
            }
        }

        /**
         * Create employees and add them to the collection of employees
         */
        private static void CreateEmployees()
        {
            //Dean Johnson: Create this employee using the no-argument constructor and set each property individually.
            Employee employee001 = new Employee(001, "Dean", "Johnson", "djohnson@teams.com", departments[2], "08/21/2020");
            //Angie Smith: Create this employee using the all-argument constructor.
            Employee employee002 = new Employee(002, "Angie", "Smith", "asmith@teams.com", departments[2], "08/21/2020");
            //Margaret Thompson: Create this employee using the all-argument constructor.
            Employee employee003 = new Employee(003, "Margaret", "Thompson", "mthompson@teams.com", departments[0], "08/21/2020");
           
            employees.Add(employee001);
            employees.Add(employee002);
            employees.Add(employee003);

            employee002.RaiseSalary(10);
            

        }
        
        
        /**
         * Print out each employee in the collection.
         */
        private static void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");
            foreach (Employee printEmployeeInfo in employees)
            {
                Console.WriteLine(printEmployeeInfo.FullName +" "+"("+ printEmployeeInfo.Salary+")" + " " + printEmployeeInfo.Department.Name);
            }

        }

        /**
         * Create the 'TEams' project.
         */
        private static void CreateTeamsProject()
        {

        }

        /**
         * Create the 'Marketing Landing Page' project.
         */
        private static void CreateLandingPageProject()
        {

        }

        /**
         * Print out each project in the collection.
         */
        private static void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");

        }
    }
}
