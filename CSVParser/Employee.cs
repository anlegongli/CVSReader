using System;

namespace CSVParser
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateHired { get; set; }

        public Employee()
        {
        }

        public Employee(string employename, DateTime birthday, decimal salary, DateTime datehired)
        {
            this.EmployeeName = employename;
            this.Birthday = birthday;
            this.Salary = salary;
            this.DateHired = datehired;
        }
    }
}
