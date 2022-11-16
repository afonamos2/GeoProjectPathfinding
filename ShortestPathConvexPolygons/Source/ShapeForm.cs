﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShortestPathConvexPolygons
{
    public partial class ShapeForm : Form
    {
        private Graph graph;
        private Path path;

        private Vec2 start = new Vec2(500, 500);
        private Vec2 dest = new Vec2(600,400);

        static readonly Stopwatch timer = new Stopwatch();

        private enum PlacementMode
        {
            None, Start, Dest, RegPolygon, Polygon
        }
        private PlacementMode placementMode = PlacementMode.None;

        private Pathfinder.Generator[] pathfinders =
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
            CreatePath();
        }

        private void CreatePath()
        {
            timer.Reset();
            timer.Start();
            graph.CreateVisibilityGraph();
            timer.Stop();
            var visGraphTime = timer.Elapsed.TotalSeconds;
            timer.Reset();
            timer.Start();
            path = pathfinders[PathGenListBox.SelectedIndex](start, dest, graph);
            timer.Stop();
            var pathTime = timer.Elapsed.TotalSeconds;

            //Updating labels
            VerticesLabel.Text = $"Vertices: {graph.Nodes.Count}";
            NodesExploredLabel.Text = $"Nodes Explored: {path.NodesExplored}";
            PathDistanceLabel.Text = $"Distance: {path.Distance}";
            GraphItemsLabel.Text = $"Graph Items: {path.GraphItems}";
            VGTimeLabel.Text = $"VG Generation: {visGraphTime}";
            PathTimeLabel.Text = $"Path Generation: {pathTime}";
            TotalTimeLabel.Text = $"Total Time: {pathTime + visGraphTime}";
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
                new Size(20, 20));
            var endRect = new Rectangle(
                new Point((int)dest.x - 10, (int)dest.y - 10), 
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
                    start = new Vec2(e.X, e.Y);
                    break;

                case PlacementMode.Dest:
                    dest = new Vec2(e.X, e.Y);
                    break;

                case PlacementMode.RegPolygon:
                    var poly = Polygon.GenerateRegularPolygon(
                        (int)VerticesNumeric.Value, 
                        (float)RadiusNumeric.Value * 10, 
                        new Vec2(e.X, e.Y),
                        (float)(RotationNumeric.Value / 360) * (float)(Math.PI * 2.0));
                    graph.AddPolygon(poly);
                    break;

                case PlacementMode.None:
                    break;
            }

            placementMode = PlacementMode.None;
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
            InitializeGraph();
            Invalidate();
        }

        private void PathGenListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (graph != null) 
                CreatePath();
            Invalidate();
        }

        private void ShapeForm_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
