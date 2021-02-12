using System;

namespace MergeLinks
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
        public void printLinkedList(Node node)
        {
            while (node != null)
            {
                Console.Write($"{node.value} ");
                node = node.next;
            }
            Console.WriteLine();
        }
        public Node mergeTwoSortedLists(Node list1, Node list2)
        {
            Node head; 
            if (list1.value < list2.value)
            {
                head = list1;
                list1 = list1.next;
            }
            else
            {
                head = list2;
                list2 = list2.next;
            }
            head.next = null;
            Node lastNode;
            lastNode = head;
            while (list1 != null && list2 != null)
            {
                if (list1.value < list2.value)
                {
                    lastNode.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    lastNode.next = list2;
                    list2 = list2.next;
                }
                lastNode = lastNode.next;
                lastNode.next = null;
            }
            if (list1 == null)
            {
                lastNode.next = list2;
            }
            else
            {
                lastNode.next = list1;
            }
            return head;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers: ");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(',', ' ');
            Solution solution = new Solution();
            Node list1 = solution.createReverseLinkedList(inputArray[0]);
            Node list2 = solution.createReverseLinkedList(inputArray[1]);
            Console.WriteLine("Reversed List 1: ");
            solution.printLinkedList(list1);
            Console.WriteLine("Reversed List 2: ");
            solution.printLinkedList(list2);
            Node mergedList = solution.mergeTwoSortedLists(list1, list2);
            Console.WriteLine("Merged List: ");
            solution.printLinkedList(mergedList);
        }
    }
}
