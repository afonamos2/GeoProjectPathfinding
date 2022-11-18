using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShortestPathConvexPolygons
{
    public partial class ShapeForm : Form
    {
        private static readonly Pen edgePen = new Pen(Color.Green);
        private static readonly Pen pathPen = new Pen(Color.Purple);
        private static readonly Pen visPen = new Pen(Color.Lavender);
        private static readonly Brush startBrush = new SolidBrush(Color.Cyan);
        private static readonly Brush endBrush = new SolidBrush(Color.Red);

        private Graph graph;
        private Path path;

        private Vec2 startVec = new Vec2(500, 500);
        private Vec2 destVec = new Vec2(600,400);

        private Graph.Node startNode;
        private Graph.Node destNode;

        static readonly Stopwatch timer = new Stopwatch();
        private double visGraphGenTime = 0;
        private double pathGenTime = 0;

        private enum PlacementMode
        {
            None, Start, Dest, RegPolygon, Polygon
        }
        private PlacementMode placementMode = PlacementMode.None;
        
        private static readonly Pathfinder.Generator[] pathfinders =
        {
            Pathfinder.BFS, Pathfinder.UCS, Pathfinder.AStar
        };

        public ShapeForm()
        {
            InitializeComponent();
            this.Width = 1600;
            this.Height = 900;
            PathGenListBox.SelectedIndex = 0; //The box starts at index -1, god knows why
            InitializeGraph();
        }

        private void InitializeGraph()
        {
            this.graph = new Graph();
            startNode = graph.AddPoint(startVec);
            destNode = graph.AddPoint(destVec);
            UpdateGraph();
        }

        private void UpdateGraph()
        {
            UpdatePoints();
            CreateVisibilityGraph();
            CreatePath();
            UpdateLabels();
            Invalidate();
        }

        private void CreateVisibilityGraph()
        {
            timer.Reset();
            timer.Start();
            graph.CreateVisibilityGraph();
            timer.Stop();
            visGraphGenTime = timer.Elapsed.TotalSeconds;

            if (graph != null && path != null)
                UpdateLabels();
        }

        private void CreatePath()
        { 
            timer.Reset();
            timer.Start();
            path = pathfinders[PathGenListBox.SelectedIndex](startNode, destNode, graph);
            timer.Stop();
            pathGenTime = timer.Elapsed.TotalSeconds;

            if (graph != null && path != null)
                UpdateLabels();
        }

        private void UpdatePoints()
        {
            graph.RemoveNode(startNode);
            startNode = graph.AddPoint(startVec);

            graph.RemoveNode(destNode);
            destNode = graph.AddPoint(destVec);
        }

        private void UpdateLabels()
        {
            VerticesLabel.Text = $"Vertices: {graph.Nodes.Count}";
            NodesExploredLabel.Text = $"Nodes Explored: {path.NodesExplored}";
            PathDistanceLabel.Text = $"Distance: {path.Distance}";
            GraphItemsLabel.Text = $"Graph Items: {path.GraphItems}";
            VGTimeLabel.Text = $"VG Generation: {visGraphGenTime}";
            PathTimeLabel.Text = $"Path Generation: {pathGenTime}";
            TotalTimeLabel.Text = $"Total Time: {pathGenTime + visGraphGenTime}";
        }

        private void ShapeForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            var startRect = new Rectangle(
                new Point((int)startVec.x - 10, (int)startVec.y - 10),
                new Size(20, 20));
            var endRect = new Rectangle(
                new Point((int)destVec.x - 10, (int)destVec.y - 10),
                new Size(20, 20));

            if (DrawPolygons.Checked || DrawVisibilityGraph.Checked)
            {
                foreach (var node in graph.Nodes)
                {
                    if (DrawVisibilityGraph.Checked)
                    {
                        foreach (var neighbor in node.neighbors)
                        {
                            g.DrawLine(visPen, node.vertex.x, node.vertex.y, neighbor.vertex.x, neighbor.vertex.y);
                        }
                    }
                    if (DrawPolygons.Checked)
                    {
                        foreach (var edge in node.edges)
                        {
                            g.DrawLine(edgePen, node.vertex.x, node.vertex.y, edge.x, edge.y);
                        }
                    }
                }
            }

            if (DrawPath.Checked)
            {
                for (int i = 0; i < path.Nodes.Count - 1; i++)
                {
                    g.DrawLine(pathPen, path.Nodes[i].x, path.Nodes[i].y, path.Nodes[i + 1].x, path.Nodes[i + 1].y);
                }
            }

            g.FillEllipse(startBrush, startRect);
            g.FillEllipse(endBrush, endRect);
        }

        private void StartPlaceButton_Click(object sender, EventArgs e)
        {
            placementMode = PlacementMode.Start;
        }

        private void DestPlaceButton_Click(object sender, EventArgs e)
        {
            placementMode = PlacementMode.Dest;
        }

        private void PolygonPlaceButton_Click(object sender, EventArgs e)
        {
            placementMode = PlacementMode.RegPolygon;
        }

        private void ShapeForm_MouseClick(object sender, MouseEventArgs e)
        {
            switch (placementMode)
            {
                case PlacementMode.Start:
                    startVec = new Vec2(e.X, e.Y);
                    UpdatePoints();
                    break;

                case PlacementMode.Dest:
                    destVec = new Vec2(e.X, e.Y);
                    UpdatePoints();
                    break;

                case PlacementMode.RegPolygon:
                    var poly = Polygon.GenerateRegularPolygon(
                        (int)VerticesNumeric.Value, 
                        (float)RadiusNumeric.Value * 10, 
                        new Vec2(e.X, e.Y),
                        (float)(RotationNumeric.Value / 360) * (float)(Math.PI * 2.0));
                    graph.AddPolygon(poly);
                    UpdateGraph();
                    break;

                case PlacementMode.None:
                    break;
            }

            CreatePath();
            Invalidate();
            placementMode = PlacementMode.None;
        }

        private void PathGenButton_Click(object sender, EventArgs e)
        {
            CreatePath();
            Invalidate();
        }

        private void DrawPolygons_CheckedChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void DrawPath_CheckedChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void DrawVisibilityGraph_CheckedChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void RefreshObjectsButton_Click(object sender, EventArgs e)
        {
            InitializeGraph();
        }

        private void PathGenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (graph != null)
                CreatePath();
            else
                InitializeGraph();
            Invalidate();
        }
    }
}
