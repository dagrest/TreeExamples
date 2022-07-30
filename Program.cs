namespace TreeExamples
{
    /*
                               0
                          /        \
                     1                 2
                  /     \           /     \
                3         4       5         6
              /
            7    
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tree Examples - VS Code");

            Node node7 = new Node("7", null, null);                            
            Node node6 = new Node("6", null, null);        
            Node node5 = new Node("5", null, null);
            Node node4 = new Node("4", null, null);        
            Node node3 = new Node("3", node7, null);
            Node node2 = new Node("2", node5, node6);        
            Node node1 = new Node("1", node3, node4);
            Node node0 = new Node("0", node1, node2);

            Console.WriteLine("printPreorder");
            printPreorder(node0);
            Console.WriteLine();

            Console.WriteLine("printInorder");
            printInorder(node0);
            Console.WriteLine();

            Console.WriteLine("printPostorder");
            printPostorder(node0);
            Console.WriteLine();

            Console.WriteLine("printLevelOrder");
            printLevelOrder(node0);
            Console.WriteLine();

        }

        public static void printLevelOrder(Node? startNode)
        {
            Queue<Node> queue = new Queue<Node>();

            if(startNode == null)
            {
                return;
            }

            Node node;
            queue.Enqueue(startNode);
            while(queue.Count() != 0)
            {
                node = queue.Dequeue();
                Console.Write(node.Value, " ");

                if(node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if(node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }

        public static void printPreorder(Node? startNode) 
        {
            if(startNode != null)
            {
                Console.Write(startNode.Value, " ");
                if(startNode.Left != null) {
                    printPreorder(startNode.Left);
                }
                if(startNode.Right != null) {
                    printPreorder(startNode.Right);
                }
            }
        }

        public static void printInorder(Node? startNode) 
        {
            if(startNode != null)
            {
                if(startNode.Left != null) {
                    printInorder(startNode.Left);
                }
                Console.Write(startNode.Value, " ");
                if(startNode.Right != null) {
                    printInorder(startNode.Right);
                }
            }
        }

        public static void printPostorder(Node? startNode) 
        {
            if(startNode != null)
            {
                if(startNode.Left != null) {
                    printPostorder(startNode.Left);
                }
                if(startNode.Right != null) {
                    printPostorder(startNode.Right);
                }
                Console.Write(startNode.Value, " ");
            }
        }
    }

    // class Tree 
    // {
    //     Node Root {get; set;}

    //     // public Tree (string value) 
    //     // {
    //     //     Root = new Node ();
    //     // }

    //     public void Add(Node parent, Node child)
    //     {

    //     }
    // }

    class Node 
    {
        public String Value {get; set;}
        public Node? Left {get; set;}
        public Node? Right {get; set;}

        //public Node(){}

        public Node(string value, Node? left, Node? right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}