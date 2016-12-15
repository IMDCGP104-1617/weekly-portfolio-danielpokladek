using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists_DanielPokladek {
    public class LinkedList<T> {

        /* Creating a LinkedList using C#.
         * 
         * InsertBeginning - Set 0 to always equal to the data user passes.
         * InsertAfter - Loop the List and find last Node, make Node after last set to null,
         *                 after add a new Node to the end with data passed.
         * RemoveBeginning - Set 0 "head" always equal to null, and make next Node the new head.
         * RemoveAfter - Loop the List and find last Node, remove the last Node.
         */


        public class Node {
            public T data;
            public Node next;
        }

        private Node head;          // The first node in the list.
        private int count = 0;      // Count/Length of the current list.

        public T Head { get { return head.data; } }

        public LinkedList( ) {     // Initializing the values, and setting them to zero.
            this.head = null;
            this.count = 0;
        }

        public void InsertBeginning ( T Data ) {   // Insert a new node at the start.
            Node newNode = new Node();
            newNode.data = Data;

            if (head == null) {
                head = newNode;
            }
            else {
                newNode.next = head;
                head = newNode;
            }

            count++;
            // If current "head" is null, set the head to "newNode"
            // If current "head" exists, set it to next node and set "newNode" to "head"
        }

        public void InsertAfter ( int after, T Data ) {
            if (head == null) {
                InsertBeginning(Data);
            }
            else {
                Node current = head;
                int counter = 0;

                while (counter != 0) {
                    current = current.next;
                    counter++;
                    if(current == null)
                        break;
                }

                Node newNode = new Node();
                newNode.data = Data;
                newNode.next = null;
                current.next = newNode;
            }

            count++;
            // If current "head" is null, run InsertBeginning() and pass the Data from InsertAfter()
            // If current "head" exists, run a while loop to find the Node which is after "int after".
            // Once the Node was found, make a "newNode", set data = Data, next Node to null
            //      and set the next Node to "newNode".
            // And if the current Node is null, break the loop.
        }

        public T RemoveBeginning ( ) {
            T ret = default(T);
            if (head != null) {
                ret = head.data;
                if (head.next == null)
                    head = null;
                else
                    head = head.next;
            }

            count--;
            return ret;
            // If "head" is not null, set ret to the data of head.
            // If next of "head" is null, set head to null.
            // If next of "head" is not null, set "head" to next.
        }

        public T RemoveAfter ( int count ) {
            T ret = default(T);

            Node current = head;

            while (current != null) {
                if (current.next != null) {
                    ret = current.next.data;
                    current.next = current.next.next;
                    count--;
                }
                break;
            }

            current = current.next;
            return ret;
            // Set current Node to head. While the current node is not null and if next node,
            // is not equal to null, grab the data from next node and make it into current node.
        }
    }
}
