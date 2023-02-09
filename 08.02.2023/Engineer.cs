using System;
using System.Collections.Generic;
using System.Text;

namespace _08._02._2023
{
    internal class Engineer: Employee
    //Engineer obyektinin salary dəyəri 1000 -dən aşağı ola bilməz
    {
        public double CountSalary;

        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 1000)
                {
                    _salary = value;
                }
            }
        }
    }
}
