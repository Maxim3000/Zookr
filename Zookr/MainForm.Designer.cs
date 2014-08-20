namespace Zookr
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.selectFileButton = new System.Windows.Forms.Button();
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.searchDirTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.sourceImageBoxLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.toleranceBar = new System.Windows.Forms.TrackBar();
            this.dropFilePanel = new System.Windows.Forms.Panel();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.imageListView1 = new Manina.Windows.Forms.ImageListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceBar)).BeginInit();
            this.resultsPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.selectFileButton.FlatAppearance.BorderSize = 0;
            this.selectFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFileButton.ForeColor = System.Drawing.Color.White;
            this.selectFileButton.Location = new System.Drawing.Point(115, 9);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(120, 23);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select Image";
            this.selectFileButton.UseVisualStyleBackColor = false;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.sourcePictureBox.Location = new System.Drawing.Point(75, 46);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(200, 200);
            this.sourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourcePictureBox.TabIndex = 1;
            this.sourcePictureBox.TabStop = false;
            this.sourcePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.sourcePictureBox_Paint);
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.selectFolderButton.FlatAppearance.BorderSize = 0;
            this.selectFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolderButton.ForeColor = System.Drawing.Color.White;
            this.selectFolderButton.Location = new System.Drawing.Point(115, 260);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(120, 23);
            this.selectFolderButton.TabIndex = 2;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = false;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // searchDirTextBox
            // 
            this.searchDirTextBox.Location = new System.Drawing.Point(6, 297);
            this.searchDirTextBox.Name = "searchDirTextBox";
            this.searchDirTextBox.Size = new System.Drawing.Size(338, 22);
            this.searchDirTextBox.TabIndex = 3;
            this.searchDirTextBox.Text = "D:\\TEST";
            this.searchDirTextBox.TextChanged += new System.EventHandler(this.folderTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LimeGreen;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(266, 529);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 606F));
            this.tableLayoutPanel1.Controls.Add(this.panelControls, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultsPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(956, 561);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelControls.Controls.Add(this.sourceImageBoxLabel);
            this.panelControls.Controls.Add(this.progressBar1);
            this.panelControls.Controls.Add(this.toleranceLabel);
            this.panelControls.Controls.Add(this.toleranceBar);
            this.panelControls.Controls.Add(this.selectFolderButton);
            this.panelControls.Controls.Add(this.searchDirTextBox);
            this.panelControls.Controls.Add(this.selectFileButton);
            this.panelControls.Controls.Add(this.searchButton);
            this.panelControls.Controls.Add(this.dropFilePanel);
            this.panelControls.Controls.Add(this.sourcePictureBox);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(3, 3);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(344, 555);
            this.panelControls.TabIndex = 6;
            // 
            // sourceImageBoxLabel
            // 
            this.sourceImageBoxLabel.AutoSize = true;
            this.sourceImageBoxLabel.ForeColor = System.Drawing.Color.Silver;
            this.sourceImageBoxLabel.Location = new System.Drawing.Point(127, 140);
            this.sourceImageBoxLabel.Name = "sourceImageBoxLabel";
            this.sourceImageBoxLabel.Size = new System.Drawing.Size(97, 13);
            this.sourceImageBoxLabel.TabIndex = 8;
            this.sourceImageBoxLabel.Text = "Or drop one here";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 529);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(254, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Location = new System.Drawing.Point(147, 346);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(56, 13);
            this.toleranceLabel.TabIndex = 6;
            this.toleranceLabel.Text = "Tolerance";
            // 
            // toleranceBar
            // 
            this.toleranceBar.Location = new System.Drawing.Point(6, 379);
            this.toleranceBar.Maximum = 9;
            this.toleranceBar.Minimum = 1;
            this.toleranceBar.Name = "toleranceBar";
            this.toleranceBar.Size = new System.Drawing.Size(338, 45);
            this.toleranceBar.TabIndex = 5;
            this.toleranceBar.Value = 1;
            this.toleranceBar.Scroll += new System.EventHandler(this.toleranceBar_Scroll);
            // 
            // dropFilePanel
            // 
            this.dropFilePanel.BackColor = System.Drawing.Color.Transparent;
            this.dropFilePanel.Location = new System.Drawing.Point(75, 46);
            this.dropFilePanel.Name = "dropFilePanel";
            this.dropFilePanel.Size = new System.Drawing.Size(200, 200);
            this.dropFilePanel.TabIndex = 9;
            this.dropFilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dropFilePanel_Paint);
            // 
            // resultsPanel
            // 
            this.resultsPanel.BackColor = System.Drawing.Color.White;
            this.resultsPanel.Controls.Add(this.imageListView1);
            this.resultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsPanel.Location = new System.Drawing.Point(353, 3);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(600, 555);
            this.resultsPanel.TabIndex = 7;
            // 
            // imageListView1
            // 
            this.imageListView1.AllowDuplicateFileNames = true;
            this.imageListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageListView1.ColumnHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.imageListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageListView1.GroupHeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.imageListView1.Location = new System.Drawing.Point(0, 0);
            this.imageListView1.Name = "imageListView1";
            this.imageListView1.PersistentCacheDirectory = "";
            this.imageListView1.PersistentCacheSize = ((long)(100));
            this.imageListView1.Size = new System.Drawing.Size(600, 555);
            this.imageListView1.TabIndex = 0;
            this.imageListView1.ThumbnailSize = new System.Drawing.Size(128, 128);
            this.imageListView1.ItemClick += new Manina.Windows.Forms.ItemClickEventHandler(this.imageListView1_ItemClick);
            this.imageListView1.ItemDoubleClick += new Manina.Windows.Forms.ItemDoubleClickEventHandler(this.imageListView1_ItemDoubleClick);
            this.imageListView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.imageListView1_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 48);
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.ShortcutKeyDisplayString = "";
            this.openFileMenuItem.Size = new System.Drawing.Size(149, 22);
            this.openFileMenuItem.Text = "Open location";
            this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(674, 600);
            this.Name = "MainForm";
            this.Text = "Zookr";
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceBar)).EndInit();
            this.resultsPanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.PictureBox sourcePictureBox;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.TextBox searchDirTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.TrackBar toleranceBar;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.Label toleranceLabel;
        private Manina.Windows.Forms.ImageListView imageListView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label sourceImageBoxLabel;
        private System.Windows.Forms.Panel dropFilePanel;
    }
}

