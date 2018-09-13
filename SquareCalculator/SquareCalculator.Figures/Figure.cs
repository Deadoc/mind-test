using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.Figures
{
    public abstract class Figure
    {
        #region Fields

        private readonly Lazy<double> _square;

        #endregion

        #region Properties

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Square => _square.Value;

        #endregion

        protected Figure()
        {
            _square = new Lazy<double>(CalculateSquare);
        }

        #region Functions

        /// <summary>
        /// Вычислить площадь фигуры
        /// </summary>
        protected abstract double CalculateSquare();

        #endregion
    }
}
