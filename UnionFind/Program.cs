using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
	public class UnionFind
	{
		//Tracks the number of elements in the union find
		private int size;
		// Tracks the size of each components
		private int[] sz;
		//id[i] points to the parent of i, if id[i] = i, then i is a root node
		private int[] id;
		//Tracks the number of components in the union find
		private int numComponents;

		public UnionFind(int size)
		{
			if (size <= 0)
			{
				Console.WriteLine("Size should be greater than zero");
			}
			this.size = numComponents = size;
			sz = new int[size];
			id = new int[size];

			for (int i = 0; i < size; i++)
			{
				//initially each component has one element itself parent to themselves
				//Link to itself (self root)
				id[i] = i;
				//intially size of each component is one
				sz[i] = 1; 
			}

		}

		public int Find(int p)
		{
			//Find the root of the component or set
			int root = p;
			while (root !=id[root])
			  root = id[root];

			//Once root is found compress the path leading back to the root
			//Doing this operation is called 'Path Compression'
			//and this gives us amortized time constant.
			while (p!=root)
			{
				int next = id[p];
				id[p] = root;
				p = next;
			}

			return root;
		}
		//Returns whether P and Q are in same component / set
		public bool IsConnected(int p, int q)
		{
			return Find(p) == Find(q);
		}

		//returns the size of component passed 
		public int ComponentSize(int p)
		{
			return sz[Find(p)];
		}

		//return the number of elements in the Union Find / Disjoint sets
		public int Size()
		{
			return size;
		}

		//returns the number of remaining components/sets
		public int Components()
		{
			return numComponents;
		}

		//unifies the passed 2 components
		public void Unify(int p, int q)
		{
			int root1 = Find(p);
			int root2 = Find(q);

			//if both the elements belongs to same root then do nothing and return
			if (root1 == root2) return;

			//now merge two components together
			//Merge smaller components with lesser childs into larger components with large number of child
			if (sz[root1] < sz[root2])
			{
				sz[root2] += sz[root1]; // element at root2 + element at root1, then gets stored into root2 index of sz array
				id[root1] = root2;
			}
			else
			{
				sz[root1] += sz[root2];
				id[root2] = root1;
			}

			//whenever two components if merged then need to reduce the components size
			numComponents--;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			UnionFind uf = new UnionFind(5);
			uf.Size();
			uf.Unify(0, 1);
			uf.Unify(2, 3);
			uf.Unify(3, 4);
			Console.WriteLine("Is 1 and 2 components were connected ? : {0}", uf.IsConnected(1, 4).ToString());
			Console.WriteLine(uf.ComponentSize(0));
			Console.WriteLine(uf.ComponentSize(1));
			Console.WriteLine(uf.ComponentSize(2));
			Console.WriteLine(uf.ComponentSize(3));
			Console.WriteLine(uf.ComponentSize(4));

			Console.WriteLine("Root element of 2 : {0}",uf.Find(2));
			Console.ReadKey();

			uf.Unify(3, 2);
			uf.Unify(0, 2);
			Console.WriteLine("Is 1 and 2 components were connected ? : {0}",uf.IsConnected(1, 4).ToString());
			Console.WriteLine(uf.ComponentSize(4));
			Console.WriteLine(uf.Components());
			Console.ReadKey();

			//MyUnionFind
			MyUnionFind muf = new MyUnionFind(3);
		}
	}
}
