using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleString
{
	class Program
	{
		public static string RestoreString(string s, int[] indices)
		{
			string result = string.Empty;
			char[] resultArray = new char[s.Length];
			var givenString = s.ToCharArray();
			int incrementalIndex = 0;

			foreach (int index in indices)
			{
				char str = givenString[incrementalIndex];
				resultArray[index] = str;
				incrementalIndex++;
				
			}
			result = new string(resultArray);
			return result;
		}
		static void Main(string[] args)
		{
			string s = "art";
			int[] indexs = {1,0,2};
			Console.WriteLine(RestoreString(s, indexs));
			Console.ReadKey();
		}
	}
}
