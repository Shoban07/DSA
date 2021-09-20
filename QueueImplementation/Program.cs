using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
	public class MyQueue<T>
	{
		public MyQueue()
		{

		}
		public MyQueue(T firstElement)
		{
			Enqueue(firstElement);
		}
		LinkedList<T> myList = new LinkedList<T>();

		public int Size()
		{
			return myList.Count;
		}

		public bool isEmpty()
		{
			return Size() == 0;
		}

		public T Peek()
		{
			if (isEmpty())
			{
				Console.WriteLine("Queue is Empty");
			}
			return myList.First<T>();
		}

		public T Dequeue()
		{
			T tiRemove = myList.First<T>();
			if (isEmpty())
			{
				Console.WriteLine("Queue is Empty");
			}
		    myList.RemoveFirst();
			return tiRemove;
		}

		public void Enqueue(T element)
		{
			myList.AddLast(element);
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			MyQueue<int> myQ = new MyQueue<int>(1);
			myQ.Enqueue(2);
			myQ.Enqueue(3);
			myQ.Enqueue(4);
			myQ.Enqueue(5);

			//deques
			myQ.Dequeue();
			myQ.Dequeue();
			Console.WriteLine("Last Item Removed : {0}",myQ.Dequeue());

			Console.WriteLine(myQ.Peek().ToString());
			Console.ReadKey();
		}
	}
}
