using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalParser
{
	class Program
	{
		public static string GoalParser2(string command)
		{
			string result = command;

			if (command.Contains("()") || command.Contains("(al)"))
			{
				result = command.Replace("()", "o");
				result = result.Replace("(al)", "al");
			}
			return result;
		}
		public static string GaolParser(string command)
		{
			string result = command;

			if (command.Contains("()"))
			{
				result = command.Replace("()", "o");
			}
			if (command.Contains("(al)"))
			{
				result = result.Replace("(al)", "al");
			}
			return result;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(GaolParser("G()()()(al)"));
			Console.WriteLine(GoalParser2("G()()()(al)"));
			Console.WriteLine(GoalParser2("G()(al)"));
			Console.WriteLine(GoalParser2("G!()!()!()!(al)!!!!!!!)("));
			Console.ReadKey();
		}
	}
}
