#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: Vector2D.cs
// 
// Current Data:
// 2019-12-07 9:03 PM
// 
// Creation Date:
// 2019-12-07 6:17 PM

#endregion

using PenguinHelperLibrary.Extension_Methods;

namespace PenguinHelperLibrary.Objects
{
    /// <summary>
    ///     An object representing a 2D Vector
    /// </summary>
    public class Vector2D
    {
        public Point2D Point2D { get; set; }

        public static Vector2D Zero => new Vector2D(0, 0);
        public static Vector2D One => new Vector2D(1, 0);

        public double Magnitude => Point2D.SqrDistance(Point2D.Origin);

        public Vector2D() : this(new Point2D())
        {
        }

        public Vector2D(Point2D point)
        {
            Point2D = point;
        }

        public Vector2D(double x, double y) : this(new Point2D(x, y))
        {
        }

        /// <summary>
        ///     Dot Product operator.
        /// </summary>
        /// <param name="vector1" />
        /// <param name="vector2" />
        /// <returns>
        ///     Returns the Dot Product of two <see cref="Vector2D" />.
        /// </returns>
        public static double operator *(Vector2D vector1, Vector2D vector2)
        {
            return vector1.Point2D.X * vector2.Point2D.X + vector1.Point2D.Y * vector2.Point2D.Y;
        }
    }
}