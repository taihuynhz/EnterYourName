using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterYourName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello: " + yourName);
        }
    }
}
