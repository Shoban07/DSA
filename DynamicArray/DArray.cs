using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
	///Design an array which grows its size when it needs to an element.
	///Basically Build a dynamic array, which grows its size in double
	///
	public class DnamicArray<T>
	{
		#region Privates
		private int length = 0;

		private int capacity = 0;

		private T[] array;
		#endregion

		#region Constructors
		public DnamicArray()
		{
			this.capacity = 4;
			array = new T[capacity];
		}
		public DnamicArray(int size)
		{
			if (this.Length < 0)
			{
				throw new Exception("Invalid Array Size");
			}
			this.capacity = size;
			array = new T[capacity];
		}
		#endregion

		#region PublicProps
		public int Length
		{
			get { return length; }
			set { length = value; }
		}

		#endregion

		#region Functions
		//to add
		public void add(T ele)
		{
			if (this.Length+1>=capacity)
			{
				if (capacity == 0)
					capacity = 1;
				else
					capacity *= 2;

				T[] new_arr = new T[capacity];
				for (int i = 0; i < this.Length; i++)
				{
					new_arr[i] = array[i];
				}
				array = new_arr;
			}
			array[Length++] = ele;
			
		}

		//to remove
		public T removeAt(int index)
		{
			if (index>=Length || index<=0)
			{
				throw new Exception("Index Out Of Bound Exception");
			}
			T data = array[index];
			T[] newArray = new T[Length - 1];
			int j = 0;
			for (int i = 0; i < Length; i++)
			{
				if (index==i)
				{
					j--;
				}
				else
				{
					newArray[j] = array[i];
				}
				j++;
			}
			array = newArray;
			capacity = --Length;
			return data;
		}

		//to remove specfific object / elememt
		public bool remove(T element)
		{
			bool res = false;
			int index = IndexOf(element);
			if (index != -1)
			{
				 res = true;
			}
			return res;
			
		}

		//to find index of object/ elemet
		public int IndexOf(T element)
		{
			int index = 0;
			for (int i = 0; i < Length; i++)
			{
				if (element.Equals(array[i]))
				{
					return index = i;
				}
				else return index = -1;
			}
			return index;
		}
		//to check the array Contains the element / object
		public bool Contains(T element)
		{
			bool res = false;
			int index = IndexOf(element);
			if (index != -1)
			{
				res = true;
			}
			return res;
		}

		//to check array is empty or not
		public bool isEmpty()
		{
			return Length == 0;
		}

		//to get the element
		public T Get(int index)
		{
			if (index>=Length||index<0)
			{
				throw new Exception("Index Out of Bound Exception");
			}
			return array[index];
		}
		//to set the element
		public void Set(int index, T element)
		{
			if (index >= Length || index < 0)
			{
				throw new Exception("Index Out of Bound Exception");
			}
			array[index] = element;
		}

		//to clear the array
		public void Clear()
		{
			for (int i = 0; i < Length; i++)
			{
				//array[i] = ;
			}
		}
		//to convert the array to string and return as array format
		public string ToStr()
		{

			StringBuilder sb;
			if (Length==0)
			{
				sb = new StringBuilder();
				sb.Append("[");
			}
			else
			{
				sb = new StringBuilder(Length);
				for (int i = 0; i < Length-1; i++)
				{
					sb.Append(array[i] + ",");
				}
			}
			return sb.Append(array[Length - 1] + "]").ToString();			
		}

		#endregion

	}
	public class Program
	{
		static void Main(string[] args)
		{
			DnamicArray<int> arrayNew = new DnamicArray<int>(5);
			arrayNew.add(10);
			arrayNew.add(100);
			arrayNew.add(1000);
			arrayNew.add(10000);
			arrayNew.add(100000);
			arrayNew.add(1000000);
			Console.WriteLine("element removed at index {0} is {1}", 2, arrayNew.removeAt(2));
			Console.WriteLine();
			Console.ReadKey();
			Console.WriteLine("Our Array");
			Console.WriteLine("Length : "+arrayNew.Length);
			arrayNew.ToString().ToArray();
			Console.WriteLine("[{0}]", string.Join(",", arrayNew.ToStr()));
			Console.ReadKey();
			
			
		}
	}
}
