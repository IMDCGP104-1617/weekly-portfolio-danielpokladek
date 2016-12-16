using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists_DanielPokladek {
    class Program {
        static void Main(string[] args) {
            LinkedList<int> list = new LinkedList<int>();

            // Check InsertBeginning and InsertAfter to see if working & compiling.
            list.InsertBeginning(0);
            list.InsertAfter(1, 1);
            list.InsertAfter(2, 2);
            list.InsertAfter(3, 3);

            // Print the "Head" value of list. Should be "1".
            Console.WriteLine(list.Head);

            // Check RemoveBeginning and RemoveAfter to see if working & compiling.
            list.RemoveAfter(0);

            // Print the "Head" value of list. Should be "1", while Node "2" should be gone (check autos).
            Console.WriteLine(list.Head);
            Console.ReadLine();
        }
    }
}