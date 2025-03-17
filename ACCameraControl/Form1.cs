using ACCameraControl.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ACCameraControl
{
    public partial class Form1 : Form
    {
        private static string gameDataOutFile = "dataout.txt";
        private static string saveDataFile = "datain.txt";
        private static int gridViewHeightCompensation = 32;
        private WindowMove winMv;
        private Control[] cameraButtons;
        private int sendCounter = 0;
        private int shotcounter = 0;
        private int lastSortedColumnIndex = -1;
        private ListSortDirection lastSortDirection = ListSortDirection.Ascending;
        private bool isResizing = false;
        private Point lastMousePosition;
        private bool enableSelectionChangedFunc = true;

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
#if DEBUG
            Console.WriteLine(Text);
#endif
            Location = new Point(0, 0);
            dataGridView1.Columns[0].ValueType = typeof(int);
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].ValueType = typeof(int);
            if (LoadDataToGrid())
            {
                autoResizeGridView(0, -1);
                resizeButton_DoubleClick(sender, e);
            }
        }

        private void ShowError(string message)
        {
#if DEBUG
            Console.WriteLine(message);
#endif
            labelAlert.Size = dataGridView1.Size;
            labelAlert.Location = dataGridView1.Location;
            labelAlert.Text = message;
            labelAlert.Visible = true;
            btnEnableWrite_Click(null, null);
        }

        private bool LoadDataToGrid()
        {
            dataGridView1.Rows.Clear();
            string[] lines = [];
            try
            {
                lines = File.ReadAllLines(gameDataOutFile);
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
                return false;
            }
            if (labelAlert.Visible)
            {
                labelAlert.Visible = false;
            }
#if DEBUG
            Console.WriteLine("[I] ROW: " + lines.Length.ToString());
#endif
            if (lines.Length == 0)
            {
                return false;
            }
            foreach (var line in lines)
            {
                string[] values = line.Split('|');
                int valuesCount = values.Length;
                int mustCount = 6;
                if (valuesCount != mustCount)
                {
                    ShowError($"There is an error in the game output data.\r\nRequires data amount: {mustCount}\r\nGets data amount: {valuesCount}");
                    return false;
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
            UpdateResizeButtonPosition();
            //autoResizeForm();
            return true;
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

        private Size autoResizeGridView(int paddingX = -1, int paddingY = -1, bool resize = true)
        {
            Size newSize = new Size();
            if (paddingX >= 0)
            {
                int totalColumnWidth = dataGridView1.Columns
                    .Cast<DataGridViewColumn>()
                    .Sum(col => col.Width);

                bool hasVerticalScrollbar = false;
                int totalRowHeight = dataGridView1.Rows
                    .Cast<DataGridViewRow>()
                    .Sum(row => row.Height);

                if (totalRowHeight + dataGridView1.ColumnHeadersHeight > dataGridView1.ClientSize.Height)
                {
                    hasVerticalScrollbar = true;
                }
                int scrollbarWidth = hasVerticalScrollbar ? SystemInformation.VerticalScrollBarWidth : 0;
                newSize.Width = totalColumnWidth + paddingX + scrollbarWidth;
                if (resize) dataGridView1.Width = newSize.Width;
            }
            if (paddingY >= 0)
            {
                int totalRowHeight = dataGridView1.Rows
                    .Cast<DataGridViewRow>()
                    .Sum(row => row.Height);
                int totalContentHeight = totalRowHeight + dataGridView1.ColumnHeadersHeight;
                bool hasHorizontalScrollbar = false;
                int totalColumnWidth = dataGridView1.Columns
                    .Cast<DataGridViewColumn>()
                    .Sum(col => col.Width);
                if (totalColumnWidth > dataGridView1.ClientSize.Width)
                {
                    hasHorizontalScrollbar = true;
                }
                int scrollbarHeight = hasHorizontalScrollbar ? SystemInformation.HorizontalScrollBarHeight : 0;
                newSize.Height = totalContentHeight + paddingY + scrollbarHeight;
                if (resize) dataGridView1.Height = newSize.Height;
            }
            if (resize)
            {
                Width = dataGridView1.ClientSize.Width + 80;
                Height = dataGridView1.ClientSize.Height + 20;
            }
            return newSize;
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
            btnMinimize.BringToFront();
            btnExit.Visible = true;
            btnExit.BringToFront();
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
            enableWrite(timerRun.Enabled);
        }

        private void enableWrite(bool enable)
        {
            btnEnableWrite.Image = enable ? Resources.pause_1000dp_FFF_FILL0_wght400_GRAD0_opsz48 : Resources.play_arrow_1000dp_FFF_FILL0_wght400_GRAD0_opsz48;
            btnEnableWrite.BackColor = enable ? Color.Gray : Color.Black;
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
            WriteFile();
        }

        private void btnCamerasCockpit_Click(object sender, EventArgs e)
        {
            clearAllCameras();
            btnCamerasCockpit.BackColor = Color.Red;
            WriteFile();
        }

        private void btnCamerasHelicopter_Click(object sender, EventArgs e)
        {
            clearAllCameras();
            btnCamerasHelicopter.BackColor = Color.Red;
            WriteFile();
        }

        private void btnCamerasCar_Click(object sender, EventArgs e)
        {
            clearAllCameras();
            btnCamerasCar.BackColor = Color.Red;
            WriteFile();
        }

        private void btnCamerasRandom_Click(object sender, EventArgs e)
        {
            clearAllCameras();
            btnCamerasRandom.BackColor = Color.Red;
            WriteFile();
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
            enableSelectionChangedFunc = false;
            btnEnableWrite.BackColor = btnEnableWrite.BackColor == Color.Black ? Color.Gray : Color.Black;
            LoadDataToGrid();
            WriteFile();
            enableSelectionChangedFunc = true;
        }

        private void WriteFile()
        {
            sendCounter++;
            string selectID = nowSelectID();
            string info = $"{selectID}|{nowSelectedCamera()}|{shotcounter}|{sendCounter}";
#if DEBUG
            Console.WriteLine("[O] " + info);
#endif
            try
            {
                File.WriteAllText(saveDataFile, info);
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(ex.ToString());
#endif
            }

            //enableSelectionChangedFunc = false;
            //LoadDataToGrid();
            //selectIDrow(selectID);
            //enableSelectionChangedFunc = true;
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

        private void UpdateResizeButtonPosition()
        {
            bool isVerticalScrollbarVisible = false;
            foreach (Control ctrl in dataGridView1.Controls)
            {
                if (ctrl is VScrollBar vScroll && vScroll.Visible)
                {
                    isVerticalScrollbarVisible = true;
                    break;
                }
            }
            if (isVerticalScrollbarVisible)
            {
                resizeButton.Width = dataGridView1.Width;
            }
            else
            {
                resizeButton.Width = dataGridView1.Width - SystemInformation.VerticalScrollBarWidth;
            }
            resizeButton.Location = new Point(
                resizeButton.Location.X,
                dataGridView1.Bottom - resizeButton.Height
            );
        }

        private void resizeButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                resizeButton.BackColor = Color.Yellow;
                isResizing = true;
                lastMousePosition = MousePosition;
            }
        }

        private void resizeButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizing)
            {
                resizeButton.BackColor = Color.Yellow;
                Point currentPosition = MousePosition;
                //int dx = currentPosition.X - lastMousePosition.X;
                int dy = currentPosition.Y - lastMousePosition.Y;
                //this.Width += dx;
                int newH = this.Height + dy;
                if (newH <= autoResizeGridView(0, 0, false).Height + gridViewHeightCompensation && newH >= this.MinimumSize.Height)
                {
                    this.Height = newH;
                    lastMousePosition = currentPosition;
                }
            }
            else
            {
                resizeButton.BackColor = Color.White;
            }
        }

        private void resizeButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                resizeButton.BackColor = Color.Gray;
                isResizing = false;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            UpdateResizeButtonPosition();
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            UpdateResizeButtonPosition();
        }

        private void resizeButton_MouseLeave(object sender, EventArgs e)
        {
            resizeButton.BackColor = Color.Gray;
        }

        private void resizeButton_DoubleClick(object sender, EventArgs e)
        {
            var currentScreen = Screen.FromControl(this);
            int gridViewH = autoResizeGridView(0, 0, false).Height + gridViewHeightCompensation;
            int winH = currentScreen.Bounds.Height - 48;
            this.Top = currentScreen.Bounds.Top;
            if (gridViewH > winH)
            {
                this.Height = winH;
            }
            else
            {
                this.Height = gridViewH;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (enableSelectionChangedFunc)
            {
#if DEBUG
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    Console.WriteLine("[S] ID=" + selectedRow.Cells[3].Value?.ToString().Trim() + " : " + selectedRow.Cells[1].Value?.ToString().Trim());
                }
#endif
                shotcounter++;
                WriteFile();
            }
        }
    }
}
