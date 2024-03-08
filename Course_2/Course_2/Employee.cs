using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course_2
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }


        public Employee (int id, string name, double salary) 
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percetage)
        {
            Salary += Salary * percetage / 100.00;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
