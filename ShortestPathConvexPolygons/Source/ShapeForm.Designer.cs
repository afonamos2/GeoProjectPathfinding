
namespace ShortestPathConvexPolygons
{
    partial class ShapeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapeForm));
            this.DrawOptionsPanel = new System.Windows.Forms.Panel();
            this.DrawOptionsLabel = new System.Windows.Forms.Label();
            this.DrawVisibilityGraph = new System.Windows.Forms.CheckBox();
            this.DrawPolygons = new System.Windows.Forms.CheckBox();
            this.DrawPath = new System.Windows.Forms.CheckBox();
            this.StartPlaceButton = new System.Windows.Forms.Button();
            this.DestPlaceButton = new System.Windows.Forms.Button();
            this.PlacementPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.FreePolygonPlaceButton = new System.Windows.Forms.Button();
            this.RefreshObjectsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RotationNumeric = new System.Windows.Forms.NumericUpDown();
            this.RadiusNumeric = new System.Windows.Forms.NumericUpDown();
            this.VerticesNumeric = new System.Windows.Forms.NumericUpDown();
            this.RegPolygonPlaceButton = new System.Windows.Forms.Button();
            this.PlacementLabel = new System.Windows.Forms.Label();
            this.PathGenPanel = new System.Windows.Forms.Panel();
            this.PathGenListBox = new System.Windows.Forms.ListBox();
            this.PathGenButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NodesExploredLabel = new System.Windows.Forms.Label();
            this.StatsPanel = new System.Windows.Forms.Panel();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.PathTimeLabel = new System.Windows.Forms.Label();
            this.VGTimeLabel = new System.Windows.Forms.Label();
            this.GraphItemsLabel = new System.Windows.Forms.Label();
            this.PathDistanceLabel = new System.Windows.Forms.Label();
            this.VerticesLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Logging = new System.Windows.Forms.CheckBox();
            this.DrawOptionsPanel.SuspendLayout();
            this.PlacementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticesNumeric)).BeginInit();
            this.PathGenPanel.SuspendLayout();
            this.StatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawOptionsPanel
            // 
            this.DrawOptionsPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.DrawOptionsPanel.Controls.Add(this.DrawOptionsLabel);
            this.DrawOptionsPanel.Controls.Add(this.DrawVisibilityGraph);
            this.DrawOptionsPanel.Controls.Add(this.DrawPolygons);
            this.DrawOptionsPanel.Controls.Add(this.DrawPath);
            this.DrawOptionsPanel.Location = new System.Drawing.Point(645, 12);
            this.DrawOptionsPanel.Name = "DrawOptionsPanel";
            this.DrawOptionsPanel.Size = new System.Drawing.Size(189, 148);
            this.DrawOptionsPanel.TabIndex = 0;
            // 
            // DrawOptionsLabel
            // 
            this.DrawOptionsLabel.AutoSize = true;
            this.DrawOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DrawOptionsLabel.Location = new System.Drawing.Point(3, 7);
            this.DrawOptionsLabel.Name = "DrawOptionsLabel";
            this.DrawOptionsLabel.Size = new System.Drawing.Size(159, 29);
            this.DrawOptionsLabel.TabIndex = 4;
            this.DrawOptionsLabel.Text = "Draw Options";
            // 
            // DrawVisibilityGraph
            // 
            this.DrawVisibilityGraph.AutoSize = true;
            this.DrawVisibilityGraph.Location = new System.Drawing.Point(8, 107);
            this.DrawVisibilityGraph.Name = "DrawVisibilityGraph";
            this.DrawVisibilityGraph.Size = new System.Drawing.Size(180, 24);
            this.DrawVisibilityGraph.TabIndex = 2;
            this.DrawVisibilityGraph.Text = "Draw Visibility Graph";
            this.DrawVisibilityGraph.UseVisualStyleBackColor = true;
            this.DrawVisibilityGraph.CheckedChanged += new System.EventHandler(this.DrawVisibilityGraph_CheckedChanged);
            // 
            // DrawPolygons
            // 
            this.DrawPolygons.AutoSize = true;
            this.DrawPolygons.Checked = true;
            this.DrawPolygons.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DrawPolygons.Location = new System.Drawing.Point(8, 47);
            this.DrawPolygons.Name = "DrawPolygons";
            this.DrawPolygons.Size = new System.Drawing.Size(140, 24);
            this.DrawPolygons.TabIndex = 1;
            this.DrawPolygons.Text = "Draw Polygons";
            this.DrawPolygons.UseVisualStyleBackColor = true;
            this.DrawPolygons.CheckedChanged += new System.EventHandler(this.DrawPolygons_CheckedChanged);
            // 
            // DrawPath
            // 
            this.DrawPath.AutoSize = true;
            this.DrawPath.Checked = true;
            this.DrawPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DrawPath.Location = new System.Drawing.Point(8, 77);
            this.DrawPath.Name = "DrawPath";
            this.DrawPath.Size = new System.Drawing.Size(109, 24);
            this.DrawPath.TabIndex = 0;
            this.DrawPath.Text = "Draw Path";
            this.DrawPath.UseVisualStyleBackColor = true;
            this.DrawPath.CheckedChanged += new System.EventHandler(this.DrawPath_CheckedChanged);
            // 
            // StartPlaceButton
            // 
            this.StartPlaceButton.Location = new System.Drawing.Point(8, 47);
            this.StartPlaceButton.Name = "StartPlaceButton";
            this.StartPlaceButton.Size = new System.Drawing.Size(124, 39);
            this.StartPlaceButton.TabIndex = 1;
            this.StartPlaceButton.Text = "&Start";
            this.StartPlaceButton.UseVisualStyleBackColor = true;
            this.StartPlaceButton.Click += new System.EventHandler(this.StartPlaceButton_Click);
            // 
            // DestPlaceButton
            // 
            this.DestPlaceButton.Location = new System.Drawing.Point(8, 92);
            this.DestPlaceButton.Name = "DestPlaceButton";
            this.DestPlaceButton.Size = new System.Drawing.Size(124, 39);
            this.DestPlaceButton.TabIndex = 2;
            this.DestPlaceButton.Text = "&Destination";
            this.DestPlaceButton.UseVisualStyleBackColor = true;
            this.DestPlaceButton.Click += new System.EventHandler(this.DestPlaceButton_Click);
            // 
            // PlacementPanel
            // 
            this.PlacementPanel.BackColor = System.Drawing.Color.Pink;
            this.PlacementPanel.Controls.Add(this.label5);
            this.PlacementPanel.Controls.Add(this.FreePolygonPlaceButton);
            this.PlacementPanel.Controls.Add(this.RefreshObjectsButton);
            this.PlacementPanel.Controls.Add(this.label3);
            this.PlacementPanel.Controls.Add(this.label2);
            this.PlacementPanel.Controls.Add(this.label1);
            this.PlacementPanel.Controls.Add(this.RotationNumeric);
            this.PlacementPanel.Controls.Add(this.RadiusNumeric);
            this.PlacementPanel.Controls.Add(this.VerticesNumeric);
            this.PlacementPanel.Controls.Add(this.RegPolygonPlaceButton);
            this.PlacementPanel.Controls.Add(this.PlacementLabel);
            this.PlacementPanel.Controls.Add(this.StartPlaceButton);
            this.PlacementPanel.Controls.Add(this.DestPlaceButton);
            this.PlacementPanel.Location = new System.Drawing.Point(160, 12);
            this.PlacementPanel.Name = "PlacementPanel";
            this.PlacementPanel.Size = new System.Drawing.Size(480, 195);
            this.PlacementPanel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LavenderBlush;
            this.label5.Location = new System.Drawing.Point(225, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hold Ctrl to repeatedly place";
            // 
            // FreePolygonPlaceButton
            // 
            this.FreePolygonPlaceButton.Location = new System.Drawing.Point(138, 92);
            this.FreePolygonPlaceButton.Name = "FreePolygonPlaceButton";
            this.FreePolygonPlaceButton.Size = new System.Drawing.Size(133, 39);
            this.FreePolygonPlaceButton.TabIndex = 11;
            this.FreePolygonPlaceButton.Text = "&Free Polygon";
            this.FreePolygonPlaceButton.UseVisualStyleBackColor = true;
            this.FreePolygonPlaceButton.Click += new System.EventHandler(this.FreePolygonPlaceButton_Click);
            // 
            // RefreshObjectsButton
            // 
            this.RefreshObjectsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RefreshObjectsButton.Location = new System.Drawing.Point(8, 148);
            this.RefreshObjectsButton.Name = "RefreshObjectsButton";
            this.RefreshObjectsButton.Size = new System.Drawing.Size(124, 35);
            this.RefreshObjectsButton.TabIndex = 10;
            this.RefreshObjectsButton.Text = "&Refresh";
            this.RefreshObjectsButton.UseVisualStyleBackColor = false;
            this.RefreshObjectsButton.Click += new System.EventHandler(this.RefreshObjectsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label3.Location = new System.Drawing.Point(392, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rotation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.Location = new System.Drawing.Point(332, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Radius";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label1.Location = new System.Drawing.Point(274, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vertices";
            // 
            // RotationNumeric
            // 
            this.RotationNumeric.Location = new System.Drawing.Point(395, 54);
            this.RotationNumeric.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.RotationNumeric.Name = "RotationNumeric";
            this.RotationNumeric.Size = new System.Drawing.Size(65, 26);
            this.RotationNumeric.TabIndex = 6;
            // 
            // RadiusNumeric
            // 
            this.RadiusNumeric.Location = new System.Drawing.Point(335, 54);
            this.RadiusNumeric.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.RadiusNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RadiusNumeric.Name = "RadiusNumeric";
            this.RadiusNumeric.Size = new System.Drawing.Size(54, 26);
            this.RadiusNumeric.TabIndex = 5;
            this.RadiusNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // VerticesNumeric
            // 
            this.VerticesNumeric.Location = new System.Drawing.Point(277, 54);
            this.VerticesNumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.VerticesNumeric.Name = "VerticesNumeric";
            this.VerticesNumeric.Size = new System.Drawing.Size(52, 26);
            this.VerticesNumeric.TabIndex = 4;
            this.VerticesNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // RegPolygonPlaceButton
            // 
            this.RegPolygonPlaceButton.Location = new System.Drawing.Point(138, 47);
            this.RegPolygonPlaceButton.Name = "RegPolygonPlaceButton";
            this.RegPolygonPlaceButton.Size = new System.Drawing.Size(133, 39);
            this.RegPolygonPlaceButton.TabIndex = 4;
            this.RegPolygonPlaceButton.Text = "R&eg. Polygon";
            this.RegPolygonPlaceButton.UseVisualStyleBackColor = true;
            this.RegPolygonPlaceButton.Click += new System.EventHandler(this.RegPolygonPlaceButton_Click);
            // 
            // PlacementLabel
            // 
            this.PlacementLabel.AutoSize = true;
            this.PlacementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlacementLabel.Location = new System.Drawing.Point(3, 7);
            this.PlacementLabel.Name = "PlacementLabel";
            this.PlacementLabel.Size = new System.Drawing.Size(204, 29);
            this.PlacementLabel.TabIndex = 3;
            this.PlacementLabel.Text = "Object Placement";
            // 
            // PathGenPanel
            // 
            this.PathGenPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PathGenPanel.Controls.Add(this.PathGenListBox);
            this.PathGenPanel.Controls.Add(this.PathGenButton);
            this.PathGenPanel.Controls.Add(this.label4);
            this.PathGenPanel.Location = new System.Drawing.Point(12, 12);
            this.PathGenPanel.Name = "PathGenPanel";
            this.PathGenPanel.Size = new System.Drawing.Size(140, 195);
            this.PathGenPanel.TabIndex = 4;
            // 
            // PathGenListBox
            // 
            this.PathGenListBox.CausesValidation = false;
            this.PathGenListBox.FormattingEnabled = true;
            this.PathGenListBox.ItemHeight = 20;
            this.PathGenListBox.Items.AddRange(new object[] {
            "BFS",
            "UCS",
            "AStar"});
            this.PathGenListBox.Location = new System.Drawing.Point(8, 107);
            this.PathGenListBox.Name = "PathGenListBox";
            this.PathGenListBox.Size = new System.Drawing.Size(124, 64);
            this.PathGenListBox.TabIndex = 5;
            this.PathGenListBox.SelectedIndexChanged += new System.EventHandler(this.PathGenListBox_SelectedIndexChanged);
            // 
            // PathGenButton
            // 
            this.PathGenButton.BackColor = System.Drawing.Color.White;
            this.PathGenButton.Location = new System.Drawing.Point(8, 47);
            this.PathGenButton.Name = "PathGenButton";
            this.PathGenButton.Size = new System.Drawing.Size(124, 39);
            this.PathGenButton.TabIndex = 9;
            this.PathGenButton.Text = "&Generate Path";
            this.PathGenButton.UseVisualStyleBackColor = false;
            this.PathGenButton.Click += new System.EventHandler(this.PathGenButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Path Gen";
            // 
            // NodesExploredLabel
            // 
            this.NodesExploredLabel.AutoSize = true;
            this.NodesExploredLabel.Location = new System.Drawing.Point(4, 85);
            this.NodesExploredLabel.Name = "NodesExploredLabel";
            this.NodesExploredLabel.Size = new System.Drawing.Size(121, 20);
            this.NodesExploredLabel.TabIndex = 5;
            this.NodesExploredLabel.Text = "Nodes Explored";
            // 
            // StatsPanel
            // 
            this.StatsPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.StatsPanel.Controls.Add(this.Logging);
            this.StatsPanel.Controls.Add(this.TotalTimeLabel);
            this.StatsPanel.Controls.Add(this.PathTimeLabel);
            this.StatsPanel.Controls.Add(this.VGTimeLabel);
            this.StatsPanel.Controls.Add(this.GraphItemsLabel);
            this.StatsPanel.Controls.Add(this.PathDistanceLabel);
            this.StatsPanel.Controls.Add(this.VerticesLabel);
            this.StatsPanel.Controls.Add(this.label6);
            this.StatsPanel.Controls.Add(this.NodesExploredLabel);
            this.StatsPanel.Location = new System.Drawing.Point(840, 12);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.Size = new System.Drawing.Size(305, 238);
            this.StatsPanel.TabIndex = 6;
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Location = new System.Drawing.Point(3, 160);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(100, 20);
            this.TotalTimeLabel.TabIndex = 11;
            this.TotalTimeLabel.Text = "Total time (s)";
            // 
            // PathTimeLabel
            // 
            this.PathTimeLabel.AutoSize = true;
            this.PathTimeLabel.Location = new System.Drawing.Point(4, 135);
            this.PathTimeLabel.Name = "PathTimeLabel";
            this.PathTimeLabel.Size = new System.Drawing.Size(64, 20);
            this.PathTimeLabel.TabIndex = 10;
            this.PathTimeLabel.Text = "Path (s)";
            // 
            // VGTimeLabel
            // 
            this.VGTimeLabel.AutoSize = true;
            this.VGTimeLabel.Location = new System.Drawing.Point(4, 110);
            this.VGTimeLabel.Name = "VGTimeLabel";
            this.VGTimeLabel.Size = new System.Drawing.Size(102, 20);
            this.VGTimeLabel.TabIndex = 9;
            this.VGTimeLabel.Text = "Vis Graph (s)";
            // 
            // GraphItemsLabel
            // 
            this.GraphItemsLabel.AutoSize = true;
            this.GraphItemsLabel.Location = new System.Drawing.Point(4, 60);
            this.GraphItemsLabel.Name = "GraphItemsLabel";
            this.GraphItemsLabel.Size = new System.Drawing.Size(96, 24);
            this.GraphItemsLabel.TabIndex = 8;
            this.GraphItemsLabel.Text = "Graph Items";
            this.GraphItemsLabel.UseCompatibleTextRendering = true;
            // 
            // PathDistanceLabel
            // 
            this.PathDistanceLabel.AutoSize = true;
            this.PathDistanceLabel.Location = new System.Drawing.Point(4, 185);
            this.PathDistanceLabel.Name = "PathDistanceLabel";
            this.PathDistanceLabel.Size = new System.Drawing.Size(109, 20);
            this.PathDistanceLabel.TabIndex = 7;
            this.PathDistanceLabel.Text = "Path Distance";
            // 
            // VerticesLabel
            // 
            this.VerticesLabel.AutoSize = true;
            this.VerticesLabel.Location = new System.Drawing.Point(4, 35);
            this.VerticesLabel.Name = "VerticesLabel";
            this.VerticesLabel.Size = new System.Drawing.Size(67, 20);
            this.VerticesLabel.TabIndex = 6;
            this.VerticesLabel.Text = "Vertices";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Statistics";
            // 
            // Logging
            // 
            this.Logging.AutoSize = true;
            this.Logging.Location = new System.Drawing.Point(7, 208);
            this.Logging.Name = "Logging";
            this.Logging.Size = new System.Drawing.Size(146, 24);
            this.Logging.TabIndex = 12;
            this.Logging.Text = "Enable Logging";
            this.Logging.UseVisualStyleBackColor = true;
            this.Logging.CheckedChanged += new System.EventHandler(this.Logging_CheckedChanged);
            // 
            // ShapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.StatsPanel);
            this.Controls.Add(this.PathGenPanel);
            this.Controls.Add(this.PlacementPanel);
            this.Controls.Add(this.DrawOptionsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShapeForm";
            this.Text = "Shortest Path";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShapeForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShapeForm_MouseClick);
            this.DrawOptionsPanel.ResumeLayout(false);
            this.DrawOptionsPanel.PerformLayout();
            this.PlacementPanel.ResumeLayout(false);
            this.PlacementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticesNumeric)).EndInit();
            this.PathGenPanel.ResumeLayout(false);
            this.PathGenPanel.PerformLayout();
            this.StatsPanel.ResumeLayout(false);
            this.StatsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawOptionsPanel;
        private System.Windows.Forms.CheckBox DrawVisibilityGraph;
        private System.Windows.Forms.CheckBox DrawPolygons;
        private System.Windows.Forms.CheckBox DrawPath;
        private System.Windows.Forms.Button StartPlaceButton;
        private System.Windows.Forms.Button DestPlaceButton;
        private System.Windows.Forms.Panel PlacementPanel;
        private System.Windows.Forms.Label PlacementLabel;
        private System.Windows.Forms.Label DrawOptionsLabel;
        private System.Windows.Forms.Button RegPolygonPlaceButton;
        private System.Windows.Forms.NumericUpDown RotationNumeric;
        private System.Windows.Forms.NumericUpDown RadiusNumeric;
        private System.Windows.Forms.NumericUpDown VerticesNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PathGenPanel;
        private System.Windows.Forms.Button PathGenButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RefreshObjectsButton;
        private System.Windows.Forms.ListBox PathGenListBox;
        private System.Windows.Forms.Label NodesExploredLabel;
        private System.Windows.Forms.Panel StatsPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PathDistanceLabel;
        private System.Windows.Forms.Label VerticesLabel;
        private System.Windows.Forms.Label GraphItemsLabel;
        private System.Windows.Forms.Label VGTimeLabel;
        private System.Windows.Forms.Label PathTimeLabel;
        private System.Windows.Forms.Label TotalTimeLabel;
        private System.Windows.Forms.Button FreePolygonPlaceButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Logging;
    }
}

