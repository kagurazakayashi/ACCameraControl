using System.Security.Cryptography;
using System.Windows.Forms;

namespace ACCameraControl
{
    public partial class Form1 : Form
    {
        private string gameDataOutFile = "dataout.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(gameDataOutFile))
            {
                openFileDialog1.Title = $"�Ҳ����ļ� {gameDataOutFile} , ���ֶ�ָ��һ����";
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
            listBox1.Items.Clear();
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
                    if (MessageBox.Show($"��Ϸ��������д���\r\n��Ҫ������: {mustCount}\r\n���������: {valuesCount}", "���ݴ���", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
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
                string[] sInfos = [dPos, dName, dStatus, dID, dSpeed, dTyres];
                listBox1.Items.Add(string.Join("  |  ", sInfos));
            }
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
    }
}
