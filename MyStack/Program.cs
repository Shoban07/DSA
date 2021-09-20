using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
	//implementing Stack using linked list
	public class MyStack<T>
	{
		//simple node in a LL consists
		//1. data which holds the input for the node
		//2. next which holds the reference of the next data
		private class StackNode<T>
		{
			public T data;
			public StackNode<T> next;
			public StackNode(T data)
			{
				this.data = data;
			}
			
		}

		private StackNode<T> top;
		public T Pop()
		{
			if (top==null)
			{
				//throw new exception 
				Console.WriteLine("Exception: Stack is empty");
			}
			T item = top.data;
			top = top.next;
			return item;
		}
		public void Push(T item)
		{
			StackNode<T> t = new StackNode<T>(item);
			t.next = top;
			top = t;
		}

		public T Peek()
		{
			if (top==null)
			{
				//throw exception
				Console.WriteLine("Exception: Stack is empty");
			}
			return top.data;
			//Console.WriteLine(top.data.ToString());
		}

		public bool isEmpty()
		{
			return top == null;
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			string[] names = { "Shoban","Vaishali","Kannan", "Renuka", "Vishva" };
			Stack<string> newStack= new Stack<string>(names);
			newStack.Push("Sample");
			newStack.Push("Ramp");
			newStack.Pop();//Ramp popped out
			newStack.Peek();//Sample is the current top of string
			foreach (var item in newStack.Reverse())
			{
				Console.WriteLine(item);
				Console.WriteLine();
				Console.ReadKey();
			}
			MyStack<int> mystack = new MyStack<int>();
			//Push
			mystack.Push(1);
			mystack.Push(100);
			mystack.Push(20);
			mystack.Push(34);

			mystack.Pop();
			mystack.Pop();
			mystack.Pop();

			if (!mystack.isEmpty())
			{
				Console.WriteLine(mystack.Peek().ToString());
				Console.ReadKey();
			}
			
		}
	}
}
