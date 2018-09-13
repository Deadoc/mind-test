using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.Figures.Primitives
{
    public class Circle : Figure
    {
        #region Properties

        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius { get; }

        #endregion

        public Circle(double radius)
        {
            Radius = radius;
        }

        #region Functions

        /// <summary>
        /// Вычислить площадь круга
        /// </summary>
        protected sealed override double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }

        #endregion
    }
}
