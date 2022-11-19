using System.Collections.Generic;

public class Path 
{
    private int _nodesExplored;
    private List<Vec2> _nodes;
    private float _distance;

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

    public Path(List<Vec2> path) {
        _nodes = path;
    }
}