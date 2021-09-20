using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
	class Program
	{
		public class DoublyLinkedList
		{
			public class Node {

				public int data;
				public Node next;
				public Node prev;

			}
				
			public Node first;

			//public int capacity;

			private int capacity;

			public int Capacity
			{
				get {
					if (capacity == 0 & first != null)
					{
						capacity = length;
					}
					return capacity; }
				set { capacity = value; }
			}


			public int length = 0;

			public DoublyLinkedList()
			{

			}
			public DoublyLinkedList(int capacity)
			{
				this.capacity = capacity;
			}

			//isEmpty or not 
			public bool IsEmpty()
			{
				return (first == null);
			}

			#region add_methods
			//AddFirst --> adds current node in the first place
			public void addFirst(int data)
			{
				if (length>=capacity && capacity!=0)
				{
					Console.WriteLine("Linked List OverFlows");
				}
				else
				{
					Node newNode = new Node();
					newNode.data = data;
					if (first != null)
					{
						first.prev = newNode;
					}
					newNode.next = first;
					first = newNode;
					length++;
				}
			}

			public void addLast(int data)
			{
				if (length >= capacity && capacity != 0)
				{
					Console.WriteLine("Linked List OverFlows");
				}
				else
				{
					if (first == null)
					{
						addFirst(data);
					}
					else
					{
						Node newNode = new Node();
						newNode.data = data;
						Node Current = first;
						while (Current.next != null)
						{
							Current = Current.next;
						}
						Current.next = newNode;
						newNode.prev = Current;
						length++;
					}
				}
			}

			public void addAftert(int data, int atData)
			{
				if (length >= capacity && capacity != 0)
				{
					Console.WriteLine("Linked List OverFlows");
				}
				else
				{
					Node newNode = new Node();
					newNode.data = data;
					Node current = first;
					while (current.data != atData)
					{
						current = current.next;
					}
					Node temp = current.next;
					current.next = newNode;
					newNode.prev = current;
					newNode.next = temp;
					temp.prev = newNode;
					length++;
				}
			}
			#endregion

			#region remove_methods

			public int removeFirst()
			{
				Node current = first;
				Node temp = current.next;
				temp.prev = null;
				first.next = null;
				first = temp;
				return current.data;
			}

			public int removeLast()
			{
				Node current = first;
				
				while (current.next.next!=null)
				{
					//temp = current;
					current = current.next;
				}
				Node temp = current.next;
				current.next = null;
				return temp.data;

			}

			public int removeAt(int data)
			{
				Node current = first;
				while (current != null && current.data!=data)
				{
					current = current.next;
				}
				Node temp = current;

				if (current != null && current.next!=null)
				{
					current.prev.next = temp.next;
					current.next.prev = temp.prev;
					temp.next = null;
					temp.prev = null;
				}
				else
				{
					if (current == null)
					{
						Console.WriteLine("No such element exists to delete");
						temp = new Node();
						temp.data = int.MinValue;
					}
					else
						temp.data = removeLast();
				}
				return temp.data;
			}

			#endregion

			public bool Contains(int data)
			{
				bool elementExists = false;
				Node current = first;
				while (current!=null && current.data!=data)
				{
					current = current.next;
				}
				if (current != null && current.data==data)
				{
					elementExists = true;
				}
				return elementExists;
			}

			public string PrintAllData()
			{
				StringBuilder str = new StringBuilder("[ ");

				Node node = first;

				while (node != null)
				{
					str.Append(node.data.ToString() + ", ");
					node = node.next;
				}

				str.Append(" ]");
				return str.ToString();
			}
		}

		static void Main(string[] args)
		{
			DoublyLinkedList dll = new DoublyLinkedList();
			dll.addLast(-2);
			dll.addFirst(1);
			dll.addFirst(0);
			dll.addFirst(-1);
			dll.addLast(2);
			dll.addAftert(3, -2);
			dll.addLast(3);
			//Console.WriteLine(dll.removeFirst()+ " has been removed from Linked List");
			//Console.WriteLine(dll.removeLast() + " has been removed from the last of the Linked List");
			Console.WriteLine(dll.removeAt(3)+ " element has been removed from linked list");
			Console.WriteLine(dll.removeAt(3) + " element has been removed from linked list");
			Console.WriteLine(dll.removeAt(3) + " element has been removed from linked list");
			Console.WriteLine( "0 is it exists in the Linked List? : {0}", dll.Contains(0));
			Console.WriteLine("10 is it exists in the Linked List? : {0}", dll.Contains(10));
			Console.WriteLine(dll.PrintAllData());
			Console.ReadKey();
		}
	}
}
