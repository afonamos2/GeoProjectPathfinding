using System.Collections.Generic;

using static Graph;

public static class BFS {
    public static Path GeneratePath(Vec2 start, Vec2 dest, Graph graph) {

        Queue<Node> queue = new Queue<Node>();
        HashSet<Vec2> visited = new HashSet<Vec2>();
        Dictionary<Vec2, Vec2> paths = new Dictionary<Vec2, Vec2>();

        Node destNode = graph.AddPoint(dest);
        Node startNode = graph.AddPoint(start);

        queue.Enqueue(startNode);

        int nodeExplored = 0;

        while (queue.Count > 0) {
            nodeExplored++;

            Node currNode = queue.Dequeue();
            visited.Add(currNode.vertex);

            if (currNode.vertex == dest) {
                break;
            }

            foreach (var neighbor in currNode.neighbors) { 
                if (!visited.Contains(neighbor.vertex)) {
                    nodeExplored++;
                    queue.Enqueue(neighbor);
                    if (paths.ContainsKey(neighbor.vertex)) {
                        paths[neighbor.vertex] = currNode.vertex;
                    } else {
                        paths.Add(neighbor.vertex, currNode.vertex);
                    }
                }
            }
        }

        List<Vec2> pathList = new List<Vec2>();
        Vec2 state = dest;
        float distance = 0f;

        //Backtracking visited nodes to find path
        while (state != start) {
            pathList.Add(state);
            Vec2 prevState = paths[state];
            distance += Vec2Ext.Distance(state, prevState);
            state = prevState;
        }
        pathList.Add(start);

        pathList.Reverse();
        Path path = new Path(pathList);
        path.NodesExplored = nodeExplored;
        path.Distance = distance;
        path.GraphItems = graph.ItemCount;

        graph.RemoveNode(startNode);
        graph.RemoveNode(destNode);

        return path;
    }
}
