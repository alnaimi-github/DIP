using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class VisiCard:ICard
    {
        public void Charge()
        {
            Console.WriteLine("Charaging using Visi Card...");
        }
    }
}
