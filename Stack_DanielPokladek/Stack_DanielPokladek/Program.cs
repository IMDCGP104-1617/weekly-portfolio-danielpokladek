using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_DanielPokladek {
    class Program {
        static void Main ( string[] args ) {
            Stack<string> stack1 = new Stack<string>();

            stack1.Push("ABC");
            stack1.Push("DEF");
            stack1.Push("GHI");
            stack1.Push("JKL");

#if DEBUG
            Console.WriteLine("   ");
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}
