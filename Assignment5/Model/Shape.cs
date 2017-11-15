using Assignment5.Data;
using Math3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Model
{
    public class Shape
    {
        public Matrix Points { get; set; }
        public Tuple<int, int>[] Lines { get; set; }
        //public Vector Centroid { get => new Vector(MidX, MidY, MidZ); }
        public Vector Centroid { get => Points[0]; }
        public double DeltaX { get => Delta(0); }
        public double DeltaY { get => Delta(1); }
        public double DeltaZ { get => Delta(2); }
        public double MinX { get => Min(0); }
        public double MinY { get => Min(1); }
        public double MinZ { get => Min(2); }
        public double MaxX { get => Max(0); }
        public double MaxY { get => Max(1); }
        public double MaxZ { get => Max(2); }
        public double MidX { get => Mid(0); }
        public double MidY { get => Mid(1); }
        public double MidZ { get => Mid(2); }

        private Matrix SavedPoints;

        public Shape(string pointPath, string linePath)
        {
            Points = Parser.GetPointsFromFile(pointPath);
            SavedPoints = new Matrix(Points);
            Lines = Parser.GetLinesFromFile(linePath);
        }

        public void Reset()
        {
            Points = new Matrix(SavedPoints);
        }

        public void Transform(params Matrix[] m) => Points.Transform(m);
        public void TransformAboutPoint(Vector p, params Matrix[] m) => Points.TransformAboutPoint(p, m);

        private double Delta(int index)
        {
            double max = Points[0, index];
            double min = Points[0, index];
            for (int i = 1; i < Points.Rows; i++)
            {
                double x = Points[i, index];
                if (x > max)
                {
                    max = x;
                }
                else if (x < min)
                {
                    min = x;
                }
            }
            return max - min;
        }

        private double Mid(int index)
        {
            double max = Points[0, index];
            double min = Points[0, index];
            for (int i = 1; i < Points.Rows; i++)
            {
                double x = Points[i, index];
                if (x > max)
                {
                    max = x;
                }
                else if (x < min)
                {
                    min = x;
                }
            }
            return (max + min) / 2;
        }

        private double Max(int index)
        {
            double max = Points[0, index];
            for (int i = 1; i < Points.Rows; i++)
            {
                double x = Points[i, index];
                if (x > max)
                {
                    max = x;
                }
            }
            return max;
        }

        private double Min(int index)
        {
            double min = Points[0, index];
            for (int i = 1; i < Points.Rows; i++)
            {
                double x = Points[i, index];
                if (x < min)
                {
                    min = x;
                }
            }
            return min;
        }
    }
}
