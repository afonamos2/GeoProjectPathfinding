using System.Collections.Generic;
public class Path {
    private List<Vec2> _nodes;

    public List<Vec2> Nodes {
        get {return _nodes;}
    }

    public Path(List<Vec2> path) {
        _nodes = path;
    }
}