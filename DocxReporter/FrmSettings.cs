using System;
using System.Windows.Forms;

namespace DocxSearcher
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            TxtDefaultFileDicectory.Text = GlobalSettings.Data.Configurations.DefaultDirectory;
        }

        private void BtnBrowseDefaultFileDicectory_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            fbd.SelectedPath = this.TxtDefaultFileDicectory.Text;

            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                TxtDefaultFileDicectory.Text = fbd.SelectedPath;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            GlobalSettings.Data.Configurations.DefaultDirectory = TxtDefaultFileDicectory.Text;
            GlobalSettings.Management.Save();
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
