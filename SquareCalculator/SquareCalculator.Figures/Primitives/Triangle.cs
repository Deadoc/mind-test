using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculator.Figures.Primitives
{
    public class Triangle : Figure
    {
        #region Fields

        private readonly Lazy<bool> _isRightAngled;

        #endregion

        #region Properties

        /// <summary>
        /// Первая сторона
        /// </summary>
        public double FirstSide { get; }

        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double SecondSide { get; }

        /// <summary>
        /// Третья сторона
        /// </summary>
        public double ThirdSide { get; }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightAngled => _isRightAngled.Value;

        #endregion

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            _isRightAngled = new Lazy<bool>(CheckIsRightAngled);
        }

        #region Functions

        /// <summary>
        /// Проверить, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        private bool CheckIsRightAngled()
        {
            var maxSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();
            var maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == FirstSide * FirstSide + SecondSide * SecondSide + ThirdSide * ThirdSide;
        }

        /// <summary>
        /// Вычислить площадь треугольника
        /// </summary>
        protected sealed override double CalculateSquare()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            var firstSideCoeficient = semiPerimeter - FirstSide;
            var secondSideCoeficient = semiPerimeter - SecondSide;
            var thirdSideCoeficient = semiPerimeter - ThirdSide;

            return Math.Sqrt(semiPerimeter * firstSideCoeficient * secondSideCoeficient * thirdSideCoeficient);
        }
        
        #endregion
    }
}
