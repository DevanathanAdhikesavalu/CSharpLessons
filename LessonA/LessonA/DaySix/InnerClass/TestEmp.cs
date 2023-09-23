using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DaySix.InnerClass
{
    class OuterClass
    {
        public int Eno = 0;
        private readonly InnerClass address;

        public OuterClass()
        {
            address = new InnerClass(this);
        }
        public InnerClass GetAddress()
        {
            return address;
        }
        public class InnerClass
        {
            public string Address1;
            public string Address2;
            private readonly OuterClass e1;

            internal InnerClass(OuterClass outerEmp)
            {
                if(outerEmp==null)
                    throw new NullReferenceException("Outer class a Null!! so object instanciated ");
                e1 = outerEmp;
            }
            public override String ToString()
            {
                return Address1+","+Address2+"of  : "+e1.Eno;
            }
        }

    }
    class TestEmp
    {
        public static void TestA()
        {
            try
            {
                OuterClass.InnerClass address = new OuterClass.InnerClass(null);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            OuterClass e1 = new OuterClass();
            //Inner class object
            OuterClass.InnerClass add = e1.GetAddress();
            add.Address1 = "Ambattur";
            add.Address2 = "Chennai";
            Console.WriteLine($"Address1:{add.Address1}");
            Console.WriteLine($"Address2:{add.Address2}");
            Console.WriteLine(add.ToString());
        }
    }
}
