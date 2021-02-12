using System;
using System.Collections.Generic;

namespace AddTwoNumbers
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
        //public Node createLinkedList(string num)
        //{
        //    Node node;
        //    Node root;
        //    node = root = new Node(0);
        //    for (int i = 0; i < num.Length; i++)
        //    {
        //        node.value = num[i] - '0';
        //        if (i < num.Length - 1)
        //        {
        //            node = node.next = new Node(0);
        //        }
        //    }
        //    return root;
        //}
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
        public Node addLinkedList(Node list1, Node list2)
        {
            Node curr = new Node(0);
            Node head = curr;
            int carry = 0;
            while (list1 != null && list2!= null)
            {
                int sum = carry + list1.value + list2.value;
                curr.next = new Node(sum % 10);
                carry = (int)(sum / 10);
                curr = curr.next;
                list1 = list1.next;
                list2 = list2.next;
            }
            Node leftover = null;
            if (list1 == null)
            {
                leftover = list2;
            }
            else
            {
                leftover = list1;
            }

            while (leftover != null)
            {
                int sum = leftover.value + carry;
                curr.next = new Node(sum % 10);
                carry = (int)(sum / 10);
                curr = curr.next;
                leftover = leftover.next;
            }
            if (carry > 0)
            {
                curr.next = new Node(carry);
            }
            head = head.next;
            return head;
        }

        public Node reverseList (Node list)
        {
            if (list == null || list.next == null)
            {
                return list;
            }
            Node prev = null;
            Node curr = list;
            while(curr != null)
            {
                Node temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }
            return prev;
        }
    }

    
    class Program
    {
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
            Node addedList = solution.addLinkedList(list1, list2);
            Console.WriteLine("Sum of Reversed List 1 and List 2: ");
            solution.printLinkedList(solution.reverseList(addedList));
        }
    }
}