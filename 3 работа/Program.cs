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
            bool r = (x >= Math.Abs(y) && (y >= 1 && y <= 1)); 
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
