using Assignment5.Model;
using Math3D;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    static class Program
    {
        public static World World { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            World = new World();
            World.Shape = new Shape("C:/Users/aw3someone/source/repos/4560/Assignment5/Assignment5/Data/Qpoints3D.200810.dat", "C:/Users/aw3someone/source/repos/4560/Assignment5/Assignment5/Data/Qlines3D.200810.dat");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gui(World));
            /*
            Vector n = new Vector(new double[] { -28, -40, -5 });
            Vector nUnit = n.Unit;
            Console.WriteLine($"unit vector n: { nUnit}");
            Vector z = new Vector(new double[] { 0, 0, 1 });
            Vector v = z - (Vector.Dot(z, nUnit) * nUnit);
            Vector vUnit = v.Unit;
            Console.WriteLine($"unit vector v: { vUnit }");
            Vector uUnit = Vector.Cross(nUnit, vUnit);
            Console.WriteLine($"unit vector u: { uUnit }");
            A3();
            */
        }
        private static void A3()
        {
            Matrix q2 = new Matrix(
                new Vector[]
                {
                    new Vector(200, 600, 0),
                    new Vector(200, 100, 0),
                    new Vector(400, 100, 0),
                    new Vector(400, 250, 0),
                    new Vector(700, 250, 0),
                    new Vector(700, 350, 0),
                    new Vector(400, 350, 0),
                    new Vector(400, 600, 0),
                });
            Matrix[] t2 = new Matrix[]
            {
                Matrix.TranslationMatrix(-200, -100, 0),
                Matrix.ScaleMatrix(1.6, 0.5, 1),
                Matrix.TranslationMatrix(200, 100, 0),
            };
            q2.Transform(t2);
            Console.WriteLine(q2);
        }
    }
}
