using Manina.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zookr
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {
        delegate void ClearListViewDelegate();
        delegate void AddResultDelegate(string imagePath);
        private bool isSearching = false;
        private string sourceImagePath = null;
        private string searchDirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private int tolerance = 5;
        
        public string SourceImagePath
        {
            get { return sourceImagePath; }
            set
            {
                try
                {
                    sourcePictureBox.Image = Image.FromFile(value);
                    sourceImagePath = value;
                    sourceImageBoxLabel.Visible = false;
                    dropFilePanel.Visible = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Invalid file format", "Error");                    
                }
            }
        }
        public string SearchDirPath
        {
            get
            {
                return searchDirPath;
            }
            set
            {
                searchDirPath = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("SearchDirPath"));
            }
        }
        public int Tolerance
        {
            get { return tolerance; }
            set { tolerance = value; }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public MainForm()
        {
            InitializeComponent();
            this.imageListView1.SetRenderer(new ImageListViewRenderers.TilesRenderer());
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(MainFormDragEnter);
            this.DragDrop += new DragEventHandler(MainFormDragDrop);
                                    
            searchDirTextBox.DataBindings.Add("Text", this, "SearchDirPath");
            toleranceBar.DataBindings.Add("Value", this, "Tolerance");
        }

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        private void selectFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select image";
                ofd.Filter = "Image files | *.*";

                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        SourceImagePath = ofd.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file:\n" + ex.Message);
                }
            }
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                try
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        SearchDirPath = fbd.SelectedPath;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening folder:\n" + ex.Message);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (SourceImagePath == null)
            {
                MessageBox.Show("No source image selected", "Error");
            }
            else if (!Directory.Exists(searchDirPath))
            {
                MessageBox.Show("Invalid search directory", "Error");
            }
            else
            {
                if (isSearching)
                {
                    backgroundWorker1.CancelAsync();
                    this.searchButton.Text = "Search";
                }
                else
                {
                    this.searchButton.Text = "Stop";
                    isSearching = true;                
                    backgroundWorker1.RunWorkerAsync();   
                }
            }
        }
                
        public void clearListView()
        {
            if (this.InvokeRequired)
            {
                ClearListViewDelegate clvd = new ClearListViewDelegate(clearListView);
                this.Invoke(clvd);
            }
            else
            {
                imageListView1.Items.Clear();
            }
        }

        public void addResult(string imagePath)
        {
            if (this.InvokeRequired)
            {
                AddResultDelegate ard = new AddResultDelegate(addResult);
                object[] parameters = { imagePath};
                this.Invoke(ard, parameters);
            }
            else
            {
                imageListView1.Items.Add(imagePath);
                
            }
        }
        
        private void folderTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchDirPath = searchDirTextBox.Text;
        }

        private void MainFormDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainFormDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
            SourceImagePath = files[0];
        }

        public void reportProgress(int percentage)
        {
            backgroundWorker1.ReportProgress(percentage);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Controller.Instance.startSearch();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.isSearching = false;
            this.searchButton.Text = "Search";
        }

        private void toleranceBar_Scroll(object sender, EventArgs e)
        {
            Tolerance = toleranceBar.Value;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void imageListView1_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            if (e.Buttons == MouseButtons.Left)
            {
                System.Diagnostics.Process.Start(e.Item.FileName);
            }
        }

        private void imageListView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if(imageListView1.SelectedItems.Count > 0) {
                    var confirm = MessageBox.Show("Delete selected images?", 
                                                  "Delete", 
                                                  MessageBoxButtons.OKCancel);
                    if (confirm == DialogResult.OK)
                    {
                        foreach(ImageListViewItem item in imageListView1.SelectedItems) {                            
                            File.Delete(item.FileName);
                            imageListView1.Items.Remove(item);
                        }                    
                    }
                }
            }
        }

        private void imageListView1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Buttons == MouseButtons.Right)
            {
                contextMenuStrip1.Tag = e.Item;
                contextMenuStrip1.Show(MousePosition);                
            }
        }
        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            var item = (ImageListViewItem) contextMenuStrip1.Tag;
            var arg = @"/select, " + item.FileName;
            System.Diagnostics.Process.Start("explorer.exe", arg); 
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Delete image?", 
                                                  "Delete", 
                                                  MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                var item = (ImageListViewItem) contextMenuStrip1.Tag;
                File.Delete(item.FileName);
                imageListView1.Items.Remove(item);
            }

        }

        private void sourcePictureBox_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        private void dropFilePanel_Paint(object sender, PaintEventArgs e)
        {
            float[] dashValues = { 5, 2, 15, 4 };
            Pen blackPen = new Pen(Color.LightGray, 1);
            blackPen.DashPattern = dashValues;
            e.Graphics.DrawRectangle(blackPen, 0, 0, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }
    }
}
