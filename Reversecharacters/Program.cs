using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversecharacters
{
	class Program
	{
		public static int[] RunningSum(int[] nums)
		{
			List<int> result = new List<int>();
			int addtwonums = 0;
			foreach (int num in nums)
			{
				addtwonums += num;
				result.Add(addtwonums);
			}
			return result.ToArray();
		}
		public static int[] GetConcatenation(int[] nums)
		{
			
			int[] arrayString = nums.ToArray();
			int[] duparrayString = nums.ToArray();
			int[] combined = arrayString.Concat(duparrayString).ToArray();
			return combined;
		}
		static void Main(string[] args)
		{
			string bracketString = "[";
			int[] gapArray = { 1,2,3};
			char[] myBracketsChar = bracketString.ToCharArray();
			Array.Reverse(myBracketsChar);
			Console.WriteLine(myBracketsChar);
			GetConcatenation(gapArray);
			RunningSum(gapArray);
			Console.ReadKey();
		}
	}
}
