
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
            this.label1 = new System.Windows.Forms.Label();
            this.RotationNumeric = new System.Windows.Forms.NumericUpDown();
            this.RadiusNumeric = new System.Windows.Forms.NumericUpDown();
            this.VerticesNumeric = new System.Windows.Forms.NumericUpDown();
            this.PolygonPlaceButton = new System.Windows.Forms.Button();
            this.PlacementLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PathGenButton = new System.Windows.Forms.Button();
            this.RefreshObjectsButton = new System.Windows.Forms.Button();
            this.DrawOptionsPanel.SuspendLayout();
            this.PlacementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticesNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawOptionsPanel
            // 
            this.DrawOptionsPanel.BackColor = System.Drawing.Color.White;
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
            this.StartPlaceButton.Text = "Start";
            this.StartPlaceButton.UseVisualStyleBackColor = true;
            this.StartPlaceButton.Click += new System.EventHandler(this.StartPlaceButton_Click);
            // 
            // DestPlaceButton
            // 
            this.DestPlaceButton.Location = new System.Drawing.Point(8, 92);
            this.DestPlaceButton.Name = "DestPlaceButton";
            this.DestPlaceButton.Size = new System.Drawing.Size(124, 39);
            this.DestPlaceButton.TabIndex = 2;
            this.DestPlaceButton.Text = "Destination";
            this.DestPlaceButton.UseVisualStyleBackColor = true;
            this.DestPlaceButton.Click += new System.EventHandler(this.DestPlaceButton_Click);
            // 
            // PlacementPanel
            // 
            this.PlacementPanel.Controls.Add(this.RefreshObjectsButton);
            this.PlacementPanel.Controls.Add(this.label3);
            this.PlacementPanel.Controls.Add(this.label2);
            this.PlacementPanel.Controls.Add(this.label1);
            this.PlacementPanel.Controls.Add(this.RotationNumeric);
            this.PlacementPanel.Controls.Add(this.RadiusNumeric);
            this.PlacementPanel.Controls.Add(this.VerticesNumeric);
            this.PlacementPanel.Controls.Add(this.PolygonPlaceButton);
            this.PlacementPanel.Controls.Add(this.PlacementLabel);
            this.PlacementPanel.Controls.Add(this.StartPlaceButton);
            this.PlacementPanel.Controls.Add(this.DestPlaceButton);
            this.PlacementPanel.Location = new System.Drawing.Point(161, 12);
            this.PlacementPanel.Name = "PlacementPanel";
            this.PlacementPanel.Size = new System.Drawing.Size(478, 195);
            this.PlacementPanel.TabIndex = 3;
            this.PlacementPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PlacementPanel_Paint);
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
            10,
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
            // PolygonPlaceButton
            // 
            this.PolygonPlaceButton.Location = new System.Drawing.Point(138, 47);
            this.PolygonPlaceButton.Name = "PolygonPlaceButton";
            this.PolygonPlaceButton.Size = new System.Drawing.Size(133, 39);
            this.PolygonPlaceButton.TabIndex = 4;
            this.PolygonPlaceButton.Text = "Regular Polygon";
            this.PolygonPlaceButton.UseVisualStyleBackColor = true;
            this.PolygonPlaceButton.Click += new System.EventHandler(this.PolygonPlaceButton_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label3.Location = new System.Drawing.Point(392, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rotation";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PathGenButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 195);
            this.panel1.TabIndex = 4;
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
            // PathGenButton
            // 
            this.PathGenButton.Location = new System.Drawing.Point(8, 39);
            this.PathGenButton.Name = "PathGenButton";
            this.PathGenButton.Size = new System.Drawing.Size(124, 39);
            this.PathGenButton.TabIndex = 9;
            this.PathGenButton.Text = "Generate Path";
            this.PathGenButton.UseVisualStyleBackColor = true;
            this.PathGenButton.Click += new System.EventHandler(this.PathGenButton_Click);
            // 
            // RefreshObjectsButton
            // 
            this.RefreshObjectsButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RefreshObjectsButton.Location = new System.Drawing.Point(8, 148);
            this.RefreshObjectsButton.Name = "RefreshObjectsButton";
            this.RefreshObjectsButton.Size = new System.Drawing.Size(124, 35);
            this.RefreshObjectsButton.TabIndex = 10;
            this.RefreshObjectsButton.Text = "Refresh";
            this.RefreshObjectsButton.UseVisualStyleBackColor = false;
            this.RefreshObjectsButton.Click += new System.EventHandler(this.RefreshObjectsButton_Click);
            // 
            // ShapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button PolygonPlaceButton;
        private System.Windows.Forms.NumericUpDown RotationNumeric;
        private System.Windows.Forms.NumericUpDown RadiusNumeric;
        private System.Windows.Forms.NumericUpDown VerticesNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PathGenButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RefreshObjectsButton;
    }
}

