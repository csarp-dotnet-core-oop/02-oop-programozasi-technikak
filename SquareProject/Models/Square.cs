namespace SquareProject.Models
{
    public class Square
    {
        private double _side;
        public double Side
        {
            get => _side;
        }

        public Square(double side)
        {
            _side = side;
        }
    }
}
