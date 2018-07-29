using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World");
            Console.WriteLine ("\n What is your name?");
            var name = Console.ReadLine ();
            var date = DateTime.Now;
            Console.Write ($"\nHello {name}, on {date:d} at {date:t}!");

            Console.WriteLine ("\nPress any key to countine...");
            Console.ReadKey (true);
        }
    }
}