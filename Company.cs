using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfEmployee
{
    public class Company : ICompany
    {
        public string Name => throw new NotImplementedException();

        public Employee[] Employees => throw new NotImplementedException();

        public void AddEmployee(Employee employee, DateTime contractStartDate)
        {
            throw new NotImplementedException();
        }

        public EmployeeMonthlyReport[] GetMonthlyReport(DateTime periodStartDate, DateTime periodEndDate)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(int employeeId, DateTime contractEndDate)
        {
            throw new NotImplementedException();
        }

        public void ReportHours(int employeeId, DateTime dateAndTime, int hours, int minutes)
        {
            throw new NotImplementedException();
        }
    }
}
