using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSVParser;
using CSVReaderMVC.Models;

namespace CSVReaderMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public List<EmployeeViewModel> getEmployees()
        {
            List<EmployeeViewModel> employeesViewModel = new List<EmployeeViewModel>();
            List<Employee> employees = new List<Employee>();
            bool isInValid = false;
            employees = CSVReader.getEmployees(Server.MapPath("sample1.csv"), out isInValid);
            int i = 0;
            

            foreach (Employee employee in employees)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.EmployeeName = employee.EmployeeName;
                employeeViewModel.Birthday = employee.Birthday.ToShortDateString();
                employeeViewModel.Salary = employee.Salary;

                employeeViewModel.DateHired = employee.DateHired.ToShortDateString();

                employeesViewModel.Add(employeeViewModel);
                i++;
            }
            if (isInValid)
            {
                ViewBag.Message = string.Format("This CSV file has invalid record, we could only show first {0} record", i);
            }
            else
            {
                ViewBag.Message = null;
            }
            return employeesViewModel;
        }

        public ActionResult Index()
        {
            List<EmployeeViewModel> employees = new List<EmployeeViewModel>();
            employees = getEmployees();
            return View(employees);
        }

    }
}
