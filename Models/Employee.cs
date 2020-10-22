using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Employee
    {
        public long EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string MailID { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public Nullable<long> Phone { get; set; }
        public string Address { get; set; }
        public Nullable<long> Salary { get; set; }
        public Nullable<int> Age { get; set; }

    }
}
