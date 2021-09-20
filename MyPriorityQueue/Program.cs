using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPriorityQueue
{
	public class PriorityQueue<T> where T : IComparable<T>
	{
		private List<T> data;
		
		public PriorityQueue()
		{
			this.data = new List<T>();
		}

		public void Enqueue(T item)
		{
			data.Add(item);
			int ci = data.Count - 1; // child index; start at end
			while (ci > 0)
			{
				int pi = (ci - 1) / 2; // parent index
				if (data[ci].CompareTo(data[pi]) >= 0) break; // child item is larger than (or equal) parent so we're done
				//storing the current child data in tmp
				T tmp = data[ci];
				//swapping the child to parent
				//storing the parent current data into child 
				data[ci] = data[pi];
				//storing the temp from child data into parent data 
				data[pi] = tmp;
				//swapped the nodes
				//now swapping the indexes, hence when new node enters it enters into the child node
				ci = pi;
			}
		}

		public T Dequeue()
		{
			// assumes pq is not empty; up to calling code
			int li = data.Count - 1; // last index (before removal)
			T frontItem = data[0];   // fetch the front
			data[0] = data[li];
			data.RemoveAt(li);

			--li; // last index (after removal)//--li = 2-1 => becomes 1 now
			int pi = 0; // parent index. start at front of pq
			while (true)
			{
				int ci = pi * 2 + 1; // left child index of parent
				if (ci > li) break;  // no children so done
				int rc = ci + 1;     // right child
				if (rc <= li && data[rc].CompareTo(data[ci]) < 0) // if there is a rc (ci + 1), and it is smaller than left child, use the rc instead
					ci = rc;
				if (data[pi].CompareTo(data[ci]) <= 0) break; // parent is smaller than (or equal to) smallest child so done
				T tmp = data[pi];
				data[pi] = data[ci];
				data[ci] = tmp; // swap parent and child
				pi = ci;
			}
			return frontItem;
		}

		public T Peek()
		{
			T frontItem = data[0];
			return frontItem;
		}

		public int Count()
		{
			return data.Count;
		}

		public override string ToString()
		{
			string s = "";
			for (int i = 0; i < data.Count; ++i)
				s += data[i].ToString() + " ";
			s += "count = " + data.Count;
			return s;
		}

		public bool IsConsistent()
		{
			// is the heap property true for all data?
			if (data.Count == 0) return true;
			int li = data.Count - 1; // last index
			for (int pi = 0; pi < data.Count; ++pi) // each parent index
			{
				int lci = 2 * pi + 1; // left child index
				int rci = 2 * pi + 2; // right child index

				if (lci <= li && data[pi].CompareTo(data[lci]) > 0) return false; // if lc exists and it's greater than parent then bad.
				if (rci <= li && data[pi].CompareTo(data[rci]) > 0) return false; // check the right child too.
			}
			return true; // passed all checks
		} // IsConsistent
	} // PriorityQueue
// ns
class Program
	{
		
		static void Main(string[] args)
		{
			PriorityQueue<int> myPq = new PriorityQueue<int>();
			myPq.Enqueue(10);
			myPq.Enqueue(8);
			myPq.Enqueue(7);
			myPq.Dequeue();
			Console.WriteLine(myPq.IsConsistent());
			Console.ReadKey();
			Console.ReadKey();
		}
	}
}
