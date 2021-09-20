using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
	public class CircularLinkedList
	{
		public class Node
		{
			public int data;
			public Node next;
			public Node prev;
		}

		public Node first;

		public void addFirst(int data)
		{
			Node newNode = new Node();
			newNode.data = data;
			first = newNode;
			first.prev = newNode.prev;
			first.next = newNode.next;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			CircularLinkedList cl = new CircularLinkedList();
			cl.addFirst(1);
		}
	}
}
