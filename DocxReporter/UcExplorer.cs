using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DocxSearcher
{
    public partial class UcExplorer : UserControl
    {

        public delegate void AddToReportListEventHandler(List<Tuple<string, string>> items);

        public event AddToReportListEventHandler AddToReportList;
        public UcExplorer()
        {
            InitializeComponent();
            this.TxtDirectory.Text = GlobalSettings.Data.Configurations.DefaultDirectory;
        }



        public void ExpandCollapse(bool isExpand)
        {
            ePanelSearch.Expand = isExpand;
        }

        private void ePanel_SizeChanged(object sender, EventArgs e)
        {
            var ePanel = sender as EgoDevil.Utilities.UI.EPanels.EPanel;

            int x = ePanel.Width - this.Width;
            int y = ePanel.Height - this.Height;

            this.Left -= x;
            this.Top -= y;
            this.Size = ePanel.Size;
        }
        private void BtnSearchDirectory_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.SelectedPath = this.TxtDirectory.Text;

            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                this.TxtDirectory.Text = fbd.SelectedPath;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.LvSearchResult.Items.Clear();

            try
            {
                foreach (var filePath in Search(this.TxtDirectory.Text, this.TxtKeyword.Text, this.CboxUseSubdirectories.Checked, this.CboxCaseSensitive.Checked, this.RbtnRegex.Checked, RbtnTitle.Checked))
                {
                    var file = new FileInfo(filePath);

                    this.LvSearchResult.Items.Add(new ListViewItem(new string[] { file.Name, string.Format("{0:0.0}", file.Length / 1024d), file.FullName }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Exception details:\n{0}", ex), string.Format("Exception '{0}' occurred.", ex.GetType()), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LvSearchResult_ItemActivate(object sender, EventArgs e)
        {
            string filePath = ((ListView)sender).SelectedItems[0].SubItems[2].Text;
            if (File.Exists(filePath))
            {
                Process.Start(filePath);
            }
        }


        private void TsmiOpen_Click(object sender, EventArgs e)
        {
            string filePath = LvSearchResult.SelectedItems[0].SubItems[2].Text;
            if (File.Exists(filePath))
            {
                Process.Start(filePath);
            }
        }
        private void TsmiAddToReportList_Click(object sender, EventArgs e)
        {
            if (LvSearchResult.SelectedItems == null || LvSearchResult.SelectedItems.Count == 0)
            {
                return;
            }

            if (AddToReportList != null)
            {
                List<Tuple<string, string>> items = new List<Tuple<string, string>>();
                foreach (var item in LvSearchResult.SelectedItems)
                {
                    var lvi = item as ListViewItem;
                    items.Add(new Tuple<string, string>(lvi.SubItems[0].Text, lvi.SubItems[2].Text));
                }

                AddToReportList.Invoke(items);
            }
        }

        private void LvSearchResult_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip.Show(LvSearchResult, e.Location);//鼠标右键按下弹出菜单
            }
        }

        private static IEnumerable<string> Search(string directory, string searchString, bool searchSubdirectories, bool caseSensitive, bool useRegex, bool searchInTitle)
        {
            var isMatch = useRegex ? new Predicate<string>(x => Regex.IsMatch(x, searchString, caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase))
                : new Predicate<string>(x => x.IndexOf(searchString, caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) >= 0);

            var files = Directory.GetFiles(directory, "*.docx", searchSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            foreach (var filePath in files)
            {
                string docxText = string.Empty;


                if (searchInTitle)
                {
                    docxText = System.IO.Path.GetFileNameWithoutExtension(filePath);
                }
                else
                {
                    try
                    {
                        using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            docxText = new DocxToStringConverter(stream).Convert();
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                if (!string.IsNullOrEmpty(docxText) && isMatch(docxText))
                {
                    yield return filePath;
                }

            }
        }

        private void LvSearchResult_ItemDrag(object sender, ItemDragEventArgs e)
        {

            var files = new List<string>();
            foreach (ListViewItem item in LvSearchResult.SelectedItems)
            {
                files.Add(item.SubItems[2].Text);
            }
            LvSearchResult.DoDragDrop(files.ToArray(), DragDropEffects.Link);
        }
    }
}
