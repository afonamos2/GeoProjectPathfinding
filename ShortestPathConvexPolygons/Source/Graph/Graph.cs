using System;
using System.Collections.Generic;

public partial class Graph {
    
    private List<Polygon> _polygons;
    private List<Node> _nodes;
    private bool _visibilityGraph;

    public List<Node> Nodes {
        get {return _nodes;}
        set {_nodes = value;}
    }

    public List<Polygon> Polygons {
        get {return _polygons;}
    }

    public bool VisibilityGraph => _visibilityGraph;

    public Graph() {
        _nodes = new List<Node>();
        _polygons = new List<Polygon>();
        _visibilityGraph = false;
    }

    public void AddPolygon(Polygon polygon) {
        List<Vec2> vertices = polygon.Vertices;
        List<Node> newNodes = new List<Node>();

        for (int i = 0; i < vertices.Count; i++) {
            var node = new Node();
            node.vertex = vertices[i];
            node.neighbors = new List<Node>();
            node.edges = new List<Vec2>();
            node.poly = polygon;
            newNodes.Add(node);
        }
        
        for (int i = 0; i < vertices.Count; i++) {
            newNodes[i].edges.Add(vertices[Util.Mod(i - 1, vertices.Count)]);
            newNodes[i].edges.Add(vertices[Util.Mod(i + 1, vertices.Count)]);
            newNodes[i].neighbors.Add(newNodes[Util.Mod(i - 1, vertices.Count)]);
            newNodes[i].neighbors.Add(newNodes[Util.Mod(i + 1, vertices.Count)]);
        }        

        _polygons.Add(polygon);
        _nodes.AddRange(newNodes);
    }

    public Node AddPoint(Vec2 point) {
        var node = new Node();
        
        node.vertex = point;
        node.neighbors = new List<Node>();
        node.edges = new List<Vec2>();
        
        node.poly = new Polygon();
        node.poly.Vertices = new List<Vec2>();
        node.poly.Vertices.Add(point);
        
        AddVisibleNeighbors(node);
        _nodes.Add(node);
        _polygons.Add(node.poly);

        return node;
    }

    //Guaranteed to create bugs
    public void RemoveNode(Node node) {
        foreach (var neighbor in node.neighbors) {
            neighbor.neighbors.Remove(node);
        }
        _nodes.Remove(node);
    }

    public void CreateVisibilityGraph() {
        // Cleaning up current visibility graph
        if (_visibilityGraph) {
            foreach (var node in _nodes) {
                if (node.edges.Count > 1 && node.neighbors.Count > 2) {
                    node.neighbors.RemoveRange(2, node.neighbors.Count - 2);
                }
            }
        }

        foreach (var node in _nodes) {
            AddVisibleNeighbors(node);
        }
        _visibilityGraph = true;
    }

    public bool LineIntersectsPolygon(Vec2 a, Vec2 b) {
        foreach (var node in _nodes) {
            foreach (var edge in node.edges) {
                if (Vec2Ext.Intersect(a, b, node.vertex, edge)) {
                    return true;
                }
            }
        }
        return false;
    }
    
    private void AddVisibleNeighbors(Node node) {
        foreach (var dest in _nodes) {
            if (!dest.poly.Equals(node.poly) && !LineIntersectsPolygon(node.vertex, dest.vertex)) {
                if (!node.neighbors.Contains(dest))
                    node.neighbors.Add(dest);
                if (!dest.neighbors.Contains(node))
                    dest.neighbors.Add(node);
            }
        }
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
