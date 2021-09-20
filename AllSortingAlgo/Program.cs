using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AllSortingAlgo
{
	public class Sorting
	{
		public int[] BubbleSort(int[] arr)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			int n = arr.Length;
			for (int i = 0; i < n-1; i++)
			{
				int flag = 0;
				for (int j = 0; j < n-1-i; j++)
				{
					if (arr[j]>arr[j+1])
					{
						int temp = arr[j];
						arr[j] = arr[j + 1];
						arr[j + 1] = temp;
						flag = 1;
					}
					
				}
				if (flag==0)
					break;
			}
			sw.Stop();
			Console.WriteLine("Time Taken for sorting in Bubble Sort : "+sw.ElapsedTicks);
			return arr;
		}

		public int[] InsertionSort(int[] arr)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			int n = arr.Length;
			for (int i = 1; i < n; i++)
			{
				int temp = arr[i];
				int j = i - 1;
				while (j>=0 && arr[j]>temp)
				{
					arr[j + 1] = arr[j];
					j--;
				}
				arr[j + 1] = temp;
			}
			sw.Stop();
			Console.WriteLine("Time Taken for sorting in Insertion Sort : " + sw.ElapsedTicks);
			return arr;
		}

		public int[] SelectionSort(int[] arr)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			int n = arr.Length;
			for (int i = 0; i < n-1; i++)
			{
				int min = i;
				for (int j = i+1; j < n; j++)
				{
					if (arr[j]<arr[min])
					{
						min = j;
					}
				}
				if (min!=i)
				{
					int temp = arr[i];
					arr[i] = arr[min];
					arr[min] = temp;
				}
			}
			sw.Stop();
			Console.WriteLine("Time Taken for sorting in Selection Sort : " + sw.ElapsedTicks);
			return arr;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int[] givenArray = new int[] { 7, 9, 3, 5, 0, 2, 10, 1 };
			Sorting sort = new Sorting();
			Console.WriteLine("[{0}]", string.Join(",", sort.BubbleSort(givenArray)));
			Console.WriteLine();
			Console.WriteLine("[{0}]", string.Join(",", sort.InsertionSort(givenArray)));
			Console.WriteLine();
			Console.WriteLine("[{0}]", string.Join(",", sort.SelectionSort(givenArray)));
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
