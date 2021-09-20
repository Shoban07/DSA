using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
	// reference link followed
	//https://www.youtube.com/watch?v=o4bAoo_gFBU&list=PL1ZN0H1sYpfLsEWZ0WxoVcBqi3sIR0SXX&index=1
	public class BubbleSort
	{
		//generalMethod
		public int[] BubleSort(int[] arr, Stopwatch stopWatch)
		{
			stopWatch.Reset();
			stopWatch.Start();
			int n = arr.Length; //size of the array
			for (int i = 0; i < n-1; i++)//outer loop that runs the passes
			{
				for (int j = 0; j < n-1; j++)//inner loop that runs the comparisons
				{
					if (arr[j]>arr[j+1])// if the element at j'th position is greater than the element at j+1'th position ; Then swap arr[j] and a[j+1]
					{
						int temp = arr[j]; //storing the element going to be swapped in the temp variables
						arr[j] = arr[j + 1]; // swap 
						arr[j + 1] = temp; // swap with temp
					}
				}
			}
			stopWatch.Stop();
			Console.WriteLine("Elapsed Time is {0} ms", stopWatch.ElapsedTicks);
			return arr;
		}

		//in general after each pass we have one element which is the largest element placed at their correct position
		//Hence the comparison of last element in the array was not necessary and can be avoided
		//optimized the unwanted comparison swap check after sorting.
		public int[] ComparisonSwapOptimizedBubleSort(int[] arr, Stopwatch stopWatch)
		{
			stopWatch.Reset();
			stopWatch.Start();
			int n = arr.Length; //n is the size of the array  /no of elements in the given array
			for (int i = 0; i < n - 1; i++)//outer loop to track the passes
			{
				//here as we no the unwanted comparison was related to the passes count.
				//as we know for each pass the unwanted comparison gets reduces as the elements are getting sorted in position
				//thus the comparison can be restricted as j<n-1-i => here we know n-1 is loop runs comparison but n-1-i restricts the unwanted comparisons
				//hence
				for (int j = 0; j < n-1-i; j++)
				{
					if (arr[j]>arr[j+1])// if the element at j'th position is greater than the element at j+1'th position ; Then swap arr[j] and a[j+1]
					{
						int temp = arr[j]; //storing the element going to be swapped in the temp variables
						arr[j] = arr[j + 1]; // swap 
						arr[j + 1] = temp; // swap with temp
					}
				}
			}
			stopWatch.Stop();
			Console.WriteLine("Elapsed Time is {0} ms", stopWatch.ElapsedTicks);
			return arr;
		}

		//We have optimized our algorithm in way to restrict the unwanted comparison swap checks
		//In case if we have a semi sorted array to be sorted.
		//In this situation we have passes run thru for n-1 times.
		//But our case don't require unwanted passes to occur.
		//Hence we have to set flag for comparison tracking. => if comparison was done and elements were swapped. Then, allow the next pass to occur.
		// if no comparison swap was occurred. Then , stop the passes run thru.
		//By doing this we can have semi sorted array to a sorted array with less number of execution of passes and comparison [i.e., more optimized one]
		public int[] PassesOptimizedBubleSort(int[] arr, Stopwatch stopWatch)
		{
			stopWatch.Reset();
			stopWatch.Start();
			int flag;
			int n = arr.Length;//n is the size of the array  /no of elements in the given array
			for (int i = 0; i < n - 1; i++)//outer loop to track the passes
			{
				//here we have a flag to check if comparison was happened in the inner loop or not
				flag = 0; 

				//here as we no the unwanted comparison was related to the passes count.
				//as we know for each pass the unwanted comparison gets reduces as the elements are getting sorted in position
				//thus the comparison can be restricted as j<n-1-i => here we know n-1 is loop runs comparison but n-1-i restricts the unwanted comparisons
				//hence
				for(int j=0;j<n-1-i;j++)
				{
					if (arr[j] > arr[j + 1])// if the element at j'th position is greater than the element at j+1'th position ; Then swap arr[j] and a[j+1]
					{
						int temp = arr[j]; //storing the element going to be swapped in the temp variables
						arr[j] = arr[j + 1]; // swap 
						arr[j + 1] = temp; // swap with temp

						//set flag = 1 -> to signal that comparison has happenned in the current pass
						flag = 1;
					}
				}
				if (flag == 0)//if no comparison happen on the current flag then it means array was sorted. Hence we can stop the passes
				{
					break;
				}
			}
			stopWatch.Stop();
			Console.WriteLine("Elapsed Time is {0} ms", stopWatch.ElapsedTicks);
			return arr;
		}

	}
	class Program
	{
		static void Main(string[] args)
		{
			//stop watch to calculate elapsed time for each method to see the optimizationin live
			Stopwatch stopWatch = new Stopwatch();
			BubbleSort bubbleSort = new BubbleSort();
			int[] givenArray = new int[] { 16, 15, 6, 8, 5,5,78,90,124,1262,1812,12,18,89,73,65,100,176,194,254,78543, 16, 15, 6, 8, 5, 5, 78, 90, 124, 1262, 1812, 12, 18, 89, 73, 65, 100, 176, 194, 254, 78543 };

			//Bubble sort without optimization
			Console.WriteLine("[{0}]",string.Join(",",bubbleSort.BubleSort(givenArray,stopWatch)));
			Console.WriteLine();
			Console.ReadKey();

			//Bubble sort with comparison loop optimized
			Console.WriteLine("[{0}]", string.Join(",", bubbleSort.ComparisonSwapOptimizedBubleSort(givenArray,stopWatch)));
			Console.WriteLine();
			Console.ReadKey();

			//Bubble sort with comparison loop and passes loop optimized
			Console.WriteLine("[{0}]", string.Join(",", bubbleSort.PassesOptimizedBubleSort(givenArray,stopWatch)));
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
