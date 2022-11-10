using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShortestPathConvexPolygons
{
    public partial class ShapeForm : Form
    {
        private Graph graph;
        private Path path;

        private Vec2 start = new Vec2(500, 500);
        private Vec2 dest = new Vec2(600,400);

        private enum PlacementMode
        {
            None, Start, Dest, Polygon
        }

        private PlacementMode placementMode = PlacementMode.None;

        private Pathfinder[] pathfinders =
        {
            BFS.GeneratePath, UCS.GeneratePath, AStar.GeneratePath
        };

        public ShapeForm()
        {
            InitializeComponent();
            this.Width = 1600;
            this.Height = 900;
            PathGenListBox.SelectedIndex = 0; //The box starts at index -1, god knows why
            InitializeGraph();
        }

        private void ShapeForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen startPen = new Pen(Color.Cyan);
            Pen endPoint = new Pen(Color.Red);
            Pen edgePen = new Pen(Color.Green);
            Pen pathPen = new Pen(Color.Purple);
            Pen visPen = new Pen(Color.Lavender);

            Brush startBrush = new SolidBrush(Color.Cyan);
            Brush endBrush = new SolidBrush(Color.Red);

            var startRect = new Rectangle(
                new Point((int)start.x - 10, (int)start.y - 10), 
                new Size(new Point(20, 20)));
            var endRect = new Rectangle(
                new Point((int)dest.x - 10, (int)dest.y - 10), 
                new Size(new Point(20, 20)));

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

        private void InitializeGraph()
        {
            this.graph = new Graph();
            CreatePath();
        }

        private void CreatePath()
        {
            graph.CreateVisibilityGraph();
            path = pathfinders[PathGenListBox.SelectedIndex](start, dest, graph);

            //Updating labels
            VerticesLabel.Text = $"Vertices: {graph.Nodes.Count}";
            NodesExploredLabel.Text = $"Nodes Explored: {path.NodesExplored}";
            PathDistanceLabel.Text = $"Distance: {path.Distance}";
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
            placementMode = PlacementMode.Polygon;
        }

        private void ShapeForm_MouseClick(object sender, MouseEventArgs e)
        {
            switch (placementMode)
            {
                case PlacementMode.Start:
                    start = new Vec2(e.X, e.Y);
                    placementMode = PlacementMode.None;
                    break;

                case PlacementMode.Dest:
                    dest = new Vec2(e.X, e.Y);
                    placementMode = PlacementMode.None;
                    break;

                case PlacementMode.Polygon:
                    var poly = Polygon.GenerateRegularPolygon(
                        (int)VerticesNumeric.Value, 
                        (float)RadiusNumeric.Value * 10, 
                        new Vec2(e.X, e.Y),
                        (float)(RotationNumeric.Value / 360) * (float)(Math.PI * 2.0));
                    graph.AddPolygon(poly);
                    placementMode = PlacementMode.None;
                    break;

                case PlacementMode.None:
                    break;
            }
            CreatePath();
            Invalidate();
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
            graph = new Graph();
            CreatePath();
            Invalidate();
        }

        private void PathGenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (graph != null) 
                CreatePath();
            Invalidate();
        }
    }
}
