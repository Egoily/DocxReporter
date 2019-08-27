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
            this.txtDirectory.Text = GlobalSettings.Data.Configurations.DefaultDirectory;
        }

        private void btnSearchDirectory_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.SelectedPath = this.txtDirectory.Text;

            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                this.txtDirectory.Text = fbd.SelectedPath;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lvSearchResult.Items.Clear();

            try
            {
                foreach (var filePath in Search(this.txtDirectory.Text, this.txtSearch.Text, this.cBoxUseSubdirectories.Checked, this.cBoxCaseSensitive.Checked, this.rBtnRegex.Checked))
                {
                    var file = new FileInfo(filePath);

                    this.lvSearchResult.Items.Add(new ListViewItem(new string[] { file.Name, string.Format("{0:0.0}", file.Length / 1024d), file.FullName }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("Exception details:\n{0}", ex), string.Format("Exception '{0}' occurred.", ex.GetType()), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resultListView_ItemActivate(object sender, EventArgs e)
        {
            string filePath = ((ListView)sender).SelectedItems[0].SubItems[2].Text;
            if (File.Exists(filePath))
            {
                Process.Start(filePath);
            }
        }

        private static IEnumerable<string> Search(string directory, string searchString, bool searchSubdirectories, bool caseSensitive, bool useRegex)
        {
            var isMatch = useRegex ? new Predicate<string>(x => Regex.IsMatch(x, searchString, caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase))
                : new Predicate<string>(x => x.IndexOf(searchString, caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) >= 0);

            foreach (var filePath in Directory.GetFiles(directory, "*.docx", searchSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly))
            {
                string docxText;

                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    docxText = new DocxToStringConverter(stream).Convert();
                }

                if (isMatch(docxText))
                {
                    yield return filePath;
                }
            }
        }
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            string filePath = lvSearchResult.SelectedItems[0].SubItems[2].Text;
            if (File.Exists(filePath))
            {
                Process.Start(filePath);
            }
        }
        private void tsmiAddToReportList_Click(object sender, EventArgs e)
        {
            if (lvSearchResult.SelectedItems == null || lvSearchResult.SelectedItems.Count == 0)
            {
                return;
            }

            if (AddToReportList != null)
            {
                List<Tuple<string, string>> items = new List<Tuple<string, string>>();
                foreach (var item in lvSearchResult.SelectedItems)
                {
                    var lvi = item as ListViewItem;
                    items.Add(new Tuple<string, string>(lvi.SubItems[0].Text, lvi.SubItems[2].Text));
                }

                AddToReportList.Invoke(items);
            }
        }

        private void resultListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip.Show(lvSearchResult, e.Location);//鼠标右键按下弹出菜单
            }
        }


    }
}
