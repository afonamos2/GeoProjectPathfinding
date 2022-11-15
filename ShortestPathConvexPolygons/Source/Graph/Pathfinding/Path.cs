using System.Collections.Generic;

public delegate Path Pathfinder(Vec2 start, Vec2 dest, Graph graph);

public class Path {
    private int _nodesExplored;
    private List<Vec2> _nodes;
    private float _distance;
    private int _graphItems;

    public List<Vec2> Nodes => _nodes;
    public int NodesExplored
    {
        get => _nodesExplored;
        set { _nodesExplored = value; }
    }
    public float Distance
    {
        get => _distance;
        set { _distance = value; }
    }
    public int GraphItems
    {
        get => _graphItems;
        set { _graphItems = value; }
    }

    public Path(List<Vec2> path) {
        _nodes = path;
    }
}