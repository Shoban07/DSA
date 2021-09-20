using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSA.LinkedList;

namespace DSA
{
	public class Program
	{
		public  void Display(LinkedList<string> listofString, string sentence)
		{
			string greet = sentence + " !, ";
			foreach (string word in listofString)
			{
				greet += word.ToString()+" ";
			}
			Console.WriteLine(greet);
		}

		static void Main(string[] args)
		{
			//#region LinkedList
			//Program pgm = new Program();
			//SinglyLinkedList sl = new SinglyLinkedList();
			//sl.insertFirst(100);
			//sl.insertFirst(99);
			//sl.insertFirst(10);
			//sl.insertFirst(89);
			//sl.insertLast(10001);
			//sl.displayList();
			//Console.ReadKey();

			//Console.WriteLine("After Deletion of first node");
			//sl.deleteFirst();
			//sl.displayList();
			//Console.ReadKey();

			

			//string[] words = { "Hai", "Shoban", "Hello", "From", "Programming", "World"};
			//LinkedList<string> myls = new LinkedList<string>(words);
			//pgm.Display(myls, "Hello There");
			////Console.WriteLine(myls);
			//Console.ReadKey();
			//#endregion

			#region Hash map / Dictionary
			//Problem to calculate sum of two numers = 9
			//array [] = {2,7,11,15};
			int[] numbers = { 2, 7, 11, 15 };
			int target = 9;
			twoSumMethod(numbers, target);
			#endregion

		}

		private static void twoSumMethod(int[] numbers, int target)
		{
			#region usingTuple
			Dictionary<int, int> twoSum = new Dictionary<int, int>();
			string resultString = string.Empty;
			for (int i = 0; i < numbers.Length; i++)
			{
				int complement = target - numbers[i];
				int complementIndex = Array.IndexOf(numbers, complement);
				if (complementIndex!=-1 && complementIndex!=i)
				{
					twoSum.Add(i, numbers[i]);
				}

			}
			List<int> keys = twoSum.Keys.ToList();
			resultString = "[" + string.Join(",", keys) + "]";
			Console.WriteLine(resultString);
			Console.ReadKey();
			#endregion

			//string resultString = string.Empty;
			//Dictionary<int, int> twoSum = new Dictionary<int, int>();
			//for (int i = 0; i < numbers.Length; i++)
			//{

			//	//int val;
			//	int arrayvalue = numbers[i];

			//	//twoSum.TryGetValue(arrayvalue, out val);
			//	int res = target - arrayvalue;
			//	if (!twoSum.ContainsValue(res))
			//	{
			//		twoSum.Add(i, numbers[i]);
			//	}
			//	else
			//	{
			//		twoSum.Add(i, numbers[i]);
			//		List<int> keys = twoSum.Keys.ToList();
			//		resultString = "[" + string.Join(",", keys) + "]";
			//		Console.WriteLine(resultString);
			//	}
			//}
			//Console.ReadKey();
		}
	}
}
