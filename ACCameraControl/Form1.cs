using ACCameraControl.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ACCameraControl
{
    public partial class Form1 : Form
    {
        private string gameDataOutFile = "dataout.txt";
        private string saveDataFile = "datain.txt";
        private WindowMove winMv;
        private Control[] cameraButtons;
        private Int64 sendCounter = 0;
        private Int64 shotcounter = 0;
        private int lastSortedColumnIndex = -1;
        private ListSortDirection lastSortDirection = ListSortDirection.Ascending;

        public Form1()
        {
            InitializeComponent();
            winMv = new WindowMove(this);
            cameraButtons = new Control[]
            {
                btnCamerasTV,
                btnCamerasCockpit,
                btnCamerasHelicopter,
                btnCamerasCar,
                btnCamerasRandom
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = new Point(0, 0);
            dataGridView1.Columns[0].ValueType = typeof(int);
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].ValueType = typeof(int);
            if (!File.Exists(gameDataOutFile))
            {
                openFileDialog1.Title = $"Can't find the file {gameDataOutFile} , please specify one manually.";
                openFileDialog1.InitialDirectory = Application.StartupPath;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    gameDataOutFile = openFileDialog1.FileName;
                }
                else
                {
                    Application.Exit();
                    return;
                }
            }
            LoadDataToGrid();
        }

        private void LoadDataToGrid()
        {
            dataGridView1.Rows.Clear();
            var lines = File.ReadAllLines(gameDataOutFile);
            Console.WriteLine("Data Length:" + lines.Length.ToString());
            if (lines.Length == 0)
            {
                return;
            }
            foreach (var line in lines)
            {
                string[] values = line.Split('|');
                int valuesCount = values.Length;
                int mustCount = 6;
                if (valuesCount != mustCount)
                {
                    if (MessageBox.Show($"There is an error in the game output data. \r\n Requires data amount: {mustCount}\r\n Gets data amount: {valuesCount}", "Data Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    {
                        Application.Exit();
                        return;
                    }
                }
                string dPos = values[1];
                string dName = values[0];
                string dStatus = values[2];
                string dID = values[3];
                string dSpeed = values[4];
                string dTyres = values[5];
                dataGridView1.Rows.Add([dPos, dName, dStatus, dID, dSpeed, dTyres]);
            }
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            autoResizeGridView();
            RestoreUserSort();
            //autoResizeForm();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                //DataGridViewCellStyle { BackColor=Color [Red], ForeColor=Color [White], SelectionBackColor=Color [White], SelectionForeColor=Color [Black] }
                e.CellStyle!.BackColor = Color.FromArgb(220, 0, 0);
                e.CellStyle!.ForeColor = Color.White;
                e.CellStyle!.SelectionForeColor = Color.Black;
                e.CellStyle!.SelectionBackColor = Color.White;
            }
        }

        private void autoResizeGridView()
        {
            int paddingX = 60;
            int paddingY = 30;
            int totalColumnWidth = dataGridView1.Columns
                .Cast<DataGridViewColumn>()
                .Sum(col => col.Width);
            int totalRowHeight = dataGridView1.Rows
                .Cast<DataGridViewRow>()
                .Sum(row => row.Height) + dataGridView1.ColumnHeadersHeight;
            dataGridView1.Width = totalColumnWidth + paddingX;
            dataGridView1.Height = totalRowHeight + paddingY;
        }

        private void autoResizeForm()
        {
            int paddingX = 0;
            int paddingY = 0;
            this.ClientSize = new System.Drawing.Size(
                dataGridView1.Width + paddingX,
                dataGridView1.Height + paddingY
            );
        }

        private void btnMoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            btnMoveWindow.BackColor = Color.Yellow;
            winMv.MouseDown(sender, e);
        }

        private void btnMoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            winMv.MouseMove(sender, e);
            btnMinimize.Visible = true;
            btnExit.Visible = true;
        }

        private void btnMoveWindow_MouseUp(object sender, MouseEventArgs e)
        {
            btnMoveWindow.BackColor = Color.Black;
            winMv.MouseUp(sender, e);
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = !dataGridView1.Visible;
            btnShowList.Image = dataGridView1.Visible ? Resources.keyboard_double_arrow_left_1000dp_FFF_FILL0_wght400_GRAD0_opsz48 : Resources.keyboard_double_arrow_right_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
        }

        private void btnEnableWrite_Click(object sender, EventArgs e)
        {
            timerRun.Enabled = !timerRun.Enabled;
            btnEnableWrite.Image = timerRun.Enabled ? Resources.pause_1000dp_FFF_FILL0_wght400_GRAD0_opsz48 : Resources.play_arrow_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnEnableWrite.BackColor = timerRun.Enabled ? Color.Gray : Color.Black;
        }

        private void btnMoveWindow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Location = new Point(0, 0);
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (btnMinimize.Visible)
            {
                btnMinimize.Visible = false;
                btnExit.Visible = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            btnMinimize.Visible = false;
            btnExit.Visible = false;
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TransgenderPride_Click(object sender, EventArgs e)
        {
            Color color1 = ColorTranslator.FromHtml("#F5A9B8");
            Color color2 = ColorTranslator.FromHtml("#5BCEFA");
            TransgenderPride.BackColor = (TransgenderPride.BackColor == color1) ? color2 : color1;
        }

        private int nowSelectedCamera()
        {
            for (int i = 0; i < cameraButtons.Length; i++)
            {
                if (cameraButtons[i].BackColor == Color.Red)
                {
                    return i + 1;
                }
            }
            return 0;
        }

        private string nowSelectID()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                object cellValue = selectedRow.Cells[3].Value;
                if (cellValue != null)
                {
                    string cellString = (string)cellValue;
                    return cellString;
                }
            }
            return "0";
        }

        private void selectIDrow(string selectID)
        {
            dataGridView1.ClearSelection();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value.ToString() == selectID)
                {
                    row.Selected = true;
                    //dataGridView1.FirstDisplayedScrollingRowIndex = row.Index; // 自动滚动到这行
                    break;
                }
            }
        }

        private void clearAllCameras()
        {
            foreach (var btn in cameraButtons)
            {
                btn.BackColor = Color.Black;
            }
            shotcounter++;
        }

        private void btnCamerasTV_Click(object sender, EventArgs e)
        {
            clearAllCameras();
            btnCamerasTV.BackColor = Color.Red;
        }

        private void btnCamerasCockpit_Click(object sender, EventArgs e)
        {
            clearAllCameras();
            btnCamerasCockpit.BackColor = Color.Red;
        }

        private void btnCamerasHelicopter_Click(object sender, EventArgs e)
        {
            clearAllCameras();
            btnCamerasHelicopter.BackColor = Color.Red;
        }

        private void btnCamerasCar_Click(object sender, EventArgs e)
        {
            clearAllCameras();
            btnCamerasCar.BackColor = Color.Red;
        }

        private void btnCamerasRandom_Click(object sender, EventArgs e)
        {
            clearAllCameras();
            btnCamerasRandom.BackColor = Color.Red;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    btnCamerasTV_Click(this, new EventArgs());
                    return true;
                case Keys.F2:
                    btnCamerasCockpit_Click(this, new EventArgs());
                    return true;
                case Keys.F3:
                    btnCamerasHelicopter_Click(this, new EventArgs());
                    return true;
                case Keys.F4:
                    btnCamerasCar_Click(this, new EventArgs());
                    return true;
                case Keys.F5:
                    btnCamerasRandom_Click(this, new EventArgs());
                    return true;
                case Keys.F11:
                    btnEnableWrite_Click(this, new EventArgs());
                    return true;
                case Keys.F12:
                    btnShowList_Click(this, new EventArgs());
                    return true;
            }
            if (keyData == (Keys.Alt | Keys.F4) || keyData == (Keys.Control | Keys.Q))
            {
                btnExit_Click(this, new EventArgs());
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timerRun_Tick(object sender, EventArgs e)
        {
            btnEnableWrite.BackColor = btnEnableWrite.BackColor == Color.Black ? Color.Gray : Color.Black;
            sendCounter++;
            string selectID = nowSelectID();
            // 回报格式是: ID | 镜头号 | 镜头号变一次就+1 | 每两秒递增1
            string info = $"{selectID}|{nowSelectedCamera()}|{shotcounter}|{sendCounter}";
            Console.WriteLine(info);
            try
            {
                File.WriteAllText(saveDataFile, info);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            LoadDataToGrid();
            selectIDrow(selectID);
        }

        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            int index = e.Column.Index;
            if (index == 0 || index == 3 || index == 4)
            {
                if (int.TryParse(e.CellValue1?.ToString(), out int val1) &&
                    int.TryParse(e.CellValue2?.ToString(), out int val2))
                {
                    e.SortResult = val1.CompareTo(val2);
                    e.Handled = true; // 阻止默认字符串排序
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var column = dataGridView1.Columns[e.ColumnIndex];
                var currentDirection = lastSortDirection == ListSortDirection.Ascending ?
                                       ListSortDirection.Descending : ListSortDirection.Ascending;
                dataGridView1.Sort(column, currentDirection);
                lastSortedColumnIndex = e.ColumnIndex;
                lastSortDirection = currentDirection;
            }
        }

        private void RestoreUserSort()
        {
            if (lastSortedColumnIndex >= 0)
            {
                var col = dataGridView1.Columns[lastSortedColumnIndex];
                dataGridView1.Sort(col, lastSortDirection);
            }
        }

    }
}
