using System.Collections.Generic;

using static Graph;

public class UCS {
    public static Path GeneratePath(Vec2 start, Vec2 dest, Graph graph) {

        PriorityQueue<double, Node> queue = new PriorityQueue<double, Node>();
        HashSet<Vec2> visited = new HashSet<Vec2>();
        Dictionary<Vec2, Vec2> paths = new Dictionary<Vec2, Vec2>();
        Dictionary<Vec2, double> costs = new Dictionary<Vec2, double>();

        Node destNode = graph.AddPoint(dest);
        Node startNode = graph.AddPoint(start);

        queue.Enqueue(0f, startNode);
        costs.Add(start, 0f);
        
        int nodeExplored = 0;
        while (!queue.IsEmpty) {
            nodeExplored++;

            Node currNode = queue.DequeueValue();
            visited.Add(currNode.vertex);

            if (currNode.vertex == dest) {
                break;
            }

            foreach (var neighbor in currNode.neighbors) {
                if (!visited.Contains(neighbor.vertex)) {
                    nodeExplored++;
                    if (!costs.ContainsKey(neighbor.vertex)) {
                        costs.Add(neighbor.vertex, float.PositiveInfinity);
                    }

                    double newCost = costs[currNode.vertex] + Vec2Ext.Distance(currNode.vertex, neighbor.vertex);
                    
                    if (costs[neighbor.vertex] > newCost) {
                        queue.Enqueue(newCost, neighbor);
                        costs[neighbor.vertex] = newCost;
                        if (paths.ContainsKey(neighbor.vertex)) {
                            paths[neighbor.vertex] = currNode.vertex;
                        } else {
                            paths.Add(neighbor.vertex, currNode.vertex);
                        }
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

        graph.RemoveNode(startNode);
        graph.RemoveNode(destNode);

        return path;
    }
}
