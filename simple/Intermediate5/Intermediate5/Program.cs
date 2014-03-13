/* 
Write a program that automatically generates essays for you.
Using a sample text, create a directed (multi-)graph where the words of a text are nodes and there is a directed edge between u and v if u is followed by v in your sample text. Multiple occurrences lead to multiple edges.
Do a random walk on this graph: Starting from an arbitrary node choose a random successor. If no successor exists, choose another random node.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Intermediate5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Which txt file would you like for input?");
			String fileName = Console.ReadLine ();

			String[] postSplit = new String[1];
		
			try
			{
				using (StreamReader sr = new StreamReader(fileName))
				{
					String line = sr.ReadToEnd();
					postSplit = line.Split(' ');
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
			}

			Graph theGraph = new Graph ();

			for (int i = 0; i < postSplit.Length - 1; i++) {
				Node temp = new Node (postSplit [i]);
				Node temp2 = new Node (postSplit [i + 1]);

				theGraph.AddNode (temp);
				theGraph.AddNode (temp2);
		
				theGraph.AddEdge (temp, temp2);
			}
		
			theGraph.PrintAllEdges ();
		}


	}

	class Node 
	{
		String text;

		public Node (String s) {
			text = s;
		}
	}

	class Graph 
	{
		List<Node> verts;
		Dictionary<Node, Node> edges;

		public Graph(List<Node> nodes) {
			verts = nodes;
		}

		public Graph() {
			verts = new List<Node> ();
			edges = new Dictionary<Node, Node> ();
		}

		public void AddNode(Node n) {
			if (!verts.Contains (n)) {
				verts.Add (n);
			}
		}

		public void AddEdge(Node f, Node t) {
			edges.Add (f, t);
		}

		public void PrintAllEdges() {
			Console.WriteLine(edges.Values.ToString ());
		}

	}
}
