using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
                     

        private void PolygonPaint_Click (object sender, RoutedEventArgs e)
        {
            double x = 0;
            double y = 0;
            try
            {
                PaintPanel.Children.Clear();
                var Points = PolygonPoint.Text.Split(';');

                Polygon polygon = new Polygon();

                foreach (var item in Points)
                {
                    var Point = item.Split(' ');
                    polygon.Points.Add(new Point(double.Parse(Point[0]), double.Parse(Point[1])));
                }

                polygon.Fill = Brushes.Aqua;
                polygon.Stroke = Brushes.Azure;
                PaintPanel.Children.Add(polygon);  
            }
            catch (Exception exc)
            {

                Log.Text += exc.ToString();

            }
        }

        private void CirclePaint_Click (object sender, RoutedEventArgs e)
        {
            try
            {
                Ellipse ellipse = new Ellipse();

                ellipse.Height = Convert.ToDouble(CircleRadius.Text);
                ellipse.Width = Convert.ToDouble(CircleRadius.Text);


                ellipse.Stroke = Brushes.Cyan;
                ellipse.Fill = Brushes.Crimson;
                PaintPanel.Children.Clear();
                PaintPanel.Children.Add(ellipse);

            }
            catch (Exception exc)
            {

            }
        }
    }
}
