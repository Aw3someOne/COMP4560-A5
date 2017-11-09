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
            if (World.Shape != null) {
                Graphics graphics = e.Graphics;
                graphics.Clear(Color.Black);
                Pen pen = new Pen(Color.White, 3);

                Matrix screen = new Matrix(World.Shape.Points);

                // windowing
                screen.Transform(_windowingMatrix);
                foreach (Tuple<int, int> line in World.Shape.Lines)
                {
                    graphics.DrawLine(
                        pen,
                        (int)screen[line.Item1].X,
                        Height - (int)screen[line.Item1].Y,
                        (int)screen[line.Item2].X,
                        Height - (int)screen[line.Item2].Y);
                }
            }
        }
    }
}
