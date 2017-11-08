using Math3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Model
{
    public class Shape
    {
        public Matrix Points { get; set; }
        public Tuple<int, int>[] Lines { get; set; }
    }
}
