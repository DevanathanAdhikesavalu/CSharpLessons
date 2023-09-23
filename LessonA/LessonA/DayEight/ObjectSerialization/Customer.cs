using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayEight.ObjectSerialization
{
    [Serializable]
    class Customer 
    {
        private readonly double Id;
        public string Title = String.Empty;
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string MiddleName { get; set; } = String.Empty;
        public double CreditLimit { get; set; }
        public Customer(double v1) { Id = v1; }
        public double GetID()
        {
            return Id;
        }
        public override string ToString()
        {
            return $"Details:{Id}{FirstName}{MiddleName}{LastName}{CreditLimit}";
        }
    }
}
