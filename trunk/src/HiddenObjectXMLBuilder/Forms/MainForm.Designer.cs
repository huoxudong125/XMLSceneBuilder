﻿namespace HiddenObjectsXMLBuilder
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxSrcPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDstPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.listViewScenes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBrowseSourcePath = new System.Windows.Forms.Button();
            this.buttonBrowseDstPath = new System.Windows.Forms.Button();
            this.textBoxTextsXmlLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTextsXmlBrowse = new System.Windows.Forms.Button();
            this.checkBoxRebuildTexts = new System.Windows.Forms.CheckBox();
            this.checkBoxRebuildTP = new System.Windows.Forms.CheckBox();
            this.checkBoxBuildAlphaSelection = new System.Windows.Forms.CheckBox();
            this.checkBoxActiveZonesVisible = new System.Windows.Forms.CheckBox();
            this.checkBoxRebuildItems = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRebuildResources = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxNavigation = new System.Windows.Forms.CheckBox();
            this.checkBoxRebuildLevels = new System.Windows.Forms.CheckBox();
            this.checkBoxGlints = new System.Windows.Forms.CheckBox();
            this.checkBoxRebuildHints = new System.Windows.Forms.CheckBox();
            this.checkBoxRebuildScene = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxMorfing = new System.Windows.Forms.CheckBox();
            this.checkBoxFadeAnimations = new System.Windows.Forms.CheckBox();
            this.checkBoxHummingBirds = new System.Windows.Forms.CheckBox();
            this.checkBoxSomeFuncs = new System.Windows.Forms.CheckBox();
            this.checkBoxEE = new System.Windows.Forms.CheckBox();
            this.buttonLevelsXmlBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLevelsXmlLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonNavigation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNavigation = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glintsAdderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapsAndAnimationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveParametres = new System.Windows.Forms.Button();
            this.resourcesManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.ImageKey = "(none)";
            this.buttonStart.Location = new System.Drawing.Point(378, 697);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(115, 32);
            this.buttonStart.TabIndex = 33;
            this.buttonStart.Text = "Build";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBoxSrcPath
            // 
            this.textBoxSrcPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSrcPath.Location = new System.Drawing.Point(173, 36);
            this.textBoxSrcPath.Name = "textBoxSrcPath";
            this.textBoxSrcPath.Size = new System.Drawing.Size(284, 20);
            this.textBoxSrcPath.TabIndex = 1;
            this.textBoxSrcPath.TextChanged += new System.EventHandler(this.textBoxSrcPath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path to \"png\"";
            // 
            // textBoxDstPath
            // 
            this.textBoxDstPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDstPath.Location = new System.Drawing.Point(173, 71);
            this.textBoxDstPath.Name = "textBoxDstPath";
            this.textBoxDstPath.Size = new System.Drawing.Size(284, 20);
            this.textBoxDstPath.TabIndex = 3;
            this.textBoxDstPath.TextChanged += new System.EventHandler(this.textBoxDstPath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Path to \"scenes\"";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(3, 3);
            this.textBoxLog.MaxLength = 3276799;
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(479, 32);
            this.textBoxLog.TabIndex = 33;
            this.textBoxLog.Text = "Log";
            this.textBoxLog.WordWrap = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(8, 289);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonClearAll);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSelectAll);
            this.splitContainer1.Panel1.Controls.Add(this.listViewScenes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLog);
            this.splitContainer1.Size = new System.Drawing.Size(485, 191);
            this.splitContainer1.SplitterDistance = 149;
            this.splitContainer1.TabIndex = 14;
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearAll.Location = new System.Drawing.Point(88, 122);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAll.TabIndex = 16;
            this.buttonClearAll.Text = "Uncheck All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSelectAll.Location = new System.Drawing.Point(7, 122);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 15;
            this.buttonSelectAll.Text = "Check All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // listViewScenes
            // 
            this.listViewScenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewScenes.CheckBoxes = true;
            this.listViewScenes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewScenes.GridLines = true;
            this.listViewScenes.Location = new System.Drawing.Point(3, 3);
            this.listViewScenes.Name = "listViewScenes";
            this.listViewScenes.Size = new System.Drawing.Size(479, 113);
            this.listViewScenes.TabIndex = 14;
            this.listViewScenes.UseCompatibleStateImageBehavior = false;
            this.listViewScenes.View = System.Windows.Forms.View.Details;
            this.listViewScenes.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewScenes_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Scene";
            this.columnHeader1.Width = 1000;
            // 
            // buttonBrowseSourcePath
            // 
            this.buttonBrowseSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseSourcePath.Location = new System.Drawing.Point(463, 34);
            this.buttonBrowseSourcePath.Name = "buttonBrowseSourcePath";
            this.buttonBrowseSourcePath.Size = new System.Drawing.Size(30, 23);
            this.buttonBrowseSourcePath.TabIndex = 2;
            this.buttonBrowseSourcePath.Text = "...";
            this.buttonBrowseSourcePath.UseVisualStyleBackColor = true;
            this.buttonBrowseSourcePath.Click += new System.EventHandler(this.buttonBrowseSourcePath_Click);
            // 
            // buttonBrowseDstPath
            // 
            this.buttonBrowseDstPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseDstPath.Location = new System.Drawing.Point(463, 69);
            this.buttonBrowseDstPath.Name = "buttonBrowseDstPath";
            this.buttonBrowseDstPath.Size = new System.Drawing.Size(30, 23);
            this.buttonBrowseDstPath.TabIndex = 4;
            this.buttonBrowseDstPath.Text = "...";
            this.buttonBrowseDstPath.UseVisualStyleBackColor = true;
            this.buttonBrowseDstPath.Click += new System.EventHandler(this.buttonBrowseDstPath_Click);
            // 
            // textBoxTextsXmlLocation
            // 
            this.textBoxTextsXmlLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTextsXmlLocation.Location = new System.Drawing.Point(173, 108);
            this.textBoxTextsXmlLocation.Name = "textBoxTextsXmlLocation";
            this.textBoxTextsXmlLocation.Size = new System.Drawing.Size(284, 20);
            this.textBoxTextsXmlLocation.TabIndex = 5;
            this.textBoxTextsXmlLocation.TextChanged += new System.EventHandler(this.textBoxTextsXmlLocation_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path to \"texts\"";
            // 
            // buttonTextsXmlBrowse
            // 
            this.buttonTextsXmlBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTextsXmlBrowse.Location = new System.Drawing.Point(463, 106);
            this.buttonTextsXmlBrowse.Name = "buttonTextsXmlBrowse";
            this.buttonTextsXmlBrowse.Size = new System.Drawing.Size(30, 23);
            this.buttonTextsXmlBrowse.TabIndex = 6;
            this.buttonTextsXmlBrowse.Text = "...";
            this.buttonTextsXmlBrowse.UseVisualStyleBackColor = true;
            this.buttonTextsXmlBrowse.Click += new System.EventHandler(this.buttonTextsXmlBrowse_Click);
            // 
            // checkBoxRebuildTexts
            // 
            this.checkBoxRebuildTexts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxRebuildTexts.AutoSize = true;
            this.checkBoxRebuildTexts.Checked = true;
            this.checkBoxRebuildTexts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRebuildTexts.Location = new System.Drawing.Point(14, 706);
            this.checkBoxRebuildTexts.Name = "checkBoxRebuildTexts";
            this.checkBoxRebuildTexts.Size = new System.Drawing.Size(82, 17);
            this.checkBoxRebuildTexts.TabIndex = 32;
            this.checkBoxRebuildTexts.Text = "rebuild texts";
            this.checkBoxRebuildTexts.UseVisualStyleBackColor = true;
            this.checkBoxRebuildTexts.CheckedChanged += new System.EventHandler(this.checkBoxRebuildTexts_CheckedChanged);
            // 
            // checkBoxRebuildTP
            // 
            this.checkBoxRebuildTP.AutoSize = true;
            this.checkBoxRebuildTP.Checked = true;
            this.checkBoxRebuildTP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRebuildTP.Location = new System.Drawing.Point(10, 40);
            this.checkBoxRebuildTP.Name = "checkBoxRebuildTP";
            this.checkBoxRebuildTP.Size = new System.Drawing.Size(124, 17);
            this.checkBoxRebuildTP.TabIndex = 18;
            this.checkBoxRebuildTP.Text = "rebuild Texture Pack";
            this.checkBoxRebuildTP.UseVisualStyleBackColor = true;
            this.checkBoxRebuildTP.CheckedChanged += new System.EventHandler(this.checkBoxRebuildTP_CheckedChanged);
            // 
            // checkBoxBuildAlphaSelection
            // 
            this.checkBoxBuildAlphaSelection.AutoSize = true;
            this.checkBoxBuildAlphaSelection.Location = new System.Drawing.Point(22, 81);
            this.checkBoxBuildAlphaSelection.Name = "checkBoxBuildAlphaSelection";
            this.checkBoxBuildAlphaSelection.Size = new System.Drawing.Size(147, 17);
            this.checkBoxBuildAlphaSelection.TabIndex = 20;
            this.checkBoxBuildAlphaSelection.Text = "Generate Alpha Selection";
            this.checkBoxBuildAlphaSelection.UseVisualStyleBackColor = true;
            // 
            // checkBoxActiveZonesVisible
            // 
            this.checkBoxActiveZonesVisible.AutoSize = true;
            this.checkBoxActiveZonesVisible.Location = new System.Drawing.Point(22, 63);
            this.checkBoxActiveZonesVisible.Name = "checkBoxActiveZonesVisible";
            this.checkBoxActiveZonesVisible.Size = new System.Drawing.Size(167, 17);
            this.checkBoxActiveZonesVisible.TabIndex = 19;
            this.checkBoxActiveZonesVisible.Text = "Save the Active Zones visible";
            this.checkBoxActiveZonesVisible.UseVisualStyleBackColor = true;
            // 
            // checkBoxRebuildItems
            // 
            this.checkBoxRebuildItems.AutoSize = true;
            this.checkBoxRebuildItems.Location = new System.Drawing.Point(22, 42);
            this.checkBoxRebuildItems.Name = "checkBoxRebuildItems";
            this.checkBoxRebuildItems.Size = new System.Drawing.Size(102, 17);
            this.checkBoxRebuildItems.TabIndex = 27;
            this.checkBoxRebuildItems.Text = "rebuild items.xml";
            this.checkBoxRebuildItems.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxRebuildResources);
            this.groupBox1.Controls.Add(this.checkBoxRebuildTP);
            this.groupBox1.Controls.Add(this.checkBoxBuildAlphaSelection);
            this.groupBox1.Controls.Add(this.checkBoxActiveZonesVisible);
            this.groupBox1.Location = new System.Drawing.Point(8, 486);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 110);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resources";
            // 
            // checkBoxRebuildResources
            // 
            this.checkBoxRebuildResources.AutoSize = true;
            this.checkBoxRebuildResources.Checked = true;
            this.checkBoxRebuildResources.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRebuildResources.Location = new System.Drawing.Point(10, 17);
            this.checkBoxRebuildResources.Name = "checkBoxRebuildResources";
            this.checkBoxRebuildResources.Size = new System.Drawing.Size(124, 17);
            this.checkBoxRebuildResources.TabIndex = 17;
            this.checkBoxRebuildResources.Text = "rebuild resources.xml";
            this.checkBoxRebuildResources.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxNavigation);
            this.groupBox2.Controls.Add(this.checkBoxRebuildLevels);
            this.groupBox2.Controls.Add(this.checkBoxGlints);
            this.groupBox2.Controls.Add(this.checkBoxRebuildHints);
            this.groupBox2.Controls.Add(this.checkBoxRebuildScene);
            this.groupBox2.Controls.Add(this.checkBoxRebuildItems);
            this.groupBox2.Location = new System.Drawing.Point(8, 602);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 89);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scene";
            // 
            // checkBoxNavigation
            // 
            this.checkBoxNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxNavigation.Checked = true;
            this.checkBoxNavigation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNavigation.Location = new System.Drawing.Point(283, 65);
            this.checkBoxNavigation.Name = "checkBoxNavigation";
            this.checkBoxNavigation.Size = new System.Drawing.Size(166, 17);
            this.checkBoxNavigation.TabIndex = 31;
            this.checkBoxNavigation.Text = "Add to navigation and quest";
            this.checkBoxNavigation.UseVisualStyleBackColor = true;
            this.checkBoxNavigation.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxRebuildLevels
            // 
            this.checkBoxRebuildLevels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRebuildLevels.Checked = true;
            this.checkBoxRebuildLevels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRebuildLevels.Location = new System.Drawing.Point(283, 42);
            this.checkBoxRebuildLevels.Name = "checkBoxRebuildLevels";
            this.checkBoxRebuildLevels.Size = new System.Drawing.Size(139, 17);
            this.checkBoxRebuildLevels.TabIndex = 30;
            this.checkBoxRebuildLevels.Text = "Add to levels.xml";
            this.checkBoxRebuildLevels.UseVisualStyleBackColor = true;
            this.checkBoxRebuildLevels.CheckedChanged += new System.EventHandler(this.checkBoxRebuildLevels_CheckedChanged);
            // 
            // checkBoxGlints
            // 
            this.checkBoxGlints.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxGlints.Checked = true;
            this.checkBoxGlints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGlints.Location = new System.Drawing.Point(283, 19);
            this.checkBoxGlints.Name = "checkBoxGlints";
            this.checkBoxGlints.Size = new System.Drawing.Size(74, 17);
            this.checkBoxGlints.TabIndex = 29;
            this.checkBoxGlints.Text = "glints.xml";
            this.checkBoxGlints.UseVisualStyleBackColor = true;
            // 
            // checkBoxRebuildHints
            // 
            this.checkBoxRebuildHints.AutoSize = true;
            this.checkBoxRebuildHints.Location = new System.Drawing.Point(22, 65);
            this.checkBoxRebuildHints.Name = "checkBoxRebuildHints";
            this.checkBoxRebuildHints.Size = new System.Drawing.Size(100, 17);
            this.checkBoxRebuildHints.TabIndex = 28;
            this.checkBoxRebuildHints.Text = "rebuild hints.xml";
            this.checkBoxRebuildHints.UseVisualStyleBackColor = true;
            // 
            // checkBoxRebuildScene
            // 
            this.checkBoxRebuildScene.AutoSize = true;
            this.checkBoxRebuildScene.Checked = true;
            this.checkBoxRebuildScene.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRebuildScene.Location = new System.Drawing.Point(10, 19);
            this.checkBoxRebuildScene.Name = "checkBoxRebuildScene";
            this.checkBoxRebuildScene.Size = new System.Drawing.Size(89, 17);
            this.checkBoxRebuildScene.TabIndex = 26;
            this.checkBoxRebuildScene.Text = "rebuild scene\r\n";
            this.checkBoxRebuildScene.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.checkBoxMorfing);
            this.groupBox3.Controls.Add(this.checkBoxFadeAnimations);
            this.groupBox3.Controls.Add(this.checkBoxHummingBirds);
            this.groupBox3.Controls.Add(this.checkBoxSomeFuncs);
            this.groupBox3.Controls.Add(this.checkBoxEE);
            this.groupBox3.Location = new System.Drawing.Point(289, 486);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 110);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scripts";
            // 
            // checkBoxMorfing
            // 
            this.checkBoxMorfing.AutoSize = true;
            this.checkBoxMorfing.Checked = true;
            this.checkBoxMorfing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMorfing.Enabled = false;
            this.checkBoxMorfing.Location = new System.Drawing.Point(137, 40);
            this.checkBoxMorfing.Name = "checkBoxMorfing";
            this.checkBoxMorfing.Size = new System.Drawing.Size(60, 17);
            this.checkBoxMorfing.TabIndex = 23;
            this.checkBoxMorfing.Text = "morfing";
            this.checkBoxMorfing.UseVisualStyleBackColor = true;
            // 
            // checkBoxFadeAnimations
            // 
            this.checkBoxFadeAnimations.AutoSize = true;
            this.checkBoxFadeAnimations.Location = new System.Drawing.Point(14, 86);
            this.checkBoxFadeAnimations.Name = "checkBoxFadeAnimations";
            this.checkBoxFadeAnimations.Size = new System.Drawing.Size(144, 17);
            this.checkBoxFadeAnimations.TabIndex = 25;
            this.checkBoxFadeAnimations.Text = "ncux_fade_animation.lua";
            this.checkBoxFadeAnimations.UseVisualStyleBackColor = true;
            // 
            // checkBoxHummingBirds
            // 
            this.checkBoxHummingBirds.AutoSize = true;
            this.checkBoxHummingBirds.Location = new System.Drawing.Point(14, 63);
            this.checkBoxHummingBirds.Name = "checkBoxHummingBirds";
            this.checkBoxHummingBirds.Size = new System.Drawing.Size(113, 17);
            this.checkBoxHummingBirds.TabIndex = 24;
            this.checkBoxHummingBirds.Text = "humming_birds.lua";
            this.checkBoxHummingBirds.UseVisualStyleBackColor = true;
            // 
            // checkBoxSomeFuncs
            // 
            this.checkBoxSomeFuncs.AutoSize = true;
            this.checkBoxSomeFuncs.Location = new System.Drawing.Point(14, 40);
            this.checkBoxSomeFuncs.Name = "checkBoxSomeFuncs";
            this.checkBoxSomeFuncs.Size = new System.Drawing.Size(100, 17);
            this.checkBoxSomeFuncs.TabIndex = 22;
            this.checkBoxSomeFuncs.Text = "some_funcs.lua";
            this.checkBoxSomeFuncs.UseVisualStyleBackColor = true;
            this.checkBoxSomeFuncs.CheckedChanged += new System.EventHandler(this.checkBoxSomeFuncs_CheckedChanged);
            // 
            // checkBoxEE
            // 
            this.checkBoxEE.AutoSize = true;
            this.checkBoxEE.Checked = true;
            this.checkBoxEE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEE.Location = new System.Drawing.Point(14, 17);
            this.checkBoxEE.Name = "checkBoxEE";
            this.checkBoxEE.Size = new System.Drawing.Size(55, 17);
            this.checkBoxEE.TabIndex = 21;
            this.checkBoxEE.Text = "ee.lua";
            this.checkBoxEE.UseVisualStyleBackColor = true;
            // 
            // buttonLevelsXmlBrowse
            // 
            this.buttonLevelsXmlBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLevelsXmlBrowse.Location = new System.Drawing.Point(463, 179);
            this.buttonLevelsXmlBrowse.Name = "buttonLevelsXmlBrowse";
            this.buttonLevelsXmlBrowse.Size = new System.Drawing.Size(30, 23);
            this.buttonLevelsXmlBrowse.TabIndex = 10;
            this.buttonLevelsXmlBrowse.Text = "...";
            this.buttonLevelsXmlBrowse.UseVisualStyleBackColor = true;
            this.buttonLevelsXmlBrowse.Click += new System.EventHandler(this.buttonLevelsXmlBrowse_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Path to \"levels.xml\"";
            // 
            // textBoxLevelsXmlLocation
            // 
            this.textBoxLevelsXmlLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLevelsXmlLocation.Location = new System.Drawing.Point(173, 181);
            this.textBoxLevelsXmlLocation.Name = "textBoxLevelsXmlLocation";
            this.textBoxLevelsXmlLocation.Size = new System.Drawing.Size(284, 20);
            this.textBoxLevelsXmlLocation.TabIndex = 9;
            this.textBoxLevelsXmlLocation.TextChanged += new System.EventHandler(this.textBoxLevelsXmlLocation_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "First or last name (to be spelled out in the gdd_name)";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(273, 216);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(220, 20);
            this.textBoxName.TabIndex = 11;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonNavigation
            // 
            this.buttonNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNavigation.Location = new System.Drawing.Point(463, 143);
            this.buttonNavigation.Name = "buttonNavigation";
            this.buttonNavigation.Size = new System.Drawing.Size(30, 23);
            this.buttonNavigation.TabIndex = 8;
            this.buttonNavigation.Text = "...";
            this.buttonNavigation.UseVisualStyleBackColor = true;
            this.buttonNavigation.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Path to \"hint_system\"";
            // 
            // textBoxNavigation
            // 
            this.textBoxNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNavigation.Location = new System.Drawing.Point(173, 145);
            this.textBoxNavigation.Name = "textBoxNavigation";
            this.textBoxNavigation.Size = new System.Drawing.Size(284, 20);
            this.textBoxNavigation.TabIndex = 7;
            this.textBoxNavigation.TextChanged += new System.EventHandler(this.textBoxNavigation_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemProjects,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "&File";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(129, 22);
            this.toolStripMenuItemExit.Text = "E&xit";
            this.toolStripMenuItemExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemProjects
            // 
            this.toolStripMenuItemProjects.Name = "toolStripMenuItemProjects";
            this.toolStripMenuItemProjects.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItemProjects.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItemProjects.Text = "&Projects";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glintsAdderToolStripMenuItem,
            this.mapsAndAnimationsToolStripMenuItem,
            this.resourcesManagerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // glintsAdderToolStripMenuItem
            // 
            this.glintsAdderToolStripMenuItem.Name = "glintsAdderToolStripMenuItem";
            this.glintsAdderToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.glintsAdderToolStripMenuItem.Text = "Glints Adder";
            this.glintsAdderToolStripMenuItem.Click += new System.EventHandler(this.glintsAdderToolStripMenuItem_Click);
            // 
            // mapsAndAnimationsToolStripMenuItem
            // 
            this.mapsAndAnimationsToolStripMenuItem.Name = "mapsAndAnimationsToolStripMenuItem";
            this.mapsAndAnimationsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.mapsAndAnimationsToolStripMenuItem.Text = "Maps and Animations";
            // 
            // buttonSaveParametres
            // 
            this.buttonSaveParametres.Location = new System.Drawing.Point(12, 250);
            this.buttonSaveParametres.Name = "buttonSaveParametres";
            this.buttonSaveParametres.Size = new System.Drawing.Size(155, 23);
            this.buttonSaveParametres.TabIndex = 12;
            this.buttonSaveParametres.Text = "&Save Settings";
            this.buttonSaveParametres.UseVisualStyleBackColor = true;
            this.buttonSaveParametres.Click += new System.EventHandler(this.buttonSaveParametres_Click);
            this.buttonSaveParametres.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSaveParametres_Click);
            // 
            // resourcesManagerToolStripMenuItem
            // 
            this.resourcesManagerToolStripMenuItem.Name = "resourcesManagerToolStripMenuItem";
            this.resourcesManagerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.resourcesManagerToolStripMenuItem.Text = "Resources Manager";
            this.resourcesManagerToolStripMenuItem.Click += new System.EventHandler(this.resourcesManagerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(505, 741);
            this.Controls.Add(this.buttonSaveParametres);
            this.Controls.Add(this.buttonNavigation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNavigation);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonLevelsXmlBrowse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLevelsXmlLocation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBoxRebuildTexts);
            this.Controls.Add(this.buttonTextsXmlBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTextsXmlLocation);
            this.Controls.Add(this.buttonBrowseDstPath);
            this.Controls.Add(this.buttonBrowseSourcePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDstPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSrcPath);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1500, 1030);
            this.MinimumSize = new System.Drawing.Size(515, 689);
            this.Name = "MainForm";
            this.Text = "HiddenObjectsXmlBuilder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxSrcPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDstPath;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxLog;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView listViewScenes;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button buttonBrowseSourcePath;
		private System.Windows.Forms.Button buttonBrowseDstPath;
		private System.Windows.Forms.TextBox textBoxTextsXmlLocation;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonTextsXmlBrowse;
		private System.Windows.Forms.Button buttonClearAll;
		private System.Windows.Forms.Button buttonSelectAll;
		private System.Windows.Forms.CheckBox checkBoxRebuildTexts;
        private System.Windows.Forms.CheckBox checkBoxRebuildTP;
		private System.Windows.Forms.CheckBox checkBoxBuildAlphaSelection;
		private System.Windows.Forms.CheckBox checkBoxActiveZonesVisible;
		private System.Windows.Forms.CheckBox checkBoxRebuildItems;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBoxRebuildScene;
		private System.Windows.Forms.CheckBox checkBoxRebuildResources;
		private System.Windows.Forms.CheckBox checkBoxRebuildHints;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxSomeFuncs;
        private System.Windows.Forms.CheckBox checkBoxEE;
        private System.Windows.Forms.CheckBox checkBoxHummingBirds;
        private System.Windows.Forms.CheckBox checkBoxFadeAnimations;
        private System.Windows.Forms.CheckBox checkBoxGlints;
        private System.Windows.Forms.CheckBox checkBoxMorfing;
        private System.Windows.Forms.CheckBox checkBoxRebuildLevels;
        private System.Windows.Forms.Button buttonLevelsXmlBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLevelsXmlLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonNavigation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNavigation;
        private System.Windows.Forms.CheckBox checkBoxNavigation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProjects;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.Button buttonSaveParametres;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glintsAdderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapsAndAnimationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesManagerToolStripMenuItem;
    }
}