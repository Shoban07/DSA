using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
	//reference followed
	//https://www.youtube.com/watch?v=yCxV0kBpA6M&list=PL1ZN0H1sYpfLsEWZ0WxoVcBqi3sIR0SXX&index=2&t=87s
	public class InsertionSort
	{
		public int[] InsertSort(int[] arr)
		{
			int n = arr.Length;
			//outer loop for iterating the elements in the unsorted sublist
			//intializes with 1, as the 0th index elemet was considered as sorted sublist

			for (int i =1;i<n;i++) // moves from right to left [us1->us2]
			{
				//declare temp variable to which holds elemet from unsorted sub list every time
				int temp = arr[i];
				int j = i - 1; // initilizing the inner with i-1 as the inner loop starts from 0th index and has decrement phase for comparison

				// if j >= 0 and element in array and jth index > temp value, then right shift the jth element index value [i.e to the next index where temp value was previously there]
				while(j>=0&&arr[j]>temp)
				{
					arr[j + 1] = arr[j]; //right shift
					j--; //decrementing the sorted sublist

					//if the temp value was lesser than the element at sorted sub list,
					//then it moves for comparison with the next element in the sorted sub list. it moves from right to left [s1<-s2] 
				}
				//when jth index becomes lesser than zero or arr[j] < temp 
				//[i.e when the sorted sub list reacjes the 0th index or when temp becomes greater than the current element at jth index ]
				//then
				arr[j + 1] = temp; // place the temp, as it ideally reaches the right position a[j+1] in the sorted array

				//and now the for loop breaks
			}
			return arr;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			//sample output
			int[] givenArray = new int[] { 5,4,5,1,6,2};
			InsertionSort ins = new InsertionSort();
			Console.WriteLine("[{0}]", string.Join(",", ins.InsertSort(givenArray)));
			Console.ReadKey();

		}
	}
}
