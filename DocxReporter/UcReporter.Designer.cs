

namespace DocxSearcher
{
    partial class UcReporter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ePanel = new EgoDevil.Utilities.UI.EPanels.EPanel();
            this.GboxReport = new System.Windows.Forms.GroupBox();
            this.DgviewReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GboxDocList = new System.Windows.Forms.GroupBox();
            this.DgviewCases = new System.Windows.Forms.DataGridView();
            this.ColCaseFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbtnUp = new System.Windows.Forms.ToolStripButton();
            this.TsbtnDown = new System.Windows.Forms.ToolStripButton();
            this.TsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbtnGenerate = new System.Windows.Forms.ToolStripButton();
            this.ePanel.SuspendLayout();
            this.GboxReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgviewReport)).BeginInit();
            this.GboxDocList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgviewCases)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ePanel
            // 
            this.ePanel.AssociatedSplitter = null;
            this.ePanel.BackColor = System.Drawing.Color.Transparent;
            this.ePanel.CaptionFont = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ePanel.CaptionHeight = 27;
            this.ePanel.Controls.Add(this.GboxReport);
            this.ePanel.Controls.Add(this.GboxDocList);
            this.ePanel.Controls.Add(this.toolStrip);
            this.ePanel.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ePanel.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.ePanel.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.ePanel.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ePanel.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.ePanel.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ePanel.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ePanel.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ePanel.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.ePanel.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.ePanel.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.ePanel.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ePanel.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.ePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ePanel.Image = null;
            this.ePanel.Location = new System.Drawing.Point(0, 0);
            this.ePanel.MinimumSize = new System.Drawing.Size(27, 27);
            this.ePanel.Name = "ePanel";
            this.ePanel.PanelStyle = EgoDevil.Utilities.UI.EPanels.PanelStyle.Office2007;
            this.ePanel.ShowExpandIcon = true;
            this.ePanel.ShowTransparentBackground = false;
            this.ePanel.Size = new System.Drawing.Size(388, 480);
            this.ePanel.TabIndex = 0;
            this.ePanel.ToolTipTextCloseIcon = null;
            this.ePanel.ToolTipTextExpandIconPanelCollapsed = "展开";
            this.ePanel.ToolTipTextExpandIconPanelExpanded = "收起";
            this.ePanel.SizeChanged += new System.EventHandler(this.ePanel_SizeChanged);
            // 
            // GboxReport
            // 
            this.GboxReport.Controls.Add(this.DgviewReport);
            this.GboxReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GboxReport.Location = new System.Drawing.Point(1, 414);
            this.GboxReport.Name = "GboxReport";
            this.GboxReport.Size = new System.Drawing.Size(386, 65);
            this.GboxReport.TabIndex = 7;
            this.GboxReport.TabStop = false;
            this.GboxReport.Text = "报告";
            // 
            // DgviewReport
            // 
            this.DgviewReport.AllowUserToAddRows = false;
            this.DgviewReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            this.DgviewReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgviewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgviewReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgviewReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgviewReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgviewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgviewReport.ColumnHeadersVisible = false;
            this.DgviewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DgviewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgviewReport.Location = new System.Drawing.Point(3, 17);
            this.DgviewReport.MultiSelect = false;
            this.DgviewReport.Name = "DgviewReport";
            this.DgviewReport.ReadOnly = true;
            this.DgviewReport.RowTemplate.Height = 23;
            this.DgviewReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgviewReport.Size = new System.Drawing.Size(380, 45);
            this.DgviewReport.TabIndex = 0;
            this.DgviewReport.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgviewReport_CellMouseDoubleClick);
            this.DgviewReport.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridViewRowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "案例";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "FilePath";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 5;
            // 
            // GboxDocList
            // 
            this.GboxDocList.Controls.Add(this.DgviewCases);
            this.GboxDocList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GboxDocList.Location = new System.Drawing.Point(1, 28);
            this.GboxDocList.Name = "GboxDocList";
            this.GboxDocList.Size = new System.Drawing.Size(386, 451);
            this.GboxDocList.TabIndex = 7;
            this.GboxDocList.TabStop = false;
            this.GboxDocList.Text = "文档列表";
            // 
            // DgviewCases
            // 
            this.DgviewCases.AllowDrop = true;
            this.DgviewCases.AllowUserToAddRows = false;
            this.DgviewCases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            this.DgviewCases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgviewCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgviewCases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgviewCases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgviewCases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgviewCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgviewCases.ColumnHeadersVisible = false;
            this.DgviewCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCaseFile,
            this.ColFilePath});
            this.DgviewCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgviewCases.Location = new System.Drawing.Point(3, 17);
            this.DgviewCases.MultiSelect = false;
            this.DgviewCases.Name = "DgviewCases";
            this.DgviewCases.ReadOnly = true;
            this.DgviewCases.RowTemplate.Height = 23;
            this.DgviewCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgviewCases.Size = new System.Drawing.Size(380, 431);
            this.DgviewCases.TabIndex = 0;
            this.DgviewCases.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgviewCases_CellMouseMove);
            this.DgviewCases.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridViewRowPostPaint);
            this.DgviewCases.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgviewCases_RowsAdded);
            this.DgviewCases.DragDrop += new System.Windows.Forms.DragEventHandler(this.DgviewCases_DragDrop);
            this.DgviewCases.DragEnter += new System.Windows.Forms.DragEventHandler(this.DgviewCases_DragEnter);
            // 
            // ColCaseFile
            // 
            this.ColCaseFile.HeaderText = "案例";
            this.ColCaseFile.Name = "ColCaseFile";
            this.ColCaseFile.ReadOnly = true;
            this.ColCaseFile.Width = 5;
            // 
            // ColFilePath
            // 
            this.ColFilePath.HeaderText = "FilePath";
            this.ColFilePath.Name = "ColFilePath";
            this.ColFilePath.ReadOnly = true;
            this.ColFilePath.Visible = false;
            this.ColFilePath.Width = 5;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbtnAdd,
            this.toolStripSeparator1,
            this.TsbtnUp,
            this.TsbtnDown,
            this.TsbtnDelete,
            this.toolStripSeparator2,
            this.TsbtnGenerate});
            this.toolStrip.Location = new System.Drawing.Point(4, 2);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(139, 25);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip";
            // 
            // TsbtnAdd
            // 
            this.TsbtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TsbtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbtnAdd.Image = global::DocxReporter.Properties.Resources.Browse;
            this.TsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbtnAdd.Name = "TsbtnAdd";
            this.TsbtnAdd.Size = new System.Drawing.Size(23, 22);
            this.TsbtnAdd.Text = "加入";
            this.TsbtnAdd.ToolTipText = "加入文档";
            this.TsbtnAdd.Click += new System.EventHandler(this.TsbtnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbtnUp
            // 
            this.TsbtnUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbtnUp.Image = global::DocxReporter.Properties.Resources.ArrowUp;
            this.TsbtnUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbtnUp.Name = "TsbtnUp";
            this.TsbtnUp.Size = new System.Drawing.Size(23, 22);
            this.TsbtnUp.Text = "上移";
            this.TsbtnUp.Click += new System.EventHandler(this.TsbtnUp_Click);
            // 
            // TsbtnDown
            // 
            this.TsbtnDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbtnDown.Image = global::DocxReporter.Properties.Resources.ArrowDown;
            this.TsbtnDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbtnDown.Name = "TsbtnDown";
            this.TsbtnDown.Size = new System.Drawing.Size(23, 22);
            this.TsbtnDown.Text = "下移";
            this.TsbtnDown.Click += new System.EventHandler(this.TsbtnDown_Click);
            // 
            // TsbtnDelete
            // 
            this.TsbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbtnDelete.Image = global::DocxReporter.Properties.Resources.Intersect;
            this.TsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbtnDelete.Name = "TsbtnDelete";
            this.TsbtnDelete.Size = new System.Drawing.Size(23, 22);
            this.TsbtnDelete.Text = "移除";
            this.TsbtnDelete.Click += new System.EventHandler(this.TsbtnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbtnGenerate
            // 
            this.TsbtnGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbtnGenerate.Image = global::DocxReporter.Properties.Resources.Merge;
            this.TsbtnGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbtnGenerate.Name = "TsbtnGenerate";
            this.TsbtnGenerate.Size = new System.Drawing.Size(23, 22);
            this.TsbtnGenerate.Text = "生成报告";
            this.TsbtnGenerate.Click += new System.EventHandler(this.TsbtnGenerate_Click);
            // 
            // UcReporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ePanel);
            this.Name = "UcReporter";
            this.Size = new System.Drawing.Size(388, 480);
            this.ePanel.ResumeLayout(false);
            this.ePanel.PerformLayout();
            this.GboxReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgviewReport)).EndInit();
            this.GboxDocList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgviewCases)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EgoDevil.Utilities.UI.EPanels.EPanel ePanel;
        private System.Windows.Forms.DataGridView DgviewCases;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCaseFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFilePath;
        private System.Windows.Forms.GroupBox GboxReport;
        private System.Windows.Forms.DataGridView DgviewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox GboxDocList;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton TsbtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbtnUp;
        private System.Windows.Forms.ToolStripButton TsbtnDown;
        private System.Windows.Forms.ToolStripButton TsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TsbtnGenerate;
    }
}
