using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        public static void PrintTheObj<T>(T obj)
        {
            Console.WriteLine(obj);
        }

        static void Main(string[] args)
        {
            PrintTheObj<int>(42);
            PrintTheObj<string>("hello");
            PrintTheObj<double>(1.2);

            SwapList<int> list = new SwapList<int>();
            list.Add(42);
            list.Add(30);
            list.Add(20);

            Console.WriteLine("1" + " " + list[0] + " " + "2" + " " + list[1] + " " + "3" + " " + list[2]);
            list.Swap(1,2);
            Console.WriteLine("1" + " " + list[0] + " " + "2" + " " + list[1] + " " + "3" + " " + list[2]);



            Console.ReadLine();
        }
    }
}
