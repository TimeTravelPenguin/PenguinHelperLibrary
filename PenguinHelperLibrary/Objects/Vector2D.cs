#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: Vector2D.cs
// 
// Current Data:
// 2019-12-08 1:52 AM
// 
// Creation Date:
// 2019-12-07 6:17 PM

#endregion

using PenguinHelperLibrary.Extension_Methods;

namespace PenguinHelperLibrary.Objects
{
    /// <summary>
    ///     An object representing a 2D Vector, with the base at the origin
    /// </summary>
    public class Vector2D
    {
        /// <summary>
        ///     Returns a <see cref="Vector2D" /> of <see cref="Magnitude" /> zero
        /// </summary>
        public static Vector2D Zero => new Vector2D(0, 0);

        /// <summary>
        ///     Returns a <see cref="Vector2D" /> of <see langword="X = 1" />, <see langword="Y = 0" />.
        /// </summary>
        public static Vector2D One => new Vector2D(1, 0);

        private Point2D Point2D { get; } = new Point2D();

        /// <summary>
        ///     The X coordinate of the vector
        /// </summary>
        public double X
        {
            get => Point2D.X;
            set => Point2D.X = value;
        }

        /// <summary>
        ///     The Y coordinate of the vector
        /// </summary>
        public double Y
        {
            get => Point2D.Y;
            set => Point2D.Y = value;
        }

        /// <summary>
        ///     Returns the length of the <see cref="Vector2D" />
        /// </summary>
        public double Magnitude => Point2D.SqrDistance(Point2D.Origin);

        /// <summary>
        ///     Creates a <see cref="Vector2D" /> with <see cref="Magnitude" /> zero
        /// </summary>
        /// <seealso cref="Zero" />
        public Vector2D() : this(Zero)
        {
        }

        /// <summary>
        ///     Creates a <see cref="Vector2D" />, with initial <see cref="X" /> and <see cref="Y" /> values
        ///     defined by the <see cref="PenguinHelperLibrary.Objects.Point2D" /> <paramref name="point" /> parameter.
        /// </summary>
        /// <param name="point">
        ///     <see cref="PenguinHelperLibrary.Objects.Point2D" /> object used
        ///     to initialize <see cref="X" /> and <see cref="Y" />.
        /// </param>
        public Vector2D(Point2D point)
        {
            Point2D = point;
        }

        /// <summary>
        ///     Creates a <see cref="Vector2D" />, with initial <see cref="X" /> and <see cref="Y" /> values
        ///     defined by the <see cref="Vector2D" /> <paramref name="vector" /> parameter.
        /// </summary>
        /// <param name="vector">
        ///     <see cref="Vector2D" /> object used to initialize <see cref="X" /> and <see cref="Y" />.
        /// </param>
        public Vector2D(Vector2D vector)
        {
            Point2D = vector.Point2D;
        }

        /// <summary>
        ///     Creates a <see cref="Vector2D" />, with initial <see cref="X" /> and <see cref="Y" /> values
        ///     defined by the parameters passed.
        /// </summary>
        /// <param name="x">
        ///     The value to set <see cref="X" />
        /// </param>
        /// <param name="y">
        ///     The value to set <see cref="Y" />
        /// </param>
        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        ///     Returns the angle of the vector.
        /// </summary>
        /// <param name="angleType">
        ///     The <see cref="Angle" /> type to return.
        /// </param>
        /// <returns>
        ///     Returns <see cref="double" /> value of the angle of the vector.
        /// </returns>
        public double Theta(Angle angleType)
        {
            return Point2D.ATan(Zero.Point2D, angleType);
        }

        /// <summary>
        ///     <see cref="Vector2D" /> dot product operator.
        /// </summary>
        /// <param name="vectorLhs" />
        /// <param name="vectorRhs" />
        /// <returns>
        ///     Returns the dot product of two <see cref="Vector2D" />.
        /// </returns>
        public static double operator *(Vector2D vectorLhs, Vector2D vectorRhs)
        {
            return vectorLhs.X * vectorRhs.X + vectorLhs.Y * vectorRhs.Y;
        }
    }
}