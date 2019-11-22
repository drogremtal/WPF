using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using First_lab;
using System.Xml.Serialization;
using System.IO;

namespace Singleton
{
    class FigureFactory : Singleton<FigureFactory>
    {
        //private Dictionary<int, Figure> CallBackMap = new Dictionary<int, Figure> { };

        private static Dictionary<int, Figure> CallBackMap = new Dictionary<int, Figure> {
            {
                0,new Triangle(){}},
            {
                1,new Circle(){}},
            {
                2,new Polygon(){ }}
        };

        private FigureFactory()
        {

        }

        public Figure CreateFigure(int Id)
        {
            Figure figure;
            var find = CallBackMap.TryGetValue(Id, out figure);
            return figure;
        }

        public bool RegisterFigure(int id, Figure figure)
        {
            try
            {
                Logger.Instance.WriteLogErrorMsg(string.Format("Регистрация {0}", this.GetType().Name));
                CallBackMap.Add(id, figure);
                return true;
            }
            catch
            {
                Logger.Instance.WriteLogErrorMsg(string.Format("Ошибка при регистрация {0}", this.GetType().Name));
                return false;
            }

        }
        void UnregisterFigure() { }



        //private Figure CreateTriangle()
        //{
        //    return new Triangle()
        //    {
        //        Color = 1,
        //        Point1 = new Figure.Point(new Random(100).Next(), new Random(100).Next()),
        //        Point2 = new Figure.Point(new Random(100).Next(), new Random(100).Next()),
        //        Point3 = new Figure.Point(new Random(100).Next(), new Random(100).Next())
        //    };
        //}


        //private Figure CreateCircle()
        //{
        //    return new Circle()
        //    {
        //        Color = new Random(100).Next(),
        //        point = new Figure.Point(new Random(100).Next(), new Random(100).Next()),
        //        R = new Random(20).Next()
        //    };
        //}

        //private static Polygon CreatePolygon()
        //{

        //    return new Polygon()
        //    {
        //        Color = new Random(359).Next(),
        //        Points = Points
        //    };
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="polygon"> Сама фигура</param>
        public void WriteToXml(Figure figure)
        {
            XmlSerializer xml = new XmlSerializer(figure.GetType());
            using (FileStream fs = new FileStream(figure.GetType().Name + ".xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, figure);
                Console.WriteLine("Объект сериализован");
            }
        }
    }
}
