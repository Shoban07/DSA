using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
	class MyUnionFind
	{
		//To keep track of the size of the components
		private int size;
		//To keep track of the components
		private int[] id;
		//To keep track of size of each components
		private int[] sz;
		//To keep track of number of components seperately for live results
		//as whenever unify occurs the count of seperate component reduces
		private int numComponents;
		//intilization of Union Find
		public MyUnionFind(int size)
		{
			if (size<=1)
			{
				Console.WriteLine("Size cannot be lesser than 1");
			}
			this.size = numComponents = size;
			id = new int[size];
			sz = new int[size];

			for (int i = 0; i < size; i++)
			{
				//initially all the elements / components are root to itself and are disjoint to each other
				id[i] = i;
				//initially the size of each component is one, as everything has only one element under them
				sz[i] = 1;
			}
		}

		public int Find(int p)
		{
			int root = p;
			//iterate till reaching the root element for the 'p' element
			while (root != id[root])
				root = id[root];

			//compress the path between the element in search to thier respective root node as found above 
			while (p!=root)//compress untill reaching root node
			{
				//set the next with value in the current 'p'
				int next = id[p];
				//set the id[p] to current root
				id[p] = root;
				//set p to next;
				p = next;

				//repeats untill p becomes the root.
			}
			return root;
		}

		//checks whether the passed two elements were connected or not
		public bool IsConnected(int p, int q)
		{
			return Find(p) == Find(q);
		}

		//Returns the size of the components for passed 'p'
		public int Size(int p)
		{
			return sz[Find(p)];
		}
		//returns the number of components as bijection or disjoint
		public int ComponentsLeft()
		{
			return numComponents;
		}

		//unifies the passed two components
		public void Unify(int p, int q)
		{
			//returns the root of 'p'
			int root1 = Find(p);
			//returns the root of 'q'
			int root2 = Find(q);

			//if element 'p' and 'q' belongs to same root element then no need to unify
			if (root1 == root2) return;

			//if the components present in p's root is lesser than q's root
			if (sz[root1]<sz[root2])
			{
				//then map p's component to root of q's
				sz[root2] += sz[root1]; //adds the count increase in q's component count
				id[root1] = root2; // maps the p's element to root of q's
			}
			//if the components present in p's root is greater than q's root
			else
			{
				//then map q's component to root of p's
				sz[root1] += sz[root2]; // adds the count increase in p's component
				id[root2] = root1; //maps the q's element to the root of p's
			}

			//after each unify reduce the component count
			numComponents--;
		}
	}
}
 