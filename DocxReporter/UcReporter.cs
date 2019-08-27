using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace DocxSearcher
{
    public partial class UcReporter : UserControl
    {
        private string _reportFileName;
        private bool _reportGenerated = false;
        public UcReporter()
        {
            InitializeComponent();
        }

        private void ePanel_SizeChanged(object sender, EventArgs e)
        {
            int x = ePanel.Width - this.Width;
            int y = ePanel.Height - this.Height;

            this.Left -= x;
            this.Top -= y;
            this.Size = ePanel.Size;
        }

        private void DataGridViewRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //======================================================
            //标识行号
            try
            {
                DataGridView dgv = sender as DataGridView;
                Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                                                    Convert.ToInt32(e.RowBounds.Location.Y + (e.RowBounds.Height - dgv.RowHeadersDefaultCellStyle.Font.Size) / 2),
                                                    dgv.RowHeadersWidth - 4,
                                                    e.RowBounds.Height);
                TextRenderer.DrawText(e.Graphics,
                                     (e.RowIndex + 1).ToString(),
                                     dgv.RowHeadersDefaultCellStyle.Font,
                                     rectangle,
                                     dgv.RowHeadersDefaultCellStyle.ForeColor,
                                      TextFormatFlags.Right);
            }
            catch (Exception ex)
            {
                Console.Write("RowPostPaint:" + ex.Message);
            }
        }



        public void AddCase(List<Tuple<string, string>> items)
        {
            if (items != null && items.Any())
            {
                foreach (var item in items)
                {
                    dgvCases.Rows.Add(item.Item1, item.Item2);
                }
            }

        }
        public void RemoveCase()
        {
            if (dgvCases.SelectedRows != null && dgvCases.SelectedRows.Count > 0)
            {
                foreach (var item in dgvCases.SelectedRows)
                {
                    var dgv = item as DataGridViewRow;
                    dgvCases.Rows.Remove(dgv);
                }
                dgvCases.Refresh();
            }
        }

        private void MoveCase(bool isUp)
        {
            if (dgvCases.SelectedRows == null || dgvCases.SelectedRows.Count == 0)
            {
                return;
            }
            int selectedIndex = dgvCases.CurrentRow.Index;
            if (selectedIndex <= 0 && isUp)
            {
                //To the Top
                return;
            }
            if (selectedIndex >= 0 && !isUp && selectedIndex >= dgvCases.RowCount - 1)
            {
                //To the Buttom
                return;
            }

            if (isUp)
            {
                var preRow = this.dgvCases.Rows[selectedIndex - 1];
                this.dgvCases.Rows.RemoveAt(selectedIndex - 1);
                this.dgvCases.Rows.Insert((selectedIndex), preRow);
            }
            else
            {
                var nextRow = this.dgvCases.Rows[selectedIndex + 1];
                this.dgvCases.Rows.RemoveAt(selectedIndex + 1);
                this.dgvCases.Rows.Insert((selectedIndex == 0 ? 0 : selectedIndex - 1), nextRow);
            }

        }

        public void MoveUpCase()
        {
            MoveCase(true);
        }
        private void MoveDownCase()
        {
            MoveCase(false);
        }

        private bool GenerateReport(string fileName)
        {
            try
            {
                var files = new List<string>();
                int row = dgvCases.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    string path = dgvCases.Rows[i].Cells["colFilePath"].Value.ToString();
                    if (!files.Contains(path))
                    {
                        files.Add(path);
                    }
                }

                var docxWriter = new DocxWriter(fileName);
                docxWriter.AppendDocuments(files.ToArray());

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    
        private void BtnGenerate_Click(object sender, EventArgs e)
        {

            if (dgvCases.RowCount <= 0)
            {
                MessageBox.Show("请加入检索文档", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var sfd = new SaveFileDialog()
            {
                Filter = "(*.docx)|*.docx|(*.doc)|*.doc",
            };
            sfd.ShowDialog();
            if (string.IsNullOrEmpty(sfd.FileName))
            {
                return;
            }
            BtnBrowse.Visible = false;
            _reportFileName = sfd.FileName;
            _reportGenerated = GenerateReport(_reportFileName);
            BtnBrowse.Visible = _reportGenerated;
            if (_reportGenerated)
            {
                MessageBox.Show("生成检索报告成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("生成检索报告成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if (File.Exists(_reportFileName))
            {
                System.Diagnostics.Process.Start(_reportFileName);
            }
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            MoveUpCase();
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            MoveDownCase();
        }



        private void BtnDelete_Click(object sender, EventArgs e)
        {
            RemoveCase();
        }

        private void ePanel_PanelExpanding(object sender, EgoDevil.Utilities.UI.EPanels.XPanderStateChangeEventArgs e)
        {
            BtnBrowse.Visible = _reportGenerated;
        }

  
    }
}
