using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    public partial class Matrix
    {
        protected Vector[] M { get; private set; }
        public int Rows { get => M.Length; }
        public int Columns { get => M[0].Size; }

        public Matrix(int row)
        {
            M = new Vector[row];
        }

        public Matrix(int row, int col) : this(row)
        {
            for (int i = 0; i < row; i++)
            {
                M[i] = new Vector(size: col);
            }
        }

        public Matrix(params Vector[] v)
        {
            int c = v[0].Size;
            for (int i = 1; i < v.Length; i++)
            {
                if (v[i].Size != c)
                {
                    throw new Exception("Vectors are not the same size");
                }
            }
            M = new Vector[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                M[i] = new Vector(v[i]);
            }
        }

        /*
         * copy constructor
         */
        public Matrix(Matrix m)
        {
            M = new Vector[m.Rows];
            for (int i = 0; i < m.Rows; i++)
            {
                M[i] = new Vector(m[i]);
            }
        }

        // Transforms the matrix about a point p, by each of matrices in m by calculating tNet
        public void TransformAboutPoint(Vector p, params Matrix[] m)
        {
            Matrix tNet = Matrix.TranslationMatrix(-p);
            for (int i = 0; i < m.Length; i++)
            {
                tNet *= m[i];
            }
            tNet *= Matrix.TranslationMatrix(p);
            for (int i = 0; i < Rows; i++)
            {
                this[i].Transform(tNet);
            }
        }

        // Transforms the matrix by each of the matrices in m by calculating tNet
        public void Transform(params Matrix[] m)
        {
            Matrix tNet = new Matrix(m[0]);
            for (int i = 1; i < m.Length; i++)
            {
                tNet *= m[i];
            }
            for (int i = 0; i < Rows; i++)
            {
                this[i].Transform(tNet);
            }
        }

        public override string ToString()
        {
            string s = $"Matrix ({ Rows },{ Columns })";
            s += "[";
            foreach (Vector v in M)
            {
                s += $"\n{ v }";
            }
            s += "]";
            return s;
        }
    }
}
