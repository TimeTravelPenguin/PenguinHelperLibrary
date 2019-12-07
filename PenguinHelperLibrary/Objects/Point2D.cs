#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: Point2D.cs
// 
// Current Data:
// 2019-12-07 7:50 PM
// 
// Creation Date:
// 2019-12-07 6:26 PM

#endregion

namespace PenguinHelperLibrary.Objects
{
    public class Point2D
    {
        /// <summary>
        /// The X coordinate of the point
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// The Y coordinate of the point
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Returns a <see cref="Point2D"/> with <see langword="X = 0"/>, <see langword="Y = 0"/>
        /// </summary>
        public static Point2D Origin => new Point2D(0, 0);

        public Point2D() : this(Origin)
        {
        }

        public Point2D(Point2D point)
        {
            X = point.X;
            Y = point.Y;
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}