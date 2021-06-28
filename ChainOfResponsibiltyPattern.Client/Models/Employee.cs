using System.Collections.Generic;

namespace ChainOfResponsibiltyPattern.Client.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public int RequestdLeaves { get; set; }
    }

    public class EmployeeLeaveRequestRepo
    {
        public static List<Employee> GetEmployeeLeaveRequest()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Name = "Vishnu",
                    RequestdLeaves = 4
                },
                new Employee
                {
                    Name = "Annapoorani",
                    RequestdLeaves = 100
                },
                new Employee
                {
                    Name = "Vinoth",
                    RequestdLeaves = 15
                },
                new Employee
                {
                    Name = "Abhishek",
                    RequestdLeaves = 10
                },
                new Employee
                {
                    Name = "Haja",
                    RequestdLeaves = 38
                },
            };
            return employees;
        }
    }
}
