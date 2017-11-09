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
        private const int tranV = 35;
        private const int tranH = 75;
        private const double scaleup = 1.1;
        private const double scaledown = 0.9;
        private const double rot = 0.05;
        private const double shear = 0.1;

        public Gui(World world)
        {
            InitializeComponent();
            World = world;
            renderPanel1.World = World;
            renderPanel1.Dock = DockStyle.Fill;

#if DEBUG
            World.Shape = new Shape("C:/Users/aw3someone/source/repos/4560/Assignment5-WinForms/Assignment5/Data/Qpoints3D.200810.dat", "C:/Users/aw3someone/source/repos/4560/Assignment5-WinForms/Assignment5/Data/Qlines3D.200810.dat");
            renderPanel1.CalculateWindow();
#endif

            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Text = "COMP 4560: Assignment 5";
            ResizeRedraw = true;
            //ClientSize = new Size(1280, 1024);
            AutoSizeMode = AutoSizeMode.GrowAndShrink;

            openToolStripMenuItem.Click += new EventHandler(MenuItemFileOpen_Click);
            exitToolStripMenuItem.Click += new EventHandler(MenuItemFileExit_Click);

            upToolStripMenuItem.Click += new EventHandler(MenuItemTranslateUp_Click);
            downToolStripMenuItem.Click += new EventHandler(MenuItemTranslateDown_Click);
            leftToolStripMenuItem.Click += new EventHandler(MenuItemTranslateLeft_Click);
            rightToolStripMenuItem.Click += new EventHandler(MenuItemTranslateRight_Click);
            scaleUpToolStripMenuItem.Click += new EventHandler(MenuItemScaleUp_Click);
            scaleDownToolStripMenuItem.Click += new EventHandler(MenuItemScaleDown_Click);
            rotXToolStripMenuItem.Click += new EventHandler(MenuItemRotateX_Click);
            rotYToolStripMenuItem.Click += new EventHandler(MenuItemRotateY_Click);
            rotZToolStripMenuItem.Click += new EventHandler(MenuItemRotateZ_Click);
            resetToolStripMenuItem.Click += new EventHandler(MenuItemReset_Click);
            shearRightToolStripMenuItem.Click += new EventHandler(MenuItemShearRight_Click);
            shearLeftToolStripMenuItem.Click += new EventHandler(MenuItemShearLeft_Click);
        }

        private void MenuItemFileOpen_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openPointsDialog = new OpenFileDialog();
            openPointsDialog.Title = "Open Points file";
            openPointsDialog.Filter = "Data Files (*.DAT)|*.DAT|" + "All files (*.*)|*.*";

            OpenFileDialog openLinesDialog = new OpenFileDialog();
            openLinesDialog.Title = "Open Lines file";
            openLinesDialog.Filter = "Data Files (*.DAT)|*.DAT|" + "All files (*.*)|*.*";

            if (openPointsDialog.ShowDialog() == DialogResult.OK && openLinesDialog.ShowDialog() == DialogResult.OK)
            {
                World.Shape = new Shape(openPointsDialog.FileName, openLinesDialog.FileName);
                renderPanel1.CalculateWindow();
                renderPanel1.Invalidate();                
            }
        }
        private void MenuItemFileExit_Click(object sender, EventArgs e) => Application.Exit();

        private void MenuItemTranslateUp_Click(object sender, EventArgs e)
        {
            World.Shape.Transform(Matrix.TranslationMatrix(0, tranV / renderPanel1.ScaleFactor, 0));
            renderPanel1.Invalidate();
        }

        private void MenuItemTranslateDown_Click(object sender, EventArgs e)
        {
            World.Shape.Transform(Matrix.TranslationMatrix(0, -tranV / renderPanel1.ScaleFactor, 0));
            renderPanel1.Invalidate();
        }

        private void MenuItemTranslateLeft_Click(object sender, EventArgs e)
        {
            World.Shape.Transform(Matrix.TranslationMatrix(-tranH / renderPanel1.ScaleFactor, 0, 0));
            renderPanel1.Invalidate();
        }
        private void MenuItemTranslateRight_Click(object sender, EventArgs e)
        {
            World.Shape.Transform(Matrix.TranslationMatrix(tranH / renderPanel1.ScaleFactor, 0, 0));
            renderPanel1.Invalidate();
        }
        private void MenuItemScaleUp_Click(object sender, EventArgs e)
        {
            World.Shape.TransformAboutPoint(
                World.Shape.Centroid,
                Matrix.ScaleMatrix(scaleup, scaleup, scaleup));
            renderPanel1.Invalidate();
        }
        private void MenuItemScaleDown_Click(object sender, EventArgs e)
        {
            World.Shape.TransformAboutPoint(
                World.Shape.Centroid,
                Matrix.ScaleMatrix(scaledown, scaledown, scaledown));
            renderPanel1.Invalidate();
        }
        private void MenuItemRotateX_Click(object sender, EventArgs e)
        {
            World.Shape.TransformAboutPoint(
                World.Shape.Centroid,
                Matrix.RotationMatrixX(rot));
            renderPanel1.Invalidate();
        }
        private void MenuItemRotateY_Click(object sender, EventArgs e)
        {
            World.Shape.TransformAboutPoint(
                World.Shape.Centroid,
                Matrix.RotationMatrixY(rot));
            renderPanel1.Invalidate();
        }
        private void MenuItemRotateZ_Click(object sender, EventArgs e)
        {
            World.Shape.TransformAboutPoint(
                World.Shape.Centroid,
                Matrix.RotationMatrixZ(rot));
            renderPanel1.Invalidate();
        }
        private void MenuItemReset_Click(object sender, EventArgs e)
        {
            World.Shape.Reset();
            renderPanel1.Invalidate();
        }
        private void MenuItemShearRight_Click(object sender, EventArgs e)
        {
            Vector c = World.Shape.Centroid;
            double min = World.Shape.MinY;
            World.Shape.TransformAboutPoint(
                new Vector(c.X, min, c.Z),
                Matrix.ShearXWRTYMatrix(shear));
            renderPanel1.Invalidate();
        }
        private void MenuItemShearLeft_Click(object sender, EventArgs e)
        {
            Vector c = World.Shape.Centroid;
            double min = World.Shape.MinY;
            World.Shape.TransformAboutPoint(
                new Vector(c.X, min, c.Z),
                Matrix.ShearXWRTYMatrix(-shear));
            renderPanel1.Invalidate();
        }
    }
}
