using System;
using System.Collections.Generic;
using System.Text;

namespace _02_01_setter_newfile.Model
{
    /// <summary>
    /// S1.02 Sqare osztály a model rétegben és a Square.cs állományban.
    ///       Figyeljük meg, hogy a namespace most "_04SquareProject.model" lett.
    /// </summary>
    class Square
    {
        /// <summary>
        /// S1.03 A négyzet oldala.
        /// </summary>
        private double _side;

        /// <summary>
        /// S1.04 Négyzetet oldalával létrehozó konstruktor.
        /// </summary>
        /// <param name="side">A négyzet oldala.</param>
        public Square(double side)
        {
            this._side = side;
        }
        /// <summary>
        /// S1.05 Side tulajdonság get metódussal.
        /// S1.06 Side tulajdonság set  metódussal.
        ///       A négyzet oldalát leolvasni (get) és módosítani is lehet (set).
        /// </summary>
        public double Side
        {
            get { return _side; }
            set { _side = value; }
        }
        /// <summary>
        /// S1.07 A négyzet kerület tulajdonsága. Csak olvasható.
        /// </summary>
        public double District
        {
            get
            {
                double district = 4 * _side;
                return district;
            }
        }
        /// <summary>
        /// S1.08 A négyzet terület tulajdonsága. Csak olvasható.
        /// </summary>
        public double Area
        {
            get
            {
                double area = _side * _side;
                return area;
            }
        }
        /// <summary>
        /// S1.09 A négyzet adatait ilyen szövegként jelenítjük meg.
        /// </summary>
        /// <returns>A négyzet odlala és a hozzá tartozó szöveg.</returns>
        public override string ToString()
        {
            return _side + " méter a négyzet oldala.";
        }
    }
}
