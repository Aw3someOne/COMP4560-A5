using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    public partial class Vector
    {
        public double this[int key] { get => V[key]; set { V[key] = value; } }

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

        public static Vector operator *(Vector v, double c)
        {
            Vector r = new Vector(v);
            for (int i = 0; i < r.Size; i++)
            {
                r[i] *= c;
            }
            return r;
        }

        public static Vector operator -(Vector lhs, Vector rhs) => lhs + -rhs;
        public static Vector operator *(double c, Vector v) => v * c;
        public static Vector operator /(Vector v, double c) => v * (1d / c);
        public static Vector operator -(Vector v) => v * -1;
    }
}
