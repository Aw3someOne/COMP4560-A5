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
                    //Console.Error.WriteLine($"REEEEEEEEEEEEEEEEEEEEEEEEE { e }");
                    Console.Error.WriteLine("String not correct Point format");
                }
            }
            points.Add(new Vector(0, 0, 0));
            return new Matrix(points.ToArray());
        }

        public static Tuple<int, int>[] GetLinesFromFile(string path)
        {
            string[] lines = File.ReadLines(path).ToArray();
            List<Tuple<int, int>> linesList = new List<Tuple<int, int>>();
            foreach (string line in lines)
            {
                string[] l = line.Split(',', ' '); // comma or space
                try
                {
                    linesList.Add(new Tuple<int, int>(int.Parse(l[0]), int.Parse(l[1])));
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine("String not correct Line format");
                    //Console.Error.WriteLine(e);
                }
            }
            return linesList.ToArray();
        }
    }
}
