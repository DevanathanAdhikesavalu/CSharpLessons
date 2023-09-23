using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAConsoleApp.DayThree
{
    internal interface IMessageService
    {
        void SendMessage(string message);
        void SendAudioMessage(string message);
        void SendVideoMessage(string message);
        void ReceiveMessage();
        void DeleteMessage();
    }
    public interface IPayments
    {
        void Makepayment(float amount);
    }
    internal  class Whatsapp : IMessageService,IPayments
    {
        public void DeleteMessage()
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void SendAudioMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void SendVideoMessage(string message)
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void ReceiveMessage()
        {
            Console.WriteLine("Method Not Implemented");
        }
        public void Makepayment(float amount)
        {
            Console.WriteLine($"Paid Amount : {amount}");
        }
    }
    public class MessageTester
    {
        public static void TestOne()
        {
            IMessageService messageService = new Whatsapp();
            IPayments paymentService = new Whatsapp();
            messageService.SendMessage("hello");
            messageService.ReceiveMessage();
            paymentService.Makepayment(1000);
            
        }
    }
}
