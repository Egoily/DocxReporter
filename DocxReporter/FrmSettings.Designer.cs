namespace DocxSearcher
{
    partial class FrmSettings
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
            this.abeamTabControl = new DocxSearcher.AbeamTabControl();
            this.tpPreferences = new System.Windows.Forms.TabPage();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblDefaultFileDicectory = new System.Windows.Forms.Label();
            this.TxtDefaultFileDicectory = new System.Windows.Forms.TextBox();
            this.BtnBrowseDefaultFileDicectory = new System.Windows.Forms.Button();
            this.abeamTabControl.SuspendLayout();
            this.tpPreferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // abeamTabControl
            // 
            this.abeamTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.abeamTabControl.Controls.Add(this.tpPreferences);
            this.abeamTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.abeamTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.abeamTabControl.ItemSize = new System.Drawing.Size(40, 120);
            this.abeamTabControl.Location = new System.Drawing.Point(0, 0);
            this.abeamTabControl.Multiline = true;
            this.abeamTabControl.Name = "abeamTabControl";
            this.abeamTabControl.SelectedIndex = 0;
            this.abeamTabControl.Size = new System.Drawing.Size(731, 359);
            this.abeamTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.abeamTabControl.TabIndex = 0;
            // 
            // tpPreferences
            // 
            this.tpPreferences.Controls.Add(this.BtnBrowseDefaultFileDicectory);
            this.tpPreferences.Controls.Add(this.TxtDefaultFileDicectory);
            this.tpPreferences.Controls.Add(this.LblDefaultFileDicectory);
            this.tpPreferences.Location = new System.Drawing.Point(124, 4);
            this.tpPreferences.Name = "tpPreferences";
            this.tpPreferences.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreferences.Size = new System.Drawing.Size(603, 351);
            this.tpPreferences.TabIndex = 0;
            this.tpPreferences.Text = "偏爱";
            this.tpPreferences.UseVisualStyleBackColor = true;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(563, 398);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 1;
            this.BtnOK.Text = "确定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(644, 398);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblDefaultFileDicectory
            // 
            this.LblDefaultFileDicectory.AutoSize = true;
            this.LblDefaultFileDicectory.Location = new System.Drawing.Point(15, 29);
            this.LblDefaultFileDicectory.Name = "LblDefaultFileDicectory";
            this.LblDefaultFileDicectory.Size = new System.Drawing.Size(83, 12);
            this.LblDefaultFileDicectory.TabIndex = 0;
            this.LblDefaultFileDicectory.Text = "文档默认路径:";
            // 
            // TxtDefaultFileDicectory
            // 
            this.TxtDefaultFileDicectory.Location = new System.Drawing.Point(104, 26);
            this.TxtDefaultFileDicectory.Name = "TxtDefaultFileDicectory";
            this.TxtDefaultFileDicectory.Size = new System.Drawing.Size(441, 21);
            this.TxtDefaultFileDicectory.TabIndex = 1;
            // 
            // BtnBrowseDefaultFileDicectory
            // 
            this.BtnBrowseDefaultFileDicectory.Location = new System.Drawing.Point(545, 24);
            this.BtnBrowseDefaultFileDicectory.Name = "BtnBrowseDefaultFileDicectory";
            this.BtnBrowseDefaultFileDicectory.Size = new System.Drawing.Size(43, 23);
            this.BtnBrowseDefaultFileDicectory.TabIndex = 2;
            this.BtnBrowseDefaultFileDicectory.Text = "...";
            this.BtnBrowseDefaultFileDicectory.UseVisualStyleBackColor = true;
            this.BtnBrowseDefaultFileDicectory.Click += new System.EventHandler(this.BtnBrowseDefaultFileDicectory_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 436);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.abeamTabControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统设置";
            this.abeamTabControl.ResumeLayout(false);
            this.tpPreferences.ResumeLayout(false);
            this.tpPreferences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AbeamTabControl abeamTabControl;
        private System.Windows.Forms.TabPage tpPreferences;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnBrowseDefaultFileDicectory;
        private System.Windows.Forms.TextBox TxtDefaultFileDicectory;
        private System.Windows.Forms.Label LblDefaultFileDicectory;
    }
}