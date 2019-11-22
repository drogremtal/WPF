using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace First_lab
{
    public class Circle : Figure
    {
        private double R;

        public Circle ()
        {
        }

        public Circle (double r)
        {
            this.r = r;
        }

        public double r { get => R; set => R = value; }


        public override double Perimetr => 2 * Math.PI * R;
        public override double Area => Math.PI * Math.Pow(R, 2);

        public override void Write ()
        {

        }

        public override void WriteToText ()
        {

        }

        public override void ReadFromText ()
        {

        }
    }
}
