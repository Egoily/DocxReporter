

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
            this.ePanel = new EgoDevil.Utilities.UI.EPanels.EPanel();
            this.dgvCases = new System.Windows.Forms.DataGridView();
            this.colCaseFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBrowse = new DocxSearcher.TipButton();
            this.BtnGenerate = new DocxSearcher.TipButton();
            this.BtnDelete = new DocxSearcher.TipButton();
            this.BtnDown = new DocxSearcher.TipButton();
            this.BtnUp = new DocxSearcher.TipButton();
            this.ePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            this.SuspendLayout();
            // 
            // ePanel
            // 
            this.ePanel.AssociatedSplitter = null;
            this.ePanel.BackColor = System.Drawing.Color.Transparent;
            this.ePanel.CaptionFont = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ePanel.CaptionHeight = 27;
            this.ePanel.Controls.Add(this.BtnBrowse);
            this.ePanel.Controls.Add(this.BtnGenerate);
            this.ePanel.Controls.Add(this.BtnDelete);
            this.ePanel.Controls.Add(this.BtnDown);
            this.ePanel.Controls.Add(this.BtnUp);
            this.ePanel.Controls.Add(this.dgvCases);
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
            this.ePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ePanel.Image = null;
            this.ePanel.Location = new System.Drawing.Point(0, 0);
            this.ePanel.MinimumSize = new System.Drawing.Size(27, 27);
            this.ePanel.Name = "ePanel";
            this.ePanel.PanelStyle = EgoDevil.Utilities.UI.EPanels.PanelStyle.Office2007;
            this.ePanel.ShowExpandIcon = true;
            this.ePanel.ShowTransparentBackground = false;
            this.ePanel.Size = new System.Drawing.Size(269, 479);
            this.ePanel.TabIndex = 0;
            this.ePanel.Text = "检索报告生成";
            this.ePanel.ToolTipTextCloseIcon = null;
            this.ePanel.ToolTipTextExpandIconPanelCollapsed = "展开";
            this.ePanel.ToolTipTextExpandIconPanelExpanded = "收起";
            this.ePanel.PanelExpanding += new System.EventHandler<EgoDevil.Utilities.UI.EPanels.XPanderStateChangeEventArgs>(this.ePanel_PanelExpanding);
            this.ePanel.SizeChanged += new System.EventHandler(this.ePanel_SizeChanged);
            // 
            // dgvCases
            // 
            this.dgvCases.AllowUserToAddRows = false;
            this.dgvCases.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            this.dgvCases.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCases.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCases.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCases.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCases.ColumnHeadersVisible = false;
            this.dgvCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCaseFile,
            this.colFilePath});
            this.dgvCases.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCases.Location = new System.Drawing.Point(1, 28);
            this.dgvCases.MultiSelect = false;
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.ReadOnly = true;
            this.dgvCases.RowTemplate.Height = 23;
            this.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCases.Size = new System.Drawing.Size(230, 450);
            this.dgvCases.TabIndex = 0;
            this.dgvCases.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridViewRowPostPaint);
            // 
            // colCaseFile
            // 
            this.colCaseFile.HeaderText = "案例";
            this.colCaseFile.Name = "colCaseFile";
            this.colCaseFile.ReadOnly = true;
            this.colCaseFile.Width = 5;
            // 
            // colFilePath
            // 
            this.colFilePath.HeaderText = "FilePath";
            this.colFilePath.Name = "colFilePath";
            this.colFilePath.ReadOnly = true;
            this.colFilePath.Visible = false;
            this.colFilePath.Width = 5;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackgroundImage = global::DocxReporter.Properties.Resources.Browse;
            this.BtnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBrowse.Location = new System.Drawing.Point(234, 206);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(32, 32);
            this.BtnBrowse.TabIndex = 5;
            this.BtnBrowse.TipText = "浏览报告";
            this.BtnBrowse.Visible = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackgroundImage = global::DocxReporter.Properties.Resources.Merge;
            this.BtnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerate.Location = new System.Drawing.Point(234, 172);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(32, 32);
            this.BtnGenerate.TabIndex = 4;
            this.BtnGenerate.TipText = "生成报告";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = global::DocxReporter.Properties.Resources.Intersect;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDelete.Location = new System.Drawing.Point(234, 112);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(32, 32);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.TipText = "移除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.BackgroundImage = global::DocxReporter.Properties.Resources.ArrowDown;
            this.BtnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDown.Location = new System.Drawing.Point(234, 81);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(32, 32);
            this.BtnDown.TabIndex = 2;
            this.BtnDown.TipText = "下移";
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.BackgroundImage = global::DocxReporter.Properties.Resources.ArrowUp;
            this.BtnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnUp.Location = new System.Drawing.Point(234, 50);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(32, 32);
            this.BtnUp.TabIndex = 1;
            this.BtnUp.TipText = "上移";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // UcReporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ePanel);
            this.Name = "UcReporter";
            this.Size = new System.Drawing.Size(269, 479);
            this.ePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EgoDevil.Utilities.UI.EPanels.EPanel ePanel;
        private System.Windows.Forms.DataGridView dgvCases;
        private TipButton BtnBrowse;
        private TipButton BtnGenerate;
        private TipButton BtnDelete;
        private TipButton BtnDown;
        private TipButton BtnUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilePath;
    }
}
