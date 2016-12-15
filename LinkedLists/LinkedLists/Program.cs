using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists_DanielPokladek {
    class Program {
        static void Main(string[] args) {
            LinkedList<string> list = new LinkedList<string>();

            // Check InsertBeginning and InsertAfter to see if working & compiling.
            list.InsertBeginning("1");
            list.InsertAfter(1, "2");
            list.InsertAfter(2, "3");
            list.InsertAfter(3, "4");
            list.InsertAfter(4, "5");

            // Print the "Head" value of list. Should be "9".
            Console.WriteLine(list.Head);

            // Check RemoveBeginning and RemoveAfter to see if working & compiling.
            list.RemoveAfter(3);

            // Print the "Head" value of list. Should be "4" (because of the removed variables).
            Console.WriteLine(list.Head);
            Console.ReadLine();
        }
    }
}