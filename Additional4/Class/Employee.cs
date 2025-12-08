using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional4.Class
{
    public class Employee
    {
        private static int employeeCount = 1000;

        public string Fullname { get; set; }
        public string DepartmentName { get; set; }
        public int No { get; set; }

        private string _position;
        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                if(value.Length >= 2 || !string.IsNullOrEmpty(value) )
                {
                    _position = value;
                }
                else
                {
                    throw new Exception("Position must be at least 2 characters long and cannot be empty.");
                }
            }
        }

        private decimal _salary;
        public decimal Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if(value >= 250)
                {
                    _salary = value;
                }
                else
                {
                    throw new Exception("Salary must be at least 2500.");
                }
            }
        }




    }
}
