using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_DanielPokladek {
    class Program {
        static void Main ( string[] args ) {
            Stack<string> stack1 = new Stack<string>();

            string[] str = { "ABC", "DEF", "GHI", "JKL" };
            Stack<string> stack2 = new Stack<string>(str);
            Stack<string> stack3 = new Stack<string>(10);

            Console.WriteLine("The elements in stack1 are: " + stack1.Count());
            Console.WriteLine("The elements in stack2 are: " + stack2.Count());
            Console.WriteLine("The elements in stack3 are: " + stack3.Count());

            stack1.Push("ABC");
            stack1.Push("DEF");
            stack1.Push("GHI");
            stack1.Push("JKL");

            Console.WriteLine("The elements in the stack1 are as: ");
            foreach (string s in stack1)
                Console.WriteLine(s);

            Console.WriteLine("The elements in the stack2 are as: ");
            foreach (string s in stack2)
                Console.WriteLine(s);

            Console.WriteLine("The elements in the stack3 are as: ");
            foreach (string s in stack3)
                Console.WriteLine(s);

            stack3.Push("One");
            stack3.Push("Two");

            Console.WriteLine("The elements in the stack3 are as: ");
            foreach (string s in stack3)
                Console.WriteLine(s);

#if DEBUG
            Console.WriteLine("   ");
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}
