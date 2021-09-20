using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNesting
{
	//Leet Code source : https://leetcode.com/problems/array-nesting/
	//Level: Medium
	class Program
	{
		public static int arrayNesting(int[] nums)
		{
			bool[] visited = new bool[nums.Length];
			int res = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (!visited[i])
				{
					int start = nums[i], count = 0;
					do
					{
						start = nums[start];
						count++;
						visited[start] = true;
					}
					while (start != nums[i]);
					res = Math.Max(res, count);
				}
			}
			return res;
		}
			public static int ArrayNesting(int[] nums)
		{
			//int[] resultArray = Array.Empty<int>() ;
			List<int> resultArray = new List<int>();
			int count = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				if (i == 0)
				{
					resultArray.Add(nums[i]);
				}
				else
				{
					int temp = nums[resultArray[i - 1]];
					if (!resultArray.Contains(temp))
					{
						resultArray.Add(temp);
					}
					else
					{
						break;
					}
				}
			}
			count = resultArray.Count;

			return count;
		}
		static void Main(string[] args)
		{
			int[] givenArray = {0,2,1};
			//Console.WriteLine("[{1}] : Length of the longest set = {0}", ArrayNesting(givenArray),givenArray);
			Console.WriteLine("[{1}] : Length of the longest set = {0}", arrayNesting(givenArray), givenArray);
			Console.ReadKey();
		}
	}
}
