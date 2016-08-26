using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSVParser;
namespace CSVReaderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            bool isInValid = false;
            employees = CSVReader.getEmployees("sample.csv",out isInValid);

            int i = 1;

            foreach (Employee employee in employees)
            {
                Console.WriteLine("employee {0}:",i++);
                Console.WriteLine("name: {0}, birthday: {1:M/d/yyyy}, salary: {2}, hiredDate: {3:M/d/yyyy}", employee.EmployeeName, employee.Birthday, employee.Salary, employee.DateHired);
            }

            if (isInValid)
            {
                Console.WriteLine("This CSV file has invalid record, we could only show first {0} record", i-1);
            }

            Console.ReadLine();
        }
    }
}
