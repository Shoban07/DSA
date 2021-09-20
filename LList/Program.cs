using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LList
{
	class Program
	{
		public class ListNode
		{
	     public int val;
		 public ListNode next;
			public ListNode(int val = 0, ListNode next = null)
			{
					this.val = val;
					this.next = next;
			}
 		}
		public static char[] AddTwoNumbers(int[] l1, int[] l2)
		{
			var l1_toarray = l1.ToArray();
			var l2_toarray = l2.ToArray();
			string l1String = string.Empty;
			string l2String = string.Empty;
			foreach (var num in l1_toarray)
			{
				l1String += num.ToString();
			}
			foreach (var num in l2_toarray)
			{
				l2String += num.ToString();
			}
			int l1batch;
			int.TryParse(l1String, out l1batch);
			int l2batch;
			int.TryParse(l2String, out l2batch);
			int l3batch = l1batch + l2batch;
			//string l3String = l3batch.ToString();
			var l3_toarray = l3batch.ToString().ToCharArray();
			Array.Reverse(l3_toarray);
			return l3_toarray;
		}
		static void Main(string[] args)
		{
			int[] num1 = { 2, 4, 3 };
			int[] num2 = { 5, 6, 4 };
			Console.WriteLine(AddTwoNumbers(num1, num2));
			Console.ReadKey();
		}
	}
}
