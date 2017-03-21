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
            
            // Check the "locals/autos" for variables.
            Console.ReadLine();
        }
    }
}