using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_работа
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool r = (y < Math.Abs(x)) && (x > -1) && (x < 1);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
