﻿namespace GenArt
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.picPattern = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrRedraw = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dNAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dNAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sVGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.seedTxtBox = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.onlyTiny = new System.Windows.Forms.CheckBox();
            this.allowEllipses = new System.Windows.Forms.CheckBox();
            this.allowCircles = new System.Windows.Forms.CheckBox();
            this.allowPolygons = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.pnlCanvas = new GenArt.Canvas();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFitness = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGeneration = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPolygons = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPattern
            // 
            this.picPattern.Image = global::GenArt.Properties.Resources.ml1;
            this.picPattern.Location = new System.Drawing.Point(12, 16);
            this.picPattern.Name = "picPattern";
            this.picPattern.Size = new System.Drawing.Size(200, 200);
            this.picPattern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPattern.TabIndex = 3;
            this.picPattern.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source image";
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Location = new System.Drawing.Point(0, 584);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(230, 41);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrRedraw
            // 
            this.tmrRedraw.Interval = 10;
            this.tmrRedraw.Tick += new System.EventHandler(this.tmrRedraw_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Generated image";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourceImageToolStripMenuItem,
            this.dNAToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // sourceImageToolStripMenuItem
            // 
            this.sourceImageToolStripMenuItem.Name = "sourceImageToolStripMenuItem";
            this.sourceImageToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sourceImageToolStripMenuItem.Text = "Source Image";
            this.sourceImageToolStripMenuItem.Click += new System.EventHandler(this.sourceImageToolStripMenuItem_Click);
            // 
            // dNAToolStripMenuItem
            // 
            this.dNAToolStripMenuItem.Name = "dNAToolStripMenuItem";
            this.dNAToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.dNAToolStripMenuItem.Text = "DNA";
            this.dNAToolStripMenuItem.Click += new System.EventHandler(this.dNAToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dNAToolStripMenuItem1,
            this.sVGToolStripMenuItem,
            this.pNGToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // dNAToolStripMenuItem1
            // 
            this.dNAToolStripMenuItem1.Name = "dNAToolStripMenuItem1";
            this.dNAToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.dNAToolStripMenuItem1.Text = "DNA";
            this.dNAToolStripMenuItem1.Click += new System.EventHandler(this.dNAToolStripMenuItem1_Click);
            // 
            // sVGToolStripMenuItem
            // 
            this.sVGToolStripMenuItem.Name = "sVGToolStripMenuItem";
            this.sVGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.sVGToolStripMenuItem.Text = "SVG";
            this.sVGToolStripMenuItem.Click += new System.EventHandler(this.sVGToolStripMenuItem1_Click);
            // 
            // pNGToolStripMenuItem
            // 
            this.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            this.pNGToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.pNGToolStripMenuItem.Text = "PNG";
            this.pNGToolStripMenuItem.Click += new System.EventHandler(this.pNGToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.seedTxtBox);
            this.splitContainer1.Panel1.Controls.Add(this.btnPrev);
            this.splitContainer1.Panel1.Controls.Add(this.btnNext);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.onlyTiny);
            this.splitContainer1.Panel1.Controls.Add(this.allowEllipses);
            this.splitContainer1.Panel1.Controls.Add(this.allowCircles);
            this.splitContainer1.Panel1.Controls.Add(this.allowPolygons);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.trackBarScale);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnStart);
            this.splitContainer1.Panel1.Controls.Add(this.picPattern);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.pnlCanvas);
            this.splitContainer1.Size = new System.Drawing.Size(1072, 625);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seed";
            // 
            // seedTxtBox
            // 
            this.seedTxtBox.Location = new System.Drawing.Point(47, 314);
            this.seedTxtBox.Name = "seedTxtBox";
            this.seedTxtBox.Size = new System.Drawing.Size(164, 20);
            this.seedTxtBox.TabIndex = 32;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(136, 245);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 31;
            this.btnPrev.Text = "Prev Image";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(136, 222);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 30;
            this.btnNext.Text = "Next Image";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 340);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 183);
            this.textBox1.TabIndex = 29;
            // 
            // onlyTiny
            // 
            this.onlyTiny.AutoSize = true;
            this.onlyTiny.Location = new System.Drawing.Point(12, 291);
            this.onlyTiny.Name = "onlyTiny";
            this.onlyTiny.Size = new System.Drawing.Size(108, 17);
            this.onlyTiny.TabIndex = 28;
            this.onlyTiny.Text = "Allow Tiny Circles";
            this.onlyTiny.UseVisualStyleBackColor = true;
            this.onlyTiny.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // allowEllipses
            // 
            this.allowEllipses.AutoSize = true;
            this.allowEllipses.Location = new System.Drawing.Point(12, 268);
            this.allowEllipses.Name = "allowEllipses";
            this.allowEllipses.Size = new System.Drawing.Size(89, 17);
            this.allowEllipses.TabIndex = 27;
            this.allowEllipses.Text = "Allow Ellipses";
            this.allowEllipses.UseVisualStyleBackColor = true;
            this.allowEllipses.CheckedChanged += new System.EventHandler(this.allowEllipses_CheckedChanged);
            // 
            // allowCircles
            // 
            this.allowCircles.AutoSize = true;
            this.allowCircles.Checked = true;
            this.allowCircles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allowCircles.Location = new System.Drawing.Point(12, 245);
            this.allowCircles.Name = "allowCircles";
            this.allowCircles.Size = new System.Drawing.Size(85, 17);
            this.allowCircles.TabIndex = 26;
            this.allowCircles.Text = "Allow Circles";
            this.allowCircles.UseVisualStyleBackColor = true;
            this.allowCircles.CheckedChanged += new System.EventHandler(this.allowCircles_CheckedChanged);
            // 
            // allowPolygons
            // 
            this.allowPolygons.AutoSize = true;
            this.allowPolygons.Location = new System.Drawing.Point(12, 222);
            this.allowPolygons.Name = "allowPolygons";
            this.allowPolygons.Size = new System.Drawing.Size(97, 17);
            this.allowPolygons.TabIndex = 25;
            this.allowPolygons.Text = "Allow Polygons";
            this.allowPolygons.UseVisualStyleBackColor = true;
            this.allowPolygons.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 568);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "10";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 568);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(0, 526);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Generated image scale:";
            // 
            // trackBarScale
            // 
            this.trackBarScale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarScale.Location = new System.Drawing.Point(0, 539);
            this.trackBarScale.Minimum = 1;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(230, 45);
            this.trackBarScale.TabIndex = 21;
            this.trackBarScale.Value = 3;
            this.trackBarScale.Scroll += new System.EventHandler(this.trackBarScale_Scroll);
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.Black;
            this.pnlCanvas.Location = new System.Drawing.Point(6, 16);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Padding = new System.Windows.Forms.Padding(5);
            this.pnlCanvas.Size = new System.Drawing.Size(600, 600);
            this.pnlCanvas.TabIndex = 1;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelFitness,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelGeneration,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelSelected,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabelPolygons});
            this.statusStrip1.Location = new System.Drawing.Point(0, 649);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1072, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Fitness";
            // 
            // toolStripStatusLabelFitness
            // 
            this.toolStripStatusLabelFitness.AutoSize = false;
            this.toolStripStatusLabelFitness.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelFitness.Name = "toolStripStatusLabelFitness";
            this.toolStripStatusLabelFitness.Size = new System.Drawing.Size(213, 17);
            this.toolStripStatusLabelFitness.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel2.Text = "Generation";
            // 
            // toolStripStatusLabelGeneration
            // 
            this.toolStripStatusLabelGeneration.AutoSize = false;
            this.toolStripStatusLabelGeneration.Name = "toolStripStatusLabelGeneration";
            this.toolStripStatusLabelGeneration.Size = new System.Drawing.Size(213, 17);
            this.toolStripStatusLabelGeneration.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel3.Text = "Selected";
            // 
            // toolStripStatusLabelSelected
            // 
            this.toolStripStatusLabelSelected.AutoSize = false;
            this.toolStripStatusLabelSelected.Name = "toolStripStatusLabelSelected";
            this.toolStripStatusLabelSelected.Size = new System.Drawing.Size(213, 17);
            this.toolStripStatusLabelSelected.Spring = true;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel5.Text = "Shapes";
            // 
            // toolStripStatusLabelPolygons
            // 
            this.toolStripStatusLabelPolygons.AutoSize = false;
            this.toolStripStatusLabelPolygons.Name = "toolStripStatusLabelPolygons";
            this.toolStripStatusLabelPolygons.Size = new System.Drawing.Size(213, 17);
            this.toolStripStatusLabelPolygons.Spring = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 671);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetic Vectorizer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Canvas pnlCanvas;
        private System.Windows.Forms.PictureBox picPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrRedraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dNAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dNAToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarScale;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFitness;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGeneration;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelected;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPolygons;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripMenuItem sVGToolStripMenuItem;
        private System.Windows.Forms.CheckBox allowCircles;
        private System.Windows.Forms.CheckBox allowPolygons;
        private System.Windows.Forms.CheckBox allowEllipses;
        private System.Windows.Forms.CheckBox onlyTiny;
        private System.Windows.Forms.ToolStripMenuItem pNGToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seedTxtBox;
    }
}

