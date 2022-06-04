using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hobbileriniz nedir?");
            string hobbiler = Console.ReadLine();

            Console.Clear();

            hobbiler = "uzmek ve musiqi dinlemek";
            Console.WriteLine (hobbiler.Substring(9,6));

            Console.ReadLine();       
        }



    }
}
