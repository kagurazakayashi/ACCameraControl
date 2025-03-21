namespace MapDataRender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            新建NToolStripButton = new ToolStripButton();
            OpenToolStripButton = new ToolStripButton();
            SaveToolStripButton = new ToolStripButton();
            打印PToolStripButton = new ToolStripButton();
            复制CToolStripButton = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { 新建NToolStripButton, OpenToolStripButton, SaveToolStripButton, 打印PToolStripButton, 复制CToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(484, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // 新建NToolStripButton
            // 
            新建NToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            新建NToolStripButton.Image = (Image)resources.GetObject("新建NToolStripButton.Image");
            新建NToolStripButton.ImageTransparentColor = Color.Magenta;
            新建NToolStripButton.Name = "新建NToolStripButton";
            新建NToolStripButton.Size = new Size(23, 22);
            新建NToolStripButton.Text = "&New";
            // 
            // OpenToolStripButton
            // 
            OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenToolStripButton.Image = (Image)resources.GetObject("OpenToolStripButton.Image");
            OpenToolStripButton.ImageTransparentColor = Color.Magenta;
            OpenToolStripButton.Name = "OpenToolStripButton";
            OpenToolStripButton.Size = new Size(23, 22);
            OpenToolStripButton.Text = "&Open CSV";
            OpenToolStripButton.Click += OpenToolStripButton_Click;
            // 
            // SaveToolStripButton
            // 
            SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveToolStripButton.Image = (Image)resources.GetObject("SaveToolStripButton.Image");
            SaveToolStripButton.ImageTransparentColor = Color.Magenta;
            SaveToolStripButton.Name = "SaveToolStripButton";
            SaveToolStripButton.Size = new Size(23, 22);
            SaveToolStripButton.Text = "&Save Image";
            SaveToolStripButton.Click += SaveToolStripButton_Click;
            // 
            // 打印PToolStripButton
            // 
            打印PToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            打印PToolStripButton.Image = (Image)resources.GetObject("打印PToolStripButton.Image");
            打印PToolStripButton.ImageTransparentColor = Color.Magenta;
            打印PToolStripButton.Name = "打印PToolStripButton";
            打印PToolStripButton.Size = new Size(23, 22);
            打印PToolStripButton.Text = "&Print Image";
            // 
            // 复制CToolStripButton
            // 
            复制CToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            复制CToolStripButton.Image = (Image)resources.GetObject("复制CToolStripButton.Image");
            复制CToolStripButton.ImageTransparentColor = Color.Magenta;
            复制CToolStripButton.Name = "复制CToolStripButton";
            复制CToolStripButton.Size = new Size(23, 22);
            复制CToolStripButton.Text = "&Copy";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog1.Title = "Open Map Point .csv";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 436);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "PNG Image (*.png)|*.png";
            saveFileDialog1.Title = "Save to .png";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(300, 300);
            Name = "Form1";
            Text = "Map data render";
            Load += Form1_Load;
            Resize += Form1_Resize;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton 新建NToolStripButton;
        private ToolStripButton OpenToolStripButton;
        private ToolStripButton SaveToolStripButton;
        private ToolStripButton 打印PToolStripButton;
        private ToolStripButton 复制CToolStripButton;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private SaveFileDialog saveFileDialog1;
    }
}
