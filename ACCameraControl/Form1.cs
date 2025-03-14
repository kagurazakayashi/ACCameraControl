using System.Security.Cryptography;
using System.Windows.Forms;

namespace ACCameraControl
{
    public partial class Form1 : Form
    {
        private string gameDataOutFile = "dataout.txt";
        private WindowMove winMv;

        public Form1()
        {
            InitializeComponent();
            winMv = new WindowMove(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].ValueType = typeof(int);
            if (!File.Exists(gameDataOutFile))
            {
                openFileDialog1.Title = $"找不到文件 {gameDataOutFile} , 请手动指定一个。";
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
                    if (MessageBox.Show($"游戏输出数据有错误。\r\n需要数据量: {mustCount}\r\n获得数据量: {valuesCount}", "数据错误", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
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
            dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            autoResizeGridView();
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

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            winMv.MouseDown(sender, e);
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            winMv.MouseMove(sender, e);
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            winMv.MouseUp(sender, e);
        }
    }
}
