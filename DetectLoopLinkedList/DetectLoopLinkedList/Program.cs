using System;

namespace DetectLoopLinkedList
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
        public Node FindBeginningofLoop(Node node)
        {
            Node slow = node;
            Node fast = node;

            while (fast!= null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    break;
                }
            }

            if (fast ==null || fast.next == null)
            {
                return null;
            }

            slow = node;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return fast;
        }
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

        public Node createLinkedList(int[] list)
        {
            Node prevNode = null;
            Node currNode = null;
            for (int i = 0; i < list.Length; i++)
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
            //Console.Write("Enter a list of numbers: ");
            //string input = Console.ReadLine();
            //string[] inputArray = input.Split(',', ' ');
            //int[] intInputArray = new int[inputArray.Length];
            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    intInputArray[i] = int.Parse(inputArray[i]);
            Node head = new Node(1);
            Node node = head.next = new Node(2);
            node = node.next = new Node(3);
            node = node.next = new Node(4);
            node.next = head.next;

            //}
            Solution solution = new Solution();
            //Node list = solution.createLinkedList(intInputArray);
            Console.WriteLine("List: ");
            node = solution.FindBeginningofLoop(head);
            Console.WriteLine($"Found at {node.value}");
            //Node startingNode = solution.FindBeginningofLoop(list);
            //Console.WriteLine("Beginning Node: ");
            //solution.printLinkedList(startingNode);
        }
    }
}
