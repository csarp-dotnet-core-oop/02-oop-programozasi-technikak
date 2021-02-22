using System;
using System.Collections.Generic;
using System.Text;

namespace _02_01_setter_newfile.model
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
        private double side;

        /// <summary>
        /// S1.04 Négyzetet oldalával létrehozó konstruktor.
        /// </summary>
        /// <param name="side">A négyzet oldala.</param>
        public Square(double side)
        {
            this.side = side;
        }
        /// <summary>
        /// S1.05 Side tulajdonság get metódussal.
        /// S1.06 Side tulajdonság set  metódussal.
        ///       A négyzet oldalát leolvasni (get) és módosítani is lehet (set).
        /// </summary>
        public double Side
        {
            get { return side; }
            set { side = value; }
        }
    }
}
