using Assignment5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Gui : Form
    {
        public World World { get; }
        public Gui(World world)
        {
            World = world;
            InitializeComponent();
        }
    }
}
