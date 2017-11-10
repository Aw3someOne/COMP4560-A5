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
    partial class RenderPanel: Panel
    {
        private Matrix _windowingMatrix;

        public World World { get; set; }
        public double ScaleFactor { get; set; }
        public bool IsPerspective { get; set; }
        public Vector CameraLocation { get; set; }
        public Vector CameraTarget { get; set; }
        private Matrix _orthographicMatrix;

        public RenderPanel()
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
            IsPerspective = false;
        }

        public void CalculateWindow()
        {
            ScaleFactor = ClientSize.Height / 2 / World.Shape.DeltaY;
            _orthographicMatrix = Matrix.OrthographicProjectionMatrix(
                new Vector(CameraLocation.X, CameraLocation.Y, CameraLocation.Z),
                new Vector(CameraTarget.X, CameraTarget.Y, CameraTarget.Z));
            Matrix scaleMatrix = Matrix.ScaleMatrix(ScaleFactor, ScaleFactor, ScaleFactor);
            Matrix centerMatrix = Matrix.TranslationMatrix(ClientSize.Width / 2, ClientSize.Height / 2, 0);
            _windowingMatrix = scaleMatrix * centerMatrix;
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
                Matrix points = new Matrix(World.Shape.Points);

                points.Transform(_orthographicMatrix);

                if (IsPerspective)
                {
                    Vector cam = new Vector(CameraLocation);
                    cam.Transform(_orthographicMatrix);
                    cam -= 25 * Vector.ZUnitVector;
                    Matrix p = Matrix.IdentityMatrix(4);
                    p[2, 3] = -1 / cam.Z;
                    for (int i = 0; i < points.Rows; i++)
                    {
                        Vector t = points[i].Homogenous * p;
                        double h = t[3];
                        t /= h;
                        points[i] = new Vector(t.X, t.Y, t.Z);
                    }
                }
                points.Transform(_windowingMatrix);

                foreach (Tuple<int, int> line in World.Shape.Lines)
                {
                    graphics.DrawLine(
                        pen,
                        (int)points[line.Item1].X,
                        ClientSize.Height - (int)points[line.Item1].Y,
                        (int)points[line.Item2].X,
                        ClientSize.Height - (int)points[line.Item2].Y);
                }
            }
        }
    }
}
