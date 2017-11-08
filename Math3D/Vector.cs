using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    public class Vector
    {
        protected double[] V { get; private set; }

        public Vector(params double[] v)
        {
            V = new double[v.Length];
            Array.Copy(v, V, v.Length);
        }

        public Vector(Vector v) : this(v.V) { }

        public int Size { get => V.Length; }

        public double Magnitude {
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

        public double this[int key]
        {
            get => V[key]; set { V[key] = value; }
        }

        public static Vector operator +(Vector lhs, Vector rhs)
        {
            if (lhs.Size != rhs.Size)
            {
                throw new Exception("Unequal Vector dimensions");
            }
            double[] v = new double[lhs.Size];
            for (int i = 0; i < lhs.Size; i++)
            {
                v[i] = lhs[i] + rhs[i];
            }
            return new Vector(v);
        }

        public static Vector operator -(Vector lhs, Vector rhs)
        {
            if (lhs.Size != rhs.Size)
            {
                throw new Exception("Unequal Vector dimensions");
            }
            double[] v = new double[lhs.Size];
            for (int i = 0; i < lhs.Size; i++)
            {
                v[i] = lhs[i] - rhs[i];
            }
            return new Vector(v);
        }

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

        public override string ToString()
        {
            string s = $"Vector [{ Size }] {{ ";
            foreach (double d in V)
            {
                s += $"{d}, ";
            }
            return s;
        }
    }
}
