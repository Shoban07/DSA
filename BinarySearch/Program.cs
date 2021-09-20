using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
	class Program
	{
		public int BinarySearch(int[] a, int x)
		{
			int p = 0;
			int r = a.Length - 1;

			while (p<=r)
			{
				int q = (p + r) / 2;

				if (x < a[q])
				{
					r = q - 1;
				}
				else if (x > a[q])
				{
					p = q + 1;
				}
				else return q;
				}
			return -1;
		}

		static void Main(string[] args)
		{
			int[] a = { 1, 4, 5, 6, 73 };
			int toFind = 5;
			Program bs = new Program();

			Console.WriteLine(a[bs.BinarySearch(a, toFind)]+" is at the index {0}",bs.BinarySearch(a, toFind));
			Console.ReadKey();
		}

	}
		
	}

