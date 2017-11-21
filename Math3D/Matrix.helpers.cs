using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    // Contains static helper functions
    public partial class Matrix
    {
        // returns a scaling matrix
        public static Matrix ScaleMatrix(double sx, double sy, double sz)
            => new Matrix(
                new Vector(sx, 0, 0, 0),
                new Vector(0, sy, 0, 0),
                new Vector(0, 0, sz, 0),
                new Vector(0, 0, 0, 1));

        public static Matrix TranslationMatrix(Vector v) => TranslationMatrix(v.X, v.Y, v.Z);

        // returns a translation matrix
        public static Matrix TranslationMatrix(double dx, double dy, double dz)
            => new Matrix(
                new Vector(1, 0, 0, 0),
                new Vector(0, 1, 0, 0),
                new Vector(0, 0, 1, 0),
                new Vector(dx, dy, dz, 1));

        // returns a rotation matrix about the x-axis, from +y to +z
        public static Matrix RotationMatrixX(double rad)
        {
            double c = Math.Cos(rad);
            double s = Math.Sin(rad);
            return new Matrix(
                new Vector(1, 0, 0, 0),
                new Vector(0, c, s, 0),
                new Vector(0, -s, c, 0),
                new Vector(0, 0, 0, 1));
        }

        // returns a rotation matrix about the y-axis, from +x to +z
        public static Matrix RotationMatrixY(double rad)
        {
            double c = Math.Cos(rad);
            double s = Math.Sin(rad);
            return new Matrix(
                new Vector(c, 0, s, 0),
                new Vector(0, 1, 0, 0),
                new Vector(-s, 0, c, 0),
                new Vector(0, 0, 0, 1));
        }

        // returns a rotation matrix about the z-axis, from +x to +y
        public static Matrix RotationMatrixZ(double rad)
        {
            double c = Math.Cos(rad);
            double s = Math.Sin(rad);
            return new Matrix(
                new Vector(c, s, 0, 0),
                new Vector(-s, c, 0, 0),
                new Vector(0, 0, 1, 0),
                new Vector(0, 0, 0, 1));
        }

        // returns a shearing matrix x with respect to y
        public static Matrix ShearXWRTYMatrix(double ratio)
        {
            return new Matrix(
                new Vector(1, 0, 0, 0),
                new Vector(ratio, 1, 0, 0),
                new Vector(0, 0, 1, 0),
                new Vector(0, 0, 0, 1));
        }

        // returns an identity matrix row X row
        public static Matrix IdentityMatrix(int row)
        {
            Matrix m = new Matrix(row, row);
            for (int i = 0; i < row; i++)
            {
                m[i, i] = 1;
            }
            return m;
        }

        // returns a transformation matrix that is the orthographic matrix from p1 looking at p2
        public static Matrix OrthographicProjectionMatrix(Vector p1, Vector p2)
        {
            Vector n = (p2 - p1).Unit;
            Vector z = Vector.YUnitVector;
            Vector v = (z - (Vector.Dot(z, n) * n)).Unit;
            Vector u = Vector.Cross(n, v);
            Vector r = new Vector(p1);
            return new Matrix(
                new Vector(u.X, v.X, n.X, 0),
                new Vector(u.Y, v.Y, n.Y, 0),
                new Vector(u.Z, v.Z, n.Z, 0),
                new Vector(Vector.Dot(-r, u), Vector.Dot(-r, v), Vector.Dot(-r, n), 1));
        }
    }
}
