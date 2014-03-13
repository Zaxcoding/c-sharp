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
		static Random rng = new Random();

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
					char [] splitOn = new char[10];
					splitOn[0] = ' ';
					splitOn[1] = ',';
					splitOn[2] = '.';
					splitOn[3] = '-';
					splitOn[4] = ';';
					splitOn[5] = ':';
					splitOn[6] = '!';
					splitOn[7] = '?';
					splitOn[8] = '\n';
					splitOn[9] = '\t';

					postSplit = line.Split(splitOn);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
			}

			Graph theGraph = new Graph ();

			for (int i = 0; i < postSplit.Length - 1; i++) {
				String temp = postSplit [i].ToLower();
				String temp2 = postSplit [i + 1].ToLower();

				theGraph.AddNode (temp);
				theGraph.AddNode (temp2);
		
				theGraph.AddEdge (temp, temp2);
			}
		
			//		theGraph.PrintAllEdges ();

			theGraph.Traverse (theGraph.GetVert (rng.Next () % theGraph.NumVerts ()));
		}


	}

	class Graph 
	{

		Random rng = new Random();

		List<String> verts;
		List<List<String>> edges;


		public Graph(List<String> nodes) {
			verts = nodes;
			edges = new List<List<String>> ();
		}

		public Graph() {
			verts = new List<String> ();
			edges = new List<List<String>>();
		}

		public int NumVerts() {
			return verts.Count;
		}

		public String GetVert(int i) {
			return verts [i];
		}

		public void AddNode(String n) {

			if (!verts.Contains (n)) {
				verts.Add (n);
				//			Console.WriteLine ("Adding {0}", n.ToString ());
				edges.Add (new List<String> ());
			}
		}

		public void AddEdge(String nodeFrom, String nodeTo) {
			//			Console.WriteLine ("Index of from: {0}, index of to: {1}", verts.IndexOf (nodeFrom), verts.IndexOf (nodeTo));
			edges [verts.IndexOf(nodeFrom)].Add (nodeTo);
		}

		public void PrintAllEdges() {
			for (int i = 0; i < edges.Count; i++) {
				Console.Write ("Start node: {0} --> ", verts [i]);
				for (int j = 0; j < edges [i].Count; j++) {
					Console.Write (" {0},", edges [i] [j]);
				}
				Console.WriteLine ();
			}
		}

		public void Traverse(String n) {
			Console.Write (" {0}", n);
			if (edges [verts.IndexOf (n)].Count == 1) {
				Traverse (verts [rng.Next () % verts.Count]);
			} else {
				int temp = rng.Next () % edges [verts.IndexOf (n)].Count;
				Traverse (edges [verts.IndexOf (n)] [temp]);
			}
		}

	}
}
