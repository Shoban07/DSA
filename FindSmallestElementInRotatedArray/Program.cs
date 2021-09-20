using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSmallestElementInRotatedArray
{
	class Program
	{
		public int FindMin(int[] nums)
		{
			if (nums == null || nums.Length == 0) return 0;
			if (nums.Length == 1) return nums[0];
			if (nums.Length == 2) return Math.Min(nums[0], nums[1]);

			int left = 0;
			int right = nums.Length - 1;
			int min = nums[0];

			while (left <= right)
			{
				min = Math.Min(min, Math.Min(nums[left], nums[right]));

				if (nums[right] > nums[left])
					break;

				left++;
				right--;
			}

			return min;

		}
		static void Main(string[] args)
		{
		}
	}
}
