using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCameraControl
{
    class WindowMove
    {
        private bool isMouseDown = false;
        private bool isDragging = false;
        private Point dragStartPoint = Point.Empty;
        private const int DragThreshold = 20;
        private Form mForm;

        public WindowMove(Form form)
        {
            mForm = form;
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                isDragging = false;
                dragStartPoint = e.Location;
            }
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouseDown) return;

            double distance = Math.Sqrt(Math.Pow(e.X - dragStartPoint.X, 2) + Math.Pow(e.Y - dragStartPoint.Y, 2));
            if (!isDragging && distance >= DragThreshold)
            {
                isDragging = true;
            }

            if (isDragging)
            {
                Point currentScreenPos = ((Control)sender).PointToScreen(e.Location);
                mForm.Location = new Point(
                    currentScreenPos.X - dragStartPoint.X,
                    currentScreenPos.Y - dragStartPoint.Y
                );
            }
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
                isDragging = false;
            }
        }
    }
}
