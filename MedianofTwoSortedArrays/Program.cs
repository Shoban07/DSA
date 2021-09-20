using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianofTwoSortedArrays
{
	class Program
	{
		public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{
			int[] resultArray = nums1.Concat(nums2).ToArray();
			Array.Sort(resultArray);
			double result = 0;
			//foreach (int num in resultArray)
			//{
			//	result += num;
			//}

			//result = result / resultArray.Length;
			if (resultArray.Length%2==0)
			{
				var firstValue = resultArray[(resultArray.Length / 2) - 1];
				var secondValue = resultArray[(resultArray.Length / 2)];
				result = (firstValue + secondValue) / 2.0;
			}
			if (resultArray.Length % 2 != 0)
			{
				result = resultArray[(resultArray.Length / 2)];
			}

			return result;

		}
		static void Main(string[] args)
		{
			int[] front = {1,2};
			int[] back = { 3,4};
			//FindMedianSortedArrays(front, back);
			Console.WriteLine(FindMedianSortedArrays(front, back));
			Console.ReadKey();
		}
	}
}
