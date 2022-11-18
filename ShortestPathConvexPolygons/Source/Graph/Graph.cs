using System;
using System.Collections.Generic;

public partial class Graph
{
    private List<Node> _nodes;
    private bool _visibilityGraph;

    public List<Node> Nodes
    {
        get { return _nodes; }
        set { _nodes = value; }
    }
    public bool VisibilityGraph => _visibilityGraph;

    public int ItemCount
    {
        get
        {
            int count = 0;
            foreach (var node in _nodes)
            {
                count++;
                foreach (var neighbor in node.neighbors)
                {
                    count++;
                }
                foreach (var edge in node.edges)
                {
                    count++;
                }
            }
            return count;
        }
    }

    public Graph()
    {
        _nodes = new List<Node>();
        _visibilityGraph = false;
    }

    public struct Node
    {
        public Vec2 vertex;
        public List<Vec2> edges;
        public List<Node> neighbors; //Contains all nodes that are visible to the current node (includes edges)

        public Node(Vec2 vertex, List<Vec2> edges, List<Node> neighbors)
        {
            this.vertex = vertex;
            this.edges = edges;
            this.neighbors = neighbors;
        }


        public class SortCWAngleToPoint : IComparer<Node>
        {
            // Point to pivot rotation around
            Node pivot;

            public SortCWAngleToPoint(Node pivot)
            {
                this.pivot = pivot;
            }

            public int Compare(Node a, Node b)
            {
                var aRelative = a.vertex - pivot.vertex;
                var bRelative = b.vertex - pivot.vertex;

                double thetaA = Math.Atan2(aRelative.y, aRelative.x);
                double thetaB = Math.Atan2(bRelative.y, bRelative.x);

                return (thetaA > thetaB) ? 1 : -1;
            }
        }
    }
}
