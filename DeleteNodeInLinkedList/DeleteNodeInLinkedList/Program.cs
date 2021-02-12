using System;

namespace DeleteNodeInLinkedList
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
        //public Node createReverseLinkedList(string num)
        //{
        //    Node prevNode = null;
        //    Node currNode = null;
        //    for (int i = 0; i < num.Length; i++)
        //    {
        //        currNode = new Node(num[i] - '0');
        //        currNode.next = prevNode;
        //        prevNode = currNode;
        //    }
        //    return currNode;
        //}

        public void deleteNode(Node node, int key)
        {
            Node temp = new Node(0);
            Node head = temp;
            Node prev = null;
            if (temp != null && temp.value == key)
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.value != key)
            {
                prev = temp;
                temp = temp.next;
            }
            prev.next = temp.next;
        }
        public Node createLinkedList(int [] list)
        {
            Node prevNode = null;
            Node currNode = null;
            for (int i=0; i<list.Length; i++)
            {
                currNode = new Node(list[i]);
                currNode.next = prevNode;
                prevNode = currNode;
            }
            return prevNode;
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
            string[] inputArray = input.Split(',', ' ');
            int[] intInputArray = new int[inputArray.Length];
            for (int i =0; i<inputArray.Length; i++)
            {
                intInputArray[i] = int.Parse(inputArray[i]);
            }
            Solution solution = new Solution();
            Node list = solution.createLinkedList(intInputArray);
            Console.WriteLine("List: ");
            solution.printLinkedList(list);
            Node deletedList = solution.deleteNode(list);
            Console.WriteLine("Deleted List: ");
            solution.printLinkedList(deletedList);
        }
    }
}
