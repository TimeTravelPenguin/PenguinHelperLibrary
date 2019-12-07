#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: MathExtensions.cs
// 
// Current Data:
// 2019-12-07 8:17 PM
// 
// Creation Date:
// 2019-12-07 6:22 PM

#endregion

using System;
using PenguinHelperLibrary.Objects;

namespace PenguinHelperLibrary.Extension_Methods
{
    public static class MathExtensions
    {
        public static double SqrDistance(this Point2D thisPoint, Point2D point)
        {
            var lhs = Math.Pow(Math.Abs(thisPoint.X - point.X), 2);
            var rhs = Math.Pow(Math.Abs(thisPoint.Y - point.Y), 2);
            return Math.Sqrt(lhs + rhs);
        }

        public static Vector2D AddVector2D(this Vector2D thisVector2D, Vector2D vector)
        {
            return new Vector2D(thisVector2D.Point2D.X + vector.Point2D.X, thisVector2D.Point2D.Y + vector.Point2D.Y);
        }
    }
}