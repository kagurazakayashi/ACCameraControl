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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.Fuchsia;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Ignotum", 16F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cPos, cName, cStatus, cID, cSpeed, cTyres });
            dataGridView1.Cursor = Cursors.PanEast;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(64, 64, 64);
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(2, 4, 2, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Ignotum", 16F);
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
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(738, 440);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            dataGridView1.MouseMove += dataGridView1_MouseMove;
            dataGridView1.MouseUp += dataGridView1_MouseUp;
            // 
            // cPos
            // 
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.ForeColor = Color.White;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(914, 608);
            Controls.Add(dataGridView1);
            Font = new Font("Ignotum", 16F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 4, 2, 4);
            Name = "Form1";
            Opacity = 0.9D;
            Text = "Asseto Corsa Remote Control";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private DataGridViewTextBoxColumn cPos;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn cStatus;
        private DataGridViewTextBoxColumn cID;
        private DataGridViewTextBoxColumn cSpeed;
        private DataGridViewTextBoxColumn cTyres;
    }
}
