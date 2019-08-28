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
                    DgviewCases.Rows.Add(item.Item1, item.Item2);
                }
            }

        }
        public void RemoveCase()
        {
            if (DgviewCases.SelectedRows != null && DgviewCases.SelectedRows.Count > 0)
            {
                foreach (var item in DgviewCases.SelectedRows)
                {
                    var dgv = item as DataGridViewRow;
                    DgviewCases.Rows.Remove(dgv);
                }
                DgviewCases.Refresh();
            }
        }

        private void MoveCase(bool isUp)
        {
            if (DgviewCases.SelectedRows == null || DgviewCases.SelectedRows.Count == 0)
            {
                return;
            }
            int selectedIndex = DgviewCases.CurrentRow.Index;
            if (selectedIndex <= 0 && isUp)
            {
                //To the Top
                return;
            }
            if (selectedIndex >= 0 && !isUp && selectedIndex >= DgviewCases.RowCount - 1)
            {
                //To the Buttom
                return;
            }

            if (isUp)
            {
                var preRow = this.DgviewCases.Rows[selectedIndex - 1];
                this.DgviewCases.Rows.RemoveAt(selectedIndex - 1);
                this.DgviewCases.Rows.Insert((selectedIndex), preRow);
            }
            else
            {
                var nextRow = this.DgviewCases.Rows[selectedIndex + 1];
                this.DgviewCases.Rows.RemoveAt(selectedIndex + 1);
                this.DgviewCases.Rows.Insert((selectedIndex == 0 ? 0 : selectedIndex - 1), nextRow);
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
                int row = DgviewCases.Rows.Count;

                for (int i = 0; i < row; i++)
                {
                    string path = DgviewCases.Rows[i].Cells["ColFilePath"].Value.ToString();
                    if (!files.Contains(path))
                    {
                        files.Add(path);
                    }
                }
                //var docxWriter = new DocxWriter(fileName);
                //docxWriter.AppendDocuments(files.ToArray());

                var template = @"Template/TypicalCaseRetrievalTemplate.dotx";
                var docxWriter = new DocxWriter(fileName, template);
                docxWriter.AppendDocumentsWithTemplate(files.ToArray());

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        private void TsbtnAdd_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "(*.doc;*.docx)|*.doc;*.docx",
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                if (ofd.FileNames != null)
                {
                    AddCasesByFilePath(ofd.FileNames);
                }
            }
        }

        private void AddCasesByFilePath(string[] files)
        {
            if (files == null)
            {
                return;
            }

            List<Tuple<string, string>> items = new List<Tuple<string, string>>();
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                items.Add(new Tuple<string, string>(fileInfo.Name, fileInfo.FullName));
            }
            AddCase(items);
        }

        private void TsbtnGenerate_Click(object sender, EventArgs e)
        {

            if (DgviewCases.RowCount <= 0)
            {
                MessageBox.Show("请加入检索文档", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var sfd = new SaveFileDialog()
            {
                Filter = "(*.docx)|*.docx|(*.doc)|*.doc",
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(sfd.FileName))
                {
                    return;
                }

                _reportFileName = sfd.FileName;
                _reportGenerated = GenerateReport(_reportFileName);

                if (_reportGenerated)
                {
                    DgviewReport.Rows.Clear();
                    var fileInfo = new FileInfo(_reportFileName);

                    DgviewReport.Rows.Add(fileInfo.Name, fileInfo.FullName);
                    MessageBox.Show("生成检索报告成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("生成检索报告失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void TsbtnUp_Click(object sender, EventArgs e)
        {
            MoveUpCase();
        }

        private void TsbtnDown_Click(object sender, EventArgs e)
        {
            MoveDownCase();
        }
        private void TsbtnDelete_Click(object sender, EventArgs e)
        {
            RemoveCase();
        }




        private void DgviewReport_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (File.Exists(_reportFileName))
            {
                System.Diagnostics.Process.Start(_reportFileName);
            }
        }

        private void DgviewCases_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else if (e.Data.GetDataPresent(typeof(List<string>)))
            {
                e.Effect = DragDropEffects.Link;
            }
            else if (e.Data.GetDataPresent(typeof(string[])))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        private void DgviewCases_DragDrop(object sender, DragEventArgs e)
        {

            if (e.Effect == DragDropEffects.Link)
            {

                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
                    AddCasesByFilePath(filePath);
                }
                else if (e.Data.GetDataPresent(typeof(List<string>)))
                {
                    var filePath = (List<string>)e.Data.GetData(typeof(List<string>));
                    AddCasesByFilePath(filePath.ToArray());
                }
                else if (e.Data.GetDataPresent(typeof(string[])))
                {
                    var filePath = (string[])e.Data.GetData(typeof(string[]));
                    AddCasesByFilePath(filePath);
                }
            }

            else if (e.Effect == DragDropEffects.Move)
            {
                if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
                {
                    int idx = GetRowFromPoint(e.X, e.Y);
                    if (idx < 0)
                    {
                        return;
                    }
                    DataGridViewRow row = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
                    DgviewCases.Rows.Remove(row);
                    selectionIdx = idx;
                    DgviewCases.Rows.Insert(idx, row);

                }

            }
        }

        private void DgviewCases_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left))
            {
                if ((e.RowIndex > -1))
                {
                    DgviewCases.DoDragDrop(DgviewCases.Rows[e.RowIndex], DragDropEffects.Move);
                }
            }
        }

        private int selectionIdx = 0;

        private int GetRowFromPoint(int x, int y)
        {
            for (int i = 0; i < DgviewCases.RowCount; i++)
            {
                Rectangle rec = DgviewCases.GetRowDisplayRectangle(i, false);
                if (DgviewCases.RectangleToScreen(rec).Contains(x, y))
                {
                    return i;
                }
            }
            return -1;
        }

        private void DgviewCases_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (selectionIdx > -1)
            {

                DgviewCases.Rows[selectionIdx].Selected = true;

                DgviewCases.CurrentCell = DgviewCases.Rows[selectionIdx].Cells[0];

            }
        }


    }
}
