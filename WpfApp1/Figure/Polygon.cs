using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Xml.Serialization;


namespace First_lab
{
    [Serializable]
    public class Polygon : Figure
    {
        private PointCollection points;



        public PointCollection Points { get => points; set => points = value; }

        public Polygon (PointCollection points)
        {          
  
        }

        public Polygon ()
        {
        }






        /// <summary>
        /// 
        /// </summary>
        public override double Area
        {
            get
            {
                double Square = 0;
                for (int i = 0; i < Points.Count - 1; i++)
                {
                    Square += (Points[i].X + Points[i + 1].X) * (Points[i].Y - Points[i + 1].Y);
                }
                return 0.5 * Math.Abs(Square);
            }
        }

        public override double Perimetr
        {
            get
            {
                var line = new List<double> { };
                for (int i = 0; i < Points.Count - 1; i++)
                {
                    line.Add(Math.Sqrt(
                        Math.Pow(Points[i + 1].X - Points[i].X, 2)
                      + Math.Pow(Points[i + 1].X - Points[i].Y, 2)));
                }
                double s = 0;
                foreach (var item in line)
                {
                    s += item;
                }
                return s;
            }
        }

       

        public override void Write ()
        {
            throw new NotImplementedException();
        }

        public override void WriteToText ()
        {
            throw new NotImplementedException();
        }

        public override void ReadFromText ()
        {
            throw new NotImplementedException();
        }
    }
}
