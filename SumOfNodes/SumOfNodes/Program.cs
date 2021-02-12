using System;

namespace SumOfNodes
{
    class Node
    {
        public int value;
        public Node next;
        public Node(int data)
        {
            value = data;
            next = null;
        }
    }
    class Solution
    {
        public Node createReverseLinkedList(string num)
        {
            Node prevNode = null;
            Node currNode = null;
            for (int i = 0; i < num.Length; i++)
            {
                currNode = new Node(num[i] - '0');
                currNode.next = prevNode;
                prevNode = currNode;
            }
            return currNode;
        }
        public int addLinkedList(Node list)
        {
            int sum = 0;
            while (list != null)
            {
                sum += list.value;
                list = list.next;
            }
            return sum;
        }
        public void printLinkedList(Node node)
        {
            while (node != null)
            {
                Console.Write($"{node.value} ");
                node = node.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a list of numbers: ");
            string input = Console.ReadLine();
            Solution solution = new Solution();
            Node list = solution.createReverseLinkedList(input);
            Console.WriteLine("Reversed List: ");
            solution.printLinkedList(list);
            Console.WriteLine("Sum of numbers in list: ");
            int sum = solution.addLinkedList(list);
        }
    }
}
