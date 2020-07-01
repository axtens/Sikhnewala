using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuarterMaster.Configuration;
using QuarterMaster.Debugging;
using QuarterMaster.Logging;

namespace Sikhnewala
{
    public partial class Form1 : Form
    {
        public Config config = new QuarterMaster.Configuration.Config();

        public ApplicationLogging T = new ApplicationLogging(
            "Sikhnewala",
            "Sikhnewala",
            Environment.GetEnvironmentVariable("SIKHNEWALA_LOGS") ?? "D:\\Sikhnewala_Logs",
            tabbed: true);

        public int cursor;

        public List<LogItem> logItemsCollection = new List<LogItem>();

        public string filterText = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            T.Module(MethodBase.GetCurrentMethod().Name);
            var folderGroups = config.Retrieve("folder.groups");
            if (folderGroups.Length == 0)
            {
                Environment.Exit(0);
            }
            List<string> folderGroupList = folderGroups.Split(' ').ToList<string>();
            folderGroupList.Sort();
            T.Inform("folderGroups", folderGroups);
            LBGroup.DataSource = folderGroupList;
            LBGroup.SetSelected(0, false);
            T.Module();
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBFilter_TextChanged(object sender, EventArgs e)
        {
            filterText = "";
        }

        private void LbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BPrevious_Click(object sender, EventArgs e)
        {
            T.Module(MethodBase.GetCurrentMethod().Name);
            var roes = dgvLogs.Rows;
            LStatus.Text = "Search Backwards";
            for (var r = cursor - 1; r >= 0; r--)
            //foreach (DataGridViewRow roe in roes)
            {
                var roe = roes[r];
                var target = string.Empty;
                for (var i = 0; i < roe.Cells.Count; i++)
                {
                    target += roe.Cells[i].Value;
                    LStatus.Visible = !LStatus.Visible;
                    LStatus.Refresh();
                }
                if (target.Contains(TBSearch.Text))
                {
                    cursor = roe.Index;
                    dgvLogs.FirstDisplayedScrollingRowIndex = cursor;
                    break;
                }
            }
            LStatus.Visible = false;
            T.Module();
        }

        private void BSubsequent_Click(object sender, EventArgs e)
        {
            T.Module(MethodBase.GetCurrentMethod().Name);
            var roes = dgvLogs.Rows;
            LStatus.Text = "Searching Forwards";

            for (var r = cursor + 1; r < roes.Count; r++)
            //foreach (DataGridViewRow roe in roes)
            {
                var roe = roes[r];
                var target = string.Empty;
                for (var i = 0; i < roe.Cells.Count; i++)
                {
                    target += roe.Cells[i].Value;
                    LStatus.Visible = !LStatus.Visible;
                    LStatus.Refresh();
                }
                if (target.Contains(TBSearch.Text))
                {
                    cursor = roe.Index;
                    dgvLogs.FirstDisplayedScrollingRowIndex = cursor;
                    break;
                }
            }
            LStatus.Visible = false;
            T.Module();
        }

        private List<LogItem> GetLogItems(string sentName)
        {
            T.Module(MethodBase.GetCurrentMethod().Name);
            //List<LogItem> logItemsCollection = new List<LogItem>();
            logItemsCollection.Clear();
            T.Inform("sentName", sentName);
            ProcessFolderCollectionToLogItems(sentName, ref logItemsCollection);
            T.Module();
            return logItemsCollection;
        }

        private void ProcessFolderCollectionToLogItems(string sentName, ref List<LogItem> result)
        {
            T.Module(MethodBase.GetCurrentMethod().Name);
            var folderList = config.Retrieve(sentName + ".folders");
            T.Inform("folderList", folderList);
            LStatus.Text = "Reading Files";

            if (folderList != null)
            {
                var folders = folderList.Split(';');
                foreach (var folder in folders)
                {
                    T.Inform("folder", folder);
                    if (folder.StartsWith("@"))
                    {
                        ProcessFolderCollectionToLogItems(folder.Substring(1), ref result);
                    }
                    else
                    {
                        var tree = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
                        foreach (var leaf in tree)
                        {
                            LStatus.Visible = !LStatus.Visible;
                            LStatus.Refresh();
                            var fdata = File.ReadAllText(leaf).Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                            foreach (var fline in fdata)
                            {
                                if (filterText != string.Empty)
                                {
                                    if (!fline.Contains(filterText))
                                    {
                                        continue;
                                    }
                                }
                                var lineItems = fline.Split('\t');
                                if (lineItems.Length == 4)
                                {
                                    var itm = new LogItem()
                                    {
                                        Level = lineItems[0],
                                        Path = lineItems[1],
                                        Stamp = lineItems[2],
                                        Message = lineItems[3] /*.Replace("\r", "\r\n")*/
                                    };
                                    result.Add(itm);
                                }
                            }
                        }
                    }
                }
            }
            LStatus.Visible = false;
            T.Module();
        }

        private void ProcessFolderCollection(string sentName, ref List<string> files)
        {
            T.Module(MethodBase.GetCurrentMethod().Name);
            T.Inform("sentName", sentName);
            LStatus.Text = "Reading Folders";

            var folderList = config.Retrieve(sentName + ".folders");
            T.Inform("folderList", folderList);
            if (folderList != null)
            {
                var folders = folderList.Split(';');
                foreach (var folder in folders)
                {
                    if (folder.StartsWith("@"))
                    {
                        ProcessFolderCollection(folder.Substring(1), ref files);
                    }
                    else
                    {
                        if (Directory.Exists(folder))
                        {
                            var tree = Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories);
                            foreach (var leaf in tree)
                            {
                                LStatus.Visible = !LStatus.Visible;
                                LStatus.Refresh();
                                T.Inform("leaf", leaf);
                                files.Add(leaf);
                            }
                        }
                    }
                }
            }
            LStatus.Visible = false;
            T.Module();
        }

        private void LBGroup_CursorChanged(object sender, EventArgs e)
        {

        }

        private void LBGroup_MouseClick(object sender, MouseEventArgs e)
        {
            T.Module(MethodBase.GetCurrentMethod().Name);
            TBFilter.Text = string.Empty;
            var result = GetLogItems(((System.Windows.Forms.ListBox)sender).SelectedItem.ToString());
            result = result.OrderByDescending(x => x.Stamp).ToList();
            dgvLogs.DataSource = result;
            T.Module();
        }

        private void TBSearch_Enter(object sender, EventArgs e)
        {

        }

        private void TBSearch_KeyUp(object sender, KeyEventArgs e)
        {
            cursor = 0;
        }

        private void BApplyFilter_Click(object sender, EventArgs e)
        {
            T.Module(MethodBase.GetCurrentMethod().Name);

            filterText = TBFilter.Text;
            if (LBGroup.SelectedIndex > -1 && LBGroup.GetSelected(LBGroup.SelectedIndex))
            {
                var result = GetLogItems(LBGroup.SelectedItem.ToString());
                result = result.OrderByDescending(x => x.Stamp).ToList();
                dgvLogs.DataSource = result;
            }
            T.Module();
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            T.Module(MethodBase.GetCurrentMethod().Name);
            filterText = string.Empty;
            TBFilter.Text = string.Empty;
            if (LBGroup.SelectedIndex > -1 && LBGroup.GetSelected(LBGroup.SelectedIndex))
            {
                var result = GetLogItems(LBGroup.SelectedItem.ToString());
                result = result.OrderByDescending(x => x.Stamp).ToList();
                dgvLogs.DataSource = result;
            }
            T.Module();
        }

        private void BAdjust_Click(object sender, EventArgs e)
        {
            T.Module(MethodBase.GetCurrentMethod().Name);
            LStatus.Text = "Adjusting";
            LStatus.Visible = true;
            int colCount = this.dgvLogs.Columns.Count;
            for (int i = 0; i < colCount - 1; i++)
            {
                DataGridViewColumn column = dgvLogs.Columns[i]; // column[1] selects the required column 
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            dgvLogs.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvLogs.AutoResizeColumns();
            LStatus.Visible = false;
        }

        private void BReload_Click(object sender, EventArgs e)
        {
            T.Module(MethodBase.GetCurrentMethod().Name);
            var result = GetLogItems(LBGroup.SelectedItem.ToString());
            result = result.OrderByDescending(x => x.Stamp).ToList();
            dgvLogs.DataSource = result;
            T.Module();
        }
    }
}
