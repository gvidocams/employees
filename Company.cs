using System;
using EmployeeExceptions;
using System.Collections.Generic;
using System.Linq;

namespace IfEmployee
{
    public class Company : ICompany
    {
        public string Name { get; }

        public Employee[] Employees 
        { 
            get => _employeeList.ToArray(); 
        }

        private List<Employee> _employeeList;

        private List<Contract> _contractList;

        public Company(string name, List<Employee> employees, List<Contract> contracts)
        {
            Name = name;
            _employeeList = employees;
            _contractList = contracts;
        }

        public void AddEmployee(Employee employee, DateTime contractStartDate)
        {
            if (_employeeList.FirstOrDefault(e => e.Id == employee.Id) != null)
            {
                throw new DuplicateIdException(employee.Id);
            }

            _employeeList.Add(employee);
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
