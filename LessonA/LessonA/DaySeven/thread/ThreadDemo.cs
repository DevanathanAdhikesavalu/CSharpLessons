using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DaySeven.thread
{
    class ThreadDemo
    {
        public static void DemoCurrentTH()
        {
            Thread t1 = Thread.CurrentThread;
            int id = t1.ManagedThreadId;
            Console.WriteLine("ThreadID=" + id);
            Console.WriteLine("IsAlive" + t1.IsAlive);
            Console.WriteLine("Priority=" + t1.ThreadState);
            Console.WriteLine("ThreadState=" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new CultureInfo("fr-FR");
            Console.WriteLine("CurrentCulture:" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            t1.CurrentCulture = new CultureInfo("de-DE");
            Console.WriteLine("CurrentCulture:" + t1.CurrentCulture);
            Console.WriteLine(DateTime.Now.ToLongTimeString());

            /**
             *         CultureInfo tamilCulture = new CultureInfo("ta-IN");
        CultureInfo.CurrentCulture = tamilCulture;

        // Get the current date and time
        DateTime currentTime = DateTime.Now;

        // Format and print the date and time
        string formattedDateTime = currentTime.ToString("F");
        Console.WriteLine("Date and Time in Tamil: " + formattedDateTime);*/

        }
        public static void DemoA()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID" + id);
            ServiceA a1 = new ServiceA();
            a1.DoTaskA();
        }
        public static void DemoB()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);
            t1.Start();
            //a1.DoTaskA();
            Console.WriteLine("----------End of DemoB------");
        }
        public static void DemoB2()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);
            Console.WriteLine(t1.ManagedThreadId + " T1 State " + t1.ThreadState);
            t1.Start();
            Console.WriteLine(t1.ManagedThreadId + " State after Start " + t1.ThreadState);
            Thread.Sleep(3000);
            Console.WriteLine(t1.ManagedThreadId + " T1 State After Sleep " + t1.ThreadState);
            Console.WriteLine("----------End of DemoB2------");
        }
        public static void DemoC()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID " + id);
            ServiceA a1 = new ServiceA();
            Thread t1 = new Thread(a1.DoTaskA);
            t1.Start();
            a1.DoTaskB();
            Console.WriteLine("----------End of Democ------");
        }
        public static void DemoD()
        {
            Thread t = Thread.CurrentThread;
            int id = t.ManagedThreadId;
            Console.WriteLine("MainTh ID: " + id);
            ServiceA a1 = new ServiceA();
            ThreadStart ts = a1.DoTaskB;
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Start();
            t2.Start();

            t1.Join(2000);
            if (t1.IsAlive) t1.Abort();
            t2.Join(300);
            if (t2.IsAlive) t2.Abort();

            Console.WriteLine("-----------End of DemoD--------");
        }
    }
}
