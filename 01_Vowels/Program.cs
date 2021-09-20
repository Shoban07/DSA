using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Vowels
{
	class Program
	{
		public string RemoveVowelsFromString(char[] s,char[] vowels)
		{
			string res = string.Empty;
			foreach (var item in s)
			{
				if (!vowels.Contains(item))
				{
					res += item.ToString();
				}
			}
			return res;
		}

		static void Main(string[] args)
		{
			char[] vowels = {'a','e','i','o','u'};
			string sampleString = "SampleTestofIQ";
			char[] playChars = sampleString.ToLower().ToCharArray();
			string result = string.Empty;
			Program pgm = new Program();
			Console.WriteLine(pgm.RemoveVowelsFromString(playChars,vowels));
			Console.ReadKey();
		}
	}
}
