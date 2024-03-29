﻿using Assignment5.Model;
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
    partial class RenderPanel: Panel
    {
        private Matrix _windowingMatrix;

        public World World { get; set; }
        public double ScaleFactor { get; set; }

        public RenderPanel()
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
        }

        public void CalculateWindow()
        {
            ScaleFactor = ClientSize.Height / 2 / World.Shape.DeltaY;
            Vector m = World.Shape.Centroid;
            Matrix orthographicMatrix = Matrix.OrthographicProjectionMatrix(
                new Vector(m.X, m.Y, 1),
                new Vector(m.X, m.Y, 0));
            Matrix scaleMatrix = Matrix.ScaleMatrix(ScaleFactor, ScaleFactor, ScaleFactor);
            Matrix centerMatrix = Matrix.TranslationMatrix(ClientSize.Width / 2, ClientSize.Height / 2, 0);
            _windowingMatrix = orthographicMatrix * scaleMatrix * centerMatrix;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.Clear(Color.Black);
            if (World != null && World.Shape != null) {
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen pen = new Pen(Color.White, 3);

                Matrix screen = new Matrix(World.Shape.Points);

#if DEBUG
                // Draw Axes
                Pen red = new Pen(Color.Red, 3);
                Pen green = new Pen(Color.Green, 3);
                Pen blue = new Pen(Color.Blue, 3);
                Matrix xax = new Matrix(new Vector[] { new Vector(-100, 0, 0), new Vector(100, 0, 0) });
                Matrix yax = new Matrix(new Vector[] { new Vector(0, -100, 0), new Vector(0, 100, 0) });
                Matrix zax = new Matrix(new Vector[] { new Vector(0, 0, -100), new Vector(0, 0, 100) });
                xax.Transform(_windowingMatrix);
                yax.Transform(_windowingMatrix);
                graphics.DrawLine(red, (int)xax[0].X, ClientSize.Height - (int)xax[0].Y, (int)xax[1].X, ClientSize.Height - (int)xax[1].Y);
                graphics.DrawLine(green, (int)yax[0].X, ClientSize.Height - (int)yax[0].Y, (int)yax[1].X, ClientSize.Height - (int)yax[1].Y);
                graphics.DrawLine(green, (int)zax[0].X, ClientSize.Height - (int)zax[0].Y, (int)zax[1].X, ClientSize.Height - (int)zax[1].Y);
#endif

                // windowing
                screen.Transform(_windowingMatrix);
                foreach (Tuple<int, int> line in World.Shape.Lines)
                {
                    graphics.DrawLine(
                        pen,
                        (int)screen[line.Item1].X,
                        ClientSize.Height - (int)screen[line.Item1].Y,
                        (int)screen[line.Item2].X,
                        ClientSize.Height - (int)screen[line.Item2].Y);
                }
            }
        }
    }
}
