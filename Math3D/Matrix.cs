using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    class Matrix
    {
        protected double[,] M { get; private set; }
        public double this[int row, int col] { get => M[row, col]; set { M[row, col] = value; } }
        public int Rows { get => M.GetLength(0); }
        public int Columns { get => M.GetLength(1); }

        public Matrix(int row, int col)
        {
            Init(row, col);
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
            Init(v.Length, v[0].Size);
            for (int row = 0; row < v.Length; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    M[row, col] = v[row][col];
                }
            }
        }

        public Matrix(Matrix m)
        {
            M = new double[m.Rows, m.Columns];
            Array.Copy(m.M, M, m.Rows * m.Columns);
        }

        /*
         * Matrix multiplication
         */
        public static Matrix operator *(Matrix lhs, Matrix rhs)
        {
            if (lhs.Columns != rhs.Rows)
            {
                throw new Exception("Cannot multiply these two matrices due to dimensions");
            }
            Matrix r = new Matrix(lhs.Rows, rhs.Columns);
            for (int row = 0; row < lhs.Rows; row++)
            {
                for (int col = 0; col < rhs.Columns; col++)
                {
                    r[row, col] = 0;
                    for (int i = 0; i < lhs.Columns; i++)
                    {
                        r[row, col] += lhs[row, i] * rhs[i, col];
                    }
                }
            }
            return r;
        }

        /*
         * Multiple matrix by some constant c
         */
        public static Matrix operator *(Matrix m, double c)
        {
            Matrix r = new Matrix(m);
            for (int row = 0; row < m.Rows; row++)
            {
                for (int col = 0; col < m.Columns; col++)
                {
                    r[row, col] *= c;
                }
            }
            return r;
        }

        public static Matrix operator *(double c, Matrix m)
        {
            return m * c;
        }

        /*
         * Divide matrix by a constant c
         */
        public static Matrix operator /(Matrix m, double c)
        {
            return m * (1d / c);
        }

        private void Init(int row, int col)
        {
            M = new double[row, col];
        }
    }
}
