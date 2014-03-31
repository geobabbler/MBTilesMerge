using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MBTilesMerge
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tmrUI_Tick(object sender, EventArgs e)
        {
            validateUI();
        }

        private void validateUI()
        {
            if (lstFiles.Items.Count > 1)
            {
                if (lstFiles.SelectedItem != null)
                {
                    if (lstFiles.SelectedIndex > 0)
                    {
                        this.btnMoveUp.Enabled = true;
                    }
                    else
                    {
                        this.btnMoveUp.Enabled = false;
                    }
                    if (lstFiles.SelectedIndex < (lstFiles.Items.Count - 1))
                    {
                        this.btnMoveDown.Enabled = true;
                    }
                    else
                    {
                        this.btnMoveDown.Enabled = false;
                    }
                }
                else
                {
                    this.btnMoveUp.Enabled = false;
                    this.btnMoveDown.Enabled = false;
                }
                this.btnMerge.Enabled = true;
            }
            else
            {
                this.btnMoveUp.Enabled = false;
                this.btnMoveDown.Enabled = false;
                this.btnMerge.Enabled = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.tmrUI.Start();
            this.txtInstructions.Text = "NOTE: Order matters!\r\n\r\nDatabases will be merged from the bottom up. Duplicate records in a lower database will be replace by those in a higher database.\r\n\r\nEnsure proper order before merging!";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.ofdMBTiles.ShowDialog();
            if (this.ofdMBTiles.FileName != "")
            {
                var fn = new FileItem() { FileName = System.IO.Path.GetFileName(this.ofdMBTiles.FileName), FullPath = this.ofdMBTiles.FileName };
                this.lstFiles.Items.Add(fn);
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            var item = this.lstFiles.SelectedItem;
            var idx = this.lstFiles.SelectedIndex;

            this.lstFiles.Items.Remove(item);
            this.lstFiles.Items.Insert(idx - 1, item);
            this.lstFiles.SelectedItem = item;
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            var item = this.lstFiles.SelectedItem;
            var idx = this.lstFiles.SelectedIndex;

            this.lstFiles.Items.Remove(item);
            this.lstFiles.Items.Insert(idx + 1, item);
            this.lstFiles.SelectedItem = item;
        }

        private void mergeDatabases(string src, string dest)
        {
            //echo PRAGMA journal_mode=PERSIST;PRAGMA page_size=80000;PRAGMA synchronous=OFF;ATTACH DATABASE '%1' AS source;REPLACE INTO tiles SELECT * FROM source.tiles;REPLACE INTO grids SELECT * FROM source.grids;REPLACE INTO grid_data SELECT * FROM source.grid_data; | "C:\spatialite3\bin\sqlite3.exe" %2%
            string connstr = "Data Source={0};Version=3;";
            string sql = "PRAGMA journal_mode=PERSIST;" +
                "PRAGMA page_size=80000;" +
                "PRAGMA synchronous=OFF;" +
                "ATTACH DATABASE '{0}' AS source;" +
                "REPLACE INTO map SELECT * FROM source.map;" +
                "REPLACE INTO grid_key SELECT * FROM source.grid_key;" +
                "REPLACE INTO images SELECT * FROM source.images;" +
                "REPLACE INTO grid_utfgrid SELECT * FROM source.grid_utfgrid;";

            sql = string.Format(sql, src);
            connstr = string.Format(connstr, dest);

            try
            {

                using (var conn = new System.Data.SQLite.SQLiteConnection(connstr))
                {
                    conn.Open();
                    using (var cmd = new System.Data.SQLite.SQLiteCommand(conn))
                    {
                        cmd.CommandText = sql;
                        var res = cmd.ExecuteScalar();
                    }
                    conn.Close();
                }
            }
            catch { }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            var proceed = MessageBox.Show("This process will make changes to your data! It is recommended that you make a backup before proceeding! Do you wish to continue?", "Pay Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (proceed == System.Windows.Forms.DialogResult.Yes)
            {
                var dest = this.lstFiles.Items[this.lstFiles.Items.Count - 1] as FileItem;
                int start = this.lstFiles.Items.Count - 2;
                for (int i = start; i >= 0; i--)
                {
                    var src = this.lstFiles.Items[i] as FileItem;
                    mergeDatabases(src.FullPath, dest.FullPath);
                }
            }
        }
    }

    class FileItem
    {
        public string FileName { get; set; }
        public string FullPath { get; set; }
    }
}
