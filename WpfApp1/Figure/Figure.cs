using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows;
using System.Windows.Media;

namespace First_lab
{
    [Serializable]
    public abstract class Figure
    {


        public Brushes Color { get; set; }
        public Point Point { get; set; }

        public abstract double Perimetr { get; }
        public abstract double Area { get; }

        public abstract void Write();
        public abstract void WriteToText();
        public abstract void ReadFromText();

        public string path = "Figure.txt";
        
        //XmlSerializer formatter = new XmlSerializer(typeof(Figure));

        public void WriteToXml()
        {
            XmlSerializer xml = new XmlSerializer(this.GetType());
            using (FileStream fs = new FileStream(this.GetType().Name + ".xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, this);
                Console.WriteLine("Объект сериализован");
            }
        }

    }
}
