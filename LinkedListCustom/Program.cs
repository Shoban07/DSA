using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCustom
{
	public class SinglyLinkedList
	{
		//creating a seperate node class
		public class Node
		{
			//singly linked list has two thins, one which holds data
			public int data;
			// another one which holds the reference for the next node
			public Node next;
		}

		//Node which represents the first node
		public Node first;

		public bool IsEmpty()
		{
			return (first == null);
		}

		public void addFirst(int data)
		{
			Node newNode = new Node();
			newNode.data = data;
			newNode.next = first;
			first = newNode;
		}

		public void addLast(int data)
		{
			Node newNode = new Node();
			newNode.data = data;
			Node current = first;
			while (current.next!=null)
			{
				current = current.next;
			}
			current.next = newNode;
		}

		public int deleteFirst()
		{
			Node temp = first;
			first = first.next;
			return temp.data;
		}

		public void insertAfter(int insertAfter, int data)
		{
			Node current = first;
			while (current.data!=insertAfter)
			{
				current = current.next;
			}
			Node newNode = new Node();
			newNode.data = data;
			Node temp = current.next;
			current.next = newNode;
			newNode.next = temp;
		}

		public void deleteNode(int data)
		{
			Node current = first;
			Node Delete = null;
			while (current.data != data)
			{
				Delete = current;
				current = current.next;
			}
			int temp = current.data;
			Delete.next = current.next;
			
		}

		public string PrintAllData()
		{
			StringBuilder str = new StringBuilder("[ ");

			Node node = first;

			while (node!=null)
			{
				str.Append(node.data.ToString()+", ");
				node = node.next;
			}

			str.Append(" ]");
			return str.ToString();
		}
	}
	class Program
	{	
		static void Main(string[] args)
		{
			SinglyLinkedList ls = new SinglyLinkedList();
			ls.addFirst(1);
			ls.addLast(2);
			ls.addFirst(0);
			ls.insertAfter(1, 5);
			ls.deleteNode(1);
			Console.WriteLine(ls.PrintAllData());
			Console.WriteLine(ls.deleteFirst()+" has been removed from the Linked List");
			Console.WriteLine(ls.PrintAllData());
			Console.ReadKey();
		}
	}
}
