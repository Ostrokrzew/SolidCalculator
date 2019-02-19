using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidCalculator
{
    public static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static double Cuboid(double a, double b, double h)
        {
            double volumeCuboid = a * b * h;
            return volumeCuboid;
        }
        public static double Cylinder(double r, double h)
        {
            double volumeCylinder = Math.PI * Math.Pow(r,2) * h;
            return volumeCylinder;
        }
        public static double Cone(double r, double h)
        {
            double volumeCone = (Math.PI * Math.Pow(r, 2) * h) / 3;
            return volumeCone;
        }
        public static double Sphere( double r)
        {
            double volumeSphere = (Math.PI * Math.Pow(r, 3)) * 4 / 3;
            return volumeSphere;
        }
    }
}
