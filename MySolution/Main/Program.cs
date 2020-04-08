using System;
using MySolution;
using System.Collections.Generic;


namespace MySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Edges
            Edge edgeOne = new Edge("first Edge", "Hello", "Bye");
            
            //create Nodes
            Node nodeOne = new Node("Hello");
            Node nodeTwo = new Node("Bye");
            
            //create graph
            Graph gra = new Graph("myGraph");


            //Add edge and Nodes to the graphs list
            gra.SetEdge(edgeOne);
            gra.SetNode(nodeOne);
            gra.SetNode(nodeTwo);
            Console.WriteLine("the graphs name is: " + gra.GetName());
            Console.WriteLine("the graphs Edges are: " + gra.GetEdges().ToString());
            Console.WriteLine("the Graphs nodes are: " + gra.GetNodes().ToString());




            // create dot file
            // save dot file to filesystem
            // compile the dot file via console with graphviz
        }
    }
}
