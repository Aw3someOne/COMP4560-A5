using Assignment5.Model;
using Math3D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Gui : Form
    {
        public World World { get; }
        private Matrix _windowingMatrix;
        private double _scaleFactor;

        public Gui(World world)
        {
            InitializeComponent();
            World = world;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Text = "COMP 4560: Assignment 5";
            ResizeRedraw = true;
            ClientSize = new Size(1280, 1024);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _scaleFactor = ClientSize.Height / 2 / World.Shape.DeltaY;
            Vector m = World.Shape.Centroid;
            Matrix orthographicMatrix = Matrix.OrthographicProjectionMatrix(
                new Vector(m.X, m.Y, 1),
                new Vector(m.X, m.Y, 0));
            Matrix scaleMatrix = Matrix.ScaleMatrix(_scaleFactor, _scaleFactor, _scaleFactor);
            Matrix centerMatrix = Matrix.TranslationMatrix(ClientSize.Width / 2, ClientSize.Height / 2, 0);
            _windowingMatrix = orthographicMatrix * scaleMatrix * centerMatrix;
#if DEBUG
            //Console.WriteLine(orthographicMatrix);
            Console.WriteLine(_windowingMatrix);
            //Console.WriteLine($"Client Dimensions: { ClientSize.Width }, { ClientSize.Height }");
#endif
        }
    }
}
