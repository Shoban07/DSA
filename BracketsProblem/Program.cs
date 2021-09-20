using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsProblem
{
	class Program
	{
		public static int MaxDepth(string s)
		{
			int max = 0;
			int res = 0;
			int openBraceCount = 0;
			int closedBraceCount = 0;
			char[] myArray = s.ToArray();
			foreach (char letter in myArray)
			{
				if (letter.ToString().Equals("("))
					openBraceCount++;
				else if (letter.ToString().Equals(")"))
					closedBraceCount++;
				res = openBraceCount - closedBraceCount;
				if (res > max)
				{
					max = res;
				}

			}
			return max;
		}
		public static int OptimizedMaxDepth(string s)
		{
			int max = 0;
			int res = 0;
			foreach (var item in s.ToArray())
			{
				if (item.ToString().Equals("("))
				{
					res++;
				}
				else if(item.ToString().Equals(")"))
				{
					res--;
				}
				if (res>max)
				{
					max = res;
				}
			}
			return max;
		}
		static void Main(string[] args)
		{
			string input = "(1+(2*3)+((8)/4))+1";
			Console.WriteLine(MaxDepth(input));
			Console.WriteLine(OptimizedMaxDepth(input));
			Console.ReadKey();
			Stack<char> mystack = new Stack<char>();
			mystack.Pop().ToString();
		}
	}
}
