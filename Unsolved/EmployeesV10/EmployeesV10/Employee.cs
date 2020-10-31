﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesV10
{
    public class Employee
    {
        private string _name;
        private int _hoursPerWeek;

        public Employee(string name, int hoursPerWeek)
        {
            _name = name;
            _hoursPerWeek = hoursPerWeek;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HoursPerWeek
        {
            get { return _hoursPerWeek; }
            set { _hoursPerWeek = value; }
        }
    }
}
