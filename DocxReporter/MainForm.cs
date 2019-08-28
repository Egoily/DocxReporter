using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DocxSearcher
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            ucExplorer.AddToReportList += UcExplorer_AddToReportList;
          
        }

        private void UcExplorer_AddToReportList(List<Tuple<string, string>> items)
        {
            ucReporter.AddCase(items);
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            var frm = new FrmSettings();
            frm.ShowDialog(this);
            
        }
    }
}
