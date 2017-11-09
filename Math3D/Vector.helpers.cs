using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    public partial class Vector
    {
        public static Vector XUnitVector { get => new Vector(1, 0, 0); }
        public static Vector YUnitVector { get => new Vector(0, 1, 0); }
        public static Vector ZUnitVector { get => new Vector(0, 0, 1); }
    }
}
