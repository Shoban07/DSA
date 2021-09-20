using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
	public class SelectionSort
	{
		public int[] selectionSort(int[] arr)
		{
			int n = arr.Length; // returns the length of the array

			//following for loop tracks the passes count
			for (int i = 0; i < n-1; i++)
			{
				// intially the minimum element was the first element in the array we consider. 
				//but after the each outer for loop run, initial minimum elemet index shifted to next element. 
				int min = i;

				//inner loop tracks the finding of smallest element from the unsorted sub array 
				//and changes the current minimum element index with the smallest element's index found
				for (int j = i+1; j < n; j++) // i+1 is for comparing the elements each time i = 0 the a[j]<a[min] then swap
				{
					if (arr[j] < arr[min])//compare the elements and find the smallest of all in the unsorted array 
					{
						min = j;
					}
				}
				if (min!=i)// if the intial index i was not equal to the current min index then swap them swap(a[i],a[min])
				{
					int temp = arr[i]; // temp stores the first declared smallest element value
					arr[i] = arr[min]; // then the current minimum element is swapped with the first element of unsorted array which is also the first decalred smlled value
					arr[min] = temp; //swap  the min inde of array with the temp value stored
				}
			}
			return arr;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			int[] givenArray = new int[] { 7,4,3,10,8,3,1};
			SelectionSort ssort = new SelectionSort();
			Console.WriteLine("[{0}]", string.Join(",", ssort.selectionSort(givenArray)));
			Console.ReadKey();
		}
	}
}
