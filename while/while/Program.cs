using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            while (a >= -2)
            {
                Console.WriteLine(a);
                a = a - 2;
            }
            Console.ReadLine();
        }
    }
}
