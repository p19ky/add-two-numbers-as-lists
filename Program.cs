using System;
using System.Collections.Generic;

namespace LinkedListBonusProblemCSharp
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public class LinkedList
    {
        public Node head1, head2;

        public void AddFirstList(List<int> firstList)
        {
            foreach( int value in firstList )
            {
                Node newNode = new Node(value);

                if (head1 == null)
                {
                    head1 = new Node(value);
                } 
                else
                {
                    newNode.next = null;
                    Node tmpHead = head1;

                    while (tmpHead.next != null)
                    {
                        tmpHead = tmpHead.next;
                    }

                    tmpHead.next = newNode;
                }
            }

            Console.WriteLine("\nFirst list: \n");
            print(head1);
        }

        public void AddSecondList(List<int> secondList)
        {
            foreach (int value in secondList)
            {
                Node newNode = new Node(value);

                if (head2 == null)
                {
                    head2 = new Node(value);
                }
                else
                {
                    newNode.next = null;
                    Node tmpHead = head2;

                    while (tmpHead.next != null)
                    {
                        tmpHead = tmpHead.next;
                    }

                    tmpHead.next = newNode;
                }
            }

            Console.WriteLine("\nSecond list: \n");
            print(head2);
        }

        public Node addTwoNumbersLists(Node first, Node second)
        {
            Node result = null;
            Node previous = null;
            Node temporal = null;

            int carry = 0;
            int sum = 0;

            while (first != null || second != null)
            {
                sum = (first != null ? first.data : 0) + (second != null ? second.data : 0) + carry;

                carry = (sum >= 10) ? 1 : 0;

                sum = sum % 10;

                temporal = new Node(sum);

                if (result == null)
                {
                    result = temporal;
                } 
                else
                {
                    previous.next = temporal;
                }

                previous = temporal;

                if (first != null)
                {
                    first = first.next;
                }
                if (second != null)
                {
                    second = second.next;
                }

            }

            if (carry > 0)
            {
                temporal.next = new Node(carry);
            }

            return result;
        }

        public void print(Node head)
        {
            Console.Write("[ ");
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
            Console.Write("]");
            Console.WriteLine("\n");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();

            List<int> firstList = new List<int>();
            firstList.Add(9);
            firstList.Add(9);
            firstList.Add(9);
            firstList.Add(9);
            firstList.Add(9);
            firstList.Add(9);
            firstList.Add(9);
            firstList.Add(9);

            List<int> secondList = new List<int>();
            secondList.Add(9);
            secondList.Add(9);
            secondList.Add(9);
            secondList.Add(9);
            secondList.Add(9);

            myList.AddFirstList(firstList);
            myList.AddSecondList(secondList);

            Node resultListHead = myList.addTwoNumbersLists(myList.head1, myList.head2);
            Console.WriteLine("\nResult list: \n");
            myList.print(resultListHead);
        }
    }
}
