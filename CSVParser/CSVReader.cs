using System;
using System.Collections.Generic;
using System.IO;

namespace CSVParser
{
    public class CSVReader
    {
        public static List<Employee> getEmployees(string sPath, out bool isInvalid)
        {
            List<Employee> employees = new List<Employee>();
            StreamReader reader = new StreamReader(sPath);

            string record = reader.ReadLine();

            record = reader.ReadLine();

            isInvalid = false;

            string employeeName;
            decimal salary;
            DateTime birthday;
            DateTime dateHired;

            while (!string.IsNullOrEmpty(record) && !isInvalid)
            {
                string[] sTempData = record.Split(',');

                if (string.IsNullOrEmpty(sTempData[0]) || string.IsNullOrEmpty(sTempData[1]) || string.IsNullOrEmpty(sTempData[2]) || string.IsNullOrEmpty(sTempData[3]))
                {
                    isInvalid = true;
                }

                if (!isInvalid)
                {
                    try
                    {
                        salary = decimal.Parse(sTempData[2]);                                               
                        employeeName = sTempData[0].Replace("\"", "");                         
                        birthday = DateTime.Parse(sTempData[1]);
                        dateHired = DateTime.Parse(sTempData[3]);

                        if (salary > 0)
                        {
                            Employee employee = new Employee(employeeName, birthday, salary, dateHired);
                            employees.Add(employee);
                        }
                        else
                        {
                            isInvalid = true;
                        }
                        
                    }
                    catch (Exception)
                    {
                        isInvalid = true;
                    }

                }
                record = reader.ReadLine();

            }
                return employees;
        }
    }
}
