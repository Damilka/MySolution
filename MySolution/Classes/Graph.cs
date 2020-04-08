using System.Collections.Generic;

namespace MySolution
{
    public class Graph
    {

        private string graphName;
        private List<Node> graphNodes;
        private List<Edge> graphEdges;

        //, Node node, Edge edge
        public Graph(string gName)
        {
            graphName = gName;
            graphNodes = new List<Node>();
            graphEdges = new List<Edge>();

        }

        public string GetName()
        {
            return graphName;
        }

        public List<Node> GetNodes()
        {
            return graphNodes;
        }

        public void SetNode(Node node)
        {
            graphNodes.Add(node);
        }

        public List<Edge> GetEdges()
        {
            return graphEdges;
        }
        public void SetEdge(Edge edge)
        {
            graphEdges.Add(edge);
        }

    }

    public struct Node
    {

        private string nodeName;
        //string shape;
        //string fillColor;
        //string fontColor;
        //string color;
        //string style;
        //double[] size;


        public Node(string nName)
        {
            this.nodeName = nName;
        }
    }

    public struct Edge
    {

        private string edgeName;
        private string fromNode;
        private string toNode;
        //string arrowHead;
        //string arrowTail;
        //string color;
        //string fontColor;


        public Edge(string eName, string from, string to)
        {
            edgeName = eName;
            fromNode = from;
            toNode = to;
        }

        public string getEdgeName()
        {
            return edgeName;
        }
        public string getFromNode()
        {
            return fromNode;
        }
        public string getToNode()
        {
            return toNode;
        }
        //public string EdgesToString(List<Edge> edge)
        //{
        //    foreach (Edge element in edge)
        //    {
        //        return ("edge name: " + element.getEdgeName() + "edge from node:" + element.getFromNode() + "edge to node: " + element.getToNode());
        //    }
        //}
    }
}
