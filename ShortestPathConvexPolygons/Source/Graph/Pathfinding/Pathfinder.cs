using System.Collections.Generic;

using static Graph;

public static class Pathfinder {

    public delegate Path Generator( Vec2 start, Vec2 dest, Graph graph );
    public delegate float Heuristic( Vec2 point, Vec2 dest );

    public static float NullHeuristic( Vec2 point, Vec2 dest ) => 0f;

    public static Path BFS( Vec2 start, Vec2 dest, Graph graph ) =>
        GeneratePath( start, dest, graph );

    public static Path UCS( Vec2 start, Vec2 dest, Graph graph ) =>
        GenerateWeightedPath( start, dest, graph, NullHeuristic );

    public static Path AStar( Vec2 start, Vec2 dest, Graph graph ) =>
        GenerateWeightedPath( start, dest, graph, Vec2Ext.Distance );

    private static Path GeneratePath( Vec2 start, Vec2 dest, Graph graph )
    {
        Queue<Node> queue = new Queue<Node>();
        HashSet<Vec2> visited = new HashSet<Vec2>();
        Dictionary<Vec2, Vec2> paths = new Dictionary<Vec2, Vec2>();

        Node destNode = graph.AddPoint( dest );
        Node startNode = graph.AddPoint( start );

        queue.Enqueue( startNode );

        int nodeExplored = 0;

        while ( queue.Count > 0 )
        {
            Node currNode = queue.Dequeue();
            visited.Add( currNode.vertex );
            nodeExplored++;

            if ( currNode.vertex == dest )
                break;

            foreach ( var neighbor in currNode.neighbors )
            {
                if ( !visited.Contains(neighbor.vertex) )
                {
                    nodeExplored++;
                    queue.Enqueue(neighbor);
                    if ( paths.ContainsKey(neighbor.vertex) )
                    {
                        paths[neighbor.vertex] = currNode.vertex;
                    }
                    else
                    {
                        paths.Add( neighbor.vertex, currNode.vertex );
                    }
                }
            }
        }

        Path path = BacktrackToGetPath( paths, start, dest );
        path.NodesExplored = nodeExplored;
        path.GraphItems = graph.ItemCount;

        graph.RemoveNode( startNode );
        graph.RemoveNode( destNode );

        return path;
    }

    private static Path GenerateWeightedPath( Vec2 start, Vec2 dest, Graph graph, Heuristic heuristic ) 
    {
        PriorityQueue<float, Node> queue = new PriorityQueue<float, Node>();
        HashSet<Vec2> visited = new HashSet<Vec2>();
        Dictionary<Vec2, Vec2> paths = new Dictionary<Vec2, Vec2>();
        Dictionary<Vec2, float> costs = new Dictionary<Vec2, float>();

        Node destNode = graph.AddPoint( dest );
        Node startNode = graph.AddPoint( start );

        queue.Enqueue( 0f, startNode );
        costs.Add( start, 0f );

        int nodeExplored = 0;

        while ( !queue.IsEmpty )
        {
            Node currNode = queue.DequeueValue();
            visited.Add( currNode.vertex );
            nodeExplored++;

            if (currNode.vertex == dest)
                break;

            foreach ( var neighbor in currNode.neighbors )
            {
                if ( !visited.Contains(neighbor.vertex) )
                {
                    nodeExplored++;

                    if ( !costs.ContainsKey(neighbor.vertex) )
                        costs.Add(neighbor.vertex, float.PositiveInfinity);

                    float newCost = costs[currNode.vertex] + Vec2Ext.Distance(currNode.vertex, neighbor.vertex);

                    if ( costs[neighbor.vertex] > newCost )
                    {
                        queue.Enqueue( newCost + heuristic( neighbor.vertex, dest ), neighbor );
                        costs[neighbor.vertex] = newCost;

                        if ( paths.ContainsKey( neighbor.vertex ) )
                            paths[neighbor.vertex] = currNode.vertex;
                        else
                            paths.Add( neighbor.vertex, currNode.vertex );
                    }
                }
            }
        }

        Path path = BacktrackToGetPath (paths, start, dest );
        path.NodesExplored = nodeExplored;
        path.GraphItems = graph.ItemCount;

        graph.RemoveNode( startNode );
        graph.RemoveNode( destNode );

        return path;
    }

    //Backtracking visited nodes to find path
    private static Path BacktrackToGetPath( Dictionary<Vec2, Vec2> paths, Vec2 start, Vec2 dest )
    {
        List<Vec2> pathList = new List<Vec2>();
        Vec2 state = dest;
        float distance = 0f;

        while ( state != start )
        {
            pathList.Add( state );
            Vec2 prevState = paths[state];
            distance += Vec2Ext.Distance( state, prevState );
            state = prevState;
        }
        pathList.Add( start );

        pathList.Reverse();
        Path path = new Path( pathList );
        path.Distance = distance;

        return path;
    }
}
