using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketProblem2
{
	class Program
	{

		public static bool IsValid(string s)
		{
			char? top = null;
			bool result = false;
			Stack<char> braceStack = new Stack<char>();
			foreach (char bracket in s.ToArray())
			{
				if (bracket.ToString().Equals("(") || bracket.ToString().Equals("[") || bracket.ToString().Equals("{"))
				{
					braceStack.Push(bracket);
					top = bracket;
				}
				//else if (bracket.ToString().Equals("["))
				//{
				//	braceStack.Push(bracket);
				//	top = bracket;
				//}
				//else if (bracket.ToString().Equals("{"))
				//{
				//	braceStack.Push(bracket);
				//	top = bracket;
				//}
				else if (bracket.ToString().Equals(")"))
				{

					if ("(".Equals(braceStack.Pop().ToString()))
					{
						if (braceStack.Count == 0)
						{
							result = true;
						}
					}
					else
					{
						braceStack.Push(bracket);
						top = bracket;
					}
				}
				else if (bracket.ToString().Equals("]"))
				{
					if ("[".Equals(braceStack.Pop().ToString()))
					{
						if (braceStack.Count == 0)
						{
							result = true;
						}
					}
					else
					{
						braceStack.Push(bracket);
						top = bracket;
					}
				}
				else if (bracket.ToString().Equals("}"))
				{
					if ("{".Equals(braceStack.Pop().ToString()))
					{
						if (braceStack.Count == 0)
						{
							result = true;
						}
					}
				}
			}
			return result;
		}
		static void Main(string[] args)
		{
			List<string> mylistBrackets = new List<string> { "()", "()[]{}", "(]", "([)]", "{[]}" };
			foreach (var list in mylistBrackets)
			{
				Console.WriteLine(IsValid(list));
			}
			//string mybrackets = "(]";
			//Console.WriteLine(IsValid(mybrackets));
			Console.ReadKey();

		}
	}
}
