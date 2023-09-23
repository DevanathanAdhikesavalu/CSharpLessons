using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayFour
{
    public enum City { Chennai,Bangalore,Hydrabad,Pune}

    public enum Designation { Manager,Admin,Developer}
    class Employee
    {
        public readonly int Eid = 0;
        public string EName = String.Empty;
        public City ECity ;
        public Designation JobTitle;

        public Employee(int v1) 
        {
            Eid = v1;
        }
        public override string ToString()
        {
            String output = String.Empty;
            output = $"Details of a Employee are : ID{Eid} {EName} {ECity} {JobTitle}";
            return output ;
        }
    }
    class TestEmployee
    {
        public static void TestOne()
        {
            Employee emp = new Employee(567);
            emp.EName = "Deva";
            emp.ECity = City.Bangalore;  //Ecity ="Chennai"
            emp.JobTitle = Designation.Developer;  //JobTitlt = "Tester"
            String output = emp.ToString();
            Console.WriteLine(output);

        }
    }
}
