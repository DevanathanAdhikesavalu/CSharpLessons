using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayFive
{
    class Emp
    {
        private readonly double Id;

        public string Name=string.Empty;
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Emp() { }
        public Emp(double v1)
        {
            Id = v1;
        }
        public double GetID()
        {
            return Id;
        }
    }
}
