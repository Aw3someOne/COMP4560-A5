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
            World.Shape = new Shape("C:/Users/aw3someone/source/repos/4560/Assignment5-WinForms/Assignment5/Data/Qpoints3D.200810.dat", "C:/Users/aw3someone/source/repos/4560/Assignment5-WinForms/Assignment5/Data/Qlines3D.200810.dat");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gui(World));
        }
    }
}
