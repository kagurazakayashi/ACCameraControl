namespace ACCameraControl
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            cPos = new DataGridViewTextBoxColumn();
            cName = new DataGridViewTextBoxColumn();
            cStatus = new DataGridViewTextBoxColumn();
            cID = new DataGridViewTextBoxColumn();
            cSpeed = new DataGridViewTextBoxColumn();
            cTyres = new DataGridViewTextBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            btnCamerasTV = new PictureBox();
            btnCamerasCockpit = new PictureBox();
            toolTip1 = new ToolTip(components);
            btnCamerasHelicopter = new PictureBox();
            btnCamerasCar = new PictureBox();
            btnCamerasRandom = new PictureBox();
            btnMoveWindow = new PictureBox();
            btnShowList = new PictureBox();
            btnMinimize = new PictureBox();
            btnExit = new PictureBox();
            btnEnableWrite = new PictureBox();
            TransgenderPride = new PictureBox();
            timerRun = new System.Windows.Forms.Timer(components);
            resizeButton = new PictureBox();
            labelAlert = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCamerasTV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCamerasCockpit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCamerasHelicopter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCamerasCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCamerasRandom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMoveWindow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnShowList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEnableWrite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransgenderPride).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resizeButton).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.BackgroundColor = Color.Fuchsia;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cPos, cName, cStatus, cID, cSpeed, cTyres });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(64, 64, 64);
            dataGridView1.Location = new Point(70, 10);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(617, 462);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.SortCompare += dataGridView1_SortCompare;
            dataGridView1.MouseMove += dataGridView1_MouseMove;
            // 
            // cPos
            // 
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            cPos.DefaultCellStyle = dataGridViewCellStyle2;
            cPos.HeaderText = "POS";
            cPos.Name = "cPos";
            cPos.ReadOnly = true;
            // 
            // cName
            // 
            cName.HeaderText = "NAME";
            cName.Name = "cName";
            cName.ReadOnly = true;
            // 
            // cStatus
            // 
            cStatus.HeaderText = "STATUS";
            cStatus.Name = "cStatus";
            cStatus.ReadOnly = true;
            // 
            // cID
            // 
            cID.HeaderText = "ID";
            cID.Name = "cID";
            cID.ReadOnly = true;
            // 
            // cSpeed
            // 
            cSpeed.HeaderText = "SPEED";
            cSpeed.Name = "cSpeed";
            cSpeed.ReadOnly = true;
            // 
            // cTyres
            // 
            cTyres.HeaderText = "TYRES";
            cTyres.Name = "cTyres";
            cTyres.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "dataout.txt|dataout.txt|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            // 
            // btnCamerasTV
            // 
            btnCamerasTV.BackColor = Color.Black;
            btnCamerasTV.Cursor = Cursors.Hand;
            btnCamerasTV.Image = Properties.Resources.live_tv_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnCamerasTV.Location = new Point(10, 186);
            btnCamerasTV.Name = "btnCamerasTV";
            btnCamerasTV.Padding = new Padding(8, 9, 8, 9);
            btnCamerasTV.Size = new Size(53, 54);
            btnCamerasTV.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCamerasTV.TabIndex = 1;
            btnCamerasTV.TabStop = false;
            toolTip1.SetToolTip(btnCamerasTV, "[F1] TV Cameras");
            btnCamerasTV.Click += btnCamerasTV_Click;
            btnCamerasTV.MouseMove += dataGridView1_MouseMove;
            // 
            // btnCamerasCockpit
            // 
            btnCamerasCockpit.BackColor = Color.Black;
            btnCamerasCockpit.Cursor = Cursors.Hand;
            btnCamerasCockpit.Image = Properties.Resources.search_hands_free_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnCamerasCockpit.Location = new Point(10, 245);
            btnCamerasCockpit.Name = "btnCamerasCockpit";
            btnCamerasCockpit.Padding = new Padding(8, 9, 8, 9);
            btnCamerasCockpit.Size = new Size(53, 54);
            btnCamerasCockpit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCamerasCockpit.TabIndex = 1;
            btnCamerasCockpit.TabStop = false;
            toolTip1.SetToolTip(btnCamerasCockpit, "[F2] Cockpit Cameras");
            btnCamerasCockpit.Click += btnCamerasCockpit_Click;
            btnCamerasCockpit.MouseMove += dataGridView1_MouseMove;
            // 
            // btnCamerasHelicopter
            // 
            btnCamerasHelicopter.BackColor = Color.Black;
            btnCamerasHelicopter.Cursor = Cursors.Hand;
            btnCamerasHelicopter.Image = Properties.Resources.helicopter_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnCamerasHelicopter.Location = new Point(10, 304);
            btnCamerasHelicopter.Name = "btnCamerasHelicopter";
            btnCamerasHelicopter.Padding = new Padding(8, 9, 8, 9);
            btnCamerasHelicopter.Size = new Size(53, 54);
            btnCamerasHelicopter.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCamerasHelicopter.TabIndex = 1;
            btnCamerasHelicopter.TabStop = false;
            toolTip1.SetToolTip(btnCamerasHelicopter, "[F3] Helicopter");
            btnCamerasHelicopter.Click += btnCamerasHelicopter_Click;
            btnCamerasHelicopter.MouseMove += dataGridView1_MouseMove;
            // 
            // btnCamerasCar
            // 
            btnCamerasCar.BackColor = Color.Black;
            btnCamerasCar.Cursor = Cursors.Hand;
            btnCamerasCar.Image = Properties.Resources.sports_motorsports_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnCamerasCar.Location = new Point(10, 362);
            btnCamerasCar.Name = "btnCamerasCar";
            btnCamerasCar.Padding = new Padding(8, 9, 8, 9);
            btnCamerasCar.Size = new Size(53, 54);
            btnCamerasCar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCamerasCar.TabIndex = 1;
            btnCamerasCar.TabStop = false;
            toolTip1.SetToolTip(btnCamerasCar, "[F4] Car Cameras");
            btnCamerasCar.Click += btnCamerasCar_Click;
            btnCamerasCar.MouseMove += dataGridView1_MouseMove;
            // 
            // btnCamerasRandom
            // 
            btnCamerasRandom.BackColor = Color.Black;
            btnCamerasRandom.Cursor = Cursors.Hand;
            btnCamerasRandom.Image = Properties.Resources.ifl_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnCamerasRandom.Location = new Point(10, 422);
            btnCamerasRandom.Name = "btnCamerasRandom";
            btnCamerasRandom.Padding = new Padding(8, 9, 8, 9);
            btnCamerasRandom.Size = new Size(53, 54);
            btnCamerasRandom.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCamerasRandom.TabIndex = 1;
            btnCamerasRandom.TabStop = false;
            toolTip1.SetToolTip(btnCamerasRandom, "[F5] Random");
            btnCamerasRandom.Click += btnCamerasRandom_Click;
            btnCamerasRandom.MouseMove += dataGridView1_MouseMove;
            // 
            // btnMoveWindow
            // 
            btnMoveWindow.BackColor = Color.Black;
            btnMoveWindow.Cursor = Cursors.SizeAll;
            btnMoveWindow.Image = Properties.Resources.open_with_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnMoveWindow.Location = new Point(10, 10);
            btnMoveWindow.Name = "btnMoveWindow";
            btnMoveWindow.Padding = new Padding(8, 9, 8, 9);
            btnMoveWindow.Size = new Size(53, 54);
            btnMoveWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMoveWindow.TabIndex = 1;
            btnMoveWindow.TabStop = false;
            toolTip1.SetToolTip(btnMoveWindow, "Move Window");
            btnMoveWindow.MouseDoubleClick += btnMoveWindow_MouseDoubleClick;
            btnMoveWindow.MouseDown += btnMoveWindow_MouseDown;
            btnMoveWindow.MouseMove += btnMoveWindow_MouseMove;
            btnMoveWindow.MouseUp += btnMoveWindow_MouseUp;
            // 
            // btnShowList
            // 
            btnShowList.BackColor = Color.Black;
            btnShowList.Cursor = Cursors.Hand;
            btnShowList.Image = Properties.Resources.keyboard_double_arrow_left_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnShowList.Location = new Point(10, 69);
            btnShowList.Name = "btnShowList";
            btnShowList.Padding = new Padding(8, 9, 8, 9);
            btnShowList.Size = new Size(53, 54);
            btnShowList.SizeMode = PictureBoxSizeMode.StretchImage;
            btnShowList.TabIndex = 1;
            btnShowList.TabStop = false;
            toolTip1.SetToolTip(btnShowList, "[F12] Show List");
            btnShowList.Click += btnShowList_Click;
            btnShowList.MouseMove += dataGridView1_MouseMove;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Black;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Image = Properties.Resources.minimize_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnMinimize.Location = new Point(70, 10);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Padding = new Padding(8, 9, 8, 9);
            btnMinimize.Size = new Size(53, 54);
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.TabIndex = 1;
            btnMinimize.TabStop = false;
            toolTip1.SetToolTip(btnMinimize, "Minimize");
            btnMinimize.Visible = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.close_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnExit.Location = new Point(122, 10);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(8, 9, 8, 9);
            btnExit.Size = new Size(53, 54);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 1;
            btnExit.TabStop = false;
            toolTip1.SetToolTip(btnExit, "Exit");
            btnExit.Visible = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnEnableWrite
            // 
            btnEnableWrite.BackColor = Color.Black;
            btnEnableWrite.Cursor = Cursors.Hand;
            btnEnableWrite.Image = Properties.Resources.pause_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnEnableWrite.Location = new Point(10, 128);
            btnEnableWrite.Name = "btnEnableWrite";
            btnEnableWrite.Padding = new Padding(8, 9, 8, 9);
            btnEnableWrite.Size = new Size(53, 54);
            btnEnableWrite.SizeMode = PictureBoxSizeMode.StretchImage;
            btnEnableWrite.TabIndex = 1;
            btnEnableWrite.TabStop = false;
            toolTip1.SetToolTip(btnEnableWrite, "[F11] Enable Write");
            btnEnableWrite.Click += btnEnableWrite_Click;
            btnEnableWrite.MouseMove += dataGridView1_MouseMove;
            // 
            // TransgenderPride
            // 
            TransgenderPride.BackColor = Color.Black;
            TransgenderPride.Cursor = Cursors.Hand;
            TransgenderPride.Image = Properties.Resources.transgender_1000dp_FFF_FILL0_wght400_GRAD0_opsz481;
            TransgenderPride.Location = new Point(70, 69);
            TransgenderPride.Name = "TransgenderPride";
            TransgenderPride.Padding = new Padding(8, 9, 8, 9);
            TransgenderPride.Size = new Size(53, 54);
            TransgenderPride.SizeMode = PictureBoxSizeMode.StretchImage;
            TransgenderPride.TabIndex = 1;
            TransgenderPride.TabStop = false;
            TransgenderPride.Visible = false;
            TransgenderPride.Click += TransgenderPride_Click;
            TransgenderPride.MouseMove += dataGridView1_MouseMove;
            // 
            // timerRun
            // 
            timerRun.Enabled = true;
            timerRun.Interval = 2000;
            timerRun.Tick += timerRun_Tick;
            // 
            // resizeButton
            // 
            resizeButton.BackColor = Color.Gray;
            resizeButton.Cursor = Cursors.SizeNS;
            resizeButton.Location = new Point(70, 479);
            resizeButton.Name = "resizeButton";
            resizeButton.Size = new Size(617, 4);
            resizeButton.TabIndex = 2;
            resizeButton.TabStop = false;
            resizeButton.DoubleClick += resizeButton_DoubleClick;
            resizeButton.MouseDown += resizeButton_MouseDown;
            resizeButton.MouseLeave += resizeButton_MouseLeave;
            resizeButton.MouseMove += resizeButton_MouseMove;
            resizeButton.MouseUp += resizeButton_MouseUp;
            // 
            // labelAlert
            // 
            labelAlert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAlert.BackColor = Color.Black;
            labelAlert.ForeColor = Color.Red;
            labelAlert.Location = new Point(70, 40);
            labelAlert.Name = "labelAlert";
            labelAlert.Padding = new Padding(10);
            labelAlert.Size = new Size(600, 436);
            labelAlert.TabIndex = 3;
            labelAlert.Text = "LOADING";
            labelAlert.TextAlign = ContentAlignment.MiddleCenter;
            labelAlert.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(774, 485);
            Controls.Add(TransgenderPride);
            Controls.Add(btnExit);
            Controls.Add(btnMinimize);
            Controls.Add(labelAlert);
            Controls.Add(resizeButton);
            Controls.Add(btnCamerasRandom);
            Controls.Add(btnCamerasCar);
            Controls.Add(btnCamerasHelicopter);
            Controls.Add(btnCamerasCockpit);
            Controls.Add(btnShowList);
            Controls.Add(btnMoveWindow);
            Controls.Add(btnEnableWrite);
            Controls.Add(btnCamerasTV);
            Controls.Add(dataGridView1);
            Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(0, 485);
            Name = "Form1";
            Opacity = 0.9D;
            Text = "Asseto Corsa Remote Control";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            LocationChanged += Form1_LocationChanged;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCamerasTV).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCamerasCockpit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCamerasHelicopter).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCamerasCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCamerasRandom).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMoveWindow).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnShowList).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEnableWrite).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransgenderPride).EndInit();
            ((System.ComponentModel.ISupportInitialize)resizeButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private PictureBox btnCamerasTV;
        private ToolTip toolTip1;
        private PictureBox btnCamerasCockpit;
        private PictureBox btnCamerasHelicopter;
        private PictureBox btnCamerasCar;
        private PictureBox btnCamerasRandom;
        private PictureBox btnMoveWindow;
        private PictureBox btnShowList;
        private PictureBox btnMinimize;
        private PictureBox btnExit;
        private DataGridViewTextBoxColumn cPos;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn cStatus;
        private DataGridViewTextBoxColumn cID;
        private DataGridViewTextBoxColumn cSpeed;
        private DataGridViewTextBoxColumn cTyres;
        private PictureBox btnEnableWrite;
        private PictureBox TransgenderPride;
        private System.Windows.Forms.Timer timerRun;
        private PictureBox resizeButton;
        private Label labelAlert;
    }
}
