namespace MBTilesMerge
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.tmrUI = new System.Windows.Forms.Timer(this.components);
            this.ofdMBTiles = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MBTilesMerge.Properties.Resources.mbtiles;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lstFiles
            // 
            this.lstFiles.DisplayMember = "FileName";
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(214, 5);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(195, 199);
            this.lstFiles.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(456, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(176, 24);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Add MBTiles Database...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMoveUp.Location = new System.Drawing.Point(415, 5);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(30, 26);
            this.btnMoveUp.TabIndex = 3;
            this.btnMoveUp.Text = "­";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMoveDown.Location = new System.Drawing.Point(415, 60);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(30, 26);
            this.btnMoveDown.TabIndex = 4;
            this.btnMoveDown.Text = "¯";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // tmrUI
            // 
            this.tmrUI.Interval = 25;
            this.tmrUI.Tick += new System.EventHandler(this.tmrUI_Tick);
            // 
            // ofdMBTiles
            // 
            this.ofdMBTiles.Filter = "MBTiles Databases|*.mbtiles|All files|*.*";
            this.ofdMBTiles.Title = "Select MBTiles Database";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(547, 179);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 24);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(456, 179);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(85, 24);
            this.btnMerge.TabIndex = 6;
            this.btnMerge.Text = "Merge...";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // txtInstructions
            // 
            this.txtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInstructions.Location = new System.Drawing.Point(456, 41);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(176, 125);
            this.txtInstructions.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 207);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "MBTiles Merge Utility";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Timer tmrUI;
        private System.Windows.Forms.OpenFileDialog ofdMBTiles;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.TextBox txtInstructions;
    }
}

