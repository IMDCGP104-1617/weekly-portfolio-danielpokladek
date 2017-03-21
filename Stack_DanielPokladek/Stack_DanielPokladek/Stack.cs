namespace Stack_DanielPokladek {
    class Stack<T> {
        // Stack variables.
        private LinkedList<T> stackList;    // Using my own LinkedList to create a stackList.
        private int stackLength;            // Integer returning the length of the stack.


        public int StackLength {
            get { return stackLength; }     // We use the get and return functions to return a private int,
        }                                   //  so that it cannot be changed from outside the script.

        public bool isEmpty ( ) {           // A bool to check if the stack is empty.
            return stackLength == 0;        // Return true if the length of stack is zero, else return false.
        }

        public Stack ( ) {
            stackList = new LinkedList<T>();    // Create a new stack using the LinkedList.
        }

        ~Stack ( ) {
            while (!isEmpty()) {                // While the stack is not empty.
                T output;                       // T is output.
                Pop(out output);                // Pop (remove) the output of T.
            }
        }

        public void Push ( T data ) {           // Push function adds data to the beggining of stack.
            stackList.InsertBeginning(data);    // Insert the data from argument into the beginnning of stack.
            stackLength++;                      // Increase the length of the stack by 1.
        }

        public bool Pop ( out T output ) {      // Pop function removes the data from the stack.
            output = default(T);                // Make the output equal to default.
            if (isEmpty())                      // If empty, return false.
                return false;

            output = stackList.RemoveBeginning();   // Remove the first data from teh stack.
            stackLength--;                          // Decrease the stack length by 1.
            return true;                            // Return true to the bool.
        }

        public T Peek ( ) {                         // Peek function used to check the head of stack.
            return stackList.Head;                  // Return the head of stack.
        }
    }
}