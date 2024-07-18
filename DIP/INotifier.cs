using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public interface INotifier
    {
        void Notify();
    }

    public class EmailNotifier : INotifier
    {
        public void Notify()
        {
            Console.WriteLine("Sending email notification");
        }
    }

    public class SmsNotifier : INotifier
    {
        public void Notify()
        {
            Console.WriteLine("Sending SMS notification");
        }
    }
}
