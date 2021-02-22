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
    }
}
