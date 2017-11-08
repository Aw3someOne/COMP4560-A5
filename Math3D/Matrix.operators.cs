using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    public partial class Matrix
    {
        public static Vector operator *(Vector v, Matrix m)
        {
            if (v.Size != m.Rows)
            {
                throw new Exception("Cannot multiply due to dimensions");
            }
            Vector r = new Vector(size: m.Columns);
            for (int col = 0; col < m.Columns; col++)
            {
                r[col] = 0;
                for (int i = 0; i < v.Size; i++)
                {
                    r[col] += v[i] * m[i, col];
                }
            }
            return r;
        }

        /*
         * Matrix multiplication. Note: m1 * m2 DOES NOT EQUAL m2 * m1, and might not even be possible
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
                r[row] = lhs[row] * rhs;
                //for (int col = 0; col < rhs.Columns; col++)
                //{
                //    r[row, col] = 0;
                //    for (int i = 0; i < lhs.Columns; i++)
                //    {
                //        r[row, col] += lhs[row, i] * rhs[i, col];
                //    }
                //}
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
    }
}
