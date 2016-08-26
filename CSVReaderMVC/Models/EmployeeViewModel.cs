using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSVReaderMVC.Models
{
    public class EmployeeViewModel
    {
        public string EmployeeName { get; set; }
        public string Birthday { get; set; }
        public decimal Salary { get; set; }
        public string DateHired { get; set; }
    }
}