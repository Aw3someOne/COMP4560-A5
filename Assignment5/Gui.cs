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

        public Gui(World world)
        {
            InitializeComponent();
            World = world;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Text = "COMP 4560: Assignment 5";
            ResizeRedraw = true;
            ClientSize = new Size(800, 600);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            double scaleFactor = Height / 2 / World.Shape.DeltaY;
            Matrix scaleMatrix = Matrix.ScaleMatrix(scaleFactor, scaleFactor, scaleFactor);
            double offsetX = Width / 2 - scaleFactor *  World.Shape.MidX;
            double offsetY = Height / 2 - scaleFactor * World.Shape.MidY;
            Matrix offsetMatrix = Matrix.TranslationMatrix(offsetX, offsetY, 0);
            _windowingMatrix = scaleMatrix * offsetMatrix;
        }
    }
}
