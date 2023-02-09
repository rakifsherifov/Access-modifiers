using System;
using System.Collections.Generic;
using System.Text;

namespace _08._02._2023
{
    internal class Employee
    {
        public string FullName;
        protected double _salary;
        private double _discountSalary;

        public double DiscountSalary
        {
            get
            {
                return _discountSalary;
            }
            set
            {
                if (value >= 300)
                    _discountSalary = value;
            }
        }



    }
}
