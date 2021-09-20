using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrictlyIncreasingArray
{
	class Program
	{
		public static bool CanBeIncreasing(int[] nums)
		{
			bool result = false;
			int compare = 0;
			int length = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				List<int> tmpArray = new List<int>(nums);
				tmpArray.RemoveAt(i);
				//tmpArray.Sort();
				foreach (int num in tmpArray.ToArray())
				{
					if (num > compare)
					{
						compare = num;
						length++;
						if (length == tmpArray.Count)
						{
							result = true;
						}
					}
				}
				compare = 0;
				length = 0;
			}
			return result;
		}
		static void Main(string[] args)
		{
			int[] nums = { 1, 2, 10, 5, 7 };
			Console.WriteLine(CanBeIncreasing(nums).ToString());
			Console.ReadKey();

		}
	}
}
