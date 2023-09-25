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
            if (side <= 0)
                throw new SqueraSideCannotBeNagativOrZero(side + " oldalú négyzet nincs. A négyzetet nem jön létre.");
            else
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

        public override string ToString()
        {
            return $"{Side} méter a négyzet oldala.\nKerülete {Area}.\nTerülete {Area}.";
        }
    }
}
