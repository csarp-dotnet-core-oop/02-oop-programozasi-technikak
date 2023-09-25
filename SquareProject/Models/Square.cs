using System.Drawing;

namespace SquareProject.Models
{
    public class Square
    {
        private double _side;
        public double Side
        {
            get => _side; 
            set => _side = value;
        }

        public Square(double side)
        {
            _side = side;
        }

        public double Perimeter
        {
            get => 4 * _side;
        }

        public double Area
        {
            get => _side * _side;
        }
    }
}
