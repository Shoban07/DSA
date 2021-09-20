using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingString
{
	class Program
	{
		public static string ReverseStr(string s, int k)
		{
			string result = string.Empty;
			char[] input = s.ToArray();
			if (s.Length>2*k)
			{
				string res1 = string.Empty;
			}
			else
			{
				for (int i = 0; i < k; i++)
				{
					result = input[i] + result;
				}
				result += s.Substring(k);
			}
			return result;
		}
		static void Main(string[] args)
		{
			Dictionary<int, string> _rollNumberNames = new Dictionary<int, string>();
			_rollNumberNames[1] = "Arun";
			_rollNumberNames[2] = "Balaji";
			_rollNumberNames[3] = "Citizen";
			_rollNumberNames[4] = "Danny";
			_rollNumberNames[5] = "Fidget";

			Console.WriteLine(ReverseStr("abcdefg", 3));
			Console.ReadKey();
		}
	}
}
