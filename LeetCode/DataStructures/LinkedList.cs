﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionsLib.DataStructures
{
    public class Node
    {
        // Fields
        public int? Data;
        public Node Next;
        public Node Previous;

        // Constructors
        public Node()
        {
            this.Data = 0;
            this.Next = null;
            this.Previous = null;
        }

        public Node(int value)
        {
            this.Data = value;
            this.Next = new Node();
        }
    }

    /// <summary>
    /// 707. Design Linked List
    /// Design your implemenation of the linked list. You can choose to use the singly linked list or the doubly lined list. A node in a singly linked list should have two attributes: val and next. Val is the value of the current node, next is a pointer/ reference to the next node. If you want to use the double linked list, you will need one more attribute prev to indicate the previous node in the linked list. Assume all nodes in the linked list are 0-indexed.
    /// </summary>
    public class LinkedList
    {
        private Node _head;
        private Node _tail;

        public int Count;
        
        // Constructors
        public LinkedList() { }
        public LinkedList(Node head)
        {
            this._head = head;
        }

        //TODO: get(index), addAtHead(val), addAtTail(val), addAtIndex(index, val), deleteAtIndex(index)

        public void AddAtHead(int val)
        {

        }

        /// <summary>
        /// Append a node of values to the last element of the linked list.
        /// </summary>
        /// <param name="val"></param>
        public void AddAtTail(int val)
        {
            try
            {
                Node node = _head;          // Set Node to first node in the list
                while (node.Next != null)   // Traverse to the end of LinkedList
                {
                    node = node.Next;
                }
                node.Next = new Node();
                node.Next.Data = val;       // Insert value at the end of the linked list
            }
            catch
            {
                Console.WriteLine($"Error: Could not add '{val}' to Tail of Linked List");
            }
        }

        public void AddAtIndex(int index, int val)
        {
            // Intent: Loop through once and get the Count of nodes
            // Using a temp variable, insert the node into the corret index, and shift all nodes to the right by 1
            if (index < 0 || index > Count) return;

        }

        public void PrintLinkedList()
        {
            Console.WriteLine($"707. Design Linked List");
            Console.WriteLine($"Print Linked List");
            Console.Write($"HEAD => ");
            Node node = _head;
            while (node.Data != null && node.Next != null)
            {
                Console.Write($"{node.Data} => ");
                node = node.Next;
            }
             
            if (node.Next == null)
            {
                Console.Write($"{node.Data} => TAIL\n\n");
            }
        }
    }
}
