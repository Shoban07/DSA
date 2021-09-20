using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{	
	public class SinglyLinkedList
	{
		#region SingleNode
		public class Node
		{
			public int data;
			public Node next;
			public void displayNode()
			{
				Console.WriteLine("<" + data + ">");
			}

		}
		#endregion
		private Node first;

		//to check whether is empty
		public bool isEmpty(int data)
		{
			return (first == null);
		}

		//inserts the element as the first node
		public void insertFirst(int data)
		{
			Node newNode = new Node(); //create a new node
			newNode.data = data;//assigns the data to new node data area ['data'|next]
			newNode.next = first;//assigns the next field to next upcoming new node data ref
			first = newNode;//first node is now the new node created
		}

		//deletes the first node
		public Node deleteFirst()
		{
			Node temp = first; // takes the current first node
			first = first.next;//assigns the current first node with the upcoming next node
			return temp; // returns the value
		}

		//Displays the list of nodes added into the linked list
		public void displayList()
		{
			Console.WriteLine("S'Linked List--(First-->Last)");
			Node current = first;
			while (current!=null)
			{
				current.displayNode();
				current = current.next;
			}
			Console.WriteLine();
		}

		//Adds the current node to the end of the l'list
		public void insertLast(int data)
		{
			Node current = first; //seeting up the first node as current
			while(current.next!=null) //iterating through the nodes untill it becomes null
			{
				current = current.next; //iterator
			}
			//creating new node after the iterator iterates to the last node
			Node newNode = new Node();
			newNode.data = data;
			current.next = newNode;
		}

		
	}
	public class Program
	{
		static void Main(string[] args)
		{
			SinglyLinkedList singly = new SinglyLinkedList();
			singly.insertFirst(1);
			singly.insertLast(2);
		}
	}

}
