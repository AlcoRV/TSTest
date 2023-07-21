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
using TSTest.Tools;

namespace TSTest
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly GridShapeAdder _gridShapeAdder;

        public MainWindow()
        {
            InitializeComponent();
            _gridShapeAdder = new GridShapeAdder(MainGrid);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _gridShapeAdder.Add(CreateNewRandomShape());
        }

        private Shape CreateNewRandomShape()
        {
            Shape shape;
            if (new Random().Next(2) == 0)
            {
                shape = new Ellipse();
            } 
            else {
                shape = new Rectangle();
            }

            shape.Fill = CreateRundomSolidBrush();
            return shape;
        }

        private static SolidColorBrush CreateRundomSolidBrush()
        {
            var random = new Random();

            var color = new Color
            {
                R = (byte)random.Next(256),
                G = (byte)random.Next(256),
                B = (byte)random.Next(256),
                A = (byte)random.Next(256)
            };
            return new SolidColorBrush(color);
        }
    }
}
