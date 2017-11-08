using Assignment5.Model;
using Math3D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    partial class Gui
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.White, 3);

            Matrix screen = World.Shape.Points * Matrix.Identity(4);
            foreach (Tuple<int, int> line in World.Shape.Lines)
            {
                graphics.DrawLine(
                    pen,
                    (int)screen[line.Item1].X,
                    (int)screen[line.Item1].Y,
                    (int)screen[line.Item2].X,
                    (int)screen[line.Item2].Y);
            }
        }
    }
}
