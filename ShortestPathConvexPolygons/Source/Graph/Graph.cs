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

    public Graph() {
        _nodes = new List<Node>();
        _polygons = new List<Polygon>();
        _visibilityGraph = false;
    }

    public struct Node {
        public Vec2 vertex;
        public List<Vec2> edges;
        public List<Node> neighbors; //Slightly scuffed holds both edges and visible nodes, makes graph traversal code easier at the cost of memory waste
        public Polygon poly; //The polygon an object is a part of to prevent internal angles (there is a better way to do this involving checking edge angles)

        public Node(Vec2 vertex, List<Vec2> edges, List<Node> neighbors, Polygon poly) {
            this.vertex = vertex;
            this.edges = edges;
            this.neighbors = neighbors;
            this.poly = poly;
        }
    }
}
