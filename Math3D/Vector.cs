using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    public partial class Vector
    {
        public int Size { get => V.Length; }
        public double Magnitude
        {
            get
            {
                double sumsquare = 0;
                for (int i = 0; i < V.Length; i++)
                {
                    sumsquare += V[i] * V[i];
                }
                return Math.Sqrt(sumsquare);
            }
        }
        public Vector Unit { get => this / Magnitude; }
        public Vector Homogenous
        {
            get
            {
                double[] v = new double[Size + 1];
                Array.Copy(V, v, Size);
                v[Size] = 1;
                return new Vector(v);
            }
        }
        public double X { get => this[0]; set { this[0] = value; } }
        public double Y { get => this[1]; set { this[1] = value; } }
        public double Z { get => this[2]; set { this[2] = value; } }

        protected double[] V { get; private set; }

        public Vector(params double[] v)
        {
            V = new double[v.Length];
            Array.Copy(v, V, v.Length);
        }

        public Vector(int size)
        {
            V = new double[size];
        }

        public Vector(Vector v) : this(v.V) { }

        // Transforms the vector by matrix m
        public void Transform(Matrix m)
        {
            Vector v = Homogenous;
            v *= m;
            Array.Copy(v.V, V, Size);
        }

        public void Translate(int dx, int dy, int dz)
        {
            Transform(Matrix.TranslationMatrix(dx, dy, dz));
        }

        // Dot product
        public static double Dot(Vector lhs, Vector rhs)
        {
            if (lhs.Size != rhs.Size)
            {
                throw new Exception("Unequal Vector dimensions");
            }
            double sumproduct = 0;
            for (int i = 0; i < lhs.Size; i++)
            {
                 sumproduct += lhs[i] * rhs[i];
            }
            return sumproduct;
        }

        // Cross product
        public static Vector Cross(Vector lhs, Vector rhs)
        {
            if (!(lhs.Size == 3 && rhs.Size == 3))
            {
                throw new Exception("Can only take cross product in 3D");
            }
            return new Vector(new double[]
            {
                lhs[1] * rhs[2] - lhs[2] * rhs[1],
                lhs[2] * rhs[0] - lhs[0] * rhs[2],
                lhs[0] * rhs[1] - lhs[1] * rhs[0]});
        }

        public override string ToString()
        {
            string s = $"Vector ({ Size }) [ ";
            foreach (double d in V)
            {
                s += $"{d}, ";
            }
            s += "]";
            return s;
        }
    }
}
