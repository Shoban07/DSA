using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
	class Program
	{
		public static int reverse(int x) //x = 123
		{
			int rev = 0; //0 //3 // 32 //321
			while (x != 0) //123!=0 //12!=0 // 1!=0
			{
				int pop = x % 10; //pop = 123 % 10 = 3 // 12%10 = 2 // 1%10 = 1
				x /= 10; //x = 123/10 = 12 // x = 12 /10 = 1 // 1/10 = 0
				if (rev > int.MaxValue / 10 || (rev == int.MaxValue / 10 && pop > 7)) return 0;
				if (rev < int.MinValue / 10 || (rev == int.MinValue / 10 && pop < -8)) return 0;
				rev = rev * 10 + pop; //0*10+3 = rev = 3 // 3*10 + 2 = 32 // 30*10 + 2 = 321 
			}
			return rev;
		}
		public static int Reverse(int x)
		{
			int result = 0;
			string reversedFirst = string.Empty;
			int neutralisedInt = Math.Abs(x);
			char[] reversedTo = neutralisedInt.ToString().ToArray();
			Array.Reverse(reversedTo);
			reversedFirst = new string(reversedTo);

			if (reversedTo.Length>=1)
			{
				if (reversedTo[0] == '0')
				{
					reversedFirst = reversedFirst.Trim('0');
				}	
			}
			else
			{
				reversedFirst = "0";
			}
			if (x<0)
			{
				reversedFirst = "-" + reversedFirst;
			}
			

			return result = Int32.Parse(reversedFirst);
		}
		static void Main(string[] args)
		{
			int input = -123;
			Console.WriteLine(reverse(input));
			Console.ReadKey();
		}
	}
}
