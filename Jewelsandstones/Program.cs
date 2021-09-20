using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewelsandstones
{
	class Program
	{
		public static int CountofJewels(char[] jewels, char[] stonesandjewels)
		{
			int countOfJewels = 0;
			foreach (char item in stonesandjewels)
			{
				if (jewels.Contains(item))
				{
					countOfJewels++;
				}
			}
			return countOfJewels;
		}
		static void Main(string[] args)
		{
			var jewels = "aA".ToCharArray();
			var stones = "aAAbbbb".ToCharArray();
			Console.WriteLine(CountofJewels(jewels, stones).ToString());
			Console.ReadKey();
		}
	}
}
