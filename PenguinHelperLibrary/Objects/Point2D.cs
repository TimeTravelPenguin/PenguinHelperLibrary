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
        public double X { get; set; }
        public double Y { get; set; }

        public static Point2D Origin => new Point2D(0, 0);

        public Point2D() : this(0, 0)
        {
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}