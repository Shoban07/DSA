using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerWithMostWater
{
	class Program
	{
		public static int MaxArea2(int[] nums)
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

		public static int MaxArea(int[] height)
		{
			int left = 0;
			int right = height.Length - 1;
			int maxArea = 0;
			while (left<right)
			{
				maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));
				if (height[left]<height[right])
				{
					left++;
				}
				else
				{
					right--;
				}
			}
			return maxArea;
		}
		static void Main(string[] args)
		{
			int[] input = new int[] { 1,8,6,2,5,4,8,3,7};
			Console.WriteLine("Max area of given container {0}", MaxArea(input).ToString());
			Console.ReadKey();
		}
	}
}
