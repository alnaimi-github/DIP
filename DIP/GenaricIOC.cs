using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public static class GenaricIOC
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

    }
}
