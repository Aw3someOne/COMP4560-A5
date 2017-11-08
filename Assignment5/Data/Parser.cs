using Assignment5.Model;
using Math3D;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5.Data
{
    public class Parser
    {
        public static Matrix GetPointsFromFile(string path)
        {
            string[] lines = File.ReadLines(path).ToArray();
            List<Vector> points = new List<Vector>();
            foreach (string line in lines)
            {
                string[] l = line.Split(',', ' '); // comma or space
                try
                {
                    points.Add(new Vector(
                        Double.Parse(l[0]),
                        Double.Parse(l[1]),
                        Double.Parse(l[2])));
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine("REEEEEEEEEEEEEEEEEEEEEEEEE");
                }
            }
            return new Matrix(points.ToArray());
        }
    }
}
