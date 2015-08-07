namespace norplan.adm.qrtoolui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.dlgSelectImageFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.pbSelection = new System.Windows.Forms.PictureBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFiles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSelectFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnIncreaseSelectionContrast = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOpenLink = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnApprove = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReject = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSelectLogFile = new System.Windows.Forms.ToolStripButton();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbMain.Location = new System.Drawing.Point(3, 193);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(426, 250);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMain_Paint);
            this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseDown);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseMove);
            this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseUp);
            // 
            // pbSelection
            // 
            this.pbSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSelection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbSelection.Location = new System.Drawing.Point(435, 193);
            this.pbSelection.Name = "pbSelection";
            this.pbSelection.Size = new System.Drawing.Size(427, 250);
            this.pbSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelection.TabIndex = 2;
            this.pbSelection.TabStop = false;
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbLog, 2);
            this.tbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLog.Location = new System.Drawing.Point(3, 449);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(859, 131);
            this.tbLog.TabIndex = 4;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filename,
            this.Status});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvFiles, 2);
            this.dgvFiles.Location = new System.Drawing.Point(3, 23);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowHeadersWidth = 20;
            this.dgvFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(859, 144);
            this.dgvFiles.TabIndex = 6;
            this.dgvFiles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellClick);
            // 
            // Filename
            // 
            this.Filename.DataPropertyName = "Name";
            this.Filename.HeaderText = "File name";
            this.Filename.Name = "Filename";
            this.Filename.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbLog, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgvFiles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFiles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbMain, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbSelection, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(865, 583);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFiles.Location = new System.Drawing.Point(3, 0);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(426, 20);
            this.lblFiles.TabIndex = 7;
            this.lblFiles.Text = "Photos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Photo";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selection";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnExit,
            this.tsbtnSelectFolder,
            this.toolStripSeparator2,
            this.tsbtnSelectLogFile,
            this.tsbtnIncreaseSelectionContrast,
            this.tsbtnOpenLink,
            this.toolStripSeparator1,
            this.tsbtnApprove,
            this.tsbtnReject});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(865, 50);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(61, 47);
            this.tsbtnExit.Text = "Exit";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // tsbtnSelectFolder
            // 
            this.tsbtnSelectFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSelectFolder.Image")));
            this.tsbtnSelectFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSelectFolder.Name = "tsbtnSelectFolder";
            this.tsbtnSelectFolder.Size = new System.Drawing.Size(143, 47);
            this.tsbtnSelectFolder.Text = "Select photo folder";
            this.tsbtnSelectFolder.Click += new System.EventHandler(this.tsbtnSelectFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // tsbtnIncreaseSelectionContrast
            // 
            this.tsbtnIncreaseSelectionContrast.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnIncreaseSelectionContrast.Image")));
            this.tsbtnIncreaseSelectionContrast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnIncreaseSelectionContrast.Name = "tsbtnIncreaseSelectionContrast";
            this.tsbtnIncreaseSelectionContrast.Size = new System.Drawing.Size(182, 47);
            this.tsbtnIncreaseSelectionContrast.Text = "Increase selection contrast";
            this.tsbtnIncreaseSelectionContrast.Click += new System.EventHandler(this.tsbtnIncreaseSelectionContrast_Click);
            // 
            // tsbtnOpenLink
            // 
            this.tsbtnOpenLink.ForeColor = System.Drawing.Color.Blue;
            this.tsbtnOpenLink.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOpenLink.Image")));
            this.tsbtnOpenLink.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnOpenLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpenLink.Name = "tsbtnOpenLink";
            this.tsbtnOpenLink.Size = new System.Drawing.Size(98, 47);
            this.tsbtnOpenLink.Text = "Check link";
            this.tsbtnOpenLink.Click += new System.EventHandler(this.tsbtnOpenLink_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tsbtnApprove
            // 
            this.tsbtnApprove.ForeColor = System.Drawing.Color.Green;
            this.tsbtnApprove.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnApprove.Image")));
            this.tsbtnApprove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnApprove.Name = "tsbtnApprove";
            this.tsbtnApprove.Size = new System.Drawing.Size(88, 47);
            this.tsbtnApprove.Text = "Approve";
            this.tsbtnApprove.Click += new System.EventHandler(this.tsbtnApprove_Click);
            // 
            // tsbtnReject
            // 
            this.tsbtnReject.ForeColor = System.Drawing.Color.Red;
            this.tsbtnReject.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnReject.Image")));
            this.tsbtnReject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReject.Name = "tsbtnReject";
            this.tsbtnReject.Size = new System.Drawing.Size(75, 47);
            this.tsbtnReject.Text = "Reject";
            this.tsbtnReject.Click += new System.EventHandler(this.tsbtnReject_Click);
            // 
            // tsbtnSelectLogFile
            // 
            this.tsbtnSelectLogFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSelectLogFile.Image")));
            this.tsbtnSelectLogFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSelectLogFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSelectLogFile.Name = "tsbtnSelectLogFile";
            this.tsbtnSelectLogFile.Size = new System.Drawing.Size(105, 47);
            this.tsbtnSelectLogFile.Text = "Select log file";
            this.tsbtnSelectLogFile.Click += new System.EventHandler(this.tsbtnSelectLogFile_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 633);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "QR Code Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.frmMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectImageFolder;
        private System.Windows.Forms.PictureBox pbSelection;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnSelectFolder;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripButton tsbtnIncreaseSelectionContrast;
        private System.Windows.Forms.ToolStripButton tsbtnApprove;
        private System.Windows.Forms.ToolStripButton tsbtnReject;
        private System.Windows.Forms.ToolStripButton tsbtnOpenLink;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripButton tsbtnSelectLogFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}

