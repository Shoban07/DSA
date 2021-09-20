using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleRowKeyBoard
{
	class Program
	{
		public static int CharacterCount(string keys, string word)
		{
			int count = 0;
			var keysArray = keys.ToCharArray();
			var wordArray = word.ToCharArray();
			int initialNow = 0;
			int result = 0;
			foreach (var item in wordArray)
			{
				int indexAt = Array.IndexOf(keysArray,item);
				int difference = initialNow - indexAt;
				if (indexAt!=0)
				{
					count = initialNow + Math.Abs(difference);
					result = count;
				}
				else
				{
					result = count + difference;
				}
				//result = count;
				initialNow = indexAt;
			}
			return result;
		}
		static void Main(string[] args)
		{
			string kys = "pqrstuvwxyzabcdefghijklmno";
			string wrds = "hello";
			Console.WriteLine(CharacterCount(kys, wrds));
			Console.ReadKey();
		}
	}
}
