using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    class Vector3 : Vector
    {
        public double X { get => this[0]; set { this[0] = value; } }
        public double Y { get => this[1]; set { this[1] = value; } }
        public double Z { get => this[2]; set { this[2] = value; } }

        public Vector3(double x, double y, double z) : base(x, y, z) { }
        public Vector3(Vector3 v) : base(v.V) { }

        public static Vector Cross(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(
                lhs.Y * rhs.Z - lhs.Z * rhs.Y,
                lhs.Z * rhs.X - lhs.X * rhs.Z,
                lhs.X * rhs.Y - lhs.Y * rhs.X);
        }
    }
}
