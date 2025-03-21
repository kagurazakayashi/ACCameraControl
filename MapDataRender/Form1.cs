using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MapDataRender
{
    public partial class Form1 : Form
    {
        private List<PointF> points = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadCsv(openFileDialog1.FileName);
                RedrawImage();
            }
        }

        private void LoadCsv(string path)
        {
            points.Clear();
            foreach (string line in File.ReadAllLines(path))
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 2 &&
                    float.TryParse(parts[0], out float x) &&
                    float.TryParse(parts[1], out float y))
                {
                    points.Add(new PointF(x, y));
                }
            }
        }

        private void RedrawImage()
        {
            if (points.Count < 2) return;

            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            if (width < 10 || height < 10) return;

            Bitmap bmp = new(width, height);
            using Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            float minX = float.MaxValue, maxX = float.MinValue;
            float minY = float.MaxValue, maxY = float.MinValue;
            foreach (var p in points)
            {
                if (p.X < minX) minX = p.X;
                if (p.X > maxX) maxX = p.X;
                if (p.Y < minY) minY = p.Y;
                if (p.Y > maxY) maxY = p.Y;
            }

            float margin = 40;
            float plotWidth = width - 2 * margin;
            float plotHeight = height - 2 * margin;
            float scaleX = plotWidth / (maxX - minX);
            float scaleY = plotHeight / (maxY - minY);

            PointF Transform(PointF p)
            {
                float tx = margin + (p.X - minX) * scaleX;
                float ty = margin + plotHeight - (p.Y - minY) * scaleY;
                return new PointF(tx, ty);
            }

            using Pen pen = new(Color.Blue, 2);
            for (int i = 1; i < points.Count; i++)
            {
                g.DrawLine(pen, Transform(points[i - 1]), Transform(points[i]));
            }

            pictureBox1.Image?.Dispose();
            pictureBox1.Image = bmp;
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            RedrawImage();
        }
    }
}
