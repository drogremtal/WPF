using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Media;

namespace First_lab
{
    public class Triangle : Figure
    {
        private const int Id = 1;

        public new PointCollection Points { get; set; }

        public Triangle()
        {
        }

        public override double Area => 0.5 * Math.Abs(((Points[2].X - Points[1].X) * (Points[3].Y - Points[1].Y)) - (Points[3].X - Points[1].X) * (Points[2].Y - Points[1].Y));

        public override void Write()
        {
            Console.WriteLine("Triangle: " +
                "x1={0}, y1={1}," +
                "x2={2}, y2={3}," +
                "x3={4}, y3={5}", Points[1].X, Points[1].Y, Points[2].X, Points[2].Y, Points[3].X, Points[3].Y);
        }

        public override double Perimetr => throw new NotImplementedException();

        public override void WriteToText()
        {
            StreamWriter stream = new StreamWriter(path, true, System.Text.Encoding.Default);
            stream.WriteLine("Triangle: " +
                "x1={0}, y1={1} " +
                "x2={2}, y2={3} " +
                "x3={4}, y3={5};", Points[1].X, Points[1].Y, Points[2].X, Points[2].Y, Points[3].X, Points[3].Y);
            stream.Close();
        }

        public override void ReadFromText()
        {

        }
    }
}
