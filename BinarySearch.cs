using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTestApp
{

    public class BinarySearchTree
    {
        
        public static void Main(string[] args)
        {
            Node n1 = new Node(value: 1, left: null, right: null);
            Node n3 = new Node(value: 3, left: null, right: null);

            Node n2 = new Node(value: 2, left: n1, right: n3); //Positive testing

            Node n4 = new Node(value: 2, left: n3, right: n2); //negative testing

            Console.WriteLine(" Does n2 is a valid Binary Node : " + IsValidBST(n2).ToString());
            Console.WriteLine(" Does n4 is a valid Binary Node : " + IsValidBST(n4).ToString());
            Console.ReadLine();
        }
       
        private static bool IsValidBST(Node node, int MIN = int.MinValue, int MAX = int.MaxValue)
        {
            if (node == null)
                return true;

            if (node.Value > MIN
                && node.Value < MAX
                && IsValidBST(node.Left, MIN, Math.Min(node.Value, MAX))
                && IsValidBST(node.Right, Math.Max(node.Value, MIN), MAX)) 
                return true;
            else
                return false;
        }

    }

    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }
    }
}
