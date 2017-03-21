/* Creating a LinkedList using C#.
* 
* InsertBeginning - Set 0 to always equal to the data user passes.
* InsertAfter - Loop the List and find last Node, make Node after last set to null,
*                 after add a new Node to the end with data passed.
* RemoveBeginning - Set 0 "head" always equal to null, and make next Node the new head.
* RemoveAfter - Loop the List and find last Node, remove the last Node.
* 
*/

namespace LinkedLists_DanielPokladek {
    public class LinkedList<T> {

        public class Node {
            public T data;          // Data stored in the node.
            public Node next;       // Next node in the list.
        }

        private Node head;          // The first node in the list.
        private int length = 0;     // Length of the current list.

        public T Head { get { return head.data; } }     // Gets and returns the data of the head node.

        public LinkedList ( ) {     // Initialise the LinkedList.
            this.head = null;       // Make the head empty.
            this.length = 0;        // Set the length of the list to zero.
        }

        public void InsertBeginning ( T Data ) {    // Insert a new node at the start of the list.
            Node newNode = new Node();              // Create new node, and make it empty.
            newNode.data = Data;                    // Make the data of the node equal to the data from the argument.

            if (head == null) {                     // If the head is empty:
                head = newNode;                     // Set the newly created node to head.
            }
            else {                                  // Otherwise if there is a head:
                newNode.next = head;                // Set the head to the "next" node,
                head = newNode;                     // and set the newly created node to head.
            }

            length++;                               // Increase the length of the list.
        }

        public void InsertAfter ( int after, T Data ) {     // Insert new node after specific node (int after = node in list)
            Node current = head;                            // Set the current node to the head.
            int counter = 0;                                // Set the counter to zero.

            if (head == null) {                             // If there is no head:
                InsertBeginning(Data);                      // Insert the node as the head of the list.
            }
            else {                                          // Otherwise:
                while (counter != after) {                      // While the counter is not equal to after:
                    if (current.next != null) {                 // If the next node is empty,
                        current = current.next;                 // Set the current node to the next node.
                        counter++;                              // Add one to counter, and continue until we found the desired node.
                    }
                    else { break; }                         // Otherwise break out of the loop.
                }

                Node newNode = new Node();                  // Set the newNode equal to a new empty node.
                newNode.data = Data;                        // Set the data of the node to equal to the data from the argument.
                newNode.next = null;                        // Set the next node to equal to nothing.
                current.next = newNode;                     // Set the next node of currently selected node to the newly created newNode.
            }

            length++;                                       // Increase the length of the list.
        }

        public T RemoveBeginning ( ) {              // Remove the first node (head node) from the list.
            T ret = default(T);                     // Set the return to deafult value.
            if (head != null) {                     // While the head is not null:
                ret = head.data;                    // set return data to the data from head.
                if (head.next == null)                  // If the next node after head is null:
                    head = null;                        // Set the head to equal to null (as there is nothing after it).
                else                                    // Otherwise:
                    head = head.next;                       // Set head equal to the node after the head.
            }

            length--;                                   // Decrease the length of the list.
            return ret;                                 // Return the data from the head.
        }

        public T RemoveAfter ( int count ) {        // Remove new node after specific node (int count = node in list).
            T ret = default(T);                     // Set the return to default value.

            Node current = head;                    // Set the current node to equal to head.
            int counter = 0;                        // Set the counter to zero.

            while (count != counter) {              // While the count is not equal to counter:
                current = current.next;             // Set current to the next node.
                counter++;                          // Increase the counter.
                if (current.next == null) {             // If the next node is empty:
                    break;                              // Break out of the loop.
                }
            }

            if (current.next != null) {                 // If the next node is empty:
                ret = current.next.data;                // Set the return value to equal to the data of next node.
                current.next = current.next.next;       // Set the next node of the current node, to equal to the next node of next node.
                length--;                               // Decrease the length of the list.
            }
            else {                                      // Otherwise:
                return ret;                                 // Return the ret value.
            }
            return ret;                                 // Return the ret value.
        }
    }
}
