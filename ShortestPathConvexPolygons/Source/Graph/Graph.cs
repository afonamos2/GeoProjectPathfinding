using System.Collections.Generic;

public partial class Graph {
    
    private List<Polygon> _polygons;
    private List<Node> _nodes;
    private bool _visibilityGraph;

    public List<Polygon> Polygons => _polygons;
    public List<Node> Nodes {
        get {return _nodes;}
        set {_nodes = value;}
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
            foreach (var poly in _polygons)
            {
                count++;
            }
            return count;
        }
    }

    public Graph() {
        _nodes = new List<Node>();
        _polygons = new List<Polygon>();
        _visibilityGraph = false;
    }

    public struct Node {
        public Vec2 vertex;
        public List<Vec2> edges;
        public List<Node> neighbors; //Contains all nodes that are visible to the current node (includes edges)
        public Polygon poly; //To prevent internal neighbors (there is a better way to do this involving checking edge angles(too lazy at the moment))

        public Node(Vec2 vertex, List<Vec2> edges, List<Node> neighbors, Polygon poly) {
            this.vertex = vertex;
            this.edges = edges;
            this.neighbors = neighbors;
            this.poly = poly;
        }
    }
}
