using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Tools
    {
        public static int RandomNumber(int end)
        {
            var rand = new Random();
            return rand.Next(0, end);
        }
    }
}
