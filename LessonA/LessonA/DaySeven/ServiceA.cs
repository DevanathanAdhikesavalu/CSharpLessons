using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DaySeven
{
    class ServiceA
    {
        public void DoTaskA()
        {
            //Monitor.Enter(this);//to lock the object
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("inside dotask");
            Console.WriteLine("\tthread id:" + id);
            int x = 0;
            //try
            //{
                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("\tId=" + id + ":x=" + x + "icount" + icount);
                    Thread.Sleep(1000);
                }
            //}
            //finally { Monitor.Exit(this); }//costly resorce enter in finally
        }
        public void DoTaskB()
        {
            int x = 0;
            Monitor.Enter(this);//to lock the object
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("inside dotask");
            Console.WriteLine("\tthread id:" + id);
            try
            {
                for (int icount = 0; icount <= 5; icount++)
                {
                    x += icount;
                    Console.WriteLine("\tId=" + id + ":x=" + x + "icount" + icount);
                    Thread.Sleep(1000);
                }
            }
            finally { Monitor.Exit(this); }//costly resorce enter in finally
        }
    }
}
