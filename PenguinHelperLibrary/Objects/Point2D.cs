#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: Point2D.cs
// 
// Current Data:
// 2019-12-08 1:23 AM
// 
// Creation Date:
// 2019-12-07 6:26 PM

#endregion

namespace PenguinHelperLibrary.Objects
{
    /// <summary>
    ///     An object storing a pair of <see cref="double" /> values, representing a point in two dimensional space.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        ///     The X coordinate of the point
        /// </summary>
        public double X { get; set; }

        /// <summary>
        ///     The Y coordinate of the point
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        ///     Returns a <see cref="Point2D" /> with <see langword="X = 0" />, <see langword="Y = 0" />
        /// </summary>
        public static Point2D Origin => new Point2D(0, 0);

        /// <summary>
        ///     A point storing the origin value of <c>(0,0)</c>
        /// </summary>
        public Point2D() : this(Origin)
        {
        }

        /// <summary>
        ///     A point initialized by equating its values to another <see cref="Point2D" /> object.
        /// </summary>
        /// <param name="point">
        ///     The <see cref="Point2D" /> object in which to equate from.
        /// </param>
        public Point2D(Point2D point)
        {
            X = point.X;
            Y = point.Y;
        }

        /// <summary>
        ///     A point initialized by passing two <see cref="double" /> values.
        /// </summary>
        /// <param name="x">
        ///     The value to store for <see cref="X" />
        /// </param>
        /// <param name="y">
        ///     The value to store for <see cref="Y" />
        /// </param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}