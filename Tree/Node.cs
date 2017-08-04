using System;

namespace TreePortfolio {
    class Node {
        public int nodeValue;
        public Node nodeParent;
        public Node nodeLeft;
        public Node nodeRight;

        #region Bools
        public bool NoChildren ( ) {
            if (nodeLeft == null && nodeRight == null)
                return true;

            return false;
        }

        public bool TwoChildren ( ) {
            return ( nodeLeft != null && nodeRight != null );
        }

        public bool LeftChild ( ) {
            return ( nodeLeft != null );
        }

        public bool RightChild ( ) {
            return ( nodeRight != null );
        }
        #endregion

        public Node ( int nodeValue, Node nodeParent ) {     
            this.nodeValue = nodeValue;                                  
            this.nodeParent = nodeParent;                                
        }

        #region FindNode
        // FindNode function used to search for node with specific value.
        Node FindNode ( int findValue ) {
            if (findValue < nodeValue) {                  // If the value we're looking for is smaller then value of the node,  
                if (nodeLeft == null) {                   // and the left node is empty, return nothing.
                    return null;
                }

                return nodeLeft.FindNode(findValue);      // Return the value.
            }
            else if (findValue > nodeValue) {
                if (nodeRight == null) {
                    return null;
                }

                return nodeRight.FindNode(findValue);
            }
            else {
                return this;                         // If nothing was found, return this.
            }
        }
        #endregion

        #region NewNode
        // Used to create a new node, this function takes "nodeValue" argument that is stored with the node.
        public void NewNode ( int nodeValue ) {              
            if (nodeValue > this.nodeValue) {                             
                if (nodeRight == null)
                    nodeRight = new Node(nodeValue, this);           
                else
                    nodeRight.NewNode(nodeValue);                    
            }                                                   
            else {
                if (nodeLeft == null)
                    nodeLeft = new Node(nodeValue, this);            
                else
                    nodeLeft.NewNode(nodeValue);                     
            }                                                   
        }
        #endregion

        #region RemoveNode
        // Used to remove any node from the tree, it takes the "removeValue" argument to find the node with the value specified.
        public void RemoveNode ( int removeValue ) {        
            Node StartNode = FindNode(removeValue);             

            if (StartNode == null) { return; }

            if (StartNode.NoChildren()) {
                if (StartNode.nodeParent.nodeLeft.nodeValue == StartNode.nodeValue) {
                    StartNode.nodeParent.nodeLeft = null;
                }
                else if (StartNode.nodeParent.nodeRight.nodeValue == StartNode.nodeValue) {
                    StartNode.nodeParent.nodeRight = null;
                }

                StartNode = null;
            }
            else if (StartNode.LeftChild()) {
                if (StartNode.RightChild()) {
                    Node currentNode = StartNode.nodeRight;
                    while (currentNode.LeftChild()) {
                        currentNode = currentNode.nodeLeft;
                    }

                    StartNode.nodeValue = currentNode.nodeValue;
                    currentNode.nodeParent.nodeLeft = null;
                }
                else if (!StartNode.RightChild()) {
                    if (StartNode.nodeParent.LeftChild() && StartNode.nodeParent.nodeLeft.nodeValue == StartNode.nodeValue) {
                        StartNode.nodeParent.nodeLeft = StartNode.nodeLeft;
                        StartNode.nodeLeft.nodeParent = StartNode.nodeParent;
                        StartNode = null;
                    }
                    else {
                        StartNode.nodeParent.nodeRight = StartNode.nodeRight;
                        StartNode.nodeLeft.nodeParent = StartNode.nodeParent;
                        StartNode = null;
                    }
                }
            }
            else {
                if (StartNode.nodeParent.LeftChild() && StartNode.nodeParent.nodeLeft.nodeValue == StartNode.nodeValue) {
                    StartNode.nodeParent.nodeLeft = StartNode.nodeLeft;
                    StartNode.nodeRight.nodeParent = StartNode.nodeParent;
                    StartNode = null;
                }
                else {
                    StartNode.nodeParent.nodeRight = StartNode.nodeRight;
                    StartNode.nodeRight.nodeParent = StartNode.nodeParent;
                    StartNode = null;
                }
            }
        }
        #endregion

        #region Traverse
        public void InOrderTraverse ( ) {
            if (LeftChild()) {
                nodeLeft.InOrderTraverse();
            }

            Console.WriteLine(nodeValue);

            if (RightChild()) {
                nodeRight.InOrderTraverse();
            }
        }

        public void PreOrderTraverse ( ) {
            Console.WriteLine(nodeValue);

            if (LeftChild()) {
                nodeLeft.PreOrderTraverse();
            }

            if (RightChild()) {
                nodeRight.PreOrderTraverse();
            }
        }

        public void PostOrderTraverse ( ) {
            if (LeftChild()) {
                nodeLeft.PostOrderTraverse();
            }

            if (RightChild()) {
                nodeRight.PostOrderTraverse();
            }

            Console.WriteLine(nodeValue);
        }

        #endregion
    }
}
