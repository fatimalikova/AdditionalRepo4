using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional4.Class
{
    public class Department
    {
        List<Employee> Employees = new List<Employee>();
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(!string.IsNullOrEmpty(value) || value.Length >= 2)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Department name must be at least 2 characters long and cannot be empty.");
                }
            }
        }


        private int _workerLimit;
        public int WorkerLimit
        {
            get
            {
                return _workerLimit;
            }
            set
            {
                if(value >= 1)
                {
                    _workerLimit = value;
                }
                else
                {
                    throw new Exception("Worker limit must be at least 1.");
                }
            }
        }


        private decimal _salaryLimit;
        public decimal SalaryLimit
        {
            get
            {
                return _salaryLimit;
            }
            set
            {
                if(value >= 250)
                {
                    _salaryLimit = value;
                }
                else
                {
                    throw new Exception("Salary limit must be at least 2500.");
                }
            }
        }


        public decimal CalcSalaryAverage()
        {
            if(Employees.Count == 0)
            {
                return 0;
            }
            decimal totalSalary = 0;
            foreach (var employee in Employees)
            {
                totalSalary += employee.Salary;
            }
            return totalSalary / Employees.Count;

        }
    }
}
