using System.Collections.Generic;

public partial class Polygon
{
    private List<Vec2> _vertices;
    private List<Pair<Vec2>> _edges;

    public List<Vec2> Vertices
    {
        get { return _vertices; }
        set
        {
            _vertices = value;
            GenerateEdges();
        }
    }

    public List<Pair<Vec2>> Edges
    {
        get
        {
            if (_edges.Count != _vertices.Count)
            {
                GenerateEdges();
            }
            return _edges;
        }
    }

    public Polygon()
    {
        _vertices = new List<Vec2>();
        _edges = new List<Pair<Vec2>>();
    }

    public void AddPoint(Vec2 point)
    {
        _vertices.Add(point);
    }

    public bool LineIntersectsPolygon(Vec2 pointA, Vec2 pointB)
    {
        foreach (var edge in _edges)
        {
            if (Vec2Ext.Intersect(pointA, pointB, edge.a, edge.b))
            {
                return true;
            }
        }
        return false;
    }

    private void GenerateEdges()
    {
        List<Pair<Vec2>> newEdges = new List<Pair<Vec2>>();
        for (int i = 0; i < _vertices.Count; i++)
        {
            newEdges.Add(new Pair<Vec2>(_vertices[i], _vertices[(i + 1) % _vertices.Count]));
        }
        _edges = newEdges;
    }
}
