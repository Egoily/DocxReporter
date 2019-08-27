namespace DocxSearcher
{
    partial class UcExplorer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBoxSearchDirectory = new System.Windows.Forms.GroupBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnSearchDirectory = new System.Windows.Forms.Button();
            this.cBoxUseSubdirectories = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxFind = new System.Windows.Forms.GroupBox();
            this.rBtnRegex = new System.Windows.Forms.RadioButton();
            this.rBtnText = new System.Windows.Forms.RadioButton();
            this.cBoxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lvSearchResult = new System.Windows.Forms.ListView();
            this.colFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddToReportList = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBoxSearchDirectory.SuspendLayout();
            this.groupBoxFind.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.White;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBoxSearchDirectory);
            this.splitContainer.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer.Panel1.Controls.Add(this.groupBoxFind);
            this.splitContainer.Panel1MinSize = 240;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lvSearchResult);
            this.splitContainer.Size = new System.Drawing.Size(680, 493);
            this.splitContainer.SplitterDistance = 240;
            this.splitContainer.TabIndex = 4;
            // 
            // groupBoxSearchDirectory
            // 
            this.groupBoxSearchDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchDirectory.Controls.Add(this.txtDirectory);
            this.groupBoxSearchDirectory.Controls.Add(this.btnSearchDirectory);
            this.groupBoxSearchDirectory.Controls.Add(this.cBoxUseSubdirectories);
            this.groupBoxSearchDirectory.Location = new System.Drawing.Point(6, 3);
            this.groupBoxSearchDirectory.Name = "groupBoxSearchDirectory";
            this.groupBoxSearchDirectory.Size = new System.Drawing.Size(228, 72);
            this.groupBoxSearchDirectory.TabIndex = 8;
            this.groupBoxSearchDirectory.TabStop = false;
            this.groupBoxSearchDirectory.Text = "文档目录";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.Location = new System.Drawing.Point(6, 20);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(216, 21);
            this.txtDirectory.TabIndex = 4;
            // 
            // btnSearchDirectory
            // 
            this.btnSearchDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchDirectory.Location = new System.Drawing.Point(190, 43);
            this.btnSearchDirectory.Name = "btnSearchDirectory";
            this.btnSearchDirectory.Size = new System.Drawing.Size(32, 23);
            this.btnSearchDirectory.TabIndex = 3;
            this.btnSearchDirectory.Text = "...";
            this.btnSearchDirectory.UseVisualStyleBackColor = true;
            this.btnSearchDirectory.Click += new System.EventHandler(this.btnSearchDirectory_Click);
            // 
            // cBoxUseSubdirectories
            // 
            this.cBoxUseSubdirectories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cBoxUseSubdirectories.AutoSize = true;
            this.cBoxUseSubdirectories.Location = new System.Drawing.Point(8, 45);
            this.cBoxUseSubdirectories.Name = "cBoxUseSubdirectories";
            this.cBoxUseSubdirectories.Size = new System.Drawing.Size(108, 16);
            this.cBoxUseSubdirectories.TabIndex = 2;
            this.cBoxUseSubdirectories.Text = "在子目录中搜索";
            this.cBoxUseSubdirectories.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(58, 320);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 48);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBoxFind
            // 
            this.groupBoxFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFind.Controls.Add(this.rBtnRegex);
            this.groupBoxFind.Controls.Add(this.rBtnText);
            this.groupBoxFind.Controls.Add(this.cBoxCaseSensitive);
            this.groupBoxFind.Controls.Add(this.txtSearch);
            this.groupBoxFind.Controls.Add(this.lb1);
            this.groupBoxFind.Location = new System.Drawing.Point(6, 104);
            this.groupBoxFind.Name = "groupBoxFind";
            this.groupBoxFind.Size = new System.Drawing.Size(228, 190);
            this.groupBoxFind.TabIndex = 1;
            this.groupBoxFind.TabStop = false;
            this.groupBoxFind.Text = "搜索";
            // 
            // rBtnRegex
            // 
            this.rBtnRegex.AutoSize = true;
            this.rBtnRegex.Location = new System.Drawing.Point(8, 130);
            this.rBtnRegex.Name = "rBtnRegex";
            this.rBtnRegex.Size = new System.Drawing.Size(83, 16);
            this.rBtnRegex.TabIndex = 9;
            this.rBtnRegex.Text = "正则表达式";
            this.rBtnRegex.UseVisualStyleBackColor = true;
            // 
            // rBtnText
            // 
            this.rBtnText.AutoSize = true;
            this.rBtnText.Checked = true;
            this.rBtnText.Location = new System.Drawing.Point(8, 109);
            this.rBtnText.Name = "rBtnText";
            this.rBtnText.Size = new System.Drawing.Size(47, 16);
            this.rBtnText.TabIndex = 7;
            this.rBtnText.TabStop = true;
            this.rBtnText.Text = "文本";
            this.rBtnText.UseVisualStyleBackColor = true;
            // 
            // cBoxCaseSensitive
            // 
            this.cBoxCaseSensitive.AutoSize = true;
            this.cBoxCaseSensitive.Location = new System.Drawing.Point(8, 152);
            this.cBoxCaseSensitive.Name = "cBoxCaseSensitive";
            this.cBoxCaseSensitive.Size = new System.Drawing.Size(84, 16);
            this.cBoxCaseSensitive.TabIndex = 3;
            this.cBoxCaseSensitive.Text = "区分大小写";
            this.cBoxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(6, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(216, 21);
            this.txtSearch.TabIndex = 2;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(6, 31);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(47, 12);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "关键字:";
            // 
            // lvSearchResult
            // 
            this.lvSearchResult.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFileName,
            this.colSize,
            this.colFilePath});
            this.lvSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSearchResult.FullRowSelect = true;
            this.lvSearchResult.HideSelection = false;
            this.lvSearchResult.Location = new System.Drawing.Point(0, 0);
            this.lvSearchResult.MultiSelect = false;
            this.lvSearchResult.Name = "lvSearchResult";
            this.lvSearchResult.Size = new System.Drawing.Size(436, 493);
            this.lvSearchResult.TabIndex = 8;
            this.lvSearchResult.UseCompatibleStateImageBehavior = false;
            this.lvSearchResult.View = System.Windows.Forms.View.Details;
            this.lvSearchResult.ItemActivate += new System.EventHandler(this.resultListView_ItemActivate);
            this.lvSearchResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resultListView_MouseClick);
            // 
            // colFileName
            // 
            this.colFileName.Text = "文件名";
            this.colFileName.Width = 400;
            // 
            // colSize
            // 
            this.colSize.Text = "大小 [KB]";
            this.colSize.Width = 100;
            // 
            // colFilePath
            // 
            this.colFilePath.Text = "路径";
            this.colFilePath.Width = 460;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiAddToReportList});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 48);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(148, 22);
            this.tsmiOpen.Text = "打开";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiAddToReportList
            // 
            this.tsmiAddToReportList.Name = "tsmiAddToReportList";
            this.tsmiAddToReportList.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddToReportList.Text = "加到检索列表";
            this.tsmiAddToReportList.Click += new System.EventHandler(this.tsmiAddToReportList_Click);
            // 
            // UcExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Name = "UcExplorer";
            this.Size = new System.Drawing.Size(680, 493);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBoxSearchDirectory.ResumeLayout(false);
            this.groupBoxSearchDirectory.PerformLayout();
            this.groupBoxFind.ResumeLayout(false);
            this.groupBoxFind.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBoxSearchDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnSearchDirectory;
        private System.Windows.Forms.CheckBox cBoxUseSubdirectories;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBoxFind;
        private System.Windows.Forms.RadioButton rBtnRegex;
        private System.Windows.Forms.RadioButton rBtnText;
        private System.Windows.Forms.CheckBox cBoxCaseSensitive;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ListView lvSearchResult;
        private System.Windows.Forms.ColumnHeader colFileName;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colFilePath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddToReportList;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
    }
}
