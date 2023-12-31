using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp154
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = "abcdefghijklmabcdefghijklm";

            Console.WriteLine("Substring from index 20 to end is" + $"\"{letters.Substring(20)}\"");
            Console.WriteLine("Substring from index 0 of length 6 is" + $"\"{letters.Substring(0, 6)}\"");

            Console.ReadLine();
        }
    }
}
