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
            this.GboxSearchDirectory = new System.Windows.Forms.GroupBox();
            this.TxtDirectory = new System.Windows.Forms.TextBox();
            this.BtnSearchDirectory = new System.Windows.Forms.Button();
            this.CboxUseSubdirectories = new System.Windows.Forms.CheckBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.GboxSearch = new System.Windows.Forms.GroupBox();
            this.GboxSearchType = new System.Windows.Forms.GroupBox();
            this.RbtnContent = new System.Windows.Forms.RadioButton();
            this.RbtnTitle = new System.Windows.Forms.RadioButton();
            this.GboxSearchPattern = new System.Windows.Forms.GroupBox();
            this.RbtnRegex = new System.Windows.Forms.RadioButton();
            this.RbtnText = new System.Windows.Forms.RadioButton();
            this.CboxCaseSensitive = new System.Windows.Forms.CheckBox();
            this.TxtKeyword = new System.Windows.Forms.TextBox();
            this.LblKeyword = new System.Windows.Forms.Label();
            this.LvSearchResult = new System.Windows.Forms.ListView();
            this.ColFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAddToReportList = new System.Windows.Forms.ToolStripMenuItem();
            this.ePanelSearch = new EgoDevil.Utilities.UI.EPanels.EPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.GboxSearchDirectory.SuspendLayout();
            this.GboxSearch.SuspendLayout();
            this.GboxSearchType.SuspendLayout();
            this.GboxSearchPattern.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.ePanelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.White;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(1, 28);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.LvSearchResult);
            this.splitContainer.Panel1MinSize = 240;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.BtnSearch);
            this.splitContainer.Panel2.Controls.Add(this.GboxSearchDirectory);
            this.splitContainer.Panel2.Controls.Add(this.GboxSearch);
            this.splitContainer.Size = new System.Drawing.Size(539, 436);
            this.splitContainer.SplitterDistance = 339;
            this.splitContainer.TabIndex = 4;
            // 
            // GboxSearchDirectory
            // 
            this.GboxSearchDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GboxSearchDirectory.Controls.Add(this.TxtDirectory);
            this.GboxSearchDirectory.Controls.Add(this.BtnSearchDirectory);
            this.GboxSearchDirectory.Controls.Add(this.CboxUseSubdirectories);
            this.GboxSearchDirectory.Location = new System.Drawing.Point(10, 14);
            this.GboxSearchDirectory.Name = "GboxSearchDirectory";
            this.GboxSearchDirectory.Size = new System.Drawing.Size(183, 72);
            this.GboxSearchDirectory.TabIndex = 8;
            this.GboxSearchDirectory.TabStop = false;
            this.GboxSearchDirectory.Text = "文档目录";
            // 
            // TxtDirectory
            // 
            this.TxtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDirectory.Location = new System.Drawing.Point(6, 20);
            this.TxtDirectory.Name = "TxtDirectory";
            this.TxtDirectory.Size = new System.Drawing.Size(171, 21);
            this.TxtDirectory.TabIndex = 4;
            // 
            // BtnSearchDirectory
            // 
            this.BtnSearchDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchDirectory.Location = new System.Drawing.Point(145, 43);
            this.BtnSearchDirectory.Name = "BtnSearchDirectory";
            this.BtnSearchDirectory.Size = new System.Drawing.Size(32, 23);
            this.BtnSearchDirectory.TabIndex = 3;
            this.BtnSearchDirectory.Text = "...";
            this.BtnSearchDirectory.UseVisualStyleBackColor = true;
            this.BtnSearchDirectory.Click += new System.EventHandler(this.BtnSearchDirectory_Click);
            // 
            // CboxUseSubdirectories
            // 
            this.CboxUseSubdirectories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CboxUseSubdirectories.AutoSize = true;
            this.CboxUseSubdirectories.Location = new System.Drawing.Point(8, 45);
            this.CboxUseSubdirectories.Name = "CboxUseSubdirectories";
            this.CboxUseSubdirectories.Size = new System.Drawing.Size(108, 16);
            this.CboxUseSubdirectories.TabIndex = 2;
            this.CboxUseSubdirectories.Text = "在子目录中搜索";
            this.CboxUseSubdirectories.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSearch.Location = new System.Drawing.Point(42, 365);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(113, 48);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.Text = "搜索";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // GboxSearch
            // 
            this.GboxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GboxSearch.Controls.Add(this.GboxSearchType);
            this.GboxSearch.Controls.Add(this.GboxSearchPattern);
            this.GboxSearch.Controls.Add(this.CboxCaseSensitive);
            this.GboxSearch.Controls.Add(this.TxtKeyword);
            this.GboxSearch.Controls.Add(this.LblKeyword);
            this.GboxSearch.Location = new System.Drawing.Point(10, 103);
            this.GboxSearch.Name = "GboxSearch";
            this.GboxSearch.Size = new System.Drawing.Size(183, 224);
            this.GboxSearch.TabIndex = 1;
            this.GboxSearch.TabStop = false;
            this.GboxSearch.Text = "搜索";
            // 
            // GboxSearchType
            // 
            this.GboxSearchType.Controls.Add(this.RbtnContent);
            this.GboxSearchType.Controls.Add(this.RbtnTitle);
            this.GboxSearchType.Location = new System.Drawing.Point(6, 78);
            this.GboxSearchType.Name = "GboxSearchType";
            this.GboxSearchType.Size = new System.Drawing.Size(213, 45);
            this.GboxSearchType.TabIndex = 9;
            this.GboxSearchType.TabStop = false;
            this.GboxSearchType.Text = "搜索类型";
            // 
            // RbtnContent
            // 
            this.RbtnContent.AutoSize = true;
            this.RbtnContent.Location = new System.Drawing.Point(72, 20);
            this.RbtnContent.Name = "RbtnContent";
            this.RbtnContent.Size = new System.Drawing.Size(47, 16);
            this.RbtnContent.TabIndex = 9;
            this.RbtnContent.Text = "内容";
            this.RbtnContent.UseVisualStyleBackColor = true;
            // 
            // RbtnTitle
            // 
            this.RbtnTitle.AutoSize = true;
            this.RbtnTitle.Checked = true;
            this.RbtnTitle.Location = new System.Drawing.Point(11, 20);
            this.RbtnTitle.Name = "RbtnTitle";
            this.RbtnTitle.Size = new System.Drawing.Size(47, 16);
            this.RbtnTitle.TabIndex = 7;
            this.RbtnTitle.TabStop = true;
            this.RbtnTitle.Text = "标题";
            this.RbtnTitle.UseVisualStyleBackColor = true;
            // 
            // GboxSearchPattern
            // 
            this.GboxSearchPattern.Controls.Add(this.RbtnRegex);
            this.GboxSearchPattern.Controls.Add(this.RbtnText);
            this.GboxSearchPattern.Location = new System.Drawing.Point(6, 129);
            this.GboxSearchPattern.Name = "GboxSearchPattern";
            this.GboxSearchPattern.Size = new System.Drawing.Size(213, 45);
            this.GboxSearchPattern.TabIndex = 9;
            this.GboxSearchPattern.TabStop = false;
            this.GboxSearchPattern.Text = "搜索方式";
            // 
            // RbtnRegex
            // 
            this.RbtnRegex.AutoSize = true;
            this.RbtnRegex.Location = new System.Drawing.Point(72, 20);
            this.RbtnRegex.Name = "RbtnRegex";
            this.RbtnRegex.Size = new System.Drawing.Size(83, 16);
            this.RbtnRegex.TabIndex = 9;
            this.RbtnRegex.Text = "正则表达式";
            this.RbtnRegex.UseVisualStyleBackColor = true;
            // 
            // RbtnText
            // 
            this.RbtnText.AutoSize = true;
            this.RbtnText.Checked = true;
            this.RbtnText.Location = new System.Drawing.Point(11, 20);
            this.RbtnText.Name = "RbtnText";
            this.RbtnText.Size = new System.Drawing.Size(47, 16);
            this.RbtnText.TabIndex = 7;
            this.RbtnText.TabStop = true;
            this.RbtnText.Text = "文本";
            this.RbtnText.UseVisualStyleBackColor = true;
            // 
            // CboxCaseSensitive
            // 
            this.CboxCaseSensitive.AutoSize = true;
            this.CboxCaseSensitive.Location = new System.Drawing.Point(8, 180);
            this.CboxCaseSensitive.Name = "CboxCaseSensitive";
            this.CboxCaseSensitive.Size = new System.Drawing.Size(84, 16);
            this.CboxCaseSensitive.TabIndex = 3;
            this.CboxCaseSensitive.Text = "区分大小写";
            this.CboxCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // TxtKeyword
            // 
            this.TxtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtKeyword.Location = new System.Drawing.Point(6, 45);
            this.TxtKeyword.Name = "TxtKeyword";
            this.TxtKeyword.Size = new System.Drawing.Size(171, 21);
            this.TxtKeyword.TabIndex = 2;
            // 
            // LblKeyword
            // 
            this.LblKeyword.AutoSize = true;
            this.LblKeyword.Location = new System.Drawing.Point(6, 31);
            this.LblKeyword.Name = "LblKeyword";
            this.LblKeyword.Size = new System.Drawing.Size(47, 12);
            this.LblKeyword.TabIndex = 0;
            this.LblKeyword.Text = "关键字:";
            // 
            // LvSearchResult
            // 
            this.LvSearchResult.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.LvSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LvSearchResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColFileName,
            this.ColSize,
            this.ColFilePath});
            this.LvSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvSearchResult.FullRowSelect = true;
            this.LvSearchResult.HideSelection = false;
            this.LvSearchResult.Location = new System.Drawing.Point(0, 0);
            this.LvSearchResult.Name = "LvSearchResult";
            this.LvSearchResult.Size = new System.Drawing.Size(339, 436);
            this.LvSearchResult.TabIndex = 8;
            this.LvSearchResult.UseCompatibleStateImageBehavior = false;
            this.LvSearchResult.View = System.Windows.Forms.View.Details;
            this.LvSearchResult.ItemActivate += new System.EventHandler(this.LvSearchResult_ItemActivate);
            this.LvSearchResult.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.LvSearchResult_ItemDrag);
            this.LvSearchResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LvSearchResult_MouseClick);
            // 
            // ColFileName
            // 
            this.ColFileName.Text = "文件名";
            this.ColFileName.Width = 200;
            // 
            // ColSize
            // 
            this.ColSize.Text = "大小 [KB]";
            // 
            // ColFilePath
            // 
            this.ColFilePath.Text = "路径";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiOpen,
            this.TsmiAddToReportList});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 48);
            // 
            // TsmiOpen
            // 
            this.TsmiOpen.Name = "TsmiOpen";
            this.TsmiOpen.Size = new System.Drawing.Size(148, 22);
            this.TsmiOpen.Text = "打开";
            this.TsmiOpen.Click += new System.EventHandler(this.TsmiOpen_Click);
            // 
            // TsmiAddToReportList
            // 
            this.TsmiAddToReportList.Name = "TsmiAddToReportList";
            this.TsmiAddToReportList.Size = new System.Drawing.Size(148, 22);
            this.TsmiAddToReportList.Text = "加到检索列表";
            this.TsmiAddToReportList.Click += new System.EventHandler(this.TsmiAddToReportList_Click);
            // 
            // ePanelSearch
            // 
            this.ePanelSearch.AssociatedSplitter = null;
            this.ePanelSearch.BackColor = System.Drawing.Color.Transparent;
            this.ePanelSearch.CaptionFont = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ePanelSearch.CaptionHeight = 27;
            this.ePanelSearch.Controls.Add(this.splitContainer);
            this.ePanelSearch.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ePanelSearch.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.ePanelSearch.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.ePanelSearch.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ePanelSearch.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.ePanelSearch.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ePanelSearch.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ePanelSearch.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ePanelSearch.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.ePanelSearch.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.ePanelSearch.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.ePanelSearch.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ePanelSearch.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.ePanelSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.ePanelSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ePanelSearch.Image = null;
            this.ePanelSearch.Location = new System.Drawing.Point(12, 0);
            this.ePanelSearch.MinimumSize = new System.Drawing.Size(27, 27);
            this.ePanelSearch.Name = "ePanelSearch";
            this.ePanelSearch.PanelStyle = EgoDevil.Utilities.UI.EPanels.PanelStyle.Office2007;
            this.ePanelSearch.ShowExpandIcon = true;
            this.ePanelSearch.ShowTransparentBackground = false;
            this.ePanelSearch.Size = new System.Drawing.Size(541, 465);
            this.ePanelSearch.TabIndex = 5;
            this.ePanelSearch.Text = "搜索";
            this.ePanelSearch.ToolTipTextCloseIcon = null;
            this.ePanelSearch.ToolTipTextExpandIconPanelCollapsed = "展开";
            this.ePanelSearch.ToolTipTextExpandIconPanelExpanded = "收起";
            this.ePanelSearch.SizeChanged += new System.EventHandler(this.ePanel_SizeChanged);
            // 
            // UcExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ePanelSearch);
            this.Name = "UcExplorer";
            this.Size = new System.Drawing.Size(553, 465);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.GboxSearchDirectory.ResumeLayout(false);
            this.GboxSearchDirectory.PerformLayout();
            this.GboxSearch.ResumeLayout(false);
            this.GboxSearch.PerformLayout();
            this.GboxSearchType.ResumeLayout(false);
            this.GboxSearchType.PerformLayout();
            this.GboxSearchPattern.ResumeLayout(false);
            this.GboxSearchPattern.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ePanelSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox GboxSearchDirectory;
        private System.Windows.Forms.TextBox TxtDirectory;
        private System.Windows.Forms.Button BtnSearchDirectory;
        private System.Windows.Forms.CheckBox CboxUseSubdirectories;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.GroupBox GboxSearch;
        private System.Windows.Forms.RadioButton RbtnRegex;
        private System.Windows.Forms.RadioButton RbtnText;
        private System.Windows.Forms.CheckBox CboxCaseSensitive;
        private System.Windows.Forms.TextBox TxtKeyword;
        private System.Windows.Forms.Label LblKeyword;
        private System.Windows.Forms.ListView LvSearchResult;
        private System.Windows.Forms.ColumnHeader ColFileName;
        private System.Windows.Forms.ColumnHeader ColSize;
        private System.Windows.Forms.ColumnHeader ColFilePath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TsmiAddToReportList;
        private System.Windows.Forms.ToolStripMenuItem TsmiOpen;
        private System.Windows.Forms.GroupBox GboxSearchType;
        private System.Windows.Forms.RadioButton RbtnContent;
        private System.Windows.Forms.RadioButton RbtnTitle;
        private System.Windows.Forms.GroupBox GboxSearchPattern;
        private EgoDevil.Utilities.UI.EPanels.EPanel ePanelSearch;
    }
}
