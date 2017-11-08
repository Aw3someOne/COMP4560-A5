using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    public partial class Matrix
    {
        public static Matrix ScaleMatrix(double sx, double sy, double sz)
            => new Matrix(new Vector[]
            {
                new Vector(sx, 0, 0, 0),
                new Vector(0, sy, 0, 0),
                new Vector(0, 0, sz, 0),
                new Vector(0, 0, 0, 1)
            });

        public static Matrix TranslationMatrix(double dx, double dy, double dz)
            => new Matrix(new Vector[]
            {
                new Vector(1, 0, 0, 0),
                new Vector(0, 1, 0, 0),
                new Vector(0, 0, 1, 0),
                new Vector(dx, dy, dz, 1)
            });

        public static Matrix RotationMatrixX(double rad)
        {
            double c = Math.Cos(rad);
            double s = Math.Sin(rad);
            return new Matrix(new Vector[]
            {
                new Vector(1, 0, 0, 0),
                new Vector(0, c, s, 0),
                new Vector(0, -s, c, 0),
                new Vector(0, 0, 0, 1),
            });
        }

        public static Matrix RotationMatrixY(double rad)
        {
            double c = Math.Cos(rad);
            double s = Math.Sin(rad);
            return new Matrix(new Vector[]
            {
                new Vector(c, 0, s, 0),
                new Vector(0, 1, 0, 0),
                new Vector(-s, 0, c, 0),
                new Vector(0, 0, 0, 1),
            });
        }

        public static Matrix RotationMatrixZ(double rad)
        {
            double c = Math.Cos(rad);
            double s = Math.Sin(rad);
            return new Matrix(new Vector[]
            {
                new Vector(c, s, 0, 0),
                new Vector(-s, c, 0, 0),
                new Vector(0, 0, 1, 0),
                new Vector(0, 0, 0, 1),
            });
        }

        public static Matrix Identity(int row)
        {
            Matrix m = new Matrix(row, row);
            for (int i = 0; i < row; i++)
            {
                m[i, i] = 1;
            }
            return m;
        }

        //public static Matrix ShearXWRTYMatrix()
        //{

        //}
    }
}
